using System;

namespace DesignPatternsKata.Adapter.Channel9
{
    public class MooseAdapter : ICharacter
    {
        public MooseAdapter(IMoose moose) => Moose = moose ?? throw new ArgumentNullException(nameof(moose));

        public IMoose Moose { get; }

        public int Attack() => Moose.Charge();

        public int Chase() => Moose.Run();

        public int Flee() => Moose.Run();
    }
}