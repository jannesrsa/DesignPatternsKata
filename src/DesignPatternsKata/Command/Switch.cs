namespace DesignPatternsKata.Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Switch
    {
        private ICommand _closedCommand;
        private ICommand _openedCommand;

        public Switch(ICommand closedCommand, ICommand openedCommand)
        {
            this._closedCommand = closedCommand;
            this._openedCommand = openedCommand;
        }

        //close the circuit/power on
        public void Close()
        {
            this._closedCommand.Execute();
        }

        //open the circuit/power off
        public void Open()
        {
            this._openedCommand.Execute();
        }
    }
}