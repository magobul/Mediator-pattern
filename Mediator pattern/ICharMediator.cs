using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public interface IChatMediator
    {
        void SendMessage(string message, User sender, string recipient);
        void AddUser(User user);
    }
}
