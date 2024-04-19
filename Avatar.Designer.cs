namespace active_way
{
    partial class Avatar
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

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAvatars;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBoxSelectedAvatar;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avatar));
            this.flowLayoutPanelAvatars = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxSelectedAvatar = new System.Windows.Forms.PictureBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelAvatars
            // 
            this.flowLayoutPanelAvatars.AutoScroll = true;
            this.flowLayoutPanelAvatars.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanelAvatars.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAvatars.Location = new System.Drawing.Point(307, 1);
            this.flowLayoutPanelAvatars.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelAvatars.Name = "flowLayoutPanelAvatars";
            this.flowLayoutPanelAvatars.Size = new System.Drawing.Size(271, 554);
            this.flowLayoutPanelAvatars.TabIndex = 0;
            this.flowLayoutPanelAvatars.WrapContents = false;
            // 
            // pictureBoxSelectedAvatar
            // 
            this.pictureBoxSelectedAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSelectedAvatar.BackgroundImage")));
            this.pictureBoxSelectedAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelectedAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSelectedAvatar.Location = new System.Drawing.Point(45, 44);
            this.pictureBoxSelectedAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSelectedAvatar.Name = "pictureBoxSelectedAvatar";
            this.pictureBoxSelectedAvatar.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxSelectedAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSelectedAvatar.TabIndex = 1;
            this.pictureBoxSelectedAvatar.TabStop = false;
            this.pictureBoxSelectedAvatar.Click += new System.EventHandler(this.pictureBoxSelectedAvatar_Click);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.LightGray;
            this.buttonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUploadImage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUploadImage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUploadImage.Location = new System.Drawing.Point(45, 292);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(200, 53);
            this.buttonUploadImage.TabIndex = 2;
            this.buttonUploadImage.Text = "Сохранить";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pictureBoxSelectedAvatar);
            this.panel1.Controls.Add(this.buttonUploadImage);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 559);
            this.panel1.TabIndex = 3;
            // 
            // Avatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(532, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelAvatars);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Avatar";
            this.Text = "Avatar";
            this.Load += new System.EventHandler(this.Avatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
    }
}