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
       struct Duljina
        {
             public double iznos;
             public string velicina;

            
        }


        

            public Form1()
        {
            InitializeComponent();
        }


        
        public double OmjerJedinice()

        {
           

            
            if(ListaDuljina.SelectedIndex==0 && ListaDuljine2.SelectedIndex == 1)
            {
                return 0.001;
            }
             else if(ListaDuljina.SelectedIndex==0 && ListaDuljine2.SelectedIndex == 2)
            {
                return 100;
            }
            else if(ListaDuljina.SelectedIndex == 0 && ListaDuljine2.SelectedIndex == 3)
            {
                return 1000;
            }
            else if(ListaDuljina.SelectedIndex == 1 && ListaDuljine2.SelectedIndex == 0)
            {
                return 1000;
            }
            else if(ListaDuljina.SelectedIndex == 1 && ListaDuljine2.SelectedIndex == 2)
            {
                return 100000;
            }
            else if(ListaDuljina.SelectedIndex == 1 && ListaDuljine2.SelectedIndex == 3)
            {
               return 1000000;
            }
            else if(ListaDuljina.SelectedIndex == 2 && ListaDuljine2.SelectedIndex == 0)
            {
                return 0.01;
            }
            else if(ListaDuljina.SelectedIndex == 2 && ListaDuljine2.SelectedIndex == 1)
            {
                return 0.00001;
            }
            else if(ListaDuljina.SelectedIndex == 2 && ListaDuljine2.SelectedIndex == 3)
            {
                return 10;
            }
            else if(ListaDuljina.SelectedIndex == 3 && ListaDuljine2.SelectedIndex == 0)
            {
                return 0.001;
            }
            else if(ListaDuljina.SelectedIndex == 3 && ListaDuljine2.SelectedIndex == 1)
            {
                return 0.000001;
            }
            else if(ListaDuljina.SelectedIndex == 3 && ListaDuljine2.SelectedIndex == 2)
            {
                return 0.1;
            }
            else
            {
                return 1.0;
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            double prva_duljina;
            double druga_duljina;
            double rezultat;
            string veličina_1;
            string veličina_2;
            double BrojVeličine;
           
            if (double.TryParse(IznosDuljine.Text, out prva_duljina) && double.TryParse(IznosDuljine2.Text, out druga_duljina))
            {
            

              
               
                BrojVeličine = OmjerJedinice();
                 
                





                    if (ListaOperacije.SelectedIndex == 0)
                    {
                        prva_duljina*= BrojVeličine;
                        rezultat = prva_duljina + druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina_1 = ListaDuljina.Text;

                    }
                    else
                    {
                        rezultat = prva_duljina - druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina_1 = ListaDuljina.Text;
                    }
                    switch (veličina_1)
                    {
                        case "m":
                            Velicina.Text = veličina_1;
                            break;
                        case "km":
                            Velicina.Text = veličina_1;
                            break;
                        case "mm":
                            Velicina.Text = veličina_1;
                            break;
                        case "in":
                            Velicina.Text = veličina_1;
                            break;
                        case "feet":
                            Velicina.Text = veličina_1;
                            break;
                        case "yard":
                            Velicina.Text = veličina_1;
                            break;
                        case "mile":
                            Velicina.Text = veličina_1;
                            break;
                        case "cm":
                            Velicina.Text = veličina_1;
                            break;



                    }
               
            }
            else
            {
                MessageBox.Show("niste stavili duljinu");
            }
        }
    }
}
