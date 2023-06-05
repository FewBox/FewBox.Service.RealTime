using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FewBox.SDK.Extension;
using FewBox.SDK.Realtime;
using FewBox.Core.Web.Extension;
using FewBox.Service.RealTime.Model.Repositories;
using FewBox.Service.RealTime.Repository;
using FewBox.Service.RealTime.Hubs;
using System.Collections.Generic;
using FewBox.Service.RealTime.Model.Configs;
using FewBox.Service.RealTime.Model.Services;
using FewBox.Service.RealTime.Domain;

namespace FewBox.Service.RealTime
{
    public class Startup
    {
        private IList<ApiVersionDocument> ApiVersionDocuments = new List<ApiVersionDocument> {
                new ApiVersionDocument{
                    ApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0),
                    IsDefault = true
                },
                new ApiVersionDocument{
                    ApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(2, 0, "alpha1"),
                    IsDefault = false
                }
            };
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.Configuration = configuration;
            this.Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddFewBoxSDK(MQConsumerType.Realtime);
            services.AddFewBox(this.ApiVersionDocuments, FewBoxDBType.SQLite, FewBoxAuthType.Payload);
            // Config
            var realtimeConfig = this.Configuration.GetSection("Realtime").Get<RealtimeConfig>();
            services.AddSingleton(realtimeConfig);
            // Biz
            services.AddScoped<IAppRepository, AppRepository>();
            services.AddSingleton<IMQRealtimeHandler<AllExceptRealtimeMessage>, MQAllExceptRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<AllRealtimeMessage>, MQAllRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<ClientRealtimeMessage>, MQClientRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<ClientsRealtimeMessage>, MQClientsRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<GroupExceptRealtimeMessage>, MQGroupExceptRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<GroupRealtimeMessage>, MQGroupRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<GroupsRealtimeMessage>, MQGroupsRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<UserRealtimeMessage>, MQUserRealtimeMessageHandler>();
            services.AddSingleton<IMQRealtimeHandler<UsersRealtimeMessage>, MQUsersRealtimeMessageHandler>();
            services.AddSingleton<IWebDavService, WebDavService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseFewBox(this.ApiVersionDocuments);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<FewBoxHub>("fewbox");
            });
        }
    }
}