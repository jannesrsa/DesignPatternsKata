namespace DesignPatternsKata.Command
{
    /* The Receiver class */
    public class Light : ISwitchable
    {
        public bool On { get; private set; }

        public void PowerOn()
        {
            On = true;
        }

        public void PowerOff()
        {
            On = false;
        }
    }
}