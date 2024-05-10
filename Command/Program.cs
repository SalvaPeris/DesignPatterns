using Command.Concrete;
using Command;
using Command.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is the Command pattern demo: ");

        Document document = new Document();

        ICommand openCommand = new OpenCommand(document);
        ICommand saveCommand = new SaveCommand(document);
        ICommand closeCommand = new CloseCommand(document);
        
        MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
        menu.ClickOpen();
        menu.ClickSave();
        menu.ClickClose();
        
        Console.ReadKey();
    }
}