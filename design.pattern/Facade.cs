using System;
using System.Collections.Generic;
using System.Text;

namespace design.pattern
{
    //comes under structural pattern 
    public interface Shape {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }

   
    class FacadeShapeMaker
    {
        //Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system.
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public FacadeShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }


    public class FacadePatternDemo
    {
        public void run()
        {
            FacadeShapeMaker shapeMaker = new FacadeShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }

}
