using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public partial class PhotoAlbum : Form
    {
        Control m_CurrentControl;
        public User LogedInUser { get; set; }
        public User SelectedFriend { get; set; }
        private List<bool> m_FirstDemend = new List<bool> { true, true, true };
        private Button m_ButtonPointer = null;

        public event Action<ISortAlgo,Button> RadioButtonWasClicked;

        public PhotoAlbum()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            foreach (Control button in this.Controls)
            {
                if (button is proxyButton)
                {
                    (button as proxyButton).PerformClick();
                }
            }
            foreach (Control control in groupBoxOrder.Controls)
                if (control is RadioButtonWrapper)
                    (control as RadioButtonWrapper).SortAlgo = RadioButtonWrapper.CreateNew((control as RadioButtonWrapper).Text);
            base.OnShown(e);
        }

        private void displayAdapters()
        {
            int left = 0, top = 0, numOfPhotos = 0;
            foreach (Control control in PictureCollection.Controls)
            {
                if (control is IVisibaleControl)
                {
                    (control as IVisibaleControl).Invoke(new Action(() => (control as IVisibaleControl).SetLocation(left, top)));
                    (control as IVisibaleControl).Invoke(new Action(() => (control as IVisibaleControl).SetSize(100, 100)));
                    (control as IVisibaleControl).Invoke(new Action(() => (control as IVisibaleControl).SetAtherComponents()));
                    left += 115;
                    numOfPhotos++;
                    if (numOfPhotos % 5 == 0)
                    {
                        top += 115;
                        left = 0;
                    }
                }
            }
            if (PictureCollection.Controls.Count > 0)
            {
                foreach (Control control in PictureCollection.Controls)
                {
                    if (control is PictureBoxAdapter)
                    {
                        MainPictureBox.Image = (control as PictureBoxAdapter).Image;
                        m_CurrentControl = PictureCollection.Controls[0];
                        break;
                    }
                }
            }
            else
            {
                MainPictureBox.LoadAsync("https://i.ytimg.com/vi/CKgEmWL1YrQ/maxresdefault.jpg");
            }
        }

        private void adjestPictureCollection(proxyButton i_Button)
        {
            PictureCollection.Controls.Clear();
            foreach (Control pic in i_Button.Controls)
            {
                if (pic is PictureBoxAdapter)
                {
                    PictureBoxAdapter photo = new PictureBoxAdapter();
                    photo.Image = (pic as PictureBoxAdapter).Image;
                    photo.Click += photo_Click;
                    photo.Cursor = Cursors.Hand;
                    PictureCollection.Controls.Add((photo));
                }
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
            m_CurrentControl = sender as Control;
            photoBindingSource.Position = PictureCollection.Controls.GetChildIndex(m_CurrentControl);
            MainPictureBox.Image = (m_CurrentControl as PictureBoxAdapter).Image;
            foreach (object pic in PictureCollection.Controls)
            {
                if (pic is PictureBoxAdapter)
                    (pic as PictureBoxAdapter).BorderStyle = BorderStyle.None;
            }
            (sender as PictureBoxAdapter).BorderStyle = BorderStyle.Fixed3D;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            foreach (Control button in this.Controls)
            {
                if (button is proxyButton)
                    (button as proxyButton).Dispose();
            }
            PictureCollection.Controls.Clear();
        }

        private void nextOrPrevius(bool i_Action)
        {
            try
            {
                if (((m_CurrentControl == PictureCollection.Controls[PictureCollection.Controls.Count - 1]) && (i_Action == true)) || ((m_CurrentControl == PictureCollection.Controls[0]) && (i_Action == false)))
                    throw new Exception();
                m_CurrentControl = (PictureCollection.GetNextControl((m_CurrentControl), i_Action));
                photoBindingSource.Position = PictureCollection.Controls.GetChildIndex(m_CurrentControl);
                MainPictureBox.Image = (m_CurrentControl as PictureBox).Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is the last/first photo");
            }
        }

        private void invokeChoiceButtonPressed(proxyButton i_Button)
        {
            adjestPictureCollection(i_Button);
            displayAdapters();
        }

        private void myPicsButton_Click(object sender, EventArgs e)
        {
            if (m_FirstDemend[0] == true)
                m_FirstDemend[0] = false;
            else
            {
                m_ButtonPointer = sender as proxyButton;
                photoBindingSource.DataSource = LogedInUser.PhotosTaggedIn;
                invokeChoiceButtonPressed(sender as proxyButton);
            }
        }

        private void friendsPicsButton_Click(object sender, EventArgs e)
        {

            if (m_FirstDemend[1] == true)
                m_FirstDemend[1] = false;
            else
            {
                m_ButtonPointer = sender as proxyButton;
                photoBindingSource.DataSource = SelectedFriend.PhotosTaggedIn;
                invokeChoiceButtonPressed(sender as proxyButton);
            }
        }

        private void togetherPicsButton_Click(object sender, EventArgs e)
        {

            if (m_FirstDemend[2] == true)
                m_FirstDemend[2] = false;
            else
            {
                m_ButtonPointer = sender as proxyButton;
                invokeChoiceButtonPressed(sender as proxyButton);
            }
        }

        private void prevPic_Click(object sender, EventArgs e)
        {
            nextOrPrevius(false);
        }

        private void nextPic_Click(object sender, EventArgs e)
        {
            nextOrPrevius(true);
        }

        private void radioButtonWrapperLikes_Click(object sender, EventArgs e)
        {
            if (RadioButtonWasClicked != null)
            {
                PictureCollection.Controls.Clear();
                RadioButtonWasClicked.Invoke((sender as RadioButtonWrapper).SortAlgo,m_ButtonPointer);
            }
        }
    }
}
