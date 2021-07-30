using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_BouncingPanel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private int RandomNumber(int a,int b)
        {
            return random.Next(a, b);
        }

        int maxX;
        int maxY;
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain form = sender as FormMain;
            maxX = form.Size.Width;
            maxY = form.Size.Height;

            Start();
        }
        
        
        
        private void Start()
        {
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        panel = panel1;
                        break;
                    case 1:
                        panel = panel2;
                        break;
                    case 2:
                        panel = panel3;
                        break;
                    case 3:
                        panel = panel4;
                        break;
                    case 4:
                        panel = panel5;
                        break;
                    default:
                        break;
                }
                int x;
                int y;
                int xPanel;
                int yPanel;

                xPanel = panel.Location.X;
                yPanel = panel.Location.Y;

                do
                {
                    x = RandomNumber(-75, 75);
                    y = RandomNumber(-75, 75);

                } while (((xPanel + x) > maxX - panel.Width) || ((xPanel + x) < 0) || ((yPanel + y) > maxY - panel.Height) || ((yPanel + y) < 0));

                xPanel += x;
                yPanel += y;

                panel.Location = new Point(xPanel, yPanel);
                panel.BackColor = Color.FromArgb(RandomNumber(0, 255), RandomNumber(0, 255), RandomNumber(0, 255));
            }
            
        }
    }
}
