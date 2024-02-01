namespace Fibonacci.Forms
{
    partial class RegisterForm
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
            this.reguster = new System.Windows.Forms.Button();
            this.regPassTextBox = new System.Windows.Forms.TextBox();
            this.registerPassLabel = new System.Windows.Forms.Label();
            this.regLoginTextBox = new System.Windows.Forms.TextBox();
            this.registerLoginLabel = new System.Windows.Forms.Label();
            this.regConfPassTextBox = new System.Windows.Forms.TextBox();
            this.regConfPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reguster
            // 
            this.reguster.Location = new System.Drawing.Point(128, 194);
            this.reguster.Margin = new System.Windows.Forms.Padding(4);
            this.reguster.Name = "reguster";
            this.reguster.Size = new System.Drawing.Size(176, 32);
            this.reguster.TabIndex = 11;
            this.reguster.Text = "Регистрация";
            this.reguster.UseVisualStyleBackColor = true;
            this.reguster.Click += new System.EventHandler(this.reguster_Click);
            // 
            // regPassTextBox
            // 
            this.regPassTextBox.Location = new System.Drawing.Point(31, 99);
            this.regPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regPassTextBox.Name = "regPassTextBox";
            this.regPassTextBox.PasswordChar = '*';
            this.regPassTextBox.Size = new System.Drawing.Size(360, 22);
            this.regPassTextBox.TabIndex = 10;
            // 
            // registerPassLabel
            // 
            this.registerPassLabel.AutoSize = true;
            this.registerPassLabel.Location = new System.Drawing.Point(27, 77);
            this.registerPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerPassLabel.Name = "registerPassLabel";
            this.registerPassLabel.Size = new System.Drawing.Size(56, 16);
            this.registerPassLabel.TabIndex = 9;
            this.registerPassLabel.Text = "Пароль";
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.Location = new System.Drawing.Point(31, 45);
            this.regLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(360, 22);
            this.regLoginTextBox.TabIndex = 8;
            // 
            // registerLoginLabel
            // 
            this.registerLoginLabel.AutoSize = true;
            this.registerLoginLabel.Location = new System.Drawing.Point(27, 23);
            this.registerLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLoginLabel.Name = "registerLoginLabel";
            this.registerLoginLabel.Size = new System.Drawing.Size(46, 16);
            this.registerLoginLabel.TabIndex = 7;
            this.registerLoginLabel.Text = "Логин";
            // 
            // regConfPassTextBox
            // 
            this.regConfPassTextBox.Location = new System.Drawing.Point(31, 153);
            this.regConfPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.regConfPassTextBox.Name = "regConfPassTextBox";
            this.regConfPassTextBox.PasswordChar = '*';
            this.regConfPassTextBox.Size = new System.Drawing.Size(360, 22);
            this.regConfPassTextBox.TabIndex = 12;
            // 
            // regConfPassLabel
            // 
            this.regConfPassLabel.AutoSize = true;
            this.regConfPassLabel.Location = new System.Drawing.Point(28, 133);
            this.regConfPassLabel.Name = "regConfPassLabel";
            this.regConfPassLabel.Size = new System.Drawing.Size(145, 16);
            this.regConfPassLabel.TabIndex = 13;
            this.regConfPassLabel.Text = "Подтвердите пароль";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(422, 252);
            this.Controls.Add(this.regConfPassLabel);
            this.Controls.Add(this.regConfPassTextBox);
            this.Controls.Add(this.reguster);
            this.Controls.Add(this.regPassTextBox);
            this.Controls.Add(this.registerPassLabel);
            this.Controls.Add(this.regLoginTextBox);
            this.Controls.Add(this.registerLoginLabel);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reguster;
        private System.Windows.Forms.TextBox regPassTextBox;
        private System.Windows.Forms.Label registerPassLabel;
        private System.Windows.Forms.TextBox regLoginTextBox;
        private System.Windows.Forms.Label registerLoginLabel;
        private System.Windows.Forms.TextBox regConfPassTextBox;
        private System.Windows.Forms.Label regConfPassLabel;
    }
}