namespace DesignPatternsKata.Command.Wikipedia
{
    /* The Receiver class */

    public class Engine : ISwitchable
    {
        public bool Started { get; private set; }

        public void PowerOn()
        {
            Started = true;
        }

        public void PowerOff()
        {
            Started = false;
        }
    }
}