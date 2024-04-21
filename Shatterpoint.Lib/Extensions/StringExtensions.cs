using System.Net.NetworkInformation;
using System.Security.Claims;
using Shatterpoint.Lib.Data;
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
            result = result.Replace("Supporting", $"<b>Supporting</b>");
            result = result.Replace("Primary Unit", $"<b>Primary Unit</b>");
            result = result.Replace("Secondary Unit", $"<b>Secondary Unit</b>");
            result = result.Replace("Protection", $"<b>Protection</b>");
            result = result.Replace("Impact", $"<b>Impact</b>");
            result = result.Replace("Sharpshooter", $"<b>Sharpshooter</b>");

            //Apply logo
            result = result.ReplaceWithLogo("range", IconReferences.rangeicon, "bottom");

            result = result.ReplaceWithLogo("advance", IconReferences.advanceicon, "bottom");
            result = result.ReplaceWithLogo("dash", IconReferences.dashicon, "bottom");
            result = result.ReplaceWithLogo("jump", IconReferences.jumpicon, "bottom");
            result = result.ReplaceWithLogo("climb", "/img/rule/climb.png", "bottom");
            result = result.ReplaceWithLogo("reposition", IconReferences.repositionicon, "bottom");

            result = result.ReplaceWithLogo("melee", IconReferences.meleeicon, "bottom");
            result = result.ReplaceWithLogo("ranged", IconReferences.rangedicon, "bottom");
            result = result.ReplaceWithLogo("heal", IconReferences.healicon, "bottom");
            result = result.ReplaceWithLogo("damage", IconReferences.damageicon, "bottom");
            result = result.ReplaceWithLogo("failure", IconReferences.failureicon, "bottom");

            result = result.ReplaceWithLogo("hunker", IconReferences.hunkericon, "bottom");
            result = result.ReplaceWithLogo("strained", "/img/rule/strained.png", "bottom");
            result = result.ReplaceWithLogo("disarmed", "/img/rule/disarmed.png", "bottom");
            result = result.ReplaceWithLogo("pinned", "/img/rule/pinned.png", "bottom");
            result = result.ReplaceWithLogo("exposed", IconReferences.exposeicon, "bottom");

            return result;
        }

        /// <summary>
        /// Return logo style (css). 
        /// Workaround for when css is not applied
        /// </summary>
        /// <returns></returns>
        private static string logoStyle(string verticalAlign)
        {
            return "height: 15px; margin-right: 2px; vertical-align: " + verticalAlign + ";";
        }

        /// <summary>
        /// Replace the *logoname* with <img> of source: logo.png
        /// </summary>
        /// <param name="content"></param>
        /// <param name="logoname"></param>
        /// <param name="vertivalAlign"></param>
        /// <returns></returns>
        private static string ReplaceWithLogo(this string content, string logoname, string src, string vertivalAlign)
        {
            var textToReplace = $"*{logoname}*";
            if (content.Contains(textToReplace))
            {
                content = content.Replace(textToReplace, $"<img style=\"{logoStyle(vertivalAlign)}\" alt=\"{logoname}\" src=\"{src}\" />");
            }
            return content;
        }
    }
}
