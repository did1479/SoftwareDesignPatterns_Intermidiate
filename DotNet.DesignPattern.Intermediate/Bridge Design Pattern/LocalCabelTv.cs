namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     LocalCabelTv Class
    /// </summary>
    class LocalCabelTv : IVideoSource
    {
        /// <summary>
        ///     Get Tv Guide
        /// </summary>
        /// <returns></returns>
        string IVideoSource.GetTvGuide()
        {
            return string.Format(GlobalText.GettingTVguideFromText, GlobalText.LocalCabelTVText);
        }

        /// <summary>
        ///     Play Video
        /// </summary>
        /// <returns></returns>
        string IVideoSource.PlayVideo()
        {
            return string.Format(GlobalText.PlayingText, GlobalText.LocalCabelTVText);
        }
    }
}
