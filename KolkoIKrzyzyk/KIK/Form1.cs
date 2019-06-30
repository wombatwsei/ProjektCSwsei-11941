using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIK
{
    public partial class Form1 : Form
    {
        bool turnForX = true; //sprawdza czy ruch to x czy o
        int counter = 0; //licznik ruchow
        bool isAIOn = true; //kontrolka do ai

        public Form1()
        {
            InitializeComponent();
        }

        private void zasadyGryToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Kółko i krzyżyk – gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce papieru w kratkę. Gracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi. Pole może być objęte przez jednego gracza i nie zmienia swego właściciela przez cały przebieg gry. W najbardziej popularnej w Polsce wersji gra odbywa się na polu o wymiarach 3x3. ", "Zasady gry.");
        }//menu zasady gry

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gre wykonal wombatwsei (id:11941) na projekt zaliczeniowy z lab c#. 2019r.", "O autorze.");
        }//menu o autorze

        private void zamknijGreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//wylaczanie gry z menu

        private void clickLogic(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turnForX is true) btn.Text = "X";
            else btn.Text = "O";
            turnForX = !turnForX;
            btn.Enabled = false;
            counter++;
            checkWinner();
            if ((!turnForX) && (isAIOn)) computerMove();
        }//czynnosci do wykonania po ruchu
        private void computerMove()
        {
            Button pick = null;

            pick = aiCheckForWin("O"); //sprawdza czy moze wygrac
            if(pick == null)
            {
                pick = aiCheckForWin("X"); //sprawdza czy moze zablokowac gracza
                if(pick == null)
                {
                    pick = aiCheckForFreeSpace(); //bierze wolne miejsce
                }
            }
            try
            {
                pick.PerformClick();
            }
            catch { }
        }
        private Button aiCheckForWin(string s)
        {
            //rozwiazanie siermiezne ale dziala
            //poziomo
            if ((A1.Text == s) && (A2.Text == s) && (A3.Text == ""))
                return A3;
            if ((A2.Text == s) && (A3.Text == s) && (A1.Text == ""))
                return A1;
            if ((A1.Text == s) && (A3.Text == s) && (A2.Text == ""))
                return A2;
            if ((B1.Text == s) && (B2.Text == s) && (B3.Text == ""))
                return B3;
            if ((B2.Text == s) && (B3.Text == s) && (B1.Text == ""))
                return B1;
            if ((B1.Text == s) && (B3.Text == s) && (B2.Text == ""))
                return B2;
            if ((C1.Text == s) && (C2.Text == s) && (C3.Text == ""))
                return C3;
            if ((C2.Text == s) && (C3.Text == s) && (C1.Text == ""))
                return C1;
            if ((C1.Text == s) && (C3.Text == s) && (C2.Text == ""))
                return C2;
            //pionowo
            if ((A1.Text == s) && (B1.Text == s) && (C1.Text == ""))
                return C1;
            if ((B1.Text == s) && (C1.Text == s) && (A1.Text == ""))
                return A1;
            if ((A1.Text == s) && (C1.Text == s) && (B1.Text == ""))
                return B1;
            if ((A2.Text == s) && (B2.Text == s) && (C2.Text == ""))
                return C2;
            if ((B2.Text == s) && (C2.Text == s) && (A2.Text == ""))
                return A2;
            if ((A2.Text == s) && (C2.Text == s) && (B2.Text == ""))
                return B2;
            if ((A3.Text == s) && (B3.Text == s) && (C3.Text == ""))
                return C3;
            if ((B3.Text == s) && (C3.Text == s) && (A3.Text == ""))
                return A3;
            if ((A3.Text == s) && (C3.Text == s) && (B3.Text == ""))
                return B3;
            //ukosne
            if ((A1.Text == s) && (B2.Text == s) && (C3.Text == ""))
                return C3;
            if ((B2.Text == s) && (C3.Text == s) && (A1.Text == ""))
                return A1;
            if ((A1.Text == s) && (C3.Text == s) && (B2.Text == ""))
                return B2;
            if ((A3.Text == s) && (B2.Text == s) && (C1.Text == ""))
                return C1;
            if ((B2.Text == s) && (C1.Text == s) && (A3.Text == ""))
                return A3;
            if ((A3.Text == s) && (C1.Text == s) && (B2.Text == ""))
                return B2;

            return null;
        }
        private Button aiCheckForFreeSpace()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }
        private void checkWinner()
        {
            //sprawdzam czy jest zwyciezca po wykonanym ruchu
            bool winner = false;

            //poziom
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled) winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled) winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled) winner = true;
            //pion
            else if (A1.Text == B1.Text && B1.Text == C1.Text && !A1.Enabled) winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && !A2.Enabled) winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && !A3.Enabled) winner = true;
            //ukos
            else if (A1.Text == B2.Text && B2.Text == C3.Text && !A1.Enabled) winner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !A3.Enabled) winner = true;
            
            if (winner is true)
            {
                //MessageBox.Show("win");
                disableButtons();
                if (turnForX is true)
                {
                    oWinCounter.Text = (Int32.Parse(oWinCounter.Text) + 1).ToString();
                    MessageBox.Show("Wygral - Kolko");
                }
                else
                {
                    xWinCounter.Text = (Int32.Parse(xWinCounter.Text) + 1).ToString();
                    MessageBox.Show("Wygral - Krzyzyk");
                }
            }
            else
            {
                if (counter == 9)
                {
                    drawCounter.Text = (Int32.Parse(drawCounter.Text) + 1).ToString();
                    MessageBox.Show("remis");
                }
            }
        }
        private void disableButtons()
        {
            //wylaczanie pol gry po zwyciestwie
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicjacja nowej gry bez ai
            turnForX = true;
            counter = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            isAIOn = false;
            label4.Text = "";
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            //wyswietlenie znaku po najechaniu na pole
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                if (turnForX is true)
                {
                    btn.Text = "X";
                    btn.ForeColor = Color.Navy;
                }
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.DarkRed;
                }
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            //usuniecie znaku po odjechaniu z pola
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                btn.Text = "";
                btn.ForeColor = Color.Black;
            }
        }

        private void zresetujLicznikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resetowanie licznikow po wyborze z menu
            oWinCounter.Text = "0";
            xWinCounter.Text = "0";
            drawCounter.Text = "0";
        }

        private void nowaGraTrybAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //inicjacja nowej gry z wlaczonym ai
            turnForX = true;
            counter = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            isAIOn = true;
            label4.Text = "Tryb gry z AI";
        }
    }
}
