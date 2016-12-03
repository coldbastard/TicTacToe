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
    public partial class frmPvP : Form
    {
        bool turn = true; // prawda -> gracz 1, fałsz -> gracz 2
        int turnCount = 0; // licznik tur
        int gameCount = 0; // licznik gier
        
        public frmPvP()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            txtSignP1.Enabled = false;
            txtSignP2.Enabled = false;
            txtNameP1.Enabled = false;
            txtNameP2.Enabled = false;
            btnReset.Enabled = false;
            btnStartGame.Enabled = false;
            enableAllButtons();
        }

        private void ShowScore(int ScoreType)
        {
            //wyświelenie komunikatu o wyniku - jeśli jakiś wynik jest

            if (ScoreType == 1)
            {
                dissableAllButtons();
                string winner = "";
                if (!turn)
                {
                    P2_Win_Count.Text = (Int32.Parse(P2_Win_Count.Text) + 1).ToString();
                    winner = txtNameP2.Text;
                }
                else
                {
                    P1_Win_Count.Text = (Int32.Parse(P1_Win_Count.Text) + 1).ToString();
                    winner = txtNameP1.Text;
                }
                MessageBox.Show("Wygrywa: " + winner, "Wygrana!");
            }
            else if (ScoreType == 2)
            {
                Draw_Count.Text = (Int32.Parse(Draw_Count.Text) + 1).ToString();
                MessageBox.Show("Remis jest przegraną obu stron!", "Remis!");
            }
            else MessageBox.Show("Błędne wskazanie wyniku rundy!", "Błąd!");
        }

        private void fieldClick(object sender, EventArgs e)
        {
            int ScoreType = 0;
            Button b = (Button)sender; //zrzutowanie obiektu wysłanego przez metodę fieldClick do typu Buton
            if (turn) b.Text = txtSignP1.Text;
            else b.Text = txtSignP2.Text;
            b.Enabled = false; //wyłączanie przycisku po ruchu
            ScoreType = winnerCheck(); //sprawdzamy czy ktoś wygrał
            if ((ScoreType == 1) || (ScoreType == 2))
            {
                ShowScore(ScoreType);
                gameCount++;
                //btnStartGame.Enabled = true;
                btnReset.Enabled = true; // włączenie przycisku "Reset" po ukończeniu rundy - niezależnie od wyniku
            }
            turn = !turn; //zmiana strony do wykonania ruchu
            turnCount++;
        }

        private int winnerCheck()
        {
            // metoda winnerCheck sprawdza czy na planszy jest zwycięzca

            //sprawdzenie w poziome
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "") return 1;
            // alternatywnie: (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "") return 1;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "") return 1;

            // sprawdzenie w pionie
            else if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") return 1;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "") return 1;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "") return 1;

            // sprawdzenie przekątnych
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "") return 1;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "") return 1;
            else if (turnCount == 8) return 2;
            else return 0;
        }

        private void dissableAllButtons()
        {
            //wybranie ze wszystkich kontrolek formularza samych przycisków
            foreach (Control c in Controls)
            {
                try
                {   
                    Button b = (Button)c; // rzut kontrolki "c" formularza do typu "button"
                    if ((b.Name).Substring(0,1) == "A" || (b.Name).Substring(0, 1) == "B" || (b.Name).Substring(0, 1) == "C")
                        b.Enabled = false;
                }
                catch {}
            }
        }

        private void enableAllButtons()
        {
            //wybranie ze wszystkich kontrolek formularza samych przycisków
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c; // rzut kontrolki "c" formularza do typu "button"
                    if ((b.Name).Substring(0, 1) == "A" || (b.Name).Substring(0, 1) == "B" || (b.Name).Substring(0, 1) == "C")
                    {
                        b.Enabled = true;
                        b.Text = "";
                    }
                }
                catch { }
            }
        }

        private void MouseEnterButton(object sender, EventArgs e)
        {
            // Zmiana wyglądu pola po wejściu kursora na nie
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn) b.Text = txtSignP1.Text;
                else b.Text = txtSignP2.Text;
            }
        }

        private void MouseLeaveButton(object sender, EventArgs e)
        {
            // Zmiana wyglądu pola po zejściu kursora
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void frmPvP_Load(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            dissableAllButtons();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            turnCount = 0;
            btnReset.Enabled = false;
            enableAllButtons();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
