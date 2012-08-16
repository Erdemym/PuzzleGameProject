
//===========================================================================
// Puzzle Project ©2010
// Erdem YILMAZ
// erdemym@gmail.com
// http://erdemym.wordpress.com
//===========================================================================

using System.Windows.Forms;


namespace PuzzleProject
{
    interface IControl
    {
         void ChangeSize(ref ToolStripMenuItem menuItem, int level);
         void ChangeColor(ref ToolStripMenuItem menuItem);
    }
}
