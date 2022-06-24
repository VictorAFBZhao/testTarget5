using System;

namespace testTarget5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Victor";
            char[] charArray = name.ToCharArray();
            char pri = charArray[0];
            char seg = charArray[1];
            char ter = charArray[2];
            char quar = charArray[3];
            char quin = charArray[4];
            char sext = charArray[5];
            Console.Write(sext);
            Console.Write(quin);
            Console.Write(quar);
            Console.Write(ter);
            Console.Write(seg);
            Console.Write(pri);
        }
    }
}
