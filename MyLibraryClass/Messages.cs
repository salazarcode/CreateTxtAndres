using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass
{
    public class Messages
    {
        public static void FinalMessage(bool result)
        {
            string success = "The file was created successfully...";
            string alreadyCreated = "The file already exists...";

            Console.WriteLine(result ? success : alreadyCreated);
        }
    }
}
