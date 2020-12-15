namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     Base Component Class
    /// </summary>
    class BaseComponent
    {
        protected IMediator _mediator;

        /// <summary>
        ///     Base Component
        /// </summary>
        /// <param name="mediator"></param>
        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        /// <summary>
        ///     Set Mediator
        /// </summary>
        /// <param name="mediator"></param>
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
