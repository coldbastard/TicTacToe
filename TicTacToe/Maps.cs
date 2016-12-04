using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Maps
    {
        //tworzenie mapy jako tablicy intów i przypisanie im wartości 0 
        private int [] board;

        public Maps(int boardSize)
        {
            board = new int[boardSize * boardSize];
        }

        public void defaultValue()
        {
            foreach (int a in board)
            {
                board[a] = 0;
            }
        }

        // metoda checkForWin sprawdza czy na planszy jest zwycięzca
        public int checkForWin(int turnCount)
        {
            //sprawdzenie w poziome
            if (board[0] == board[1] && board[1] == board[2] && board[2] != 0) return 1;
            else if (board[3] == board[4] && board[4] == board[5] && board[5] != 0) return 1;
            else if (board[6] == board[7] && board[7] == board[8] && board[8] != 0) return 1;
            // sprawdzenie w pionie
            else if (board[0] == board[3] && board[3] == board[6] && board[6] != 0) return 1;
            else if (board[1] == board[4] && board[4] == board[7] && board[7] != 0) return 1;
            else if (board[2] == board[5] && board[5] == board[8] && board[8] != 0) return 1;
            // sprawdzenie przekątnych
            else if (board[0] == board[4] && board[4] == board[8] && board[8] != 0) return 1;
            else if (board[2] == board[4] && board[4] == board[6] && board[6] != 0) return 1;
            // brak zwyciężcy 2 - remis 0 - graj dalej
            else if (turnCount == 8) return 2;
            else return 0;
        }

        // metoda sprawdzająca czy można wstawić znak w dane miejsce w tablicy
        public bool validateMove(int point)
        {
            if (board[point] == 0) return true;
            else return false;
        }

        //metoda wstawiająca znak w tablice
        public void insertSign(int point,int sign)
        {
            board[point] = sign;
        }

        //metoda zwracająca tablice 
        public int [] returnBoard()
        {
            return board;
        }
    }
}
