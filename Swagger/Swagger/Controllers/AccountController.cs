using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Swagger.Models;
using Swagger.Providers;
using Swagger.Results;
using System.Web.Http.Description;

namespace Swagger.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {

        /// <summary>
        /// Register a new user on application
        /// </summary>
        /// <param name="user">New user to register</param>
        /// <remarks>Adds new user to application and grant access</remarks>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        [AllowAnonymous]
        [Route("Register")]
        [ResponseType(typeof(RegisterBindingModel))]
        [HttpPost]
        public async Task<IHttpActionResult> Register(RegisterBindingModel user)
        {
            //IMPLEMENTATION OF CODE GOES HERE!!
            throw new NotImplementedException();
        }
    }
}
