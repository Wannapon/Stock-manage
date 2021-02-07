using Stock.Manage.Logic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Manage.Logic.Service.Implement
{
    public class PublicService : IPublicService
    {
        public PublicService()
        {
        }

        public async Task<bool> HelloAsync(string dtoModel)
        {
            try
            {
                bool response = false;

                if (dtoModel != null)
                {
                    response = true;
                }

                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
