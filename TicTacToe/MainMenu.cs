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
            frmPvP f1 = new frmPvP();
            f1.ShowDialog();
        }

        private void btnPvPOnline_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            int gameType = 1;
            GameEngine Engine = new GameEngine();
            Engine.playGame(gameType);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
