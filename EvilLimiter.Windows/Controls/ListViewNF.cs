using MetroFramework.Controls;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Controls
{
    public class ListViewNF : MetroListView
    {
        public ListViewNF()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
        }



        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg != 0x14)
                base.OnNotifyMessage(m);
        }


        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            
        }
    }
}
