
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System.Windows.Forms;
namespace PuzzleLibrary
{
    interface IPuzzleControl
    {
        bool IsTruePicture();
        void Attack(PictureBox pbxScrImage);
        bool IsAttack(PictureBox pbxScrImage);
        void addLostItem();

    }
}
