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
    public abstract class proxyButton : Button
    {
        public List<User> SelectedUser { get; set; } = new List<User>();
        protected bool m_SecondDemend = false;
        private ISortAlgo m_SortAlgo = null;


        protected bool m_FirstDemend = true;

        protected abstract void FillTheList();

        protected abstract void SetText();

        protected  void ClearAll()
        {
            SelectedUser.Clear();
            Controls.Clear();
            m_FirstDemend = true;
            m_SecondDemend = false;
        }

        protected override void OnClick(EventArgs e)
        {
            if (m_FirstDemend == true && m_SecondDemend == false)
            {
                Control control = this.Parent;
                if ((control as PhotoAlbum).SelectedFriend != null)
                {
                    (control as PhotoAlbum).RadioButtonWasClicked += applySortAlgo;
                    SelectedUser.Add((control as PhotoAlbum).LogedInUser);
                    SelectedUser.Add((control as PhotoAlbum).SelectedFriend);
                    SetText();
                }
                m_SecondDemend = true;
                m_FirstDemend = false;
                base.OnClick(e);
            }
            else if (m_SecondDemend == true && m_FirstDemend == false)
            {
                new Thread(() =>
                {
                    try
                    {
                        FillTheList();

                        m_SecondDemend = false;
                        Invoke((new Action(() => base.OnClick(e))));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Unable to access to this profile photos until facebook allow this up");
                    }
                }).Start();

            }
            else if (m_SecondDemend == false && m_FirstDemend == false)
                base.OnClick(e);
        }

        protected override void Dispose(bool disposing)
        {
            ClearAll();
        }

        private void applySortAlgo(ISortAlgo i_SortAlgo,Button i_Button)
        {
            if (this.Equals(i_Button))
            {
                this.m_SortAlgo = i_SortAlgo;
                m_SortAlgo.SortDataStructure(this.Controls);
                this.PerformClick();
            }
        }

    }
}
