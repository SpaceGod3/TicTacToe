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
    public partial class FTicTacToe : Form
    {

        Result result = new Result();

        int sessionNumber = 1;
        int sessionStartPlayerNumber = 1;
        int gameStartPlayerNumber = 1;


        int playerNumber = 1;

        Color cellColor = Color.FromArgb(244, 251, 245);
        Color selectedCellColor = Color.LightCoral;
        Color rescolor = Color.White;

        public FTicTacToe()
        {
            InitializeComponent();

            //ShowResult();
            CleareCells();
            ShowInfo();
        }

        private void ShowInfo()
        {
            labelSessionNumber.Text = sessionNumber.ToString();
            labelPlayerNumber.Text = string.Format("{0} ({1})",
                playerNumber, GetPlayerSymbol());
            labelPlayer1Score.Text = result.Player1Score.ToString();
            labelPlayer2Score.Text = result.Player2Score.ToString();
        }

        private string GetPlayerSymbol()
        {
            //if (playerNumber == 1)
            //    return "X";
            //else
            //    return "0";
            return playerNumber == 1 ? "X" : "0";
        }

        private void CleareCells()
        {
            foreach (Control control in tableLayoutPanelField.Controls)
            {
                control.Text = "";
            }
        }

        private void ShowResult()
        {
            this.Text = "Хрестики-нулики: " + result.ToString();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            result.Time++;
            labelTimeValue.Text = result.TimeString;
        }

        private void labelCell_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control.Text != "")
                return;
            control.Text = GetPlayerSymbol();
            if (LineBuilt())
            {
                StopSession();
                return;
            }
            //switch (playerNumber) {
            //    case 1: playerNumber = 2; break;
            //    case 2: playerNumber = 1; break;
            //}
            playerNumber = playerNumber % 2 + 1;
            ShowInfo();
        }

        private void StopSession()
        {
            //throw new NotImplementedException();
            timerTime.Enabled = false;
            ShowInfo();
        }

        private void StartNewSession()
        {
            sessionStartPlayerNumber = sessionStartPlayerNumber % 2 + 1;
            playerNumber = sessionStartPlayerNumber;
            CleareCells();
        }

        bool LineBuilt()
        {
            bool built = LineBuilt(0, 1, 2) || LineBuilt(3, 4, 5)
                || LineBuilt(6, 7, 8) || LineBuilt(0, 3, 6) || LineBuilt(1, 4, 7) || LineBuilt(2, 5, 8) || LineBuilt(0, 4, 8) || LineBuilt(2, 4, 6);
            if (built)
            {
                switch (playerNumber)
                {
                    case 1: result.Player1Score++; break;
                    case 2: result.Player2Score++; break;
                }
            }
            return built;
        }

        private bool LineBuilt(int i1, int i2, int i3)
        {
            var controls = tableLayoutPanelField.Controls;
            bool built = controls[i1].Text != ""
                && controls[i1].Text == controls[i2].Text
                && controls[i1].Text == controls[i3].Text;
            if (built)
            {
                SelectLine(i1, i2, i3);
            }
            return built;
        }

        void SelectLine(params int[] indexes)
        {
            foreach (int i in indexes)
            {
                tableLayoutPanelField.Controls[i].BackColor
                    = selectedCellColor;
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            sessionNumber++;
            foreach (Control control in tableLayoutPanelField.Controls)
            {
                control.Text = "";
                control.BackColor = rescolor;


            }
            ShowInfo();

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {


            sessionNumber = 0;
            result.Player1Score = 0;
            result.Player2Score = 0;

            foreach (Control control in tableLayoutPanelField.Controls)
            {
                control.Text = "";
                control.BackColor = rescolor;


            }
            ShowInfo();


        }


    }
}
