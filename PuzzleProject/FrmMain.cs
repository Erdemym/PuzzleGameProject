
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Threading;
using ImageProcessLibrary;



namespace PuzzleProject
{
    public partial class FrmMain : Form
    {

        private FrmMain()
        {
            InitializeComponent();
        }

        ~FrmMain()
        {
            instanceFlag = false;
        }

        public static FrmMain CreateFrmMain()
        {
            if (instanceFlag == false)
            {
                instanceFlag = true;
                return new FrmMain();

            }
            else
            {
                throw new Exception("An engine has already been created!");
            }
        }
        
    }
}
