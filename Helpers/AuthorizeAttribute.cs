using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using BookStoreApp.Entities;

namespace BookStoreApp.Helpers
{
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = (Client)context.HttpContext.Items["Client"];
            if (user == null)
            {
                context.Result = new JsonResult(new { message = "Unauthorized " })
                {
                    StatusCode = StatusCodes.Status401Unauthorized
                };
            }
        }
    }
}
