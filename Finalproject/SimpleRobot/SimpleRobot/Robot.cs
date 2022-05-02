using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRobot
{
    public partial class Robot : Form
    {
        public Robot()
        {
            InitializeComponent();
        }
        public Robots robot = null;

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            LabelArrow.Location = new Point(0, 0);
            label1.Text = Convert.ToString(LabelArrow.Location);
            label2.Text = "Going North";

            robot = new Robots(LabelArrow.Location.X, LabelArrow.Location.Y, label2.Text);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            label2.Text = "Going North";

            if (checkBox1.Checked)
            {
                robot.Positiony = robot.Positiony - 10;
            }
            else 
            {
                robot.Positiony = robot.Positiony - 1;
            }
            ValidMovement();
            updaterobotposition(robot.Positionx, robot.Positiony);
        }
        private void btnEast_Click(object sender, EventArgs e)
        {
            label2.Text = "Going East";

            if (checkBox1.Checked)
            {
                robot.Positionx = robot.Positionx + 10;
            }
            else
            {
                robot.Positionx = robot.Positionx + 1;
            }
            ValidMovement();
            updaterobotposition(robot.Positionx, robot.Positiony);
        }
        private void btnSouth_Click(object sender, EventArgs e)
        {
            label2.Text = "Going South";

            if (checkBox1.Checked)
            {
                robot.Positiony = robot.Positiony + 10;
            }
            else
            {
                robot.Positiony = robot.Positiony + 1;
            }
            ValidMovement();
            updaterobotposition(robot.Positionx, robot.Positiony);
        }
        private void btnWest_Click(object sender, EventArgs e)
        {
            label2.Text = "Going West";

            if (checkBox1.Checked)
            {
                robot.Positionx = robot.Positionx - 10;
            }
            else
            {
                robot.Positionx = robot.Positionx - 1;
            }
            ValidMovement();
            updaterobotposition(robot.Positionx, robot.Positiony);
        }
        public void updaterobotposition(int x, int y)
        {
            LabelArrow.Location = new Point(x, y);
        }
        public void ValidMovement() 
        {
            string message = "You cant move outside of the container 100x 100";

            if (robot.Positionx > 100 || robot.Positionx < 0) 
            {
                robot.Positionx = robot.Positionx;
                MessageBox.Show(message);
                robot = new Robots(LabelArrow.Location.X, LabelArrow.Location.Y, label2.Text);
            }
            else if (robot.Positiony > 100 || robot.Positiony < 0)
            {
                robot.Positiony = robot.Positiony;
                MessageBox.Show(message);
                robot = new Robots(LabelArrow.Location.X, LabelArrow.Location.Y, label2.Text);
            }
        }


        
    }
}
