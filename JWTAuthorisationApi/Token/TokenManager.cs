using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace JWTAuthorisationApi.Token
{
    public class TokenManager
    {

        #region "variable"

        private static string Secret = "AQWSEDR9AQWSEDR9AQWSEDR9AQWSEDR9AQWSEDR9AQWSEDR9";

        #endregion

        #region "Constant"

        const string CLASS_NAME = "TokenManager";

        #endregion

        #region "Error Logger"

        private static void ErrorLogger(String msgText)
        {

            System.Diagnostics.Debug.WriteLine("Exception caught in {0} class as {1}", CLASS_NAME, msgText);

        }

        #endregion

        #region "Public Method"

        /// <summary>
        /// This method is used to Get Token through userName Passed in It.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static string GernateToken(string userName)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var token = new JwtSecurityToken();
            try
            {
                byte[] key = Convert.FromBase64String(Secret);

                SymmetricSecurityKey sercurityKey = new SymmetricSecurityKey(key);

                SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor()
                {

                    Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, userName) }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(sercurityKey, SecurityAlgorithms.HmacSha256Signature)

                };

                token = handler.CreateJwtSecurityToken(descriptor);
            }
            catch (Exception exp)
            {

            }

            return handler.WriteToken(token);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static ClaimsPrincipal GetPrincipal(string token)
        {

            ClaimsPrincipal principal = null;
            try
            {

                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);

                if (jwtToken != null)
                {

                    byte[] key = Convert.FromBase64String(Secret);

                    TokenValidationParameters parameters = new TokenValidationParameters()
                    {

                        RequireExpirationTime = true,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        IssuerSigningKey = new SymmetricSecurityKey(key)

                    };
                    SecurityToken securityToken;
                    principal = tokenHandler.ValidateToken(token, parameters, out securityToken);
                }


            }
            catch (Exception exp)
            {

                //Exception Calls
                ErrorLogger(exp.Message);

            }


            return principal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public static string ValidateToken(string token)
        {

            string userName = null;

            try
            {

                ClaimsPrincipal principal = GetPrincipal(token);

                if (principal != null)
                {

                    ClaimsIdentity identity = (ClaimsIdentity)principal.Identity;

                    Claim userNameClaim = identity.FindFirst(ClaimTypes.Name);

                    userName = userNameClaim.Value;

                }

            }
            catch (Exception exp)
            {

                //Exception calls
                ErrorLogger(exp.Message);

            }

            return userName;

        }
        #endregion

    }
}