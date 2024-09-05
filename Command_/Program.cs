namespace Command_;

internal class Program {
    static void Main (string[] args) {
        string text = "";

        DelegateCommand appendCommand = new DelegateCommand (
            'a', "Добавить текст в конец", true,
            () => text += Console.ReadLine ()
        );
        DelegateCommand prependCommand = new DelegateCommand (
            'p', "Добавить текст в начало", true,
            () => text = Console.ReadLine () + text
        );
        DelegateCommand clearCommand = new DelegateCommand (
            'c', "Очистить текст", true,
            () => text = ""
        );
        IEnumerable<DelegateCommand> commands = new List<DelegateCommand> {
            appendCommand,
            prependCommand,
            clearCommand
        };

        while (true) {
            Console.WriteLine (text);

            Console.WriteLine ("Выберите желаемое действие: ");
            foreach (DelegateCommand command in commands)
                Console.WriteLine ($"{command.Icon}. {command.Name}");
            char input = Console.ReadLine ()![0];

            foreach (DelegateCommand command in commands)
                if (input == command.Icon) {
                    command.Execute ();
                    break;
                }
        }
    }
}
