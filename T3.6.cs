using System;

namespace LineApplication

{

    class Line

    {

        private double length;   // Length of a line

        public Line()


        {
            this.length = 10;

            Console.WriteLine("Object is being created, length = " + length);

        }



        public void setLength(double len)

        {

            this.length = len;    

        }

        public double getLength()

        {

            return this.length;

        }

    }



    class TestLine

    {

        static void Main(string[] args)

        {

            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }

}