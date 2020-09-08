namespace M_Assignment.Interface.Implementation {
    public class AbstractHandler : IHandler {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request, float output = 0)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request, output);
            }
            else
            {
                return output;
            }
        }
    }
}