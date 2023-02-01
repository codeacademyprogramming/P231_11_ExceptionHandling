using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = null;


            Console.WriteLine("indexi daxil edin:");
            string indexStr = Console.ReadLine();



            try
            {
                int index = Convert.ToInt32(indexStr);
                Console.WriteLine(numbers[index]);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Yaziniz duzgun formatda deyil!");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Arrayin bele bir indexi yoxdur");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi");
            }




            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");
            Console.WriteLine("......");


            int num;
            string numStr;
            do
            {
                Console.WriteLine("Ededi daxil edin:");
                numStr = Console.ReadLine();

            } while (int.TryParse(numStr, out num));
            //} while (!TryConvert(numStr, out num));


            Console.WriteLine(num);
        }


        static bool TryConvert(string value,out int num)
        {
            try
            {
                num = Convert.ToInt32(value);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }


    }
}
