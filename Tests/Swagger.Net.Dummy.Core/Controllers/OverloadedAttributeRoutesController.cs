﻿using System;
using System.Web.Http;

namespace Swagger.Net.Dummy.Controllers
{
    public class OverloadedAttributeRoutesController : ApiController
    {
        [Route("subscriptions/")]
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        [Route("users/")]
        public void GetAll(int id)
        {
            throw new NotImplementedException();
        }

        [Route("organisations/")]
        public void GetAll(int id, string name)
        {
            throw new NotImplementedException();
        }
    }
}