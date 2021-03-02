namespace BaristaApi
{
    internal interface IEspressoMachine
    {
        IEspressoMachine AddWater(int v);

        IBeverage ToBravage();
    }
}