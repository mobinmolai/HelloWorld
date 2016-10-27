using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public interface IMailService
    {
        void Send(string to, string from, string subject, string body);
    }
}
