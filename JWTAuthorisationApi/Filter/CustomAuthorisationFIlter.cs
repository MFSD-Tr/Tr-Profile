using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using JWTAuthorisationApi.FilterService;
using JWTAuthorisationApi.Token;
using System.Net;
using System.Web.Http.Results;

namespace JWTAuthorisationApi.Filter
{
    public class CustomAuthorisationFIlter : AuthorizeAttribute, IAuthenticationFilter
    {

        #region "Property"

        /// <summary>
        /// It Allow To use Multiple Users At a time 
        /// </summary>
        public bool allowMultiple
        {

            get { return false; }

        }

        #endregion

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            String AuthoParamter = string.Empty;
            HttpRequestMessage request = context.Request;
            AuthenticationHeaderValue authorization = request.Headers.Authorization;

            if (authorization == null)
            {

                context.ErrorResult = new AuthenciationFailure("Missing Authorization header", request);
                return;

            }

            if (authorization.Scheme != "Bearer")
            {

                context.ErrorResult = new AuthenciationFailure("Invalid Authorization Schema", request);
                return;

            }

            if (string.IsNullOrEmpty(authorization.Parameter))
            {

                context.ErrorResult = new AuthenciationFailure("Missing token", request);
                return;

            }

            context.Principal = TokenManager.GetPrincipal(authorization.Parameter);

        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {

            var result = await context.Result.ExecuteAsync(cancellationToken);

            if (result.StatusCode == HttpStatusCode.Unauthorized)
            {

                result.Headers.WwwAuthenticate.Add(new AuthenticationHeaderValue("Basic", "realm=localhost"));

            }
            context.Result = new ResponseMessageResult(result);

        }
    }
}