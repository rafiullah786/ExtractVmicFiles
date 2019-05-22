using SevenZip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exract7zip
{
    public class VmicFileExtractor
    {
        int totalCount = 0;


        public bool ExtractVmicFile(string path)
        {
            try
            {
                string extractFrom = path;
                int pos = extractFrom.LastIndexOf(@"\") + 1;
                string extractTo = extractFrom.Substring(0, pos);

                if (Environment.Is64BitOperatingSystem)
                {
                    //Add the address to the SevenZip dll files
                    SevenZipExtractor.SetLibraryPath(@"C:\Users\sami\Downloads\sevenzipsharp\sourceCode\sourceCode\SevenZip\7z64.dll");
                }
                SevenZipExtractor extractor = new SevenZipExtractor(extractFrom);
                extractor.ExtractArchive(extractTo);


                string extractFromImage = extractTo + @"Image.vmici";

                
                if (totalCount > 0)
                {
                    
                    return true ;
                }
                    
                
                totalCount++;
                ExtractVmicFile(extractFromImage);

                return true;

            }

            catch(Exception ex)
            {
                return false;
            }

        }
    }
}
