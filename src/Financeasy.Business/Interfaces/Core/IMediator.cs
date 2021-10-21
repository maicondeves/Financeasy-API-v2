namespace Financeasy.Business.Interfaces.Core
{
    public interface IMediator
    {
        void Return(object obj);

        object GetReturnableValue();

        bool HasReturnableValue();
    }
}