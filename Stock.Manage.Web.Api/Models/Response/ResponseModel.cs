using Stock.Manage.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Manage.Web.Api.Models.Response
{
    public class ResponseModel
    {
        public ResponseEnum code { get; set; }
        public string Message { get; set; }
    }
}
