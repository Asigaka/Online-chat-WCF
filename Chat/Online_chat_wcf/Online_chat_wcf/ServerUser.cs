using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Online_chat_wcf
{
    class ServerUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public OperationContext OperationContext { get; set; }
    }
}
