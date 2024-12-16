using Mediator_pattern;

class Program
{
    static void Main(string[] args)
    {
        IChatMediator mediator = new ChatMediator();

        User alena = new User("Алена");
        User boris = new User("Борис");
        User nikita = new User("Никита");

        mediator.AddUser(alena);
        mediator.AddUser(boris);
        mediator.AddUser(nikita);

        alena.SendMessage("Привет, Борис!", "Boris");
        boris.SendMessage("Привет, Алена!", "Alena");
        nikita.SendMessage("Привет всем!", "Alena");

        alena.ShowMessageHistory();
        boris.ShowMessageHistory();
        nikita.ShowMessageHistory();
    }
}