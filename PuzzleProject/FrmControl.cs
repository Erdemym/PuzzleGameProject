
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
using ImageProcessLibrary;
using System.Collections;
using PuzzleLibrary;
using System.Threading;


namespace PuzzleProject
{
    class FrmControl : IControl, IBasla, IYukle,IAutomaticControl
    {

        //private field
        private static int scrSize = 600;  //static
        private int counter;
        private int level;
        private int[] randNumArry = new int[100];
        private int formBackColorCount = 0;
        private ArrayList Card = new ArrayList();
        private ArrayList number = new ArrayList();
        private FrmMain clsFrm1;
        private ImageControl clsImgCont;
        private List<Image> lstPics = new List<Image>();
        private OpenFileDialog openFile;
        private PictureBox[] pbxArry = new PictureBox[100];
        private PictureBox[] pbxArray = new PictureBox[100];
        private PictureBox pbxImage;
        private PuzzleControl clsPuzzleCont;
        private Random rand = new Random();
        private Size m_size;
        
        //constructor
        public FrmControl(object a, int level)
        {

            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.openFile.FileName = "openFileDialog1";
            this.clsFrm1 = (FrmMain)a;
            this.m_size = new Size(scrSize, scrSize);
            this.counter = 0;

        }

        //public Method
        public void Basla(int level)
        {
            //-------Karıştırma-----------//
            this.level = level;


            
            if (clsFrm1.GettingPicture == null)
            {
                MessageBox.Show("Herhangi bir resim dosyası seçmediniz..");
                return;
            }
            if (counter > 0)
            {
                clsFrm1.tmrAutoComplete.Stop();
                clsFrm1.tmrAutoComplete.Enabled = false;
                clsFrm1.ClsStatusCont.GameOver(EnumStatus.Status.Lose);
                Thread.Sleep(1000);
            }


            clsFrm1.MenuBasla.Text = "Pes Et";
            clsFrm1.MenuBasla.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            clsFrm1.menuAutoComplete.Enabled = true;

            clsImgCont = new ImageControl(level, m_size.Height);


            int xForm = clsFrm1.ScrWCenter;
            int yForm = clsFrm1.ScrHCenter;
            int card = 0;

            //Küçük karlerin boyutları
            int sizeSquare = clsFrm1.GettingPicture.Width / level;


            for (int i = 0; i < level * level; i++)
            {
                //Resimlerin koordinatlarını belirliyo
                Rectangle secili_alan = new Rectangle((i % level) * sizeSquare, (i / level) * sizeSquare, sizeSquare, sizeSquare);


                pbxImage = new PictureBox();
                pbxImage.Click += new EventHandler(PbxImage_Click);

                pbxArry[i] = pbxImage;
                pbxArry[i].Name = i.ToString();

                pbxArry[i].Size = new Size(sizeSquare, sizeSquare);
                pbxArry[i].Location = new Point(xForm + (i % level) * sizeSquare, yForm + (i / level) * sizeSquare);
                pbxArry[i].BorderStyle = BorderStyle.FixedSingle;
                pbxArry[i].SizeMode = PictureBoxSizeMode.CenterImage;
                //Resimleri boyutlandırıp listeye atıyor..
                lstPics.Add(ImageControl.SplitImage(clsFrm1.GettingPicture, secili_alan));
                pbxArry[i].Image = lstPics[i];
                Card.Add(pbxArry[i]);

                int generatedRandom = rand.Next(0, level * level);
                while (number.Contains(generatedRandom))
                    generatedRandom = rand.Next(0, level * level);

                number.Add(generatedRandom);
                randNumArry[card++] = generatedRandom;

                clsFrm1.Controls.Add(pbxArry[i]);

            }

            clsFrm1.LblNumOfAttack.Enabled = true;
            clsFrm1.LblAttack.Enabled = true;
            clsFrm1.MenuBgColor.Enabled = true;
            clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;

            //for (int i = 0; i < level*level; i++)
            //{
            //    randNumArry[i] = i;
            //}

            for (int i = 0; i < level * level; i++)
            {
                PictureBox pbxImg = (PictureBox)Card[i];//buradaki pcb yerel değişken

                pbxArray[i] = (PictureBox)Card[i];
                pbxArray[i].Image = lstPics[randNumArry[i]];
            }

            pbxArry[level * level - 1].Image = null;

            counter++;

        }        

        public void PictureLoad()
        {
            //-------Resim Yükleme-----------//

            //Sayacımız oyunun başlamasını kontrol ediyor
            if (counter > 0)
            {
                MessageBox.Show("Oyun Bitmeden tekrar başlayamazsın!!!");
                return;
            }

            // Dosya seçmek için .. Filename format
            openFile.FileName = "";
            openFile.Filter = "All Picture Files (*.jpg,*.bmp,*.gif)|*.jpg;*.bmp;*.gif";
            openFile.ShowDialog();

            //dosya seçilmemişse fonksiyondan çık
            if (openFile.FileName == "")
                return;
            

            //resmin boyutları ayarlanıyo...
            clsFrm1.GettingPicture = ImageControl.resizeImage(Image.FromFile(openFile.FileName), m_size);


           
            if (clsFrm1.GettingPicture != null)
            {
                MessageBox.Show("Image Dosyanız başarı ile yüklendi...");
            }
            else
                MessageBox.Show("Dosyanız yüklenirken bir hata oluştu!!!");

        }

        public void TmrStatusControl()
        {
            if (formBackColorCount % 2 == 0)
                clsFrm1.BackColor = Color.Red;
            else
                clsFrm1.BackColor = Color.Black;
            formBackColorCount++;
        }
        public void ChangeColor(ref ToolStripMenuItem menuItem)
        {
            clsFrm1.ColorCheckedClear();
            menuItem.Checked = true;
            if (counter == 0)
            {
                clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = clsFrm1.BackColor;
                return;
            }
            switch (menuItem.Text)
            {
                case "Black": clsFrm1.BackColor = Color.Black;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Red": clsFrm1.BackColor = Color.Red;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Gray": clsFrm1.BackColor = Color.Gray;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Purple": clsFrm1.BackColor = Color.Purple;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Blue": clsFrm1.BackColor = Color.Blue;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Orange": clsFrm1.BackColor = Color.Orange;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                case "Pink": clsFrm1.BackColor = Color.Pink;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.White;
                    break;
                default: clsFrm1.BackColor = Color.White;
                    clsFrm1.LblAttack.ForeColor = clsFrm1.LblNumOfAttack.ForeColor = Color.Gray;
                    break;
            }


        }
        public void ChangeSize(ref ToolStripMenuItem menuItem, int level)
        {
            clsFrm1.SizeClear();
            menuItem.Checked = true;
            clsFrm1.ResizeBoxes(level);
        }

        //private Method
    

        private void IsAttack(PictureBox pbxScrImage)
        {
            clsPuzzleCont.Attack(pbxScrImage);
            clsFrm1.LblAttack.Text = Convert.ToString(PuzzleControl.AttackNum);
        }

        private void IsTrueImage()
        {
            if (clsPuzzleCont.IsTruePicture())
            {
                //kayıp parçayı ekle
                clsPuzzleCont.addLostItem();
                clsFrm1.ClsStatusCont.GameOver(EnumStatus.Status.Win);
            }
        }
        private void PbxImage_Click(object sender, EventArgs e)
        {

            clsPuzzleCont = new PuzzleControl(lstPics, randNumArry, pbxArray);
            PictureBox pbxScrImage = (PictureBox)sender;

            //Dogru Resim mi diye kontrol et
            this.IsTrueImage();

            //Hamle Yap
            IsAttack(pbxScrImage);


            this.IsTrueImage();

        }
        private void PbxImage_Click(PictureBox pbxScrImage)
        {
            bool wait;
            clsPuzzleCont = new PuzzleControl(lstPics, randNumArry, pbxArray);

            wait=clsPuzzleCont.IsAttack(pbxScrImage);
            clsFrm1.LblAttack.Text = Convert.ToString(PuzzleControl.AttackNum);

            if (wait)
            {
                Thread.Sleep(10);
            }

            if (clsPuzzleCont.IsTruePicture())
            {
                clsFrm1.tmrAutoComplete.Stop();
                clsFrm1.tmrAutoComplete.Enabled = false;
                clsPuzzleCont.addLostItem();
                clsFrm1.ClsStatusCont.GameOver(EnumStatus.Status.Win);

                Thread.Sleep(1000);
            }


        }

        public void AutomaticCopmlete()
        {
                this.PbxImage_Click(pbxArry[rand.Next(level * level)]);
        }

      
    }
}
