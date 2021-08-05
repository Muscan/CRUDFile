using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CRUDFile
{
    class ReadFromFileDynamic
    {
        public static void ReadFromFile2()
        {
            string path = @"../../../Files/Dinamic.txt";
            string[] line = File.ReadAllLines(path);
            string[] name = new string[line.Length];
            int[] age = new int[line.Length];
            string[] street = new string[line.Length];
            int[] houseNumber = new int[line.Length];
            string[] country = new string[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                string[] word = line[i].Split(" ");
                int j = 0;
                while (char.IsDigit(word[j][0]) == false)
                {
                    name[i] += word[j] + " ";
                    j++;
                }
                age[i] = int.Parse(word[j]);
                j++;
                country[i] = word[j];
                j++;
                while (char.IsDigit(word[j][0]) == false)
                {
                    street[i] += word[j] + " ";
                    j++;
                }
                houseNumber[i] = int.Parse(word[j]);
            }
            for(int i=0; i<name.Length; i++)
                Console.WriteLine($"{name[i]} is {age[i]} years young and it lives in {country[i]} {street[i]} {houseNumber[i]}");
        }
    }
}
