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

            // Apply "range" logo
            if (result.Contains("*range*"))
            {
                result = result.Replace("*range*", $"<img style=\"{logoStyle("bottom")}\" alt=\"range\" src=\"/img/rule/range.png\" />");
            }

            // Apply "dash" logo
            if (result.Contains("*dash*"))
            {
                result = result.Replace("*dash*", $"<img style=\"{logoStyle("baseline")}\" alt=\"dash\" src=\"/img/rule/dash.png\" />");
            }

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
    }
}
