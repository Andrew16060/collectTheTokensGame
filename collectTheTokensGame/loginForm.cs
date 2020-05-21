using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace collectTheTokensGame
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        int check = 0; 

        private void btnInputName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("If you would be so kind, please enter your name in the textbox provided as the instructions clearly stated.");
            }
            else
            {
                string pathUsername = @"../../../gameNames.txt";
                string username = txtName.Text;
                string[] readUsername = File.ReadAllLines(pathUsername);
                for (int i = 0; i < readUsername.Length; i++)
                {
                    if (readUsername[i] == username)
                    {
                        MessageBox.Show("Welcome back " + username + "!");
                        check++;
                    }
                }
                if (check == 0)
                {
                    File.AppendAllText(pathUsername, username + "\r\n");
                    MessageBox.Show("Good luck for your first game " + username + "!");
                    check++;
                }
                Form1 gameForm = new Form1();
                gameForm.ShowDialog();
                this.Close();
            }
        }
    }
}
