using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    public class Client
    {
        private string clientName;

        public string ClientName
        {
            get => clientName;
            set => clientName = value;
        }

        public Client(string clientName)
        {
            this.clientName = clientName;
        }
        public override string ToString()
        {
            return "用户名: "+clientName;
        }
    }
}
