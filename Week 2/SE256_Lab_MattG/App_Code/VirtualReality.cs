using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE256_Lab_MattG.App_Code
{
    public class VirtualReality
    {
        //Title of the headset
        private string hmdName;
        //Combined resolution of the headset (1920x1080)
        private string screenRes;
        //How many times the screen updates per second
        private string refreshRate;
        //LCD, OLED, etc.
        private string displayType;
        //Brand of the headset
        private string brand;
        //When the headset was released
        private DateTime dateReleased;
        //Is the headset powered by a PC or standalone
        private string pcOrStandalone;
        //Price of headset
        private double price;

        protected string feedback;    //NEW - PROTECTED...CHILDREN SEE THIS BUT OTHERS DO NOT


        public string HmdName
        {
            get
            {
                return hmdName;
            }

            set
            {
                hmdName = value;  //If values does not have bad words...store it
            }
        }


        public string ScreenRes
        {
            get
            {
                return screenRes;
            }

            set
            {
                screenRes = value;  //If values does not have bad words...store it
            }
        }

        public string RefreshRate
        {
            get
            {
                return refreshRate;
            }

            set
            {
                refreshRate = value;
            }
        }



        public string DisplayType
        {
            get
            {
                return displayType;
            }

            set
            {

                displayType = value;

            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {

                brand = value;

            }
        }


        public DateTime DateReleased
        {
            get
            {
                return dateReleased;
            }

            set
            {
                //If the date given is not a future date...
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    dateReleased = value;  //Past Date...store it
                }
                else
                {
                    //Future Date...Store error msg in feedback
                    feedback += "\nERROR: You cannot enter future dates";
                }
            }
        }



        public string PcOrStandalone
        {
            get
            {
                return pcOrStandalone;
            }

            set
            {

                pcOrStandalone = value; 

            }
        }




        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                {
                    price = value;
                }
                else
                {
                    feedback += "\nERROR: Price is not sufficient.";
                }
            }
        }

        //NEW- Allows class to communicate with outside programs
        public string Feedback
        {
            get { return feedback; }        //allows outside code to see feedback
            // Notice there is no SET...This is because only the class can change feedback  
        }


        //NEW - Default Constructor - Runs automatically when object instance created
        public VirtualReality()
        {
            //Initialize so that there are no nulls, especially feedback
            hmdName = "";
            screenRes = "";
            refreshRate = "";
            displayType = "";
            brand = "";
            dateReleased = DateTime.Parse("1/1/1500");
            pcOrStandalone = "";
            price = 0.0;
            feedback = "";
        }
    }
}