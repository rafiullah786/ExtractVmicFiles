using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exract7zip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giver the full path with extension to the file 
            string vmicFilePath = @"C:\E Drive\Precipoint Coding Chellange\Testing\Rattus norvegicus - Kidney.vmic";
            VmicFileExtractor vmic = new VmicFileExtractor();
            bool dziFolderpath= vmic.ExtractVmicFile(vmicFilePath);

            if (dziFolderpath == false)
                Console.WriteLine("No file found");
            else
            {
                
                int pos = vmicFilePath.LastIndexOf(@"\") + 1;
                string folderPath = vmicFilePath.Substring(0, pos);

                folderPath=folderPath + "dzc_output_files";
                Console.WriteLine(folderPath);
            }
               

        }
    }
}
