using BGC_filetester.Typer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGC_filetester
{
    public partial class Form1 : Form
    {
        List<Betalpost> result;
        bgcsend bgcfil;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BGC Pwner Filebrowser";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                
 bgcfil = new bgcsend(@fdlg.FileName);
            bgcfil.getfileinfo();
            lbBetBank.Text = bgcfil._betbank.TrimStart('0');
            lbBetKund.Text = bgcfil._betmottagare.TrimStart('0');
            lbLayout.Text = bgcfil._layoutnamn;
            lbSkrivdag.Text = bgcfil._skrivdag;
            lbTrans.Text = bgcfil._transkod;

            result = bgcfil.parsefile();
            
            import();
            }


            
        }

        private void import()
        {
            foreach(Betalpost line in result)
            {
                transkod myStatus;
                Enum.TryParse(line.transkod, out myStatus);

                ListViewItem item1 = new ListViewItem(line.GetTransaktionKod());
              
                item1.SubItems.Add(line.GetCorrectDate());

               

                item1.SubItems.Add(line.GetPeriodkod());
                item1.SubItems.Add(line.sjavfornyande);
                item1.SubItems.Add(line.betnummer.TrimStart('0'));
                item1.SubItems.Add(line.GetAmount());
                item1.SubItems.Add(line.betalningsmottagare.TrimStart('0'));
                item1.SubItems.Add(line.referense);

                listView1.Items.Add(item1);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgcfil._senddate = dateTimePicker1.Value.ToString("yyyyMMdd");
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
            bgcfil._postdate = dateTimePicker1.Value.ToString("yyyyMMdd");
            
            bgcfil.generateFile();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bgcfil.betpost[listView1.SelectedIndices[0]]._statuskod = "2";
            listView1.Items[listView1.SelectedIndices[0]].ForeColor = Color.Red;
        }



        private void setstatus()
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgcfil.betpost[listView1.SelectedIndices[0]]._statuskod = "9";
            listView1.Items[listView1.SelectedIndices[0]].ForeColor = Color.Maroon;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgcfil.betpost[listView1.SelectedIndices[0]]._statuskod = "1";
            listView1.Items[listView1.SelectedIndices[0]].ForeColor = Color.Coral;
        }
    }
}
