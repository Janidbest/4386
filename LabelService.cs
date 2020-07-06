using IdentityServer4.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Services
{
    public class LabelService : ILabelService
    {
        private readonly IIdentityServerInteractionService _IIdentityServerInteractionService;
        private readonly IHttpContextAccessor _IHttpContextAccessor;
        public LabelService(IIdentityServerInteractionService identityServerInteractionService,
             IHttpContextAccessor httpContext)
        {
            _IIdentityServerInteractionService = identityServerInteractionService;
            _IHttpContextAccessor = httpContext;
            //Finding the client
            var clientId = _IIdentityServerInteractionService.GetAuthorizationContextAsync(httpContext.HttpContext.Request.Query["returnUrl"]).Result;
            //Username = GetUserNameLabelByClientId(clientId);
        }
        public string Username => "Username";

        public string EmailAddress => "EmailAddress";

        public string Password => "Password";
    }
    
}
