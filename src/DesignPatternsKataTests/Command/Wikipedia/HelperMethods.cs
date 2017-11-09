namespace DesignPatternsKata.Command.Wikipedia
{
    public static class HelperMethods
    {
        public static Switch CreateSwitch(ISwitchable switchable)
        {
            var openCommand = new OpenSwitchCommand(switchable);
            var closeCommand = new CloseSwitchCommand(switchable);
            var returnSwitch = new Switch(openCommand, closeCommand);
            return returnSwitch;
        }
    }
}