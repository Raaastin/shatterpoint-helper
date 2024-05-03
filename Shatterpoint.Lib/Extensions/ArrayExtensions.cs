using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Shatterpoint.Lib.Data;
using Shatterpoint.Lib.Services;
using Shatterpoint.Lib.Units;

namespace Shatterpoint.Lib.Extensions
{
    /// <summary>
    /// String extensions
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Convert Unit array into json unit name array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string ToJson(this Unit[] array)
        {
            var arrayName = array.Select(x => x?.Name).ToArray();
            return JsonConvert.SerializeObject(arrayName);
        }

        /// <summary>
        /// Return an array of unit (nullable)
        /// </summary>
        /// <param name="jsonArraNames"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static Unit[] FromJson(this string jsonArraNames, UnitDataBaseService db)
        {
            var arrayName = JsonConvert.DeserializeObject<string[]>(jsonArraNames);

            var result = new Unit[6];
            for (int i = 0; i < 6; i++)
            {
                if (!string.IsNullOrEmpty(arrayName[i]))
                    result[i] = db.Get(arrayName[i]);
            }

            return result;
        }
    }
}
