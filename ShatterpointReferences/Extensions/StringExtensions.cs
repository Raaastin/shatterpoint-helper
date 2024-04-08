using ShatterpointReferences.Units;

namespace ShatterpointReferences.Extensions
{
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

            return result;
        }
    }
}
