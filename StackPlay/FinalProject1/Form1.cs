using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1
{
    public partial class Form1 : Form
    {

        private Stack<int> s;
        private int intGenerated;

        private int numInt;

        public Form1()
        {
            InitializeComponent();
            s = new Stack<int>();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Random randInt = new Random();

            //generate an integer
            intGenerated = randInt.Next(0, 100);
            //push to stack
            s.Push(intGenerated);
            //print new stack
            printStack(s);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            //if stack not empty remove element and print
            if(s.Count!=0)
            {
                s.Pop();
                printStack(s);
            }
                //if empty display messag saying so
            else
            {
                String message = "There are no elements to remove.";
                MessageBox.Show(message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //pop until stack is empty
            while(s.Count!=0)
            {
                s.Pop();
            }
            printStack(s);
        }

        private void printStack(Stack<int> s)
        {
            //create string to display
            String txt="";
            if(s.Count!=0)
            {
                foreach (var n in s)
                {
                    txt += (Convert.ToString(n) + "\r\n");
                }
            }
            else
            {
                txt = "";
            }
            
            txtOutput.Text = txt;
        }
    }
}
