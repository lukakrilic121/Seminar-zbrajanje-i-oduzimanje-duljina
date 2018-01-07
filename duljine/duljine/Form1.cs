using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duljine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prva_duljina;
            double druga_duljina;
            double rezultat;
            string veličina;

            if (double.TryParse(IznosDuljine.Text, out prva_duljina) && double.TryParse(IznosDuljine2.Text, out druga_duljina))
            {
                if (ListaDuljina.SelectedIndex == ListaDuljine2.SelectedIndex)
                {
                    if (ListaOperacije.SelectedIndex == 0)
                    {
                        rezultat = prva_duljina + druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina = ListaDuljina.Text;

                    }
                    else
                    {
                        rezultat = prva_duljina - druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina = ListaDuljina.Text;
                    }
                    switch (veličina)
                    {
                        case "m":
                            Velicina.Text = veličina;
                            break;
                        case "km":
                            Velicina.Text = veličina;
                            break;
                        case "mm":
                            Velicina.Text = veličina;
                            break;
                        case "in":
                            Velicina.Text = veličina;
                            break;
                        case "feet":
                            Velicina.Text = veličina;
                            break;
                        case "yard":
                            Velicina.Text = veličina;
                            break;
                        case "mile":
                            Velicina.Text = veličina;
                            break;
                        case "cm":
                            Velicina.Text = veličina;
                            break;



                    }
                }
                else
                {
                    MessageBox.Show("Morate izabrati iste veličine");
                }
            }
            else
            {
                MessageBox.Show("niste stavili duljinu");
            }
        }
    }
}
