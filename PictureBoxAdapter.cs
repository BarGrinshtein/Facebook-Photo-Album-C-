using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class PictureBoxAdapter : PictureBox, IVisibaleControl
    {
        public Photo m_photo;

        public void SetLocation(int i_left, int i_top)
        {
            this.Location = new Point(i_left, i_top); 
        }

        public void SetSize(int i_width, int i_height)
        {
            this.Width = i_width;
            this.Height = i_height;
        }

        public void SetAtherComponents()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Cursor = Cursors.Hand;
        }

        void IVisibaleControl.Invoke(Delegate T)
        {
            base.Invoke(T);
        }
    }
}
