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


        
       
        public double OmjerJedinice(string veličina_1,string veličina_2)
        {
            double broj=0;
            switch (veličina_2)
            {
                case "m":
                    {
                        if (veličina_1 == "km")
                        {
                            broj+= 0.001;
                        }

                        if (veličina_1 == "cm")
                        {
                            broj += 100;
                        }

                        if (veličina_1 == "mm")
                        {
                            broj += 1000;

                        }
                        if (veličina_1 == "feet")
                        {
                            broj += 3.28084;
                        }
                        if (veličina_1 == "inch")
                        {
                            broj += 39.3701;
                        }
                        if (veličina_1 == "yard")
                        {
                            broj += 1.09361;
                        }
                        break;
                    }

                case "km":
                    {
                        if (veličina_1 == "m")
                        {
                            broj += 1000;
                        }

                        if (veličina_1 == "cm")
                        {
                            broj += 100000;
                        }
                        if (veličina_1 == "mm")
                        {
                            broj += 1000000;

                        }
                        if (veličina_1 == "feet")
                        {
                            broj += 3280.84;
                        }

                        if (veličina_1 == "inch")
                        {
                            broj += 39370.1;
                        }

                        if (veličina_1 == "yard")
                        {
                            broj += 1093.61;
                        }
                        break;
                    }
                case "cm":
                    {
                        if (veličina_1 == "m")
                        {
                            broj +=  0.1;

                        }

                        if (veličina_1 == "km")
                        {
                            broj += 0.00001;
                        }
                        if (veličina_1== "mm")
                        {
                            broj += 10;
                        }
                        if (veličina_1 == "feet")
                        {
                            broj += 0.0328084;
                        }

                        if (veličina_1 == "inch")
                        {
                            broj += 0.393701;
                        }

                        if (veličina_1 == "yard")
                        {
                            broj += 0.0109361;
                        }
                        break;
                    }
                case "mm":
                    {
                        if (veličina_1 == "m")
                        {
                            broj += 0.001;

                        }

                        if (veličina_1 == "km")
                        {
                            broj += 0.000001;
                        }
                        if (veličina_1 == "cm")
                        {
                            broj += 0.1;

                        }
                        if (veličina_1 == "feet")
                        {
                            broj += 0.00328084;
                        }

                        if (veličina_1 == "inch")
                        {
                            broj += 0.0393701;
                        }

                        if (veličina_1 == "yard")
                        {
                            broj += 0.00109361;
                        }
                        break;
                    }
                
                   
            }
            return broj;
            
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
                veličina_1 = ListaDuljina.Text;
                veličina_2 = ListaDuljine2.Text;



                BrojVeličine = OmjerJedinice(veličina_1, veličina_2);
                 
                





                    if (ListaOperacije.SelectedIndex == 0)
                    {
                    
                        druga_duljina*= BrojVeličine;
                        rezultat = prva_duljina + druga_duljina;
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina_1 = ListaDuljina.Text;

                    }
                    else
                    {
                       
                        druga_duljina *= BrojVeličine;

                    if (prva_duljina < druga_duljina)
                    {
                        rezultat = druga_duljina - prva_duljina;
                    }
                    else
                    {
                       rezultat = prva_duljina - druga_duljina;
                    }
                       
                        IzracunataVrijednost.Text = rezultat.ToString();
                        veličina_1 = ListaDuljina.Text;
                    }
                   

                    
               
            }
            else
            {
                MessageBox.Show("niste stavili duljinu");
            }
        }
    }
}
