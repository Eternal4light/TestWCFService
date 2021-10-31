using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void Say(string input);
    }
}
