using System;

class Program
{
    static void Main(string[] args)
    {
        Math math = new Math("Noah Ruppe","Fractions","7.3","2-10");
        string math1 = math.GetHomeWorkList();
        Console.WriteLine(math1);

        English english = new English("Noah Ruppe","History","Effects of world war II");
        string english1 = english.GetWritingInfo();
        Console.WriteLine(english1);

    }
}