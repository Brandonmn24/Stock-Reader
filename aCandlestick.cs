using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    public class aCandlestick
    {
        //public string ticker { get; set; }
        //public string period { get; set; }
        //sets and gets the data for needed data to display
        public DateTime date { get; set; }
        public decimal open { get; set; }
        public decimal high { get; set; }
        public decimal low { get; set; }
        public decimal close { get; set; }
        public ulong volume { get; set; }

        private static char[] delimiters = { '"', ',', ';' }; //set of delimiters that are in the string line

        //This is a default constructor
        public aCandlestick() { }

        //copy constructor = new aCandleStick(someOtherCandleStick)
        public aCandlestick(aCandlestick otherCandleStick)
        {
            //ticker = otherCandleStick.ticker;
            //period = otherCandleStick.period;
            date = otherCandleStick.date;
            open = otherCandleStick.open;
            high = otherCandleStick.high;
            low = otherCandleStick.low;
            close = otherCandleStick.close;
            volume = otherCandleStick.volume;
        }

        //add ticker and add stock type daily/weekly/monthly
        public aCandlestick(string line)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string[] strings = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); //split the line by delimiters

            //ticker = strings[0];
            //period = strings[1];
            string dateString = strings[2]; //at second index since ticker and period are in 0 and 1 respectively

            date = DateTime.Parse(dateString, provider); //store date as a string
            open = Math.Round(Convert.ToDecimal(strings[3]), 2); //converts string to decimal and then round to 2 decimal places
            high = Math.Round(Convert.ToDecimal(strings[4]), 2);//converts string to decimal and then round to 2 decimal places
            low = Math.Round(Convert.ToDecimal(strings[5]), 2);//converts string to decimal and then round to 2 decimal places
            close = Math.Round(Convert.ToDecimal(strings[6]), 2); //converts string to decimal and then round to 2 decimal places
            volume = Convert.ToUInt64(strings[7]); //stores volume
        }
    }
}
