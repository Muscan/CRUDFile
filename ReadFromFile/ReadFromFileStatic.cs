using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CRUDFile
{
    class ReadFromFileStatic
    {
        public static void ReadSimpleFileOneByOne()
        {
            //Declare strings
            string path = @"../../../Files/InFile.txt";
            string[] line = File.ReadAllLines(path);//read from the lines from fles(line[0]=> linia 1 din fisier)
            string[] name = new string[line.Length];//read all the names in array of strings
            int[] age = new int[line.Length];//Age[0] => Line 1, first age

            for (int i = 0; i < line.Length; i++)
            /*For  
              John 15
              Sancy 31
              Math  89 => 3 lines*/

            {
                string[] word = line[i].Split(" ");
                name[i] = word[0];
                age[i] = int.Parse(word[1]);
            }
            for (int i = 0; i < line.Length; i++)
            {
                Console.WriteLine($"{name[i]} is {age[i]} years old.");
            }
        }
    }
}
