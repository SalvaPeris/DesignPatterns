using Command.Concrete;
using Command.Interface;

namespace Command
{
    public class MenuOptions
    {
        private ICommand _openCommand;
        private ICommand _saveCommand;
        private ICommand _closeCommand;
        public MenuOptions(ICommand openCommand, ICommand saveCommand, ICommand closeCommand)
        {
            _openCommand = openCommand;
            _saveCommand = saveCommand;
            _closeCommand = closeCommand;
        }

        public void ClickOpen()
        {
            _openCommand.Execute();
        }
        
        public void ClickSave()
        {
            _saveCommand.Execute();
        }
        
        public void ClickClose()
        {
            _closeCommand.Execute();
        }
    }
}
