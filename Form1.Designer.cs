namespace C19__EX01_Inbal311403133_Bar311492938
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.Mutual_Tagging = new System.Windows.Forms.Button();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonFriendsLocation = new System.Windows.Forms.Button();
            this.listBoxFriendLocation = new System.Windows.Forms.ListBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPageLike = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.listBoxPageLike = new System.Windows.Forms.ListBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(8, 11);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(156, 24);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "connect with facebook";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(8, 41);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(92, 17);
            this.checkBoxRememberMe.TabIndex = 2;
            this.checkBoxRememberMe.Text = "RememberMe";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.Checked = true;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(11, 91);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(153, 147);
            this.listBoxFriends.TabIndex = 3;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // Mutual_Tagging
            // 
            this.Mutual_Tagging.Enabled = false;
            this.Mutual_Tagging.Location = new System.Drawing.Point(11, 245);
            this.Mutual_Tagging.Margin = new System.Windows.Forms.Padding(2);
            this.Mutual_Tagging.Name = "Mutual_Tagging";
            this.Mutual_Tagging.Size = new System.Drawing.Size(140, 37);
            this.Mutual_Tagging.TabIndex = 4;
            this.Mutual_Tagging.Text = "Our Tags";
            this.Mutual_Tagging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Mutual_Tagging.UseVisualStyleBackColor = true;
            this.Mutual_Tagging.Click += new System.EventHandler(this.mutual_Tagging_Click);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(259, 10);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(71, 13);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "My Location :";
            // 
            // buttonFriendsLocation
            // 
            this.buttonFriendsLocation.Location = new System.Drawing.Point(262, 25);
            this.buttonFriendsLocation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFriendsLocation.Name = "buttonFriendsLocation";
            this.buttonFriendsLocation.Size = new System.Drawing.Size(131, 28);
            this.buttonFriendsLocation.TabIndex = 6;
            this.buttonFriendsLocation.Text = "Friends In My Location";
            this.buttonFriendsLocation.UseVisualStyleBackColor = true;
            this.buttonFriendsLocation.Click += new System.EventHandler(this.buttonFriendsLocation_Click);
            // 
            // listBoxFriendLocation
            // 
            this.listBoxFriendLocation.FormattingEnabled = true;
            this.listBoxFriendLocation.Location = new System.Drawing.Point(261, 69);
            this.listBoxFriendLocation.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriendLocation.Name = "listBoxFriendLocation";
            this.listBoxFriendLocation.Size = new System.Drawing.Size(132, 95);
            this.listBoxFriendLocation.TabIndex = 7;
            this.listBoxFriendLocation.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendLocation_SelectedIndexChanged);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(256, 245);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(74, 29);
            this.buttonPostStatus.TabIndex = 8;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click_1);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(345, 250);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(282, 20);
            this.textBoxPostStatus.TabIndex = 10;
            // 
            // buttonPageLike
            // 
            this.buttonPageLike.Location = new System.Drawing.Point(432, 24);
            this.buttonPageLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPageLike.Name = "buttonPageLike";
            this.buttonPageLike.Size = new System.Drawing.Size(74, 29);
            this.buttonPageLike.TabIndex = 12;
            this.buttonPageLike.Text = "Page Like";
            this.buttonPageLike.UseVisualStyleBackColor = true;
            this.buttonPageLike.Click += new System.EventHandler(this.buttonPageLike_Click_1);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.Location = new System.Drawing.Point(553, 290);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(74, 29);
            this.buttonLogOut.TabIndex = 13;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click_1);
            // 
            // listBoxPageLike
            // 
            this.listBoxPageLike.FormattingEnabled = true;
            this.listBoxPageLike.Location = new System.Drawing.Point(517, 25);
            this.listBoxPageLike.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPageLike.Name = "listBoxPageLike";
            this.listBoxPageLike.Size = new System.Drawing.Size(110, 56);
            this.listBoxPageLike.TabIndex = 14;
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(432, 108);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(74, 29);
            this.buttonEvents.TabIndex = 15;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(517, 108);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(110, 56);
            this.listBoxEvents.TabIndex = 16;
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(261, 189);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(143, 21);
            this.comboBoxPlace.TabIndex = 17;
            this.comboBoxPlace.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlace_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Places near my location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlace);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.listBoxPageLike);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonPageLike);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.listBoxFriendLocation);
            this.Controls.Add(this.buttonFriendsLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.Mutual_Tagging);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Friends_List_SelectedIndexChanged2(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Friends_List_SelectedIndexChanged1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button Mutual_Tagging;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonFriendsLocation;
        private System.Windows.Forms.ListBox listBoxFriendLocation;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPageLike;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ListBox listBoxPageLike;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.Label label1;
    }
}

