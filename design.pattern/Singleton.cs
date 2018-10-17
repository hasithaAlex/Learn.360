using System;

namespace design.pattern
{
    //creational pattern
    //provides one of the best ways to create an object.
   
    class SingleObject
    {
        private SingleObject() { }

        private static SingleObject instance = new SingleObject();

        //This pattern involves a single class which is responsible to create an object while making sure that only single object gets created. 
        //This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.
        public static SingleObject getInstance() {
            return instance;
        }

        public void getData() {
            Console.WriteLine("This is DB data!!");
        }
    }

    class Singleton
    {
        public void run()
        {
            //SingleObject singleObject = new SingleObject();
            SingleObject singleObject = SingleObject.getInstance();
            singleObject.getData();
        }
    }

}
