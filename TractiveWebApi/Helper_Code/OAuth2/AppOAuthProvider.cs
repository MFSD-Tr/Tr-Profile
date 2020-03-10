namespace WebApiOauth2.Helper_Code.OAuth2
{
    using Microsoft.Owin.Security;
    using Microsoft.Owin.Security.Cookies;
    using Microsoft.Owin.Security.OAuth;
    using TractiveWebApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System.Web;

    /// <summary>  
    /// Application OAUTH Provider class.  
    /// </summary>  
    public class AppOAuthProvider : OAuthAuthorizationServerProvider
    {
        #region Private Properties  

        /// <summary>  
        /// Public client ID property.  
        /// </summary>  
        private readonly string _publicClientId;

        /// <summary>  
        /// Database Store property.  
        /// </summary>  
        //private Oauth_APIEntities databaseManager = new Oauth_APIEntities();

        #endregion

        #region Default Constructor method.  

        /// <summary>  
        /// Default Constructor method.  
        /// </summary>  
        /// <param name="publicClientId">Public client ID parameter</param>  
        public AppOAuthProvider(string publicClientId)
        {
            //TODO: Pull from configuration  
            if (publicClientId == null)
            {
                throw new ArgumentNullException(nameof(publicClientId));
            }

            // Settings.  
            _publicClientId = publicClientId;
        }

        #endregion

        #region Grant resource owner credentials override method.  

        /// <summary>  
        /// Grant resource owner credentials overload method.  
        /// </summary>  
        /// <param name="context">Context parameter</param>  
        /// <returns>Returns when task is completed</returns>  
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            // Initialization.  
            string usernameVal = context.UserName;
            string passwordVal = context.Password;
            //var user = this.databaseManager.LoginByUsernamePassword(usernameVal, passwordVal).ToList();

            //// Verification.  
            //if (user == null || user.Count() <= 0)
            //{
            //    // Settings.  
            //    context.SetError("invalid_grant", "The user name or password is incorrect.");

            //    // Retuen info.  
            //    return;
            //}

            //Verfication

            //if (!usernameVal.Equals("Dev") && !passwordVal.Equals("123456"))
            //{

            //    context.SetError("invalid_grant", "The user name or password is incorrect. yaha pe aha hh");
            //    return;


            //}

            if (!usernameVal.Equals("Dev")) {

                context.SetError("invalid_grant", "The user name  is incorrect ");
                return;

            }
            if (!passwordVal.Equals("123456")) {

                context.SetError("invalid_grant", "The user  password is incorrect ");
                return;

            }


            // Initialization.  
            var claims = new List<Claim>();
            var userInfo = usernameVal;//user.FirstOrDefault();
            //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "Content-Type" });

            // Setting  
            claims.Add(new Claim(ClaimTypes.Name, usernameVal));//Change in UserName
                                                                // Grant access to authorize user.  
            ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);
            AuthenticationProperties properties = CreateProperties(usernameVal); //chaneg in usern

            // Setting Claim Identities for OAUTH 2 protocol.  ame
            AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, properties); //It hold Acces token for further process

           
            ClaimsIdentity cookiesClaimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);

            // Setting user authentication.  
            
            context.Validated(ticket);
            context.Request.Context.Authentication.SignIn(cookiesClaimIdentity);
        }

        #endregion

        #region Token endpoint override method.  

        /// <summary>  
        /// Token endpoint override method  
        /// </summary>  
        /// <param name="context">Context parameter</param>  
        /// <returns>Returns when task is completed</returns>  
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                // Adding.  
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Validate Client authntication override method  

        /// <summary>  
        /// Validate Client authntication override method  
        /// </summary>  
        /// <param name="context">Contect parameter</param>  
        /// <returns>Returns validation of client authentication</returns>  
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.  
            if (context.ClientId == null)
            {
                // Validate Authoorization.  
                context.Validated();
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Validate client redirect URI override method  

        /// <summary>  
        /// Validate client redirect URI override method  
        /// </summary>  
        /// <param name="context">Context parmeter</param>  
        /// <returns>Returns validation of client redirect URI</returns>  
        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            // Verification.  
            if (context.ClientId == _publicClientId)
            {
                // Initialization.  
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                // Verification.  
                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    // Validating.  
                    context.Validated();
                }
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Create Authentication properties method.  

        /// <summary>  
        /// Create Authentication properties method.  
        /// </summary>  
        /// <param name="userName">User name parameter</param>  
        /// <returns>Returns authenticated properties.</returns>  
        public static AuthenticationProperties CreateProperties(string userName)
        {
            // Settings.  
            IDictionary<string, string> data = new Dictionary<string, string>
                                               {
                                                   { "userName", userName }
                                               };

            // Return info.  
            return new AuthenticationProperties(data);
        }


        #endregion
    }
}