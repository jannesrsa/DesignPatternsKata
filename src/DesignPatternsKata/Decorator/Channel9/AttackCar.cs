using System;

namespace DesignPatternsKata.Decorator.Channel9
{
    public class AttackCar : ICar
    {
        public AttackCar(ICar decoratedCar) => DecoratedCar = decoratedCar ?? throw new ArgumentNullException(nameof(decoratedCar));

        public ICar DecoratedCar { get; }

        public int Attack()
        {
            return DecoratedCar.Attack() - 10;
        }

        public int Defend()
        {
            return DecoratedCar.Defend() + 30;
        }

        public int Drive()
        {
            return DecoratedCar.Drive() - 10;
        }
    }
}