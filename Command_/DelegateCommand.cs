namespace Command_;

public class DelegateCommand {
    public char Icon { get; }
    public string Name { get; }
    public bool IsEnabled { get; }
    public Action Action { get; }

    public DelegateCommand (char icon, string name, bool isEnabled, Action action) {
        Icon = icon;
        Name = name;
        IsEnabled = isEnabled;
        Action = action;
    }

    public void Execute () => Action ();

    public override string ToString () => Name;
}
