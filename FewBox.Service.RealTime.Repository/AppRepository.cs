using Dapper;
using FewBox.Service.RealTime.Model.Entities;
using FewBox.Service.RealTime.Model.Repositories;
using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.RealTime.Repository
{
    public class AppRepository : Repository<App>, IAppRepository
    {
        public AppRepository(IOrmSession ormSession, ICurrentUser<Guid> currentUser)
        : base("app", ormSession, currentUser)
        {
        }

        protected override string GetSaveSegmentSql()
        {
            return "Name";
        }

        protected override string GetUpdateSegmentSql()
        {
            return "Name";
        }

        protected override string GetUpdateWithUniqueKeyWhereSegmentSql()
        {
            throw new NotImplementedException();
        }
    }
}