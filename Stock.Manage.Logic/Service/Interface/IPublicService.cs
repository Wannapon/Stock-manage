using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Manage.Logic.Service.Interface
{
    public interface IPublicService
    {
        Task<bool> HelloAsync(string dtoModel);
    }
}
