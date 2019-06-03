namespace Music_Player
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.player = new System.Windows.Forms.Panel();
            this.buttonPlayerPrev = new System.Windows.Forms.Button();
            this.buttonPlayerNext = new System.Windows.Forms.Button();
            this.buttonPlayerPlay = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.buttonRecent = new System.Windows.Forms.Button();
            this.buttonPlaylist = new System.Windows.Forms.Button();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.libraryInfo = new System.Windows.Forms.Panel();
            this.panelTag = new System.Windows.Forms.Panel();
            this.tagYear = new System.Windows.Forms.Label();
            this.tagLenght = new System.Windows.Forms.Label();
            this.tagGenre = new System.Windows.Forms.Label();
            this.tagTitle = new System.Windows.Forms.Label();
            this.tagArtist = new System.Windows.Forms.Label();
            this.libtxtInfo = new System.Windows.Forms.Label();
            this.libraryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLoading = new System.Windows.Forms.Label();
            this.player.SuspendLayout();
            this.menu.SuspendLayout();
            this.libraryInfo.SuspendLayout();
            this.panelTag.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Maroon;
            this.player.Controls.Add(this.buttonPlayerPrev);
            this.player.Controls.Add(this.buttonPlayerNext);
            this.player.Controls.Add(this.buttonPlayerPlay);
            this.player.Location = new System.Drawing.Point(0, 595);
            this.player.Margin = new System.Windows.Forms.Padding(0);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(1280, 126);
            this.player.TabIndex = 1;
            // 
            // buttonPlayerPrev
            // 
            this.buttonPlayerPrev.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayerPrev.BackgroundImage")));
            this.buttonPlayerPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlayerPrev.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonPlayerPrev.FlatAppearance.BorderSize = 0;
            this.buttonPlayerPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayerPrev.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlayerPrev.Location = new System.Drawing.Point(545, 20);
            this.buttonPlayerPrev.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayerPrev.Name = "buttonPlayerPrev";
            this.buttonPlayerPrev.Size = new System.Drawing.Size(50, 50);
            this.buttonPlayerPrev.TabIndex = 2;
            this.buttonPlayerPrev.UseMnemonic = false;
            this.buttonPlayerPrev.UseVisualStyleBackColor = false;
            // 
            // buttonPlayerNext
            // 
            this.buttonPlayerNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayerNext.BackgroundImage")));
            this.buttonPlayerNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonPlayerNext.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonPlayerNext.FlatAppearance.BorderSize = 0;
            this.buttonPlayerNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayerNext.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlayerNext.Location = new System.Drawing.Point(685, 20);
            this.buttonPlayerNext.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayerNext.Name = "buttonPlayerNext";
            this.buttonPlayerNext.Size = new System.Drawing.Size(50, 50);
            this.buttonPlayerNext.TabIndex = 1;
            this.buttonPlayerNext.UseMnemonic = false;
            this.buttonPlayerNext.UseVisualStyleBackColor = false;
            // 
            // buttonPlayerPlay
            // 
            this.buttonPlayerPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayerPlay.BackgroundImage")));
            this.buttonPlayerPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayerPlay.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonPlayerPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlayerPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayerPlay.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlayerPlay.Location = new System.Drawing.Point(605, 10);
            this.buttonPlayerPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayerPlay.Name = "buttonPlayerPlay";
            this.buttonPlayerPlay.Size = new System.Drawing.Size(70, 70);
            this.buttonPlayerPlay.TabIndex = 0;
            this.buttonPlayerPlay.UseMnemonic = false;
            this.buttonPlayerPlay.UseVisualStyleBackColor = false;
            this.buttonPlayerPlay.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gray;
            this.menu.Controls.Add(this.buttonRecent);
            this.menu.Controls.Add(this.buttonPlaylist);
            this.menu.Controls.Add(this.buttonLibrary);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(300, 595);
            this.menu.TabIndex = 2;
            // 
            // buttonRecent
            // 
            this.buttonRecent.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecent.Location = new System.Drawing.Point(5, 176);
            this.buttonRecent.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRecent.Name = "buttonRecent";
            this.buttonRecent.Size = new System.Drawing.Size(290, 40);
            this.buttonRecent.TabIndex = 6;
            this.buttonRecent.Text = "Recent";
            this.buttonRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecent.UseVisualStyleBackColor = true;
            // 
            // buttonPlaylist
            // 
            this.buttonPlaylist.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaylist.Location = new System.Drawing.Point(5, 226);
            this.buttonPlaylist.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPlaylist.Name = "buttonPlaylist";
            this.buttonPlaylist.Size = new System.Drawing.Size(290, 40);
            this.buttonPlaylist.TabIndex = 5;
            this.buttonPlaylist.Text = "Playlists";
            this.buttonPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlaylist.UseVisualStyleBackColor = true;
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibrary.Location = new System.Drawing.Point(5, 126);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Size = new System.Drawing.Size(290, 40);
            this.buttonLibrary.TabIndex = 3;
            this.buttonLibrary.Text = "My music";
            this.buttonLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibrary.UseVisualStyleBackColor = true;
            this.buttonLibrary.Click += new System.EventHandler(this.LibraryButton_Click);
            // 
            // libraryInfo
            // 
            this.libraryInfo.BackColor = System.Drawing.Color.Transparent;
            this.libraryInfo.Controls.Add(this.panelTag);
            this.libraryInfo.Controls.Add(this.libtxtInfo);
            this.libraryInfo.Location = new System.Drawing.Point(300, 0);
            this.libraryInfo.Name = "libraryInfo";
            this.libraryInfo.Size = new System.Drawing.Size(980, 175);
            this.libraryInfo.TabIndex = 0;
            // 
            // panelTag
            // 
            this.panelTag.Controls.Add(this.tagYear);
            this.panelTag.Controls.Add(this.tagLenght);
            this.panelTag.Controls.Add(this.tagGenre);
            this.panelTag.Controls.Add(this.tagTitle);
            this.panelTag.Controls.Add(this.tagArtist);
            this.panelTag.Location = new System.Drawing.Point(0, 120);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(980, 50);
            this.panelTag.TabIndex = 1;
            // 
            // tagYear
            // 
            this.tagYear.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagYear.ForeColor = System.Drawing.Color.White;
            this.tagYear.Location = new System.Drawing.Point(600, 15);
            this.tagYear.Name = "tagYear";
            this.tagYear.Size = new System.Drawing.Size(50, 25);
            this.tagYear.TabIndex = 4;
            this.tagYear.Text = "Year";
            // 
            // tagLenght
            // 
            this.tagLenght.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLenght.ForeColor = System.Drawing.Color.White;
            this.tagLenght.Location = new System.Drawing.Point(840, 15);
            this.tagLenght.Name = "tagLenght";
            this.tagLenght.Size = new System.Drawing.Size(100, 25);
            this.tagLenght.TabIndex = 3;
            this.tagLenght.Text = "Lenght";
            // 
            // tagGenre
            // 
            this.tagGenre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagGenre.ForeColor = System.Drawing.Color.White;
            this.tagGenre.Location = new System.Drawing.Point(670, 15);
            this.tagGenre.Name = "tagGenre";
            this.tagGenre.Size = new System.Drawing.Size(150, 25);
            this.tagGenre.TabIndex = 2;
            this.tagGenre.Text = "Genre";
            // 
            // tagTitle
            // 
            this.tagTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagTitle.ForeColor = System.Drawing.Color.White;
            this.tagTitle.Location = new System.Drawing.Point(10, 15);
            this.tagTitle.Margin = new System.Windows.Forms.Padding(10);
            this.tagTitle.Name = "tagTitle";
            this.tagTitle.Size = new System.Drawing.Size(300, 25);
            this.tagTitle.TabIndex = 1;
            this.tagTitle.Text = "Title";
            // 
            // tagArtist
            // 
            this.tagArtist.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagArtist.ForeColor = System.Drawing.Color.White;
            this.tagArtist.Location = new System.Drawing.Point(330, 15);
            this.tagArtist.Margin = new System.Windows.Forms.Padding(10);
            this.tagArtist.Name = "tagArtist";
            this.tagArtist.Size = new System.Drawing.Size(250, 25);
            this.tagArtist.TabIndex = 0;
            this.tagArtist.Text = "Artist";
            // 
            // libtxtInfo
            // 
            this.libtxtInfo.AutoSize = true;
            this.libtxtInfo.BackColor = System.Drawing.Color.Transparent;
            this.libtxtInfo.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libtxtInfo.ForeColor = System.Drawing.Color.White;
            this.libtxtInfo.Location = new System.Drawing.Point(13, 15);
            this.libtxtInfo.Name = "libtxtInfo";
            this.libtxtInfo.Size = new System.Drawing.Size(167, 47);
            this.libtxtInfo.TabIndex = 0;
            this.libtxtInfo.Text = "My music";
            // 
            // libraryPanel
            // 
            this.libraryPanel.AutoScroll = true;
            this.libraryPanel.Controls.Add(this.labelLoading);
            this.libraryPanel.Location = new System.Drawing.Point(300, 176);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(980, 420);
            this.libraryPanel.TabIndex = 3;
            // 
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(400, 175);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(400, 175, 150, 150);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(196, 40);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Loading tracks";
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.libraryInfo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.libraryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Music";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DA Player";
            this.player.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.libraryInfo.ResumeLayout(false);
            this.libraryInfo.PerformLayout();
            this.panelTag.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Button buttonPlayerPlay;
        private System.Windows.Forms.Button buttonPlayerPrev;
        private System.Windows.Forms.Button buttonPlayerNext;
        private System.Windows.Forms.Button buttonRecent;
        private System.Windows.Forms.Button buttonPlaylist;
        private System.Windows.Forms.Button buttonLibrary;
        private System.Windows.Forms.Panel libraryInfo;
        private System.Windows.Forms.Label libtxtInfo;
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Label tagArtist;
        private System.Windows.Forms.Label tagTitle;
        private System.Windows.Forms.Label tagLenght;
        private System.Windows.Forms.Label tagGenre;
        private System.Windows.Forms.Label tagYear;
        private System.Windows.Forms.FlowLayoutPanel libraryPanel;
        private System.Windows.Forms.Label labelLoading;
    }
}

