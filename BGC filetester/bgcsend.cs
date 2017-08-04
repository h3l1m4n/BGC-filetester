using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGC_filetester
{
    class bgcsend
    {
       public List<Betalpost> betpost;
        string _path;
        public string _senddate;
        public string _postdate;

        public string _transkod { get;  set; }
        public string _skrivdag { get; set; }
        public string _layoutnamn { get; set; }
        public string _betmottagare { get; set; }
        public string  _betbank { get; set; }
        
        public bgcsend(string path)
        {
            betpost = new List<Betalpost>();
            _path = path;
        }

        public void getfileinfo()
        {
            string line1 = File.ReadLines(@_path).First();
            _transkod = line1.Substring(0, 2);
            _skrivdag = line1.Substring(2, 8);
            _layoutnamn = line1.Substring(10, 8);
            _betmottagare = line1.Substring(62, 6);
            _betbank = line1.Substring(68, 10);

        }

        public List<Betalpost> parsefile()
        {
          
            foreach (string line in File.ReadLines(@_path).Skip(1))
            {
               var betline = new Betalpost();
                betline.transkod = line.Substring(0, 2);
                betline.betdag = line.Substring(2, 8);
                betline.periodkod = line.Substring(10, 1);
                betline.sjavfornyande = line.Substring(11, 3);
                betline.betnummer = line.Substring(15, 16);
                betline.belopp = line.Substring(31, 12);
                betline.betalningsmottagare = line.Substring(43, 10);
                betline.referense = line.Substring(53, 16);
                Debug.WriteLine(betline.testline());
                betpost.Add(betline);
            }



            return betpost;
        }

        public void generateFile()
        {
            string header = string.Format("01{0}0AUTOGIRO9900                                        0{1}{2}  ",_senddate, _betmottagare, _betbank);
            using (StreamWriter writetext = new StreamWriter(@"fakebgc.txt"))
            {
                writetext.WriteLine(header);
                foreach(Betalpost post in betpost)
                writetext.WriteLine(string.Format("82{0}0    {1}{2}{3}{4}            {5}",_postdate,post.betnummer,post.belopp,post.betalningsmottagare,post.referense,post._statuskod));

            }

        }

    }
}
