using cviceniTridy1209;
using System;

class Program
{
    public static void Main(string[] args)
    {

        // INTERVAL
        Interval interval1;
        Interval interval2;
        try
        {
            interval1 = new Interval(10, 50);
            interval2 = new Interval(34, 100);

            Console.WriteLine(interval1.contains(23));
            Console.WriteLine(interval1.prunik(interval2));


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //  PRIMKA

        Primka p = new Primka(new Point(-20), new Point(100));

        Console.WriteLine(p);

        // TRIANGLE
        try
        {
            Triangle t1 = new Triangle(10, 10, 10);  //rovnostranny

            Console.WriteLine(t1);

            Console.WriteLine("rovnostranny: " + t1.rovnostranny(t1.A, t1.B, t1.C)); // true
            Console.WriteLine("rovnoramenny: " + t1.rovnoramenny(t1.A, t1.B, t1.C)); // false
            Console.WriteLine("pravouhly: " + t1.pravouhly(t1.A, t1.B, t1.C));  // false

            Console.WriteLine();

            t1.A = 5; // zmenime na rovnoramenny
            Console.WriteLine(t1);

            Console.WriteLine("rovnostranny: " + t1.rovnostranny(t1.A, t1.B, t1.C)); // false
            Console.WriteLine("rovnoramenny: " + t1.rovnoramenny(t1.A, t1.B, t1.C)); // true
            Console.WriteLine("pravouhly: " + t1.pravouhly(t1.A, t1.B, t1.C));  // false

            Console.WriteLine();


            t1.B = 3; // zmenime na nesmysl
            Console.WriteLine(t1);

            Console.WriteLine("Nerovnost: " + t1.triangleInequality());
            Console.WriteLine("rovnostranny: " + t1.rovnostranny(t1.A, t1.B, t1.C)); // false
            Console.WriteLine("rovnoramenny: " + t1.rovnoramenny(t1.A, t1.B, t1.C)); // false
            Console.WriteLine("pravouhly: " + t1.pravouhly(t1.A, t1.B, t1.C));  // false


            t1.C = -10;  //tady chytime exception
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message);
        }


    }
}
