using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void SendMessage(string message, User sender, string recipient)
        {
            User recipientUser = _users.Find(u => u.Name == recipient);
            if (recipientUser != null)
            {
                recipientUser.ReceiveMessage(message, sender.Name);
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            user.SetMediator(this);
        }
    }
}
