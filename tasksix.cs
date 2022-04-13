using System;

namespace TaskSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictureInRow = 3;
            int allPicture = 52;
            int fullRow = allPicture/ pictureInRow;
            int remainsPicture = allPicture % row;
            Console.WriteLine("Количество полностью заполненных рядов {0} \n Количество картионк сверх меры {1}", fullRow,remainsPicture);
        }
    }
}
