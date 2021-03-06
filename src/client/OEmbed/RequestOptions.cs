﻿namespace Embedly.OEmbed
{
    /// <summary>
    /// oEmbed request options
    /// </summary>
    public class RequestOptions
    {
        /// <summary>
        /// Gets or sets the maximum width of the content.
        /// </summary>
        /// <value>
        /// The maximum width.
        /// </value>
        public int MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the maximum height of the content.
        /// </summary>
        /// <value>
        /// The maximum height.
        /// </value>
        public int MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to strip styling.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [no style]; otherwise, <c>false</c>.
        /// </value>
        public bool NoStyle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to auto play videos.
        /// </summary>
        /// <value>
        ///   <c>true</c> if auto play; otherwise, <c>false</c>.
        /// </value>
        public bool AutoPlay { get; set; }

        /// <summary>
        /// Gets or sets the number of words to limit the response to.
        /// </summary>
        /// <value>
        /// The words.
        /// </value>
        public int Words { get; set; }

        /// <summary>
        /// Gets or sets the number of chars to limit the response to.
        /// </summary>
        /// <value>
        /// The chars.
        /// </value>
        public int Chars { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to force embedly to reevaluate the link 
        /// </summary>
        /// <value>
        ///   <c>true</c> if force reevaluation; otherwise, <c>false</c>.
        /// </value>
        public bool Force { get; set; }

        /// <summary>
        /// Builds query-string parameters based on the request options set
        /// </summary>
        /// <returns></returns>
        internal string GetQueryString()
        {
            string querystring = string.Empty;

            if (MaxWidth > 0)
                querystring += "&maxwidth=" + MaxWidth;

            if (MaxHeight > 0)
                querystring += "&maxheight=" + MaxHeight;

            if (Width > 0)
                querystring += "&width=" + Width;

            if (NoStyle)
                querystring += "&nostyle=true";

            if (AutoPlay)
                querystring += "&autoplay=true";

            if (Words > 0)
                querystring += "&words=" + Words;

            if (Chars > 0)
                querystring += "&chars=" + Chars;

            if (Force)
                querystring += "&force=true";

            return querystring;
        }
    }
}