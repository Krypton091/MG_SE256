using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication1
{
    class FileIO
    {
        public static string writeFile(string myFileName, string myString)
        {
            //declare a StreamWriter object
            StreamWriter sw;

            //string for feedback
            string strFeedback = "Record Added Successfully";

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
                strFeedback = "ERROR: " + x;
            }
            finally
            {

            }

            //return feedback
            return strFeedback;
        }





        //*******************************************************************************
        // Reads total file into string variable and returns it for use by driver program
        // Receives filename (including absolute address) as myFileName for 
        //   dynamic file access
        //*******************************************************************************
        public static string readFile(string myFileName)
        {
            //create string var to hold textfile contents
            string myFileString = "";
            //Declare StreamReader object
            StreamReader sr;
            //Use error-trapping whenever accessing files or servers...
            // they may not be accessible at some point!
            try
            {
                //Create object and set file and how file is to be handled
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));
                try
                {
                    //Read file from top to bottom and store it in string var
                    myFileString = sr.ReadToEnd();
                }
                finally
                {
                    sr.Close(); //Close the text file with or without errors
                }
            }
            catch (Exception exc)
            {
                string x = "ERROR: " + exc.Message; //Store error msg 
                return x;
            }
            return myFileString;   //Return the string for use by the driver program
        }
        //*******************************************************************************




        //*******************************************************************************
        // Reads the Payroll file, line-by-line and totals the Payout for each check.
        //*******************************************************************************
        public static double calcTotalPayout(string myFileName)
        {
            //Var to hold our grand total for payout
            double total = 0;

            // Create our StreamReader object
            StreamReader sr;

            try
            {
                //Open the specified file for Input
                sr = new StreamReader(File.Open(@myFileName,
                    FileMode.Open));

                try
                {
                    //While the end of file is not reached
                    //*****************************************
                    while (sr.Peek() != -1)
                    {
                        //row contains the string from one line of the textfile
                        string row = sr.ReadLine();

                        //Creates an array of strings called columns
                        // then...Parses the string (split) by each comma (',')
                        // and stores each parsed piece into the array (columns)
                        //Therefore columns[0] should be the date, columns[1] should
                        // be the first name, etc
                        string[] columns = row.Split(',');

                        //Column [6] should be the paycheck amount
                        // we convert that amount from a string to a double
                        // then add it to what already is in the var (total)
                        total += double.Parse(columns[6]);
                    }
                    //*****************************************
                }
                finally
                {
                    //Close the file with or without the error
                    sr.Close();
                }
            }
            catch (Exception exc)
            {
                //store the error message...so far, we are doing nothing with it
                string x = exc.Message;
            }

            //Return the var (total), which should have the total payout for all the checks
            return total;
        }
        //*******************************************************************************
        //*******************************************************************************




    }
}
