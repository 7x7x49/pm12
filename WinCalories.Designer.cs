
namespace active_way
{
    partial class WinCalories
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinCalories));
            this.buttonEating = new System.Windows.Forms.PictureBox();
            this.buttonSpenting = new System.Windows.Forms.PictureBox();
            this.labelEating = new System.Windows.Forms.Label();
            this.labelSpenting = new System.Windows.Forms.Label();
            this.labelNormalEating = new System.Windows.Forms.Label();
            this.labelActiveNormal = new System.Windows.Forms.Label();
            this.labelNormalDrinking = new System.Windows.Forms.Label();
            this.labelCurrentFood = new System.Windows.Forms.Label();
            this.labelCurrentSpenting = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBack = new System.Windows.Forms.PictureBox();
            this.labelNormalFood = new System.Windows.Forms.Label();
            this.picLine = new System.Windows.Forms.PictureBox();
            this.picCurrentFood = new System.Windows.Forms.PictureBox();
            this.picCurrentActive = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSpenting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEating
            // 
            this.buttonEating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.buttonEating.ErrorImage = null;
            this.buttonEating.Image = ((System.Drawing.Image)(resources.GetObject("buttonEating.Image")));
            this.buttonEating.InitialImage = null;
            this.buttonEating.Location = new System.Drawing.Point(383, 666);
            this.buttonEating.Name = "buttonEating";
            this.buttonEating.Size = new System.Drawing.Size(90, 90);
            this.buttonEating.TabIndex = 12;
            this.buttonEating.TabStop = false;
            this.buttonEating.Click += new System.EventHandler(this.buttonEating_Click);
            // 
            // buttonSpenting
            // 
            this.buttonSpenting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.buttonSpenting.ErrorImage = null;
            this.buttonSpenting.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpenting.Image")));
            this.buttonSpenting.InitialImage = null;
            this.buttonSpenting.Location = new System.Drawing.Point(247, 666);
            this.buttonSpenting.Name = "buttonSpenting";
            this.buttonSpenting.Size = new System.Drawing.Size(90, 90);
            this.buttonSpenting.TabIndex = 13;
            this.buttonSpenting.TabStop = false;
            this.buttonSpenting.Click += new System.EventHandler(this.buttonSpenting_Click);
            // 
            // labelEating
            // 
            this.labelEating.AutoSize = true;
            this.labelEating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelEating.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelEating.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.labelEating.Location = new System.Drawing.Point(253, 70);
            this.labelEating.Name = "labelEating";
            this.labelEating.Size = new System.Drawing.Size(127, 35);
            this.labelEating.TabIndex = 15;
            this.labelEating.Text = "Съедено";
            this.labelEating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSpenting
            // 
            this.labelSpenting.AutoSize = true;
            this.labelSpenting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelSpenting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelSpenting.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpenting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.labelSpenting.Location = new System.Drawing.Point(241, 166);
            this.labelSpenting.Name = "labelSpenting";
            this.labelSpenting.Size = new System.Drawing.Size(161, 35);
            this.labelSpenting.TabIndex = 16;
            this.labelSpenting.Text = "Потрачено";
            this.labelSpenting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNormalEating
            // 
            this.labelNormalEating.AutoSize = true;
            this.labelNormalEating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.labelNormalEating.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNormalEating.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormalEating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.labelNormalEating.Location = new System.Drawing.Point(224, 26);
            this.labelNormalEating.Name = "labelNormalEating";
            this.labelNormalEating.Size = new System.Drawing.Size(0, 57);
            this.labelNormalEating.TabIndex = 18;
            this.labelNormalEating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelActiveNormal
            // 
            this.labelActiveNormal.AutoSize = true;
            this.labelActiveNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelActiveNormal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelActiveNormal.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActiveNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(232)))), ((int)(((byte)(210)))));
            this.labelActiveNormal.Location = new System.Drawing.Point(29, 172);
            this.labelActiveNormal.Name = "labelActiveNormal";
            this.labelActiveNormal.Size = new System.Drawing.Size(68, 37);
            this.labelActiveNormal.TabIndex = 19;
            this.labelActiveNormal.Text = "940";
            this.labelActiveNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNormalDrinking
            // 
            this.labelNormalDrinking.AutoSize = true;
            this.labelNormalDrinking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.labelNormalDrinking.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNormalDrinking.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormalDrinking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.labelNormalDrinking.Location = new System.Drawing.Point(317, 164);
            this.labelNormalDrinking.Name = "labelNormalDrinking";
            this.labelNormalDrinking.Size = new System.Drawing.Size(0, 57);
            this.labelNormalDrinking.TabIndex = 20;
            this.labelNormalDrinking.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentFood
            // 
            this.labelCurrentFood.AutoSize = true;
            this.labelCurrentFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelCurrentFood.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCurrentFood.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.labelCurrentFood.Location = new System.Drawing.Point(501, 118);
            this.labelCurrentFood.Name = "labelCurrentFood";
            this.labelCurrentFood.Size = new System.Drawing.Size(34, 37);
            this.labelCurrentFood.TabIndex = 24;
            this.labelCurrentFood.Text = "0";
            this.labelCurrentFood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCurrentSpenting
            // 
            this.labelCurrentSpenting.AutoSize = true;
            this.labelCurrentSpenting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelCurrentSpenting.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCurrentSpenting.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentSpenting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(180)))));
            this.labelCurrentSpenting.Location = new System.Drawing.Point(501, 212);
            this.labelCurrentSpenting.Name = "labelCurrentSpenting";
            this.labelCurrentSpenting.Size = new System.Drawing.Size(34, 37);
            this.labelCurrentSpenting.TabIndex = 25;
            this.labelCurrentSpenting.Text = "0";
            this.labelCurrentSpenting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(174)))), ((int)(((byte)(131)))));
            this.buttonBack.ErrorImage = null;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.InitialImage = null;
            this.buttonBack.Location = new System.Drawing.Point(107, 666);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 90);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.TabStop = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelNormalFood
            // 
            this.labelNormalFood.AutoSize = true;
            this.labelNormalFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.labelNormalFood.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelNormalFood.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormalFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(249)))), ((int)(((byte)(227)))));
            this.labelNormalFood.Location = new System.Drawing.Point(30, 77);
            this.labelNormalFood.Name = "labelNormalFood";
            this.labelNormalFood.Size = new System.Drawing.Size(85, 37);
            this.labelNormalFood.TabIndex = 28;
            this.labelNormalFood.Text = "1894";
            this.labelNormalFood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLine
            // 
            this.picLine.Location = new System.Drawing.Point(31, 111);
            this.picLine.Name = "picLine";
            this.picLine.Size = new System.Drawing.Size(540, 3);
            this.picLine.TabIndex = 30;
            this.picLine.TabStop = false;
            // 
            // picCurrentFood
            // 
            this.picCurrentFood.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picCurrentFood.Location = new System.Drawing.Point(31, 112);
            this.picCurrentFood.Name = "picCurrentFood";
            this.picCurrentFood.Size = new System.Drawing.Size(540, 3);
            this.picCurrentFood.TabIndex = 31;
            this.picCurrentFood.TabStop = false;
            // 
            // picCurrentActive
            // 
            this.picCurrentActive.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.picCurrentActive.Location = new System.Drawing.Point(33, 208);
            this.picCurrentActive.Name = "picCurrentActive";
            this.picCurrentActive.Size = new System.Drawing.Size(540, 3);
            this.picCurrentActive.TabIndex = 33;
            this.picCurrentActive.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(33, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(540, 3);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // WinCalories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(600, 768);
            this.Controls.Add(this.picCurrentActive);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCurrentFood);
            this.Controls.Add(this.picLine);
            this.Controls.Add(this.labelNormalFood);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelCurrentSpenting);
            this.Controls.Add(this.labelCurrentFood);
            this.Controls.Add(this.labelNormalDrinking);
            this.Controls.Add(this.labelActiveNormal);
            this.Controls.Add(this.labelNormalEating);
            this.Controls.Add(this.labelSpenting);
            this.Controls.Add(this.labelEating);
            this.Controls.Add(this.buttonSpenting);
            this.Controls.Add(this.buttonEating);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinCalories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinCalories";
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSpenting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox buttonEating;
        private System.Windows.Forms.PictureBox buttonSpenting;
        private System.Windows.Forms.Label labelEating;
        private System.Windows.Forms.Label labelSpenting;
        private System.Windows.Forms.Label labelNormalEating;
        private System.Windows.Forms.Label labelActiveNormal;
        private System.Windows.Forms.Label labelNormalDrinking;
        private System.Windows.Forms.Label labelCurrentFood;
        private System.Windows.Forms.Label labelCurrentSpenting;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.Label labelNormalFood;
        private System.Windows.Forms.PictureBox picLine;
        private System.Windows.Forms.PictureBox picCurrentFood;
        private System.Windows.Forms.PictureBox picCurrentActive;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

