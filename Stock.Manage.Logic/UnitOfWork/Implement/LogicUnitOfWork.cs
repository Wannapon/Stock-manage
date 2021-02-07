using Stock.Manage.Logic.Service.Implement;
using Stock.Manage.Logic.Service.Interface;
using Stock.Manage.Logic.UnitOfWork.Interface;

namespace Stock.Manage.Logic.UnitOfWork.Implement
{
    public class LogicUnitOfWork : ILogicUnitOfWork
    {
        //private IEntityUnitOfWork entityUnitOfWork { get; set; }

        private IPublicService IPublicService;

        public LogicUnitOfWork()
        {
        }

        public IPublicService PublicService
        {
            get { return IPublicService ?? (IPublicService = new PublicService()); }
            set { IPublicService = value; }
        }



    }
}
