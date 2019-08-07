using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public class TogetherPics : proxyButton
    {

        protected override void FillTheList()
        {
            try
            {
                foreach (Photo photo in SelectedUser[1].PhotosTaggedIn)
                {

                    if (SelectedUser[0].PhotosTaggedIn.Contains(photo))
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
            }
            catch (Facebook.FacebookOAuthException e)
            {
                throw new Exception(e.Message);
            }
        }


        protected override void SetText()
        {
            this.Text = string.Format("{0} and {1}'s photos", SelectedUser[0].FirstName, SelectedUser[1].FirstName);
        }
    }
}
