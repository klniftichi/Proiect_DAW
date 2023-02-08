using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Proiect_DAW___Iftichi_Calin.Models;
using Proiect_DAW___Iftichi_Calin.Models.Enums;

namespace Proiect_DAW___Iftichi_Calin.Helpers.Atributes
{
    public class Authorization : Attribute, IAuthorizationFilter
    {
        private readonly ICollection<Rol> _roles;

        public Authorization(params Rol[] roles)
        {
            _roles = roles;
        }

        void IAuthorizationFilter.OnAuthorization(AuthorizationFilterContext context)
        {
            var unauthorizedStatusObject = new JsonResult(new { Message = "Nu aveti accesul necesar pentru a accesa aceasta functie!" }){ StatusCode=StatusCodes.Status401Unauthorized};
            
            if(_roles==null)
            {
                context.Result = unauthorizedStatusObject;
            }

            var user = (Utilizator)context.HttpContext.Items["User"];
            if(user==null || !_roles.Contains(user.Rol))
            {
                context.Result = unauthorizedStatusObject;
            }
        }
    }

}
