namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 21;
            
            
            //addition
            int sum = a + b;
            //subtraction
            int diff = a - b;
            //multiply
            int product = a * b;
            //division
            int quotient = a / b;
            //remainder
            int remainder = a % b;
            
            Console.WriteLine($"The sum of {a}+{b} is {sum}");
            Console.WriteLine($"The difference of {a}-{b} is {diff}");
            Console.WriteLine($"The product of {a}*{b} is {product}");
            Console.WriteLine($"The division of {a}/{b} is {quotient}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle radius is {AreaOfCircle(radius)}");
            
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

        }

       
        
    }
}
