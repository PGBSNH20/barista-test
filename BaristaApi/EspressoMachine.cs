using System;

namespace BaristaApi
{
    internal class EspressoMachine : IEspressoMachine
    {
        public EspressoMachine()
        {
        }

        public IEspressoMachine AddWater(int v)
        {
            return this;
        }

        public IBeverage ToBravage()
        {
            // Check if all ingrediens are present for a espesso or a latte
            return null;
        }


    }
}