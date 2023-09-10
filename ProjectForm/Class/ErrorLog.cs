using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectForm.Class
{
    class ErrorLog
    {
        public void ErorrLogText(string errorM , string errorL)
        {
            string filePath = "./ErrorLog.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                    writer.WriteLine(errorM);
                    writer.WriteLine(errorL);
            }
        }
    }
}
