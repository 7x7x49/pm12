namespace active_way
{
    partial class CountMeaningCalories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountMeaningCalories));
            this.imageAction = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winCaloriesBDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userdbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userdbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCaloriesBDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageAction
            // 
            this.imageAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.imageAction.ErrorImage = null;
            this.imageAction.Image = ((System.Drawing.Image)(resources.GetObject("imageAction.Image")));
            this.imageAction.InitialImage = null;
            this.imageAction.Location = new System.Drawing.Point(33, 33);
            this.imageAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageAction.Name = "imageAction";
            this.imageAction.Size = new System.Drawing.Size(667, 304);
            this.imageAction.TabIndex = 15;
            this.imageAction.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonSave.Location = new System.Drawing.Point(207, 663);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(292, 78);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.comboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(125, 372);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(447, 34);
            this.comboBox.TabIndex = 20;
            this.comboBox.Text = "Что будем искать?";
            this.comboBox.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Location = new System.Drawing.Point(207, 428);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 39);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "время в минутах";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(283, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "калорий";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(280, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winCaloriesBDDataSet
            //
            // 
            // winCaloriesBDDataSetBindingSource
            // 
            this.winCaloriesBDDataSetBindingSource.Position = 0;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.winCaloriesBDDataSetBindingSource;
            // 
            // foodTableAdapter
            // 
            // 
            // userdbBindingSource
            // 
            this.userdbBindingSource.DataMember = "User_db";
            this.userdbBindingSource.DataSource = this.winCaloriesBDDataSetBindingSource;
            // 
            // user_dbTableAdapter
            // 
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this.winCaloriesBDDataSetBindingSource;
            // 
            // userDataTableAdapter
            // 
            // 
            // userdbBindingSource1
            // 
            this.userdbBindingSource1.DataMember = "User_db";
            this.userdbBindingSource1.DataSource = this.winCaloriesBDDataSetBindingSource;
            // 
            // userdbBindingSource2
            // 
            this.userdbBindingSource2.DataMember = "User_db";
            this.userdbBindingSource2.DataSource = this.winCaloriesBDDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(264, 604);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountMeaningCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(78)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(715, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.imageAction);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CountMeaningCalories";
            this.Text = "CountMeaningCalories";
            this.Load += new System.EventHandler(this.CountMeaningCalories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winCaloriesBDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageAction;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource winCaloriesBDDataSetBindingSource;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private System.Windows.Forms.BindingSource userdbBindingSource;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private System.Windows.Forms.BindingSource userdbBindingSource1;
        private System.Windows.Forms.BindingSource userdbBindingSource2;
        private System.Windows.Forms.Button button1;
    }
}