namespace examleSqlAdd
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LiginField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clousButtonClick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::examleSqlAdd.Properties.Resources.black_sea_obl;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PassField);
            this.panel1.Controls.Add(this.LiginField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.clousButtonClick);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 397);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(144, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassField.Location = new System.Drawing.Point(100, 212);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(279, 38);
            this.PassField.TabIndex = 5;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LiginField
            // 
            this.LiginField.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiginField.Location = new System.Drawing.Point(100, 144);
            this.LiginField.Multiline = true;
            this.LiginField.Name = "LiginField";
            this.LiginField.Size = new System.Drawing.Size(279, 46);
            this.LiginField.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::examleSqlAdd.Properties.Resources.iconfinder_lock_285646__1_;
            this.pictureBox2.Location = new System.Drawing.Point(39, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 47);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::examleSqlAdd.Properties.Resources.iconfinder_user_285655;
            this.pictureBox1.Location = new System.Drawing.Point(39, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 46);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clousButtonClick
            // 
            this.clousButtonClick.AutoSize = true;
            this.clousButtonClick.BackColor = System.Drawing.Color.Red;
            this.clousButtonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clousButtonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clousButtonClick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clousButtonClick.Location = new System.Drawing.Point(392, 0);
            this.clousButtonClick.Name = "clousButtonClick";
            this.clousButtonClick.Size = new System.Drawing.Size(35, 39);
            this.clousButtonClick.TabIndex = 1;
            this.clousButtonClick.Text = "x";
            this.clousButtonClick.Click += new System.EventHandler(this.clousButtonClick_Click);
            this.clousButtonClick.MouseLeave += new System.EventHandler(this.clousButtonClick_MouseLeave);
            this.clousButtonClick.MouseHover += new System.EventHandler(this.clousButtonClick_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clousButtonClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LiginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button button1;
    }
}