using System.Net.Http;

namespace TreinamentoWPF.Services
{
    public class TokenStorageService
    {
        private readonly HttpClient httpContextAccessor;
        private const string AccessTokenKey = "AccessToken";
        private const string ExpirationDateKey = "ExpirationDate";

        public TokenStorageService(HttpClient httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        //public string GetAccessToken()
        //{
        //    return httpContextAccessor.Session.GetString(AccessTokenKey);
        //}

        //public void SetAccessToken(string accessToken)
        //{
        //    httpContextAccessor.HttpContext.Session.SetString(AccessTokenKey, accessToken);
        //}

        //public DateTime GetExpirationDate()
        //{
        //    var expirationDateString = httpContextAccessor.HttpContext.Session.GetString(ExpirationDateKey);
        //    if (DateTime.TryParse(expirationDateString, out DateTime expirationDate))
        //    {
        //        return expirationDate;
        //    }
        //    return DateTime.MinValue;
        //}

        //public void SetExpirationDate(DateTime expirationDate)
        //{
        //    httpContextAccessor.HttpContext.Session.SetString(ExpirationDateKey, expirationDate.ToString());
        //}

        public bool IsTokenExpired()
        {
            var expirationDate = LoggedUser.AccessTokenExpiration;
            var currentDate = DateTime.UtcNow;

            return expirationDate <= currentDate;
        }
    }
}
