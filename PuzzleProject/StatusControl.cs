
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace PuzzleProject
{
    class StatusControl:IStatusControl
    {
        //field
        private FrmMain clsFrm1;

        //constructor
        public StatusControl(object clsFrm1)
        {
            //Form1 e erişmeyi sağlıyo...
            this.clsFrm1 = (FrmMain)clsFrm1;
        }

        //public method
        public void GameOver(EnumStatus.Status status)
        {
            if (status == EnumStatus.Status.Win)
                GameWin();
            else if (status == EnumStatus.Status.Lose)
                GameLose();
            RestartGame();
        }

        //private method
        private void GameWin()
        {
            clsFrm1.tmrStatus.Start();
            MessageBox.Show("Congratulations!!!");
            MessageBox.Show("Game is Over....");
            MessageBox.Show("You Win!!!");
        }
        private void GameLose()
        {
            MessageBox.Show("Game is Over....");
            MessageBox.Show("You Lose!!!");
        }
        private void RestartGame()
        {
            DialogResult result = MessageBox.Show("Do you wanna restart game!!", "Restart", MessageBoxButtons.YesNo);

            clsFrm1.Close();

            Application.Exit();

            if (result == DialogResult.Yes)
                Application.Restart();
        }

    }
}
