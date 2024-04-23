namespace LoginForm
{
    partial class Register
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            Password = new TextBox();
            UserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            FullName = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(71, 33);
            label1.Name = "label1";
            label1.Size = new Size(372, 48);
            label1.TabIndex = 0;
            label1.Text = "Ro'yxatdan o'tish";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(158, 383);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(180, 25);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Akkauntingiz bormi ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(97, 302);
            button1.Name = "button1";
            button1.Size = new Size(305, 58);
            button1.TabIndex = 19;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(163, 233);
            Password.Name = "Password";
            Password.Size = new Size(321, 31);
            Password.TabIndex = 18;
            // 
            // UserName
            // 
            UserName.Location = new Point(163, 179);
            UserName.Name = "UserName";
            UserName.Size = new Size(321, 31);
            UserName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 233);
            label3.Name = "label3";
            label3.Size = new Size(114, 29);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // FullName
            // 
            FullName.AccessibleDescription = "";
            FullName.AccessibleName = "";
            FullName.Location = new Point(163, 131);
            FullName.Name = "FullName";
            FullName.Size = new Size(321, 31);
            FullName.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 130);
            label4.Name = "label4";
            label4.Size = new Size(119, 29);
            label4.TabIndex = 21;
            label4.Text = "Full Name";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 446);
            Controls.Add(FullName);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox Password;
        private TextBox UserName;
        private Label label3;
        private Label label2;
        private TextBox FullName;
        private Label label4;
    }
}