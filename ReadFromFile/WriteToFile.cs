using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CRUDFile
{
    class WriteToFile
    {
        public static void WritingToFile()
        {
            StreamWriter sw = new StreamWriter(@"../../../Files/WriteToFile.txt", true);//,true if I want to append
            sw.Write("Name Age Job");
            sw.Flush();
        }

    }
}
