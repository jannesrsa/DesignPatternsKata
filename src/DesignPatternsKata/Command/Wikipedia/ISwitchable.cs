namespace DesignPatternsKata.Command.Wikipedia
{
    /* An interface that defines actions that the receiver can perform */

    public interface ISwitchable
    {
        void PowerOn();

        void PowerOff();
    }
}