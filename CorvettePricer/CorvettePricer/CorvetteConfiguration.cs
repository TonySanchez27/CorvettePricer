using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvettePricer
{
    class CorvetteConfiguration
    {
        public Decimal BasePrice;
        public string Color;
        public string ConvertibleMode;
        public string TrimLevel;
        public bool HighWing;
        public bool Liftkit;
        public bool SillPlates;
        public bool FloorMats;

        public CorvetteConfiguration()
        {
            BasePrice = 67495;
            Color = "White";
            ConvertibleMode = "TopUp";
            TrimLevel = "1LT";
            HighWing = false;
            Liftkit = false;
            SillPlates = false;
            FloorMats = false;
        }

        public Decimal getBasePrice()
        {
            return BasePrice;
        }

        public Decimal getOptionsPrice()
        {
            return this.getTotalPrice() - this.BasePrice;
        }
        public Decimal getTotalPrice()
        {
            Decimal TotalPrice = BasePrice;

            if (this.TrimLevel == "2LT")
            {
                TotalPrice = TotalPrice + 6800;
            }
            if (this.Color == "Red")
            {
                TotalPrice = TotalPrice + 995;
            }
            if (this.HighWing)
            {
                TotalPrice = TotalPrice + 1150;
            }
            if (this.Liftkit)
            {
                TotalPrice = TotalPrice + 1495;
            }
            if (this.SillPlates)
            {
                TotalPrice = TotalPrice + 345;
            }
            if (this.FloorMats)
            {
                TotalPrice = TotalPrice + 235;
            }
            return TotalPrice;
        }

        public string getPictureURL()
        {
            string pictureURL;
            if (ConvertibleMode == "TopUp")
            {
                if (this.Color == "White")
                {
                    if (this.HighWing)
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.white.top.up.wing.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.up.wing.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_white_top_up_wing;

                    }
                    else
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.white.top.up.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.up.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_white_top_up;
                    }
                }
                else
                {
                    if (this.HighWing)
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.red.top.up.wing.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.up.wing.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_red_top_up_wing;
                    }
                    else
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.red.top.up.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.up.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_red_top_up;
                    }
                }
            }
            else
            {
                if (this.Color == "White")
                {
                    if (this.HighWing)
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.white.top.down.wing.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.down.wing.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_white_top_down_wing;
                    }
                    else
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.white.top.down.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.down.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_white_top_down;
                    }
                }
                else
                {
                    if (this.HighWing)
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette.red.top.down.wing.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.down.wing.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_red_top_down_wing;
                    }
                    else
                    {
                        pictureURL = "https://rphillip.asp.radford.edu/corvette/corvette/corvette.red.top.down.bmp";
                        //pictureURL = "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.down.bmp";
                        //pictureBox1.Image = CorvettePricer.Properties.Resources.corvette_red_top_down;
                    }
                }
            }
            return pictureURL;
        }



    }
}
