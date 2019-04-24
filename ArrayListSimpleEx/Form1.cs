/*Alice Rohety-Carrier*/

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

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList Message;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMessage(ArrayList msg)
        {
            lblMessage.Text = string.Empty;

            for (int i = 0; i < msg.Count; i++)
            {
                lblMessage.Text += msg[i] + " ";
            }
        }

        private void ShowReverse()
        {
            ArrayList RevMsg = new ArrayList(Message);
            
            RevMsg.Reverse();

            ShowMessage(RevMsg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Message = new ArrayList();

            Message.Add("I");
            Message.Add("Love");
            Message.Add("Programming");
            Message.Add("So");
            Message.Add("Much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            ShowMessage(Message);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ShowReverse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Message.Count > 5)
            {
                MessageBox.Show("You've Already added a word");
            }
            else
            {
                Message.Insert(1, txtSecondPos.Text);
                ShowMessage(Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Message.Count == 5)
            {
                MessageBox.Show("You've haven't added a word");
            }
            else
            {
                Message.RemoveAt(1);
                ShowMessage(Message);
            }
        }
    }
}
