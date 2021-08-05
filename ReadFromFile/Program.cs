using System;
using System.IO;
using static CRUDFile.ReadFromFileStatic;
using static CRUDFile.ReadFromFileDynamic;
using static CRUDFile.WriteToFile;

namespace CRUDFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadSimpleFileOneByOne();
            ReadFromFile2();
            WritingToFile();
            
            
        }
    }
}
