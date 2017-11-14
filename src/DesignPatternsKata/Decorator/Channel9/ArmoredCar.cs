using System;

namespace DesignPatternsKata.Decorator.Channel9
{
    public class ArmoredCar : ICar
    {
        public ArmoredCar(ICar decoratedCar) => DecoratedCar = decoratedCar ?? throw new ArgumentNullException(nameof(decoratedCar));

        public ICar DecoratedCar { get; }

        public int Attack()
        {
            return DecoratedCar.Attack();
        }

        public int Defend()
        {
            return DecoratedCar.Defend() + 40;
        }

        public int Drive()
        {
            return DecoratedCar.Drive() - 20;
        }
    }
}