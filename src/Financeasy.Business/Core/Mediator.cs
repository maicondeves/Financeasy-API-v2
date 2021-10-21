using Financeasy.Business.Interfaces.Core;

namespace Financeasy.Business.Core
{
    public class Mediator : IMediator
    {
        private object _returnableValue;

        public Mediator()
        {
            _returnableValue = null;
        }

        public object GetReturnableValue()
            => _returnableValue;

        public bool HasReturnableValue()
            => _returnableValue != null;

        public void Return(object obj)
            => _returnableValue = obj;
    }
}