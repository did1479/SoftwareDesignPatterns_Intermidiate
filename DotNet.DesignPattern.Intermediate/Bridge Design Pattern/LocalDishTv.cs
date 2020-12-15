namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     LocalDishTv Class
    /// </summary>
    class LocalDishTv : IVideoSource
    {
        /// <summary>
        ///     Get Tv Guide
        /// </summary>
        /// <returns></returns>
        string IVideoSource.GetTvGuide()
        {
            return string.Format(GlobalText.GettingTVguideFromText, GlobalText.LocalDISHTVText);
        }

        /// <summary>
        ///     Play Video
        /// </summary>
        /// <returns></returns>
        string IVideoSource.PlayVideo()
        {
            return string.Format(GlobalText.PlayingText, GlobalText.LocalDISHTVText);
        }
    }
}
