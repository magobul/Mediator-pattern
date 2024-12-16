using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    public class User
    {
        public string Name { get; }
        private IChatMediator _mediator;
        private List<string> _messageHistory;

        public User(string name)
        {
            Name = name;
            _messageHistory = new List<string>();
        }

        public void SetMediator(IChatMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMessage(string message, string recipient)
        {
            Console.WriteLine($"{Name} отправляет сообщение '{message}' пользователю {recipient}");
            _mediator.SendMessage(message, this, recipient);
            _messageHistory.Add($"Отправлено {recipient}: {message}");
        }

        public void ReceiveMessage(string message, string sender)
        {
            Console.WriteLine($"{Name} получил сообщение от {sender}: '{message}'");
            _messageHistory.Add($"Получено от {sender}: {message}");
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"История сообщений для {Name}:");
            foreach (var msg in _messageHistory)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
