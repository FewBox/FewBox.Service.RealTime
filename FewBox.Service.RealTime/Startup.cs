using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FewBox.SDK.Extension;
using FewBox.SDK.Realtime;
using NSwag;
using NSwag.Generation.Processors.Security;
using NSwag.Generation.AspNetCore;
using FewBox.Core.Web.Extension;
using FewBox.Service.RealTime.Model.Repositories;
using FewBox.Service.RealTime.Repository;
using FewBox.Service.RealTime.Hubs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            //services.AddFewBoxSDKWeb(MQConsumerType.Realtime); Todo
            services.AddFewBox(this.ApiVersionDocuments, FewBoxDBType.SQLite, FewBoxAuthType.Payload);
            // Biz
            services.AddScoped<IAppRepository, AppRepository>();
            services.AddScoped<IMQRealtimeHandler<AllExceptRealtimeMessage>, MQAllExceptRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<AllRealtimeMessage>, MQAllRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<ClientRealtimeMessage>, MQClientRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<ClientsRealtimeMessage>, MQClientsRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<GroupExceptRealtimeMessage>, MQGroupExceptRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<GroupRealtimeMessage>, MQGroupRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<GroupsRealtimeMessage>, MQGroupsRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<UserRealtimeMessage>, MQUserRealtimeMessageHandler>();
            services.AddScoped<IMQRealtimeHandler<UsersRealtimeMessage>, MQUsersRealtimeMessageHandler>();
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