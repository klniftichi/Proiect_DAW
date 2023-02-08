using Proiect_DAW___Iftichi_Calin.Helpers.JwtToken;
using Proiect_DAW___Iftichi_Calin.Services.UserService;

namespace Proiect_DAW___Iftichi_Calin.Helpers.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _nextRequestDelegate;

        public JwtMiddleware(RequestDelegate requestDelegate)
        {
            _nextRequestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpcontext, IUtilizatorService utilizatorService, IJwtUtils jwtUtils)
        {
            var token = httpcontext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            var userId=jwtUtils.ValidateJwtToken(token);
            if(userId != Guid.Empty)
            {
                httpcontext.Items["User"] = utilizatorService.UserGetById(userId);
            }
            await _nextRequestDelegate(httpcontext);
        }   



            
}



}
