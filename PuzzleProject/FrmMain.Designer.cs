
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System.Drawing;
using System.Windows.Forms;
using ImageProcessLibrary;
using System.Threading;
using System;


namespace PuzzleProject
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            clsFrmCont = new FrmControl(this, level);
            clsStatusCont = new StatusControl(this);
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBasla = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYukle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyarlar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBoyut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3X3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu4X4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu5X5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu6X6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBgColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGray = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPurple = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIpucu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutoComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAttack = new System.Windows.Forms.Label();
            this.tmrStatus = new System.Windows.Forms.Timer(this.components);
            this.lblNumOfAttack = new System.Windows.Forms.Label();
            this.tmrAutoComplete = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBasla,
            this.menuYukle,
            this.MenuAyarlar,
            this.menuIpucu,
            this.menuAutoComplete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBasla
            // 
            this.menuBasla.Name = "menuBasla";
            this.menuBasla.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.menuBasla.Size = new System.Drawing.Size(46, 20);
            this.menuBasla.Text = "Basla";
            this.menuBasla.Click += new System.EventHandler(this.menuBasla_Click);
            // 
            // menuYukle
            // 
            this.menuYukle.Name = "menuYukle";
            this.menuYukle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.menuYukle.Size = new System.Drawing.Size(48, 20);
            this.menuYukle.Text = "Yukle";
            this.menuYukle.Click += new System.EventHandler(this.menuYukle_Click);
            // 
            // MenuAyarlar
            // 
            this.MenuAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBoyut,
            this.menuBgColor});
            this.MenuAyarlar.Name = "MenuAyarlar";
            this.MenuAyarlar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.MenuAyarlar.Size = new System.Drawing.Size(56, 20);
            this.MenuAyarlar.Text = "Ayarlar";
            // 
            // menuBoyut
            // 
            this.menuBoyut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu3X3,
            this.menu4X4,
            this.menu5X5,
            this.menu6X6});
            this.menuBoyut.Name = "menuBoyut";
            this.menuBoyut.Size = new System.Drawing.Size(157, 22);
            this.menuBoyut.Text = "Boyut";
            // 
            // menu3X3
            // 
            this.menu3X3.Checked = true;
            this.menu3X3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu3X3.Name = "menu3X3";
            this.menu3X3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.menu3X3.Size = new System.Drawing.Size(129, 22);
            this.menu3X3.Text = "3X3";
            this.menu3X3.Click += new System.EventHandler(this.Menu3X3_Click);
            // 
            // menu4X4
            // 
            this.menu4X4.Name = "menu4X4";
            this.menu4X4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.menu4X4.Size = new System.Drawing.Size(129, 22);
            this.menu4X4.Text = "4X4";
            this.menu4X4.Click += new System.EventHandler(this.Menu4X4_Click);
            // 
            // menu5X5
            // 
            this.menu5X5.Name = "menu5X5";
            this.menu5X5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.menu5X5.Size = new System.Drawing.Size(129, 22);
            this.menu5X5.Text = "5X5";
            this.menu5X5.Click += new System.EventHandler(this.Menu5X5_Click);
            // 
            // menu6X6
            // 
            this.menu6X6.Name = "menu6X6";
            this.menu6X6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.menu6X6.Size = new System.Drawing.Size(129, 22);
            this.menu6X6.Text = "6X6";
            this.menu6X6.Click += new System.EventHandler(this.Menu6X6_Click);
            // 
            // menuBgColor
            // 
            this.menuBgColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBlack,
            this.menuRed,
            this.menuGray,
            this.menuPurple,
            this.menuBlue,
            this.menuOrange,
            this.menuPink,
            this.menuWhite});
            this.menuBgColor.Enabled = false;
            this.menuBgColor.Name = "menuBgColor";
            this.menuBgColor.Size = new System.Drawing.Size(157, 22);
            this.menuBgColor.Text = "Arka Plan Rengi";
            // 
            // menuBlack
            // 
            this.menuBlack.Checked = true;
            this.menuBlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuBlack.Name = "menuBlack";
            this.menuBlack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuBlack.Size = new System.Drawing.Size(153, 22);
            this.menuBlack.Text = "Black";
            this.menuBlack.Click += new System.EventHandler(this.menuBlack_Click);
            // 
            // menuRed
            // 
            this.menuRed.Name = "menuRed";
            this.menuRed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuRed.Size = new System.Drawing.Size(153, 22);
            this.menuRed.Text = "Red";
            this.menuRed.Click += new System.EventHandler(this.menuRed_Click);
            // 
            // menuGray
            // 
            this.menuGray.Name = "menuGray";
            this.menuGray.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.menuGray.Size = new System.Drawing.Size(153, 22);
            this.menuGray.Text = "Gray";
            this.menuGray.Click += new System.EventHandler(this.menuGray_Click);
            // 
            // menuPurple
            // 
            this.menuPurple.Name = "menuPurple";
            this.menuPurple.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.menuPurple.Size = new System.Drawing.Size(153, 22);
            this.menuPurple.Text = "Purple";
            this.menuPurple.Click += new System.EventHandler(this.menuPurple_Click);
            // 
            // menuBlue
            // 
            this.menuBlue.Name = "menuBlue";
            this.menuBlue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.menuBlue.Size = new System.Drawing.Size(153, 22);
            this.menuBlue.Text = "Blue";
            this.menuBlue.Click += new System.EventHandler(this.menuBlue_Click);
            // 
            // menuOrange
            // 
            this.menuOrange.Name = "menuOrange";
            this.menuOrange.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.menuOrange.Size = new System.Drawing.Size(153, 22);
            this.menuOrange.Text = "Orange";
            this.menuOrange.Click += new System.EventHandler(this.menuOrange_Click);
            // 
            // menuPink
            // 
            this.menuPink.Name = "menuPink";
            this.menuPink.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.menuPink.Size = new System.Drawing.Size(153, 22);
            this.menuPink.Text = "Pink";
            this.menuPink.Click += new System.EventHandler(this.menuPink_Click);
            // 
            // menuWhite
            // 
            this.menuWhite.Name = "menuWhite";
            this.menuWhite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.menuWhite.Size = new System.Drawing.Size(153, 22);
            this.menuWhite.Text = "White";
            this.menuWhite.Click += new System.EventHandler(this.menuWhite_Click);
            // 
            // menuIpucu
            // 
            this.menuIpucu.Name = "menuIpucu";
            this.menuIpucu.ShortcutKeyDisplayString = "";
            this.menuIpucu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.menuIpucu.Size = new System.Drawing.Size(49, 20);
            this.menuIpucu.Text = "İpucu";
            this.menuIpucu.Click += new System.EventHandler(this.menuIpucu_Click);
            // 
            // menuAutoComplete
            // 
            this.menuAutoComplete.Enabled = false;
            this.menuAutoComplete.Name = "menuAutoComplete";
            this.menuAutoComplete.Size = new System.Drawing.Size(128, 20);
            this.menuAutoComplete.Text = "AutoComplete(Beta)";
            this.menuAutoComplete.Click += new System.EventHandler(this.menuAutoComplete_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttack.ForeColor = System.Drawing.Color.Black;
            this.lblAttack.Location = new System.Drawing.Point(55, 65);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(100, 23);
            this.lblAttack.TabIndex = 0;
            this.lblAttack.Text = "0";
            // 
            // tmrStatus
            // 
            this.tmrStatus.Tick += new System.EventHandler(this.tmrStatus_Tick);
            // 
            // lblNumOfAttack
            // 
            this.lblNumOfAttack.AutoSize = true;
            this.lblNumOfAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumOfAttack.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfAttack.Location = new System.Drawing.Point(12, 48);
            this.lblNumOfAttack.Name = "lblNumOfAttack";
            this.lblNumOfAttack.Size = new System.Drawing.Size(128, 16);
            this.lblNumOfAttack.TabIndex = 1;
            this.lblNumOfAttack.Text = "Number Of Attack";
            // 
            // tmrAutoComplete
            // 
            this.tmrAutoComplete.Interval = 1;
            this.tmrAutoComplete.Tick += new System.EventHandler(this.tmrAutoComplete_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1268, 726);
            this.Controls.Add(this.lblNumOfAttack);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1278, 758);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sau_Puzzle v 0.0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Base Method


        public void ResizeBoxes(int level)
        {
            this.level = level;
        }


        public void SizeClear()
        {
            this.menu3X3.Checked = false;
            this.menu4X4.Checked = false;
            this.menu5X5.Checked = false;
            this.menu6X6.Checked = false;
        }


        public void ColorCheckedClear()
        {
            this.menuBlack.Checked = false;
            this.menuRed.Checked = false;
            this.menuGray.Checked = false;
            this.menuPurple.Checked = false;
            this.menuBlue.Checked = false;
            this.menuOrange.Checked = false;
            this.menuPink.Checked = false;
            this.menuWhite.Checked = false;
        }

        #endregion



        private void menuIpucu_Click(object sender, System.EventArgs e)
        {
            if (gettingPicture == null)
            {
                MessageBox.Show("Resim Yüklemeden bu işlem gerçekleşemez!!!");
                return;
            } 

            Ipucu ipucu = new Ipucu();
            ipucu.PbxImage.Image = ImageControl.resizeImage(gettingPicture,ipucu_size);

            ipucu.ShowDialog();
        }

        #region menuColor 
        private void menuBlack_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuBlack);
        }

        private void menuRed_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuRed);
        }

        private void menuGray_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuGray);
        }

        private void menuPurple_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuPurple);
        }

        private void menuBlue_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuBlue);
        }

        private void menuOrange_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuOrange);
        }

        private void menuPink_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuPink);
        }

        private void menuWhite_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeColor(ref this.menuWhite);
        }
        #endregion

        #region menuSize
        private void Menu3X3_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeSize(ref this.menu3X3, 3);
        }
        private void Menu4X4_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeSize(ref this.menu4X4, 4);
        }

        private void Menu5X5_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeSize(ref this.menu5X5, 5);
        }

        private void Menu6X6_Click(object sender, System.EventArgs e)
        {
            clsFrmCont.ChangeSize(ref this.menu6X6, 6);
        }

        #endregion

        #region field
        private static bool instanceFlag = false;
        private readonly static int scrSize = 600;
        private int level = 3;
        public int Level
        {
            get { return level; }
        }
        int scrWCenter = (Screen.PrimaryScreen.Bounds.Size.Width - scrSize) / 2;
        public int ScrWCenter
        {
            get { return scrWCenter; }
            set { scrWCenter = value; }
        }
        int scrHCenter = (Screen.PrimaryScreen.Bounds.Size.Height - scrSize) / 2;
        public int ScrHCenter
        {
            get { return scrHCenter; }
            set { scrHCenter = value; }
        }
        Image gettingPicture;
        public Image GettingPicture
        {
            get { return gettingPicture; }
            set { gettingPicture = value; }
        }
        Size ipucu_size = new Size(scrSize / 2, scrSize / 2);

        StatusControl clsStatusCont;
        internal StatusControl ClsStatusCont
        {
            get { return clsStatusCont; }
            set { clsStatusCont = value; }
        }

        FrmControl clsFrmCont;

        private void menuYukle_Click(object sender, EventArgs e)
        {
            clsFrmCont.PictureLoad();

        }

        private void menuBasla_Click(object sender, EventArgs e)
        {
            clsFrmCont.Basla(level);
        }

        private void tmrStatus_Tick(object sender, EventArgs e)
        {
            clsFrmCont.TmrStatusControl();
        }

        private void tmrAutoComplete_Tick(object sender, EventArgs e)
        {
            clsFrmCont.AutomaticCopmlete();
        }

        private void menuAutoComplete_Click(object sender, EventArgs e)
        {
            if (this.menuAutoComplete.Text == "StopAutoComplete")
            {
                this.tmrAutoComplete.Stop();
                this.tmrAutoComplete.Enabled = false;
                this.menuAutoComplete.Text = "AutoComplete(Beta)";
                Thread.Sleep(1000);
            }

            else if (this.menuAutoComplete.Text == "AutoComplete(Beta)")
            {
                this.tmrAutoComplete.Enabled = true;
                this.tmrAutoComplete.Start();
                this.menuAutoComplete.Text = "StopAutoComplete";
            }


        }

        private System.Windows.Forms.Label lblAttack;
 

        public System.Windows.Forms.Label LblAttack
        {
            get { return lblAttack; }
            set { lblAttack = value; }
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuYukle;
        private System.Windows.Forms.ToolStripMenuItem MenuAyarlar;
        private System.Windows.Forms.ToolStripMenuItem menuBasla;

        public System.Windows.Forms.ToolStripMenuItem MenuBasla
        {
            get { return menuBasla; }
            set { menuBasla = value; }
        }
        private ToolStripMenuItem menuIpucu;
        private ToolStripMenuItem menuBoyut;
        private ToolStripMenuItem menu3X3;
        private ToolStripMenuItem menu4X4;
        private ToolStripMenuItem menu5X5;
        private ToolStripMenuItem menu6X6;
        private ToolStripMenuItem menuBgColor;

        public ToolStripMenuItem MenuBgColor
        {
            get { return menuBgColor; }
            set { menuBgColor = value; }
        }
        private ToolStripMenuItem menuBlack;
        private ToolStripMenuItem menuRed;
        private ToolStripMenuItem menuGray;
        private ToolStripMenuItem menuPurple;
        private ToolStripMenuItem menuBlue;
        private ToolStripMenuItem menuOrange;
        private ToolStripMenuItem menuPink;
        private ToolStripMenuItem menuWhite;
        #endregion
        public System.Windows.Forms.Timer tmrStatus;
        #endregion
        private Label lblNumOfAttack;
        public System.Windows.Forms.Timer tmrAutoComplete;
        public ToolStripMenuItem menuAutoComplete;


        public Label LblNumOfAttack
        {
            get { return lblNumOfAttack; }
            set { lblNumOfAttack = value; }
        }
    }
}
