using System;

namespace AbstractHomework
{
    
           internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("chose one of them: ");
                Console.WriteLine("1.Square");
                Console.WriteLine("2.Rectangle");
                Console.WriteLine("0.Quit");
                int input = int.Parse(Console.ReadLine());


                switch (input)
                {
                    case 1:
                        Console.WriteLine("Please enter the square side length: ");
                        int side = int.Parse(Console.ReadLine());
                        Square square = new Square(side);
                        square.CalcArea();
                        break;


                    case 2:
                        Console.WriteLine("Please enter the rectangle width: ");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the rectangler length: ");
                        int length = int.Parse(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width, length);
                        rectangular.CalcArea();
                        break;

                    case 0:
                        Console.Beep();
                        Console.Clear();
                        Console.WriteLine("Good bye");
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Try to join");
                        break;
                }
            }
        }


        abstract class Figure
        {
            public abstract void CalcArea();
        }


        class Square : Figure
        {
            private int _side;

            public Square(int side)
            {
                Side = side;
            }

            public int Side
            {


                get { return _side; }


                set
                {
                    if (_side < 0)
                    {
                        Console.WriteLine("Try Again");
                        return;
                    }
                    _side = value;
                }
            }

            public override void CalcArea()
            {
                int SquareArea = Side * Side;
                Console.WriteLine($"Area of the Square:{SquareArea}");
                return;
            }
        }

        class Rectangular : Figure
        {
            private int _width;
            private int _length;


            public Rectangular(int width, int length)
            {
                Width = width;
                Length = length;
            }

            public int Length
            {
                get { return _length; }

                set
                {
                    if (_length < 0)
                    {
                        Console.WriteLine("Length fals try again");
                        return;
                    }
                    _length = value;
                }
            }

            public int Width
            {
                get { return _width; }

                set
                {
                    if (_width < 0)
                    {
                        Console.WriteLine("Length fals try again:");
                        return;
                    }
                    _width = value;
                }
            }

            public override void CalcArea()
            {
                int RecArea = Width * Length;
                Console.WriteLine($"Area of the Rectangular: {RecArea}");
                return;
            }
        }

    }

