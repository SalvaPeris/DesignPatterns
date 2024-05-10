
using Command.Interface;

namespace Command.Concrete
{
    public class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Save();
        }
    }
}
