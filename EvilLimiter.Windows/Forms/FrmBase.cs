using EvilLimiter.Windows.Common;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmBase : MetroForm
    {
        public static event EventHandler<ColorStyleChangedEventArgs> ColorStyleChanged;
        public static void OnColorStyleChanged(ColorStyleChangedEventArgs e)
            => ColorStyleChanged?.Invoke(null, e);



        public FrmBase()
        {
            InitializeComponent();
            ChangeColorStyle(Config.ColorStyle);

            ColorStyleChanged += FrmBase_ColorStyleChanged;
        }



        public void ChangeColorStyle(MetroColorStyle style)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { ChangeColorStyle(style); });
            else
            {
                smMain.Style = style;
                Style = style;
                Refresh();
            }
        }


        #region Subscribed Events

        private void FrmBase_ColorStyleChanged(object sender, ColorStyleChangedEventArgs e)
        {
            ChangeColorStyle(e.ColorStyle);
        }

        #endregion
    }



    public class ColorStyleChangedEventArgs
    {
        public MetroColorStyle ColorStyle { get; private set; }


        public ColorStyleChangedEventArgs(MetroColorStyle style)
        {
            this.ColorStyle = style;
        }
    }
}
