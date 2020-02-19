using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Beamerbeispiel.Model;

namespace WindowsFormsApp_Beamerbeispiel {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e ) {
            //textBox1.Text = "Hallo Textfeld1";
            //textBox2.Text = "Hallo Spencer";
            string s = textBox1.Text;
            
            Pirat p = new Pirat () { Name = textBox1.Text};
            Gang.Add ( p );

            List<Pirat> lp = Gang.PiratenGangBereitstellen();
            Pirat x = lp.ElementAt (0);

            textBox2.Text = x.Name;
        }
    }
}
