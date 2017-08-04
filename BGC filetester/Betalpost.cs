using BGC_filetester.Typer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGC_filetester
{
    class Betalpost
    {
        public string transkod { get;  set; }
        public string betdag { get;  set; }

        public string periodkod { get;  set; }

        public string sjavfornyande { get ; set; }

        public string betnummer { get;  set; }

        public string belopp { get;  set; }

        public string betalningsmottagare { get;  set; }
        public string referense { get;  set; }

        public string _statuskod = " ";
        public string testline()
        {

            return transkod + betdag + periodkod + sjavfornyande + betnummer + belopp + betalningsmottagare + referense;
        }

        public string GetPeriodkod()
        {
            periodkod myPeriod;
            Enum.TryParse(periodkod, out myPeriod);

            return myPeriod.ToString();

        }

        public string GetCorrectDate()
        {
            DateTime datetime = DateTime.ParseExact(betdag, "yyyyMMdd", CultureInfo.InvariantCulture);

            return datetime.ToShortDateString();
        }

        public string GetTransaktionKod()
        {
            transkod myStatus;
            Enum.TryParse(transkod, out myStatus);
            return myStatus.ToString();
        }

        public string GetAmount()
        {
            var amount = belopp.TrimStart('0');
            try
            {
               
                amount = amount.Insert(amount.Length - 2, ",");
                return amount + " kr";
            }
            catch (Exception)
            {

                return amount;
            }
           
        }
    }
}
