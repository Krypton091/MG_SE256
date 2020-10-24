using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace SE256_Lab_MattG.App_Code
{
    public class VirtualRealityV2 : VirtualReality
    {

        //***************************************************************************
        //NEW - Created this var to hold the HMD's ID assigned by the DB
        private int hmd_ID;
        //***************************************************************************


        public Int32 HMD_ID
        {
            get
            {
                return hmd_ID;
            }

            set
            {
                if (value >= 0)
                {
                    hmd_ID = value; 
                }
                else
                {
                    //Store an error msg in Feedback
                    feedback += "\nERROR: Sorry you entered an invalid EBook ID.";
                }
            }
        }


        //**************************************************************************************
        //  Ultimate goal is to add a record, BUT first we need to connect to the DB
        //    So that is how we will start this process.
        //**************************************************************************************
        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @GetConnected();     //Set the Who/What/Where of DB


            //*******************************************************************************************************
            string strSQL = "INSERT INTO HMDs (HmdName, ScreenRes, RefreshRate, DisplayType, PcOrStandalone, Brand, Price, DateReleased) VALUES (@HmdName, @ScreenRes, @RefreshRate, @DisplayType, @PcOrStandalone, @Brand, @Price, @DateReleased)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@HmdName", HmdName);
            comm.Parameters.AddWithValue("@ScreenRes", ScreenRes);
            comm.Parameters.AddWithValue("@RefreshRate", RefreshRate);
            comm.Parameters.AddWithValue("@DisplayType", DisplayType);
            comm.Parameters.AddWithValue("@PcOrStandalone", PcOrStandalone);
            comm.Parameters.AddWithValue("@Brand", Brand);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@DateReleased", DateReleased);

            //*******************************************************************************************************

            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";       //Report that we made the connection and added a record
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }

            //Return resulting feedback string
            return strResult;
        }




        //**************************************************************************************
        //  NEW - Part one of drill-down search (Takes search params to narrow the search results
        //**************************************************************************************
        public DataSet SearchHMDs(String strHmdName, String strRefreshRate)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();


            //Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();


            //Write a Select Statement to perform Search
            String strSQL = "SELECT HMD_ID, HmdName, ScreenRes, RefreshRate FROM HMDs WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (strHmdName.Length > 0)
            {
                strSQL += " AND HmdName LIKE @HmdName";
                comm.Parameters.AddWithValue("@HmdName", "%" + strHmdName + "%");
            }
            if (strRefreshRate.Length > 0)
            {
                strSQL += " AND RefreshRate LIKE @RefreshRate";
                comm.Parameters.AddWithValue("@RefreshRate", "%" + strRefreshRate + "%");
            }


            //Create DB tools and Configure
            //*********************************************************************************************
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic info to command object
            comm.Connection = conn;     //tell the commander what connection to use
            comm.CommandText = strSQL;  //tell the command what to say

            //Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

            //*********************************************************************************************

            //Get Data
            conn.Open();                //Open the connection (pick up the phone)
            da.Fill(ds, "HMDs_Temp");     //Fill the dataset with results from database and call it "HMDs_Temp"
            conn.Close();               //Close the connection (hangs up phone)

            //Return the data
            return ds;
        }







        //NEW  - Method that returns a Data Reader filled with all the data
        // of one EBook.  This one EBook is specified by the ID passed
        // to this function
        public SqlDataReader FindOneEBook(int intHMD_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = GetConnected();

            //My SQL command string to pull up one EBook's data
            string sqlString =
           "SELECT * FROM HMDs WHERE HMD_ID = @HMD_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@HMD_ID", intHMD_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Return some form of feedback
            return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

        }







        //Method that will delete one EBook record specified by the ID
        //It will return an Interger meant for feedback on how many 
        // records were deleted
        public string DeleteOneEBook(int intHMD_ID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = GetConnected();

            //My SQL command string to pull up one EBook's data
            string sqlString =
           "DELETE FROM HMDs WHERE HMD_ID = @HMD_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@HMD_ID", intHMD_ID);

            try
            {
                //Open the connection
                conn.Open();

                //Run the Delete and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Deleted.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return strResult;


        }




        /// <summary>
        /// NEW - Method to Update a Record in the DB
        /// </summary>
        /// <returns></returns>
        public string UpdateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";

            //Create SQL command string
            string strSQL = "UPDATE HMDs SET HmdName = @HmdName, ScreenRes = @ScreenRes, RefreshRate = @RefreshRate, DisplayType=@DisplayType, Brand=@Brand, Price=@Price, DateReleased=@DateReleased, DateRentalExpires=@DateRentalExpires, BookmarkPage=@BookmarkPage  WHERE HMD_ID = @HMD_ID;";

            // Create a connection to DB
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@HmdName", HmdName);
            comm.Parameters.AddWithValue("@ScreenRes", ScreenRes);
            comm.Parameters.AddWithValue("@RefreshRate", RefreshRate);
            comm.Parameters.AddWithValue("@DisplayType", DisplayType);
            comm.Parameters.AddWithValue("@Brand", Brand);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@DateReleased", DateReleased);
            comm.Parameters.AddWithValue("@HMD_ID", HMD_ID);

            try
            {
                //Open the connection
                conn.Open();

                //Run the Update and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Updated.";
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return strResult;

        }












        //**************************************************************************************
        //  NEW - Utility function so that one string controls all SQL Server Login info
        //**************************************************************************************
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_MGray;User Id=SE245_MGray;Password=008008029;";
        }




        //Default Constructor
        public VirtualRealityV2() : base()  //Calls the parents constructor
        {
            //
        }

    
    }
}