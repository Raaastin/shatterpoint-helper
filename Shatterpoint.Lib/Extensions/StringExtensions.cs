using System.Net.NetworkInformation;
using Shatterpoint.Lib.Units;

namespace Shatterpoint.Lib.Extensions
{
    /// <summary>
    /// String extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Detect specific termes and add html balise to format (ex: bold for key words)
        /// </summary>
        /// <returns></returns>
        public static string ToRawHtmlDescription(this string description)
        {
            var result = description;

            // Bold keywords
            foreach (var kw in KeyWords.KeyWordsList)
            {
                if (result.Contains(kw))
                {
                    result = result.Replace(kw, $"<b>{kw}</b>");
                }
            }

            // Bold additional words: 
            if (result.Contains("Supporting"))
            {
                result = result.Replace("Supporting", $"<b>Supporting</b>");
            }
            
            //Apply logo
            result = result.ReplaceWithLogo("range", "bottom");
            result = result.ReplaceWithLogo("dash", "baseline");
            result = result.ReplaceWithLogo("jump", "baseline");
            result = result.ReplaceWithLogo("strained", "bottom");
            result = result.ReplaceWithLogo("hunker", "baseline");

            return result;
        }

        /// <summary>
        /// Return logo style (css). 
        /// Workaround for when css is not applied
        /// </summary>
        /// <returns></returns>
        private static string logoStyle(string verticalAlign)
        {
            return "width: 15px; margin: 0px; vertical-align: " + verticalAlign + ";";
        }

        /// <summary>
        /// Replace the *logoname* with <img> of source: logo.png
        /// </summary>
        /// <param name="content"></param>
        /// <param name="logoname"></param>
        /// <param name="vertivalAlign"></param>
        /// <returns></returns>
        private static string ReplaceWithLogo(this string content, string logoname, string vertivalAlign)
        {
            var textToReplace = $"*{logoname}*";
            var logopath = $"/img/rule/{logoname}.png";
            if (content.Contains(textToReplace))
            {
                content = content.Replace(textToReplace, $"<img style=\"{logoStyle(vertivalAlign)}\" alt=\"{logoname}\" src=\"{logopath}\" />");
            }
            return content;
        }
    }
}
