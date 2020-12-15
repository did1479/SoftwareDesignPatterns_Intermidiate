namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     TvService Class
    /// </summary>
    class TvService : IVideoSource
    {
        /// <summary>
        ///     Get Tv Guide
        /// </summary>
        /// <returns></returns>
        string IVideoSource.GetTvGuide()
        {
            return string.Format(GlobalText.GettingTVguideFromText, GlobalText.IPTVText);
        }

        /// <summary>
        ///     Play Video
        /// </summary>
        /// <returns></returns>
        string IVideoSource.PlayVideo()
        {
            return string.Format(GlobalText.PlayingText, GlobalText.IPTVText);
        }
    }
}
