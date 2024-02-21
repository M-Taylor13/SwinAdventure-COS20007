using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwinAdventure
{
    public partial class Gui : Form
    {
        private string _cmdOut = "";
        public Gui()
        {
            InitializeComponent();
        }

        private void LookBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "look";
            this.Close(); // I pretty much had to close the form everytime to send the command through

        }

        private void InvBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "look at me";
            this.Close();

        }

        private void NorthBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "move north";
            this.Close();

        }

        private void WestBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "move west";
            this.Close();

        }

        private void EastBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "move east";
            this.Close();

        }

        private void SouthBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "move south";
            this.Close();

        }


        private void EnterBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = CmdText.Text;
            this.Close();

        }
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            _cmdOut = "quit";
            this.Close();

        }

        public string CmdOutput
        {
            get
            {
                return _cmdOut;
            }
        }


    }
}
