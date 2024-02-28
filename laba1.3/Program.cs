using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        char symbol = 'C'; 
        List<string> stringList = new List<string> { "Cat", "Dog", "Car", "CiviC", "Lion", "ABC","Computer","CliniC" }; 
      
        int count = stringList.Count(s =>
            s.Length > 1 &&
            s.First() == symbol &&
            s.Last() == symbol);

        Console.WriteLine($"Кількість елементів, які містять більше одного символу та починаються і закінчуються символом {symbol}: {count}");
    }
}



        
        

