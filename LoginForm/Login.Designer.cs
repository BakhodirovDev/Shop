namespace LoginForm
{
    partial class Login
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
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            Password = new TextBox();
            UserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(109, 37);
            label4.Name = "label4";
            label4.Size = new Size(301, 48);
            label4.TabIndex = 15;
            label4.Text = "Tizimga kirish";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(155, 341);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(187, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Akkauntingiz yo'qmi ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(94, 260);
            button1.Name = "button1";
            button1.Size = new Size(305, 58);
            button1.TabIndex = 13;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(160, 191);
            Password.Name = "Password";
            Password.Size = new Size(321, 31);
            Password.TabIndex = 12;
            // 
            // UserName
            // 
            UserName.Location = new Point(160, 137);
            UserName.Name = "UserName";
            UserName.Size = new Size(321, 31);
            UserName.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 191);
            label3.Name = "label3";
            label3.Size = new Size(114, 29);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 136);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 395);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox Password;
        private TextBox UserName;
        private Label label3;
        private Label label2;
    }
}