using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace calcuator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        String rovnase = "";
        bool operation_pressed = false;
        bool rovnase_pressed = false;
        bool copy_pressed = false;
        bool paste_pressed = false;
        bool držhubu = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            výsledek.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((výsledek.Text == "0")||(operation_pressed)||(rovnase_pressed))
            výsledek.Clear();
            operation_pressed = false;
            rovnase_pressed = false;
            Button n = (Button)sender;
            výsledek.Text = výsledek.Text + n.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            operation = n.Text;
            rovnase = n.Text;
            value = Double.Parse(výsledek.Text);
            operation_pressed = true;
            rovnase_pressed = true; 
        }

        private void buttonDržhubu_Click(object sender, EventArgs e)
        {            
            držhubu = true;
            bool držhubuwait = false;
            if (držhubu)                
            {
                výsledek.Text = "držhubu kokot";
                držhubuwait = true;            
            }
            
            if(držhubuwait)
            {
                Thread.Sleep(2000);
                Application.Exit();
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Button n = (Button)sender;
            //operation = n.Text;
            //value = Double.Parse(výsledek.Text);
            //operation_pressed = true;

            operation_pressed = false;
            rovnase_pressed = true;
            switch (operation)
            {
                case "+":
                    výsledek.Text = (value + Double.Parse(výsledek.Text)).ToString();
                    break;
                case "-":
                    výsledek.Text = (value - Double.Parse(výsledek.Text)).ToString();
                    break;
                case "*":
                    výsledek.Text = (value * Double.Parse(výsledek.Text)).ToString();
                    break;
                case "/":
                    výsledek.Text = (value / Double.Parse(výsledek.Text)).ToString();
                    break;
                default:
                    break;
                    
                    //if (operation == "+")
                    // výsledek.Text = value + Double.Parse(výsledek.Text);
                    //break;
         
            }
                  
        
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value = 0;
            výsledek.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            copy_pressed = true;
            if (copy_pressed == true)
            {
               string m = výsledek.Text;
               Clipboard.SetText(m);
            }
    
        
        }

        private void button20_Click(object sender, EventArgs e)
        {
            paste_pressed = true;
            string a = "";
            if(paste_pressed)
            {
                výsledek.Text = Clipboard.GetText();

            }
        }
    }

}