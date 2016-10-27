using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class DebugMailService : IMailService
    {
        public void Send(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending email.. To: {to}, from: {from}, subject: {subject}, body: {body}");
        }
    }
}
