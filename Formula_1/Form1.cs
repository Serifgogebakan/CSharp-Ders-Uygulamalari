using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula_1
{
    public partial class Form1 : Form
    {
        bool My_Car_Running = false;
        int My_Car_Velocity = 0;
        bool My_Car_Stop = true;
        bool My_Car_Left = false;
        bool My_Car_Right = false;
        bool My_Car_Break = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                My_Car_Break = false;
                My_Car_Running = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                My_Car_Running = false;
                My_Car_Break = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                My_Car_Right = false;
                My_Car_Left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                My_Car_Left = false;
                My_Car_Right = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                My_Car_Running = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                My_Car_Break = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                My_Car_Left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                My_Car_Right = false;
            }
        }
        private void Main_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void My_Car_Velocity_timer1_Tick(object sender, EventArgs e)
        {
            if(My_Car_Running && My_Car_Velocity < 80)
            {
                My_Car_Velocity = My_Car_Velocity + 5;
            }
            if(!My_Car_Running && My_Car_Velocity > 0)
            {
                My_Car_Velocity = My_Car_Velocity - 5;
            }
            if(My_Car_Break && My_Car_Velocity > 0)
            {
                My_Car_Velocity = My_Car_Velocity - 5;
            }
            if(My_Car_Velocity == 0)
            {
                My_Car_Stop = true;
            }
            else
            {
                My_Car_Stop = false;
            }
        }

        private void My_Car_Movement_timer1_Tick(object sender, EventArgs e)
        {
            if (!My_Car_Stop)
            {
                Move_Lanes();

                if(My_Car_Left && My_Car_pictureBox1.Left > 30)
                {
                    My_Car_pictureBox1.Left = My_Car_pictureBox1.Left - 5;
                }
                if(My_Car_Right && My_Car_pictureBox1.Left < 218)
                {
                    My_Car_pictureBox1.Left = My_Car_pictureBox1.Left + 5;
                }
            }
        }

        private void Move_Lanes()
        {
            Lane1_pictureBox1.Top = Lane1_pictureBox1.Top + My_Car_Velocity;
            Lane2_pictureBox1.Top = Lane2_pictureBox1.Top + My_Car_Velocity;

        }
    }
}
