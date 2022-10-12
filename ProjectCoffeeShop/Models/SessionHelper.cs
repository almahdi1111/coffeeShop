 using Microsoft.AspNetCore.Http;
 using Newtonsoft.Json;
namespace ProjectCoffeeShop.Models
{
    public static class SessionHelper
        {
            public static void SetObjectAsJson(this ISession session, string key, object value)
            {
                session.SetString(key, JsonConvert.SerializeObject(value));
            }
        public static void SetValue(this ISession session, string key, string? value)
            {
                session.SetString(key, value);
            }

            public static T GetObjectFromJson<T>(this ISession session, string key)
            {
                var value = session.GetString(key);
                return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
            }

        }
 }
