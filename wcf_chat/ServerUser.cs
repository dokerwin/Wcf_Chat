using System.ServiceModel;
using System.Data;


namespace wcf_chat
{
    public class ServerUser
    {
        private int mes;
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext operationContext { get; set; }
    }
}
