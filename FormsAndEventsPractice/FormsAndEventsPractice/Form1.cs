using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAndEventsPractice
{
    public partial class Form1 : Form
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        bool moveRight = true;
        bool moveUp = true;
        public Form1()
        {
            
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Hello World";
            MessageBox.Show("This is a message.\n"+text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += $"\nYou clicked button 2. {sender.ToString()}\n";
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text += "b3down ";
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text += "b3up ";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text += "Text box double clicked. ";
        }

        // Returns the number of vowels already in the text box.
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            uint numVowels = 0;
            foreach(char c in textBox1.Text)
            {
                if(vowels.Contains(c))
                {
                    numVowels++;
                }
            }
            if(numVowels == 0)
            {
                textBox1.Text = "There were no vowels in the text box.";
            }
            else
            {
                textBox1.Text = $"There were {numVowels} vowels in the text box.";
            }
        }

        private void label2_MouseIn(object sender, EventArgs e)
        {
            textBox2.Text = "In";
            if(checkBox1.Checked)
            {
                MessageBox.Show("Check box 1 checked.");
            }
        }

        private void label2_MouseOut(object sender, EventArgs e)
        {
            textBox2.Text = "Out";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Text box 1 disabled.");
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Text box 1 enabled.");
                textBox1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string chemical = "Fizzle!";
            string chemCode = "";
            RadioButton[] radioButtons = { C1_1, C1_2, C1_3};
            CheckBox[] checkBoxes = { C2_1, C2_2, C2_3 };

            if(C1_1.Checked)
            {
                chemCode += "A";
            }
            else if(C1_2.Checked)
            {
                chemCode += "B";
            }
            else if(C1_3.Checked)
            {
                chemCode += "C";
            }

            foreach(CheckBox cb in checkBoxes)
            {
                if(cb.Checked)
                {
                    chemCode += (Array.IndexOf(checkBoxes,cb)+1);
                }
            }

            switch(chemCode)
            {
                case "12":
                    chemical = "Water";
                    break;
                case "13":
                    chemical = "Hydrochloric Acid";
                    break;
                case "A1":
                    chemical = "Methane";
                    break;
                case "A2":
                    chemical = "Carbon Dioxide";
                    break;
                case "A3":
                    chemical = "Carbon Tetrachloride";
                    break;
                case "A12":
                    chemical = "Acetic Acid";
                    break;
                case "A13":
                    chemical = "Chloroform";
                    break;
                case "B1":
                    chemical = "Ammonia";
                    break;
                case "B2":
                    chemical = "Nitrous Oxide";
                    break;
                case "B12":
                    chemical = "Nitric Acid";
                    break;
                case "B13":
                    chemical = "Ammonium Chloride";
                    break;
                case "C1":
                    chemical = "Hydrogen Sulfide";
                    break;
                case "C2":
                    chemical = "Sulfur Trioxide";
                    break;
                case "C12":
                    chemical = "Sulfuric Acid";
                    break;
                default:
                    break;

            }
            label3.Text = chemical;
            if(chemical == "Fizzle!")
            {
                textBox1.Text += "You didn't make anything interesting.";
            }
            else
            {
                textBox1.Text += $"You made: {chemical}.";
            }
        }
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (label4.Left <= 20)
            {
                moveRight = true;
            }
            else if (label4.Left >= 420)
            {
                moveRight = false;
            }
            if (moveRight)
            {
                label4.Left++;
            }
            else
            {
                label4.Left--;
            }
            label4.Text = $"({label4.Left.ToString()}, {label4.Top.ToString()})";
        }
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            if(label4.Top <= 300)
            {
                moveUp = false;
            }
            else if(label4.Top >= 500)
            {
                moveUp = true;
            }
            if(moveUp)
            {
                label4.Top--;
            }
            else
            {
                label4.Top++;
            }
            label4.Text = $"({label4.Left.ToString()}, {label4.Top.ToString()})";
        }


    }
}
