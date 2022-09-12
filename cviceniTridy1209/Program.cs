using cviceniTridy1209;

class Program
{
    public static void Main(string[] args)
    {
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

        


    }
}
