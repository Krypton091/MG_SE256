using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class FileIO
    {
        public static void writeFile(string myFileName, string myString)
        {
            //declare a StreamWriter object
            StreamWriter sw;


            try
            {
                //Create the streamwriter and set the filename 
                // and how it is opened
                sw =
                     new StreamWriter(File.Open(@myFileName,
                     FileMode.OpenOrCreate));

                //place the cursor at the first column, on the row after the
                //last record
                sw.BaseStream.Seek(0, SeekOrigin.End);

                //write the data to the bottom of the file
                sw.WriteLine(myString);

                //Force the write, save the file, clears the buffer
                sw.Flush();

                //Close the file whether or not there was an error
                sw.Close();
            }
            catch (Exception err)
            {
                string x = err.Message;
            }
            finally
            {
            }
        

        }
    }
}
