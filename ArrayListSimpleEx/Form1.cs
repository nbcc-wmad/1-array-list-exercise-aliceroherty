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
        bool IsRev = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region User-defined Methods

        private void ShowMessage(ArrayList msg)
        {
            lblMessage.Text = string.Empty;

            for (int i = 0; i < msg.Count; i++)
            {
                lblMessage.Text += msg[i] + " ";
            }

            IsRev = false;
        }

        private void ShowReverse()
        {
            ArrayList RevMsg = new ArrayList(Message);
            
            RevMsg.Reverse();

            ShowMessage(RevMsg);

            IsRev = true;
        }

        #endregion

        #region Event-Handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Message = new ArrayList();

                Message.Add("I");
                Message.Add("Love");
                Message.Add("Programming");
                Message.Add("So");
                Message.Add("Much");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            try
            {
                ShowMessage(Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                ShowReverse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Message.Count > 5)
                {
                    MessageBox.Show("You've Already added a word");
                }
                else if (IsRev == true)
                {
                    MessageBox.Show("You cannot add a word when the message is reversed");
                }
                else
                {
                    Message.Insert(1, txtSecondPos.Text);
                    ShowMessage(Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Message.Count == 5)
                {
                    MessageBox.Show("You've haven't added a word");
                }
                else
                {
                    Message.RemoveAt(1);

                    if (IsRev == true)
                    {
                        ShowReverse();
                    }
                    else
                    {
                        ShowMessage(Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        #endregion
    }
}
