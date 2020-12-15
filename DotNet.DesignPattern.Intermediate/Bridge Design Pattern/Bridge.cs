namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     MySuperSmartTV Class
    /// </summary>
    class MySuperSmartTV
    {
        IVideoSource currentVideoSource = null;

        /// <summary>
        ///     Gets or sets VideoSource
        /// </summary>
        public IVideoSource VideoSource
        {
            get
            {
                return currentVideoSource;
            }
            set
            {
                currentVideoSource = value;
            }
        }

        /// <summary>
        ///     Show Tv Guide
        /// </summary>
        public void ShowTvGuide()
        {
            if (currentVideoSource != null)
            {
                Console.WriteLine(currentVideoSource.GetTvGuide());
            }
            else
            {
                Console.WriteLine(GlobalText.SelectVideoSourceMessage);
            }
        }

        /// <summary>
        ///     Play TV
        /// </summary>
        public void PlayTV()
        {
            if (currentVideoSource != null)
            {
                Console.WriteLine(currentVideoSource.PlayVideo());
            }
            else
            {
                Console.WriteLine(GlobalText.SelectVideoSourceToPlayMessage);
            }
        }
    }
}
