namespace DesignPatternsKata.Adapter.Channel9
{
    public class FlyingSquirrelAdapter : ICharacter
    {
        public FlyingSquirrelAdapter(IFlyingSquirrel flyingSquirrel) => FlyingSquirrel = flyingSquirrel ?? throw new System.ArgumentNullException(nameof(flyingSquirrel));

        public IFlyingSquirrel FlyingSquirrel { get; }

        public int Attack() => FlyingSquirrel.DropAcorns();

        public int Chase() => FlyingSquirrel.Fly();

        public int Flee() => FlyingSquirrel.Fly();
    }
}