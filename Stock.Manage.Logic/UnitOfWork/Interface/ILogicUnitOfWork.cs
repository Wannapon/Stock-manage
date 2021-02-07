using Stock.Manage.Logic.Service.Interface;

namespace Stock.Manage.Logic.UnitOfWork.Interface
{
    public interface ILogicUnitOfWork
    {
        IPublicService PublicService { get; set; }
    }
}
