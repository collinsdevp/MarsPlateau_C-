using System;
using System.Linq;

namespace MarsPlateau
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter grid (eg 5 3):");
            var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            Position position = new Position();

            Console.WriteLine("Enter move(eg F or/and L or/and R):");
            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.StartMoving(maxPoints, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
