using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Applicarion-Error"); // for .Net Core below 3.0
            response.Headers.Add("Access-Control-Allow-Origin", "*"); // for .Net Core below 3.0
        }
    }
}