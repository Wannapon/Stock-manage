using Microsoft.AspNetCore.Mvc;
using Stock.Manage.Common.Enum;
using Stock.Manage.Logic.UnitOfWork.Interface;
using Stock.Manage.Web.Api.Models.Response.Example;
using System;
using System.Threading.Tasks;

namespace Stock.Manage.Web.Api.Controllers
{
    [Route("api/v1/Public")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        private ILogicUnitOfWork logicUnitOfWork;

        public PublicController(ILogicUnitOfWork logicUnitOfWork)
        {
            this.logicUnitOfWork = logicUnitOfWork;
        }

        [HttpGet("PrintHello")]
        public async Task<IActionResult> Hello(string model)
        {
            try
            {
                bool result = await logicUnitOfWork.PublicService.HelloAsync(model);

                HelloModel response = new HelloModel();

                if (result == true)
                {
                    response.code = ResponseEnum.Success;
                    response.Message = ResponseEnum.Success.ToString();
                    response.Data = model;
                }

                throw new Exception();

                return Ok(response);
            }
            catch (Exception)
            {
                HelloModel response = new HelloModel()
                {
                    code = ResponseEnum.Error,
                    Message = ResponseEnum.Error.ToString(),
                    Data = null
                };

                return BadRequest(response);
            }
        }
    }
}
