using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public partial class Form1 : Form
    {
        PhotoAlbum m_MyPostsAlbum = new PhotoAlbum();
        Settings m_Settings = new Settings();
        LoginResult m_LoginResult=new LoginResult();
        User m_LoggedInUser = new User();

        public Form1()
        {
            InitializeComponent();

            this.Text = "My App";
            m_MyPostsAlbum.FormClosing += m_myPostsAlbum_FormClosing;
            m_Settings = Settings.LoadLastUser();

            if (m_Settings.RememberUser && !string.IsNullOrEmpty(m_Settings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_Settings.LastAccessToken); //שורה שבה המשתמש נשאר מחובר גם אחרי יציאה מהאפליקציה
                logedInActivities();
            }

            comboBoxPlace.Items.Add("בית קפה");
            comboBoxPlace.Items.Add("תחנת דלק");
            comboBoxPlace.Items.Add("מסעדות");
            comboBoxPlace.Items.Add("סופרמרקט");
            comboBoxPlace.Items.Add("מוסך");
            
        }


        private void m_myPostsAlbum_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBoxFriends.ClearSelected();
            Mutual_Tagging.Enabled = false;
                
        }



        protected override void OnFormClosing(FormClosingEventArgs e) // לשמור נתונים לפני שהאפליקציה נסגרת
        {
            base.OnFormClosing(e);
            m_Settings.RememberUser = this.checkBoxRememberMe.Checked;
            m_Settings.SaveLastUserToFile();
        }


        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            m_LoginResult = FacebookService.Login("341841786634866", "user_photos", "user_friends", "user_tagged_places", "user_posts", "user_events", "user_likes");//שורת חיבור למשתמש (רק צריך לבחור הרשאות).ע
            logedInActivities();
        }

        private void logedInActivities()
            
        {
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_Settings.LastAccessToken = m_LoginResult.AccessToken;
            pictureBox1.LoadAsync(m_LoggedInUser.PictureSmallURL);//טעינת תמונת פרופיל
            this.Text = string.Format("{0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            m_MyPostsAlbum.LogedInUser = m_LoggedInUser;
            foreach (User friend in m_LoggedInUser.Friends)
            {
                MyFriend myFriend = new MyFriend();
                myFriend.Friend = friend;
                listBoxFriends.Items.Add(myFriend);
            }

            labelLocation.MouseHover += labelLocation_MouseHover;
            labelLocation.MouseLeave += labelLocation_MouseLeave;
        }

        private void labelLocation_MouseLeave(object sender, EventArgs e)//כשהעכבר עובר על התווית הוא מציג את המיקום
        {
            try
            {
                labelLocation.Text = "My location";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelLocation_MouseHover(object sender, EventArgs e)//כשהעכבר עובר על התווית הוא מציג את המיקום
        {
            try
            {
                labelLocation.Text = m_LoggedInUser.Location.Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Mutual_Tagging.Enabled = true;
            

        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
                MessageBox.Show("Your status has been posted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void mutual_Tagging_Click(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex != -1)
            {
                m_MyPostsAlbum.SelectedFriend = (listBoxFriends.SelectedItem as MyFriend).Friend;
                m_MyPostsAlbum.Text = string.Format("{0} {1}", m_MyPostsAlbum.SelectedFriend.FirstName, m_MyPostsAlbum.SelectedFriend.LastName);
                m_MyPostsAlbum.ShowDialog();
            }
            else
                MessageBox.Show("Must Pick A Friend");
        }

        private void buttonFriendsLocation_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxFriendLocation.Items.Clear();

                foreach (User friend in m_LoggedInUser.Friends)
                {

                    if (friend.Location != null && friend.Location.Name == m_LoggedInUser.Location.Name)
                    {
                        listBoxFriendLocation.Items.Add(friend);
                    }
                }

                if (listBoxFriendLocation.Items.Count == 0)
                {
                    MessageBox.Show("No friends near your location");
                }
            }

            catch 
            {
                MessageBox.Show("Please login");
            }
        }

        private void buttonPageLike_Click_1(object sender, EventArgs e)
        {
            try
            {
                listBoxPageLike.Items.Clear();
                listBoxPageLike.DisplayMember = "Name";

                foreach (Page pageLike in m_LoggedInUser.LikedPages)
                {
                    listBoxPageLike.Items.Add(pageLike);
                }

                if (m_LoggedInUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages");
                }
            }
            catch 
            {
                MessageBox.Show("Plese login");
            }
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            try
            {
                m_Settings.LastAccessToken = null;
                FacebookService.Logout(logOutsuccessful);
            }
            catch
            {
                MessageBox.Show("You havent logged in yet");
            }
        }

        private void logOutsuccessful()
        {
                MessageBox.Show("Log out successful");
                Close();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxEvents.Items.Clear();
                listBoxEvents.DisplayMember = "Name";

                foreach (Event myEvents in m_LoggedInUser.Events)
                {
                    listBoxEvents.Items.Add(myEvents);
                }

                if (m_LoggedInUser.Events.Count == 0)
                {
                    MessageBox.Show("No events");
                }
            }
            catch 
            {
                MessageBox.Show("Please login");
            }
        }

        private void listBoxFriendLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedFriend = listBoxFriendLocation.SelectedItem as User;
        }

        private void comboBoxPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            string my_selected = comboBoxPlace.SelectedItem.ToString();
            string my_location = m_LoggedInUser.Location.Name.ToString();
            Place place = Place.Create(my_selected, my_location);
        }

        private void buttonPostStatus_Click_1(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
            }
            catch 
            {
                MessageBox.Show("Please login");
            }
        }
    }
}
