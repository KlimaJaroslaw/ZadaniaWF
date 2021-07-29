using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Rezystor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
                        
        }

        int cyfra1;
        int cyfra2;
        double mnoznik;
        double tolerancja;
        double rezystancja;
        StringBuilder wynik = new StringBuilder();


        private void FormMain_Load(object sender, EventArgs e)
        {
            SchemaComboBox(cbPasek1);
            SchemaComboBox(cbPasek2);
            SchemaComboBox(cbPasek3);
            SchemaComboBox(cbPasek4);            
        }

        private void SchemaComboBox(ComboBox cb)
        {
            cb.Items.Add("Srebrny");
            cb.Items.Add("Złoty");
            cb.Items.Add("Czarny");
            cb.Items.Add("Brązowy");
            cb.Items.Add("Czerwony");
            cb.Items.Add("Pomarańczowy");
            cb.Items.Add("Żółty");
            cb.Items.Add("Zielony");
            cb.Items.Add("Niebieski");
            cb.Items.Add("Fioletowy");
            cb.Items.Add("Szary");
            cb.Items.Add("Biały");
        }

        private void btOblicz_Click(object sender, EventArgs e)
        {
            if (cbPasek1.SelectedIndex >-1 && cbPasek2.SelectedIndex > -1 && cbPasek3.SelectedIndex > -1 && cbPasek4.SelectedIndex > -1)
            {
                Rezystor rezystor = new Rezystor(cyfra1, cyfra2, mnoznik, tolerancja);
                rezystancja = rezystor.ObliczRezystancje(rezystor);

                wynik.Append(rezystancja.ToString());
                wynik.Append(" k\u2126 ");
                if (tolerancja == 0)
                {
                    wynik.Append("");
                }
                else
                {
                    wynik.Append(rezystor.Tolerancja.ToString());
                    wynik.Append(" %");
                }

                tbHelp.Text = wynik.ToString();
                wynik.Clear();
            }
            
        }

        private void cbPasek_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            Panel panel;
            switch (cb.Tag)
            {
                case "1":
                    panel = panel1;
                    break;
                case "2":
                    panel = panel2;
                    break;
                case "3":
                    panel = panel3;
                    break;
                case "4":
                    panel = panel4;
                    break;
                default:
                    panel = panel5;
                    break;
            }
            if (cb == cbPasek1)
            {
                cb = cbPasek1;
                switch (cbPasek1.SelectedIndex)
                {
                    case 0:
                        cyfra1 = 0;                        
                        break;
                    case 1:
                        cyfra1 = 0;
                        break;
                    case 2:
                        cyfra1 = 0;
                        break;
                    case 3:
                        cyfra1 = 1;
                        break;
                    case 4:
                        cyfra1 = 2;
                        break;
                    case 5:
                        cyfra1 = 3;
                        break;
                    case 6:
                        cyfra1 = 4;
                        break;
                    case 7:
                        cyfra1 = 5;
                        break;
                    case 8:
                        cyfra1 = 6;
                        break;
                    case 9:
                        cyfra1 = 7;
                        break;
                    case 10:
                        cyfra1 = 8;
                        break;
                    case 11:
                        cyfra1 = 9;
                        break;
                    default:
                        break;
                }
            }

            if (cb == cbPasek2)
            {
                switch (cbPasek2.SelectedIndex)
                {
                    case 0:
                        cyfra2 = 0;
                        break;
                    case 1:
                        cyfra2 = 0;
                        break;
                    case 2:
                        cyfra2 = 0;
                        break;
                    case 3:
                        cyfra2 = 1;
                        break;
                    case 4:
                        cyfra2 = 2;
                        break;
                    case 5:
                        cyfra2 = 3;
                        break;
                    case 6:
                        cyfra2 = 4;
                        break;
                    case 7:
                        cyfra2 = 5;
                        break;
                    case 8:
                        cyfra2 = 6;
                        break;
                    case 9:
                        cyfra2 = 7;
                        break;
                    case 10:
                        cyfra2 = 8;
                        break;
                    case 11:
                        cyfra2 = 9;
                        break;
                    default:
                        break;
                }

            }

            if (cb == cbPasek3)
            {
                switch (cbPasek3.SelectedIndex)
                {
                    case 0:
                        mnoznik = Math.Pow(10, -2);
                        break;
                    case 1:
                        mnoznik = Math.Pow(10, -1);
                        break;
                    case 2:
                        mnoznik = Math.Pow(10, 0);
                        break;
                    case 3:
                        mnoznik = Math.Pow(10, 1);
                        break;
                    case 4:
                        mnoznik = Math.Pow(10, 2);
                        break;
                    case 5:
                        mnoznik = Math.Pow(10, 3);
                        break;
                    case 6:
                        mnoznik = Math.Pow(10, 4);
                        break;
                    case 7:
                        mnoznik = Math.Pow(10, 5);
                        break;
                    case 8:
                        mnoznik = Math.Pow(10, 6);
                        break;
                    case 9:
                        mnoznik = Math.Pow(10, 7);
                        break;
                    case 10:
                        mnoznik = Math.Pow(10, 8);
                        break;
                    case 11:
                        mnoznik = Math.Pow(10, 9);
                        break;
                    default:
                        break;
                }

            }

            if (cb == cbPasek4)
            {
                switch (cbPasek4.SelectedIndex)
                {
                    case 0:
                        tolerancja = 10.00;
                        break;
                    case 1:
                        tolerancja = 5.00;
                        break;
                    case 2:
                        tolerancja = 0;
                        break;
                    case 3:
                        tolerancja = 1.00;
                        break;
                    case 4:
                        tolerancja = 2.00;
                        break;
                    case 5:
                        tolerancja = 0;
                        break;
                    case 6:
                        tolerancja = 0;
                        break;
                    case 7:
                        tolerancja = 0.5;
                        break;
                    case 8:
                        tolerancja = 0.25;
                        break;
                    case 9:
                        tolerancja = 0.1;
                        break;
                    case 10:
                        tolerancja = 0.05;
                        break;
                    case 11:
                        tolerancja = 0;
                        break;
                    default:
                        break;
                }
            }

            switch (cb.SelectedIndex)
            {
                case 0:
                    panel.BackColor = Color.Silver;
                    break;
                case 1:
                    panel.BackColor = Color.Gold;
                    break;
                case 2:
                    panel.BackColor = Color.Black;
                    break;
                case 3:
                    panel.BackColor = Color.Brown;
                    break;
                case 4:
                    panel.BackColor = Color.Red;
                    break;
                case 5:
                    panel.BackColor = Color.Orange;
                    break;
                case 6:
                    panel.BackColor = Color.Yellow;
                    break;
                case 7:
                    panel.BackColor = Color.Green;
                    break;
                case 8:
                    panel.BackColor = Color.Blue;
                    break;
                case 9:
                    panel.BackColor = Color.Violet;
                    break;
                case 10:
                    panel.BackColor = Color.Gray;
                    break;
                case 11:
                    panel.BackColor = Color.White;
                    break;
                default:
                    break;
            }
        }


    }
}
