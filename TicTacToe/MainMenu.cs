using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            //against other player
            frmPvP form_1 = new frmPvP(false);
            form_1.ShowDialog();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            //againstComputer
            frmPvP form_1 = new frmPvP(true);
            form_1.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
