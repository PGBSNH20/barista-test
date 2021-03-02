using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage = new EspressoMachine()
                   .AddWater(20)
                   .AddWater(2)
                   .AddWater(3)
                   .ToBravage();


            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = 
            new EspressoMachine()
                .AddWater(20)
                .AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta)
                .AddMilk()
            .ToBravage();
            //latte is type of Latte
             */
        }
    }
}
