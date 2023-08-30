using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectForm.Class
{
    class TextValid
    {
        public void GetForm(string ResultForm)
        {
            string[] resF = ResultForm.Split(',');

            string filePath = "./Form" + resF[0] + ".txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string value in resF)
                {
                    writer.WriteLine(value);
                }
            }

            Console.WriteLine("Create File Test Success");
        }
    }
}
