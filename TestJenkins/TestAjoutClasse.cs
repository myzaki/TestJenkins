using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCIJenkins
{
    public class TestAjoutClasse
    {
        string message;
        public string GetMessage()
        {
            Message = "hello";
            return Message;
        }

        public string Message
        {
            get;
            set;
        }
    }
}
