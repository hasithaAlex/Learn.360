using System;

namespace design.pattern
{
    // comes under creational pattern
    // this pattern provides one of the best ways to create an object.

    interface Mammal
    {
        void drinkMilk();
    }
    
    class Human : Mammal
    {
        public void drinkMilk()
        {
            Console.WriteLine("Human drinking!!");
        }
    }

    class Zeebra : Mammal
    {
        public void drinkMilk()
        {
            Console.WriteLine("Zeebra drinking");
        }
    }

    class MammalFactory
    {
        // In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.
        public static Mammal getMammal(String MammalType) {
            if (MammalType == null)
            {
                return null;
            }
            else if (MammalType.Equals("Human", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Human();
            }
            else if (MammalType.Equals("Zeebra", StringComparison.CurrentCultureIgnoreCase))
            {
                return new Zeebra();
            }

            return null;
        }
    }
              
    class Factory
    {
        public void run()
        {
            Mammal human = MammalFactory.getMammal("Human");
            human.drinkMilk();

            Mammal zeebra = MammalFactory.getMammal("Zeebra");
            zeebra.drinkMilk();
        }
    }

}
