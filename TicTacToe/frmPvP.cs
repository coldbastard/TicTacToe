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
        // właściwości używane jak zmienne

        bool againstComputer = false;
        // ^: false -> gramy z innym graczem || true -> gramy przeciw komputerowi
        bool turn = true; // true -> Player1, false -> Player2
        bool startTurn = true; // domyślnie true
        int turnCount = 0; // licznik tur
        int gameCount = 0; // licznik gier

        // Stałe sterujące rezultatem gry:
        const int DrawResultInt = 2; // Remis
        const int WinResultInt = 1;  // Wygrana
        const int NoResultInt = 0;   // Brak rezultatu

        // KONSTRUKTORY

        public frmPvP(bool gameType)
        {
            // konstruktor parametryczny
            if (gameType) againstComputer = true;
            else againstComputer = false;
            InitializeComponent();
        }

        public frmPvP()
        {
            // domyślny konstruktor
            InitializeComponent();
        }

    // METODY FORMULARZA WYWOŁYWANE W TRAKCIE GRY

        // METODY AI

        private void ForceComputerToMakeMove()
        {
            // sprawdza czy gramy z komputerem i czy to jego tura
            // jeśli tak to uruchamia jego ruch
            if (!turn && againstComputer)
            {
                ComputerMakeMove();
            }
        }

        private void ComputerMakeMove()
        {
            // Sposób wykonywania ruchu:
            // 1: Sprawdź czy możesz wygrać w jednym ruchu
            // 2: Sprawdź czy możesz przeciwnik może wygrać w jednym ruchu
            // 3: Postaw w rogu
            // 4: Postaw w pustym miejscu
            try
            {
                Button move = null;
                move = LookForWinOrBlock(txtSignP2.Text); //look for win
                if (move == null)
                {
                    move = LookForWinOrBlock(txtSignP1.Text); //look for block
                    if (move == null)
                    {
                        move = LookForCorner(txtSignP2.Text);
                        if (move == null)
                        {
                            move = LookForOpenSpace();
                        }
                    }
                }

                move.PerformClick();
            }
            catch
            {
                //MessageBox.Show("Chuj w dupe");
            }
        }

        private Button LookForWinOrBlock(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            // sprawdza kolumny
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == "")) return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == "")) return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == "")) return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == "")) return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == "")) return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == "")) return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == "")) return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == "")) return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == "")) return C2;

            // sprawdza wiersze
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == "")) return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == "")) return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == "")) return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == "")) return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == "")) return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == "")) return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == "")) return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == "")) return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == "")) return B3;

            // sprawdzenie przekątnych
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == "")) return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == "")) return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == "")) return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == "")) return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == "")) return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == "")) return B2;

            return null;
        }

        private Button LookForCorner(string mark)
        {
            // Poszukiwanie wolnego miejsca w narożniku
            if (A1.Text == mark)
            {
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
                if (C1.Text == "") return C1;
            }

            if (A3.Text == mark)
            {
                if (A1.Text == "") return A1;
                if (C3.Text == "") return C3;
                if (C1.Text == "") return C1;
            }

            if (C3.Text == mark)
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }

            if (C1.Text == mark)
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C3.Text == "") return C3;
            }

            // jeśli wszystkie narożniki są zajęte zwróć pusty ruch
            if (A1.Text != "" && A3.Text != "" && C1.Text != "" && C3.Text != "") return null;


            // 
            Random rnd = new Random();

            while(true)
            {
                int liczba = rnd.Next(1, 5); // losuje liczbę całkowitą z przedziału od 1 do 4
                if (liczba==1 && A1.Text == "") return A1;
                if (liczba == 2 && A3.Text == "") return A3;
                if (liczba == 3 && C1.Text == "") return C1;
                if (liczba == 4 && C3.Text == "") return C3;
            }
        }

        private Button LookForOpenSpace()
        {
            // Poszukiwanie wolnego miejsca na ruch
            if (A1.Text == "") return A1;
            else if (A2.Text == "") return A2;
            else if (A3.Text == "") return A3;
            else if (B1.Text == "") return B1;
            else if (B2.Text == "") return B2;
            else if (B3.Text == "") return B3;
            else if (C1.Text == "") return C1;
            else if (C2.Text == "") return C2;
            else if (C3.Text == "") return C3;
            return null;
        }

        // METODY INNE

        private void Summerize()
        {
            // wyświetla ogólne podsumowanie gry
            string Message = "Ilość tur: " + gameCount + "\n"
                + txtNameP1.Text + ": " + P1_Win_Count.Text + "\n"
                + txtNameP2.Text + ": " + P2_Win_Count.Text + "\n"
                + "Remisy: " + Draw_Count.Text;
            MessageBox.Show(Message, "Podsumowanie!");
        }
        
        private void ShowScore(int ScoreType)
        {
            //wyświelenie komunikatu o wyniku w zależności od wartości 'ScoreType'
            if (ScoreType == WinResultInt)
            {
                string winner = "";
                DissableAllButtons();
                if (!turn)
                {
                    P2_Win_Count.Text = (Int32.Parse(P2_Win_Count.Text) + 1).ToString();
                    winner = txtNameP2.Text + " (" + txtSignP2.Text + ")";
                }
                else
                {
                    P1_Win_Count.Text = (Int32.Parse(P1_Win_Count.Text) + 1).ToString();
                    winner = txtNameP1.Text + " (" + txtSignP1.Text + ")";
                }
                MessageBox.Show("Wygrywa: " + winner, "Wygrana!");
            }
            else if (ScoreType == DrawResultInt)
            {
                Draw_Count.Text = (Int32.Parse(Draw_Count.Text) + 1).ToString();
                MessageBox.Show("Remis jest przegraną obu stron!", "Remis!");
            }
            else MessageBox.Show("Błędne wskazanie wyniku rundy!", "Błąd!");
        }

        private int WinnerCheck()
        {
            // metoda winnerCheck sprawdza aktualny rezultat gry: brak = 0, wygrana = 1, remis = 2

            //sprawdzenie w poziome
            if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "") return WinResultInt;
            // alternatywnie: (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled)
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "") return WinResultInt;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "") return WinResultInt;

            // sprawdzenie w pionie
            else if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "") return WinResultInt;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "") return WinResultInt;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "") return WinResultInt;

            // sprawdzenie przekątnych
            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "") return WinResultInt;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "") return WinResultInt;
            else if (turnCount == 8) return DrawResultInt;
            else return NoResultInt;
        }

        private void ClearAllButtons()
        {
            // czyszczenie opisów wszystkich przycisków
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }

        private void DissableAllButtons()
        {
            // ustawienie wszystkich przycisków planszy jako aktywnych <- na granicy RiGCzu (Rozumu i Godności Człowieka)
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;

            // Kiepska wersja z rzutowaniem kontrolek do typu przycisk <- bardziej podoba mi sie rozwiązanie z hardkodowanymi przyciskami
            // wybranie ze wszystkich kontrolek formularza samych przycisków
            //    foreach (Control c in Controls)
            //{
            //    try
            //    {   
            //        Button b = (Button)c; // rzut kontrolki "c" formularza do typu "button"
            //        if ((b.Name).Substring(0,1) == "A" || (b.Name).Substring(0, 1) == "B" || (b.Name).Substring(0, 1) == "C")
            //            b.Enabled = false;
            //    }
            //    catch {}
            //}
        }

        private void EnableAllButtons()
        {
            // ustawienie wszystkich przycisków planszy jako aktywnych <- na granicy RiGCzu (Rozumu i Godności Człowieka)
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            // Kiepska wersja z rzutowaniem kontrolek do typu przycisk <- bardziej podoba mi sie rozwiązanie z hardkodowanymi przyciskami

            //foreach (Control c in Controls)
            //{
            //    try
            //    {
            //        Button b = (Button)c; // rzut kontrolki "c" formularza do typu "button"
            //        if ((b.Name).Substring(0, 1) == "A" || (b.Name).Substring(0, 1) == "B" || (b.Name).Substring(0, 1) == "C")
            //        {
            //            b.Enabled = true;
            //            b.Text = "";
            //        }
            //    }
            //    catch {}
            //}
        }

        private void SetbtnResetStatus()
        {
            // SetbtnResetStatus() blokuje/odblokowuje przycisk btnReset w zależności czy występują:
            // takie same wartości w polach teksowych z nazwami i symbolami obu graczy
            // albo czy któreś z pol jest puste
            if (txtSignP2.Text == txtSignP1.Text || txtNameP1.Text == txtNameP2.Text ||
                txtNameP2.Text == "" || txtNameP1.Text == "" || txtSignP2.Text == "" || txtSignP1.Text == "")
            {
                btnStartGame.Enabled = false;
            }
            else
            {
                btnStartGame.Enabled = true;
            }

        }

    // ZDARZENIA

        // ZDARZENIE PRZY ZAŁADOWANIU FORMULARZA

        private void FrmPvP_Load(object sender, EventArgs e)
        {
            // reset przycisków przy załadowaniu planszy
            btnReset.Enabled = false;
            DissableAllButtons();
        }

        // ZDARZENIA NA PRZYCISKACH PLANSZY

        private void MouseEnterButton(object sender, EventArgs e)
        {
            // Zmiana wyglądu pola po wejściu kursora na przycisk
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = txtSignP1.Text;
                }
                else
                {
                    b.Text = txtSignP2.Text;
                }
            }
        }

        private void MouseLeaveButton(object sender, EventArgs e)
        {
            // Zmiana wyglądu przycisk po zejściu z niego kursora
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void FieldClick(object sender, EventArgs e)
        {
            // FieldClick() odpowiada za wszystkie działania po naciśnięciu przycisków planszy

            // działania na samymprzycisku
            Button b = (Button)sender; // zrzutowanie obiektu wysłanego przez metodę FieldClick do typu Buton
            if (turn) b.Text = txtSignP1.Text;
            else b.Text = txtSignP2.Text;
            b.Enabled = false; // wyłączanie przycisku po wykonaniu ruchu

            // sprawdzenie rezultatu
            int ScoreType = NoResultInt; // patrz: WinnerCheck()
            ScoreType = WinnerCheck(); // sprawdzamy czy ktoś wygrał: brak = NoResultInt, wygrana = WinResultInt, remis = DrawResultInt
            if ((ScoreType == WinResultInt) || (ScoreType == DrawResultInt))
            {
                ShowScore(ScoreType);
                gameCount++;
                btnReset.Enabled = true; // włączenie przycisku "Reset" po ukończeniu rundy - niezależnie od wyniku
            }
            else
            {
                turn = !turn; // zmiana strony po ruchu
                turnCount++; // zwiększenie licznika tur
            }

            // Jeśli gramy z komputerem i to jego tura to zostanie wywołany jego ruch!
            ForceComputerToMakeMove();
        }

        // ZDARZENIA PRZYCISKÓW INTERFEJSU PRZED GRĄ

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            txtSignP1.Enabled = false;
            txtSignP2.Enabled = false;
            txtNameP1.Enabled = false;
            txtNameP2.Enabled = false;
            btnReset.Enabled = false;
            btnStartGame.Enabled = false;
            EnableAllButtons();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // reset planszy po zakonczonej partii
            turn = !startTurn; // zmiana strony po zresetowaniu planszy
            startTurn = !startTurn;
            turnCount = 0;
            btnReset.Enabled = false;
            EnableAllButtons();
            ClearAllButtons();
            // Jeśli gramy z komputerem i to jego tura to zostanie wywołany jego ruch!
            ForceComputerToMakeMove();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // koniec gry
            Summerize();
            this.Close();
        }

        private void txtNameP1_TextChanged(object sender, EventArgs e)
        {
            SetbtnResetStatus();
        }

        private void txtNameP2_TextChanged(object sender, EventArgs e)
        {
            SetbtnResetStatus();
        }

        private void txtSignP1_TextChanged(object sender, EventArgs e)
        {
            SetbtnResetStatus();
        }

        private void txtSignP2_TextChanged(object sender, EventArgs e)
        {
            SetbtnResetStatus();
        }
    }
}
