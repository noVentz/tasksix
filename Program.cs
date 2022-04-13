using System;

namespace TaskSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 3, allPicture = 52;
            int fullRow = allPicture/row;
            int remainsPicture = allPicture % row;
            Console.WriteLine("Количество полностью заполненных рядов {0} \n Количество картионк сверх меры {1}", fullRow,remainsPicture);
        }
    }
}
