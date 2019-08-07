using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class MyPics : proxyButton
    {
       
        protected override void FillTheList()
        {
            try
            {
                foreach (Photo photo in SelectedUser[0].PhotosTaggedIn)
                {

                    PictureBoxAdapter pic = new PictureBoxAdapter();
                    pic.m_photo = photo;
                    pic.Load(photo.PictureNormalURL);
                    pic.Visible = false;

                    Invoke((Action)(() =>
                    {
                        this.Controls.Add(pic);
                    }));
                }
            }
            catch (Facebook.FacebookOAuthException e)
            {
                throw new Exception(e.Message);
            }

        }


        protected override void SetText()
        {
            this.Text = "My Photos";
        }
    }
}
