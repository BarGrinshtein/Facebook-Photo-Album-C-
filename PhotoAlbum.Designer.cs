namespace C19__EX01_Inbal311403133_Bar311492938
{
    partial class PhotoAlbum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoAlbum));
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureCollection = new System.Windows.Forms.Panel();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.likedByBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrevPic = new System.Windows.Forms.PictureBox();
            this.NextPic = new System.Windows.Forms.PictureBox();
            this.TogetherPicsButton = new C19__EX01_Inbal311403133_Bar311492938.TogetherPics();
            this.FriendsPicsButton = new C19__EX01_Inbal311403133_Bar311492938.FriendsPics();
            this.MyPicsButton = new C19__EX01_Inbal311403133_Bar311492938.MyPics();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonWrapperUploads = new C19__EX01_Inbal311403133_Bar311492938.RadioButtonWrapper();
            this.radioButtonWrapperLikes = new C19__EX01_Inbal311403133_Bar311492938.RadioButtonWrapper();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            this.DetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likedByBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPic)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Album Name:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(3, 91);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(3, 15);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(90, 17);
            nameLabel1.TabIndex = 4;
            nameLabel1.Text = "Photo Name:";
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPictureBox.Location = new System.Drawing.Point(112, 2);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(365, 274);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // PictureCollection
            // 
            this.PictureCollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureCollection.AutoScroll = true;
            this.PictureCollection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PictureCollection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureCollection.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.photoBindingSource, "CreatedTime", true));
            this.PictureCollection.Location = new System.Drawing.Point(12, 306);
            this.PictureCollection.Name = "PictureCollection";
            this.PictureCollection.Size = new System.Drawing.Size(793, 135);
            this.PictureCollection.TabIndex = 1;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetailsPanel.Controls.Add(nameLabel1);
            this.DetailsPanel.Controls.Add(this.nameTextBox1);
            this.DetailsPanel.Controls.Add(createdTimeLabel);
            this.DetailsPanel.Controls.Add(this.createdTimeDateTimePicker);
            this.DetailsPanel.Controls.Add(nameLabel);
            this.DetailsPanel.Controls.Add(this.nameTextBox);
            this.DetailsPanel.Location = new System.Drawing.Point(483, 2);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(317, 154);
            this.DetailsPanel.TabIndex = 2;
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Name", true));
            this.nameTextBox1.Location = new System.Drawing.Point(106, 10);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox1.TabIndex = 5;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photoBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(106, 86);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.createdTimeDateTimePicker.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Album.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(106, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // likedByBindingSource
            // 
            this.likedByBindingSource.DataMember = "LikedBy";
            this.likedByBindingSource.DataSource = this.photoBindingSource;
            // 
            // PrevPic
            // 
            this.PrevPic.BackColor = System.Drawing.SystemColors.Control;
            this.PrevPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrevPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevPic.ImageLocation = "https://image.freepik.com/free-icon/no-translate-detected_318-10099.jpg";
            this.PrevPic.Location = new System.Drawing.Point(7, 174);
            this.PrevPic.Name = "PrevPic";
            this.PrevPic.Size = new System.Drawing.Size(99, 48);
            this.PrevPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrevPic.TabIndex = 8;
            this.PrevPic.TabStop = false;
            this.PrevPic.Click += new System.EventHandler(this.prevPic_Click);
            // 
            // NextPic
            // 
            this.NextPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NextPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPic.ImageLocation = "https://image.freepik.com/free-icon/no-translate-detected_318-50470.jpg";
            this.NextPic.Location = new System.Drawing.Point(7, 228);
            this.NextPic.Name = "NextPic";
            this.NextPic.Size = new System.Drawing.Size(99, 48);
            this.NextPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextPic.TabIndex = 9;
            this.NextPic.TabStop = false;
            this.NextPic.Click += new System.EventHandler(this.nextPic_Click);
            // 
            // TogetherPicsButton
            // 
            this.TogetherPicsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TogetherPicsButton.Location = new System.Drawing.Point(7, 112);
            this.TogetherPicsButton.Name = "TogetherPicsButton";
            this.TogetherPicsButton.SelectedUser = ((System.Collections.Generic.List<FacebookWrapper.ObjectModel.User>)(resources.GetObject("TogetherPicsButton.SelectedUser")));
            this.TogetherPicsButton.Size = new System.Drawing.Size(99, 44);
            this.TogetherPicsButton.TabIndex = 7;
            this.TogetherPicsButton.Text = "togetherPics1";
            this.TogetherPicsButton.UseVisualStyleBackColor = true;
            this.TogetherPicsButton.Click += new System.EventHandler(this.togetherPicsButton_Click);
            // 
            // FriendsPicsButton
            // 
            this.FriendsPicsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FriendsPicsButton.Location = new System.Drawing.Point(7, 62);
            this.FriendsPicsButton.Name = "FriendsPicsButton";
            this.FriendsPicsButton.SelectedUser = ((System.Collections.Generic.List<FacebookWrapper.ObjectModel.User>)(resources.GetObject("FriendsPicsButton.SelectedUser")));
            this.FriendsPicsButton.Size = new System.Drawing.Size(99, 44);
            this.FriendsPicsButton.TabIndex = 6;
            this.FriendsPicsButton.Text = "friendsPics1";
            this.FriendsPicsButton.UseVisualStyleBackColor = true;
            this.FriendsPicsButton.Click += new System.EventHandler(this.friendsPicsButton_Click);
            // 
            // MyPicsButton
            // 
            this.MyPicsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MyPicsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPicsButton.Location = new System.Drawing.Point(7, 12);
            this.MyPicsButton.Name = "MyPicsButton";
            this.MyPicsButton.SelectedUser = ((System.Collections.Generic.List<FacebookWrapper.ObjectModel.User>)(resources.GetObject("MyPicsButton.SelectedUser")));
            this.MyPicsButton.Size = new System.Drawing.Size(99, 44);
            this.MyPicsButton.TabIndex = 5;
            this.MyPicsButton.Text = "myPics1";
            this.MyPicsButton.UseVisualStyleBackColor = true;
            this.MyPicsButton.Click += new System.EventHandler(this.myPicsButton_Click);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrder.Controls.Add(this.radioButtonWrapperUploads);
            this.groupBoxOrder.Controls.Add(this.radioButtonWrapperLikes);
            this.groupBoxOrder.Location = new System.Drawing.Point(490, 174);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(207, 102);
            this.groupBoxOrder.TabIndex = 10;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Sort Options";
            // 
            // radioButtonWrapperUploads
            // 
            this.radioButtonWrapperUploads.AutoSize = true;
            this.radioButtonWrapperUploads.Location = new System.Drawing.Point(7, 54);
            this.radioButtonWrapperUploads.Name = "radioButtonWrapperUploads";
            this.radioButtonWrapperUploads.Size = new System.Drawing.Size(121, 21);
            this.radioButtonWrapperUploads.SortAlgo = null;
            this.radioButtonWrapperUploads.TabIndex = 1;
            this.radioButtonWrapperUploads.Text = "First Uploaded";
            this.radioButtonWrapperUploads.UseVisualStyleBackColor = true;
            this.radioButtonWrapperUploads.Click += new System.EventHandler(this.radioButtonWrapperLikes_Click);
            // 
            // radioButtonWrapperLikes
            // 
            this.radioButtonWrapperLikes.AutoSize = true;
            this.radioButtonWrapperLikes.Location = new System.Drawing.Point(7, 27);
            this.radioButtonWrapperLikes.Name = "radioButtonWrapperLikes";
            this.radioButtonWrapperLikes.Size = new System.Drawing.Size(96, 21);
            this.radioButtonWrapperLikes.SortAlgo = null;
            this.radioButtonWrapperLikes.TabIndex = 0;
            this.radioButtonWrapperLikes.Text = "Most Likes";
            this.radioButtonWrapperLikes.UseVisualStyleBackColor = true;
            this.radioButtonWrapperLikes.Click += new System.EventHandler(this.radioButtonWrapperLikes_Click);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.photoBindingSource;
            // 
            // PhotoAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 464);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.NextPic);
            this.Controls.Add(this.PrevPic);
            this.Controls.Add(this.TogetherPicsButton);
            this.Controls.Add(this.FriendsPicsButton);
            this.Controls.Add(this.MyPicsButton);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.PictureCollection);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "PhotoAlbum";
            this.Text = "PhotoAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likedByBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextPic)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Panel PictureCollection;
        private System.Windows.Forms.Panel DetailsPanel;
        private MyPics MyPicsButton;
        private FriendsPics FriendsPicsButton;
        private TogetherPics TogetherPicsButton;
        private System.Windows.Forms.PictureBox PrevPic;
        private System.Windows.Forms.PictureBox NextPic;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private RadioButtonWrapper radioButtonWrapperUploads;
        private RadioButtonWrapper radioButtonWrapperLikes;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource likedByBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
    }
}