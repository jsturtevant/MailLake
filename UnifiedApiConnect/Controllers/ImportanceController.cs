using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnifiedApiConnect.Controllers
{
    public class ImportanceController : ApiController
    {
        [HttpGet]
        public int GetImportance(string id)
        {
            //to grab mail and calculate importance
            return 1;
        }

        [HttpPost]
        public int Post(string mailId, int importance)
        {
            //to grab mail and update importance
            //-1/0/1
            return 1;
        }
    }
}
