using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Say(string input);
    }
}
