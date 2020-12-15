namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     Interface IMediator
    /// </summary>
    public interface IMediator
    {
        /// <summary>
        ///     Notify
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        void Notify(object sender, string ev);
    }
}
