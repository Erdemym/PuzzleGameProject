
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

namespace PuzzleLibrary
{
    public class PuzzleControl : IPuzzleControl
    {
        //private field
        private int level;
        private int scrSize;
        private int[] randNumArry;
        private List<Image> lstPics;
        private PictureBox[] pbxArray;
        //private static field
        private static int attackNum = 0;

        //property
        public static int AttackNum
        {
            get { return attackNum; }
        }

        //costructor
        public PuzzleControl(List<Image> lstPics, int[] randNumArry, PictureBox[] pbxArray)
        {
            this.level = ImageControl.NLevel;
            this.scrSize = ImageControl.ScrSize;
            this.lstPics = lstPics;
            this.randNumArry = randNumArry;
            this.pbxArray = pbxArray;
 
        }

        //public method
        public bool IsTruePicture()
        {
            //Doğru Resmi Kontrolu
            for (int i = 0; i < level * level; i++)
            {
                if (randNumArry[level * level - 1] == i)
                    continue;

                if (pbxArray[i].Image != lstPics[i])
                    return false;

            }

            return true;
        }
        public bool IsAttack(PictureBox pbxScrImage)
        {
            bool result = false;
            //Hamle
            int x = (pbxScrImage.Location.X - (Screen.PrimaryScreen.Bounds.Width - scrSize) / 2) / (scrSize / level);
            int y = (pbxScrImage.Location.Y - (Screen.PrimaryScreen.Bounds.Height - scrSize) / 2) / (scrSize / level);



            if(AC_Algorithms(pbxScrImage,x, y))
                return result ;

            for (int i = 0; i < level * level; i++)
            {

                //seçtiğimiz resim boş olan karenin sağ sol aşşağı veya yukarısındamı... 
                //pbxArray Ekrandaki dizi
                //pbxScrImage tıklanan reslim...
                if ((pbxArray[i].Image == null) && (
                    ((pbxScrImage.Location.X) == pbxArray[i].Location.X + scrSize / level) && ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y) ||
                    ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y + scrSize / level) && ((pbxScrImage.Location.X) == pbxArray[i].Location.X) ||
                    ((pbxScrImage.Location.X) == pbxArray[i].Location.X - scrSize / level) && ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y) ||
                    ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y - scrSize / level) && ((pbxScrImage.Location.X) == pbxArray[i].Location.X)
                ))
                {
                    pbxArray[i].Image = pbxScrImage.Image;
                    attackNum++;
                    pbxScrImage.Image = null;//yol bul
                    result = true;
                }

            }
            return result;
        }
        public void addLostItem()
        {
            //Kayıp Parçayı Ekle
            for (int j = 0; j < level * level; j++)
            {
                if (pbxArray[j].Image == null)
                    pbxArray[j].Image = lstPics[randNumArry[level * level - 1]];
            }
        }
        public void Attack(PictureBox pbxScrImage)
        {


            //Hamle
            for (int i = 0; i < level * level; i++)
            {

                //seçtiğimiz resim boş olan karenin sağ sol aşşağı veya yukarısındamı... 
                //pbxArray Ekrandaki dizi
                //pbxScrImage tıklanan reslim...
                if ((pbxArray[i].Image == null) && (
                    ((pbxScrImage.Location.X) == pbxArray[i].Location.X + scrSize / level) && ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y) ||
                    ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y + scrSize / level) && ((pbxScrImage.Location.X) == pbxArray[i].Location.X) ||
                    ((pbxScrImage.Location.X) == pbxArray[i].Location.X - scrSize / level) && ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y) ||
                    ((pbxScrImage.Location.Y) == pbxArray[i].Location.Y - scrSize / level) && ((pbxScrImage.Location.X) == pbxArray[i].Location.X)
                ))
                {
                    pbxArray[i].Image = pbxScrImage.Image;
                    attackNum++;
                    pbxScrImage.Image = null;//yol bul

                }
            }
        }
        
        //private method

        private bool AC_Algorithms(PictureBox pbxScrImage, int x, int y)
        {
            bool result = true;

            if (randNumArry[level * level - 1] == (y * level + x))
                return result;
            if (pbxArray[0].Image != null && pbxArray[0].Image == lstPics[0] && (pbxScrImage.Image == lstPics[y * level + x]))
            {
                if ((level == 3) && (((x == 0 || x == 1||x==2) && (y == 0)) || ((y == 0 || y == 1) && (x == 0))))
                    return result;
                if ((level == 4) && (((x == 0 || x == 1 || x == 2 || x == 3) && (y == 0)) || ((y == 0 || y == 1 || y == 2) && (x == 0))))
                    return result;
                if ((level == 5) && (((x == 0 || x == 1 || x == 2 || x == 3 || x == 4) && (y == 0)) || ((y == 0 || y == 1 || y == 2 || y == 3) && (x == 0))) || ((x == 0 || x == 1 || x == 2 || x == 3 || x == 4) && (y == 4)) || ((y == 0 || y == 1 || y == 2 || y == 3) && (x == 4)))
                    return result;
                if ((level == 6) && (((x == 0 || x == 1 || x == 2 || x == 3 || x == 4 || x == 5) && (y == 0)) || ((x == 0 || x == 1 || x == 2 || x == 3 || x == 4 || x == 5) && (y == 5)) || ((y == 0 || y == 1 || y == 2 || y == 3 || y == 4 || y == 5) && (x == 0)) || ((y == 0 || y == 1 || y == 2 || y == 3 || y == 4) && (x == 5))))
                    return result;
            }
            return false;
        }
    }
}
