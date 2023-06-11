namespace order_management
{
    partial class Form1
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
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label pwdLabel1;
            System.Windows.Forms.Label role_idLabel1;
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.role_CheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            nomLabel1 = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            pwdLabel1 = new System.Windows.Forms.Label();
            role_idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(29, 53);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(36, 16);
            nomLabel1.TabIndex = 22;
            nomLabel1.Text = "nom:";
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(29, 81);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(43, 16);
            emailLabel1.TabIndex = 24;
            emailLabel1.Text = "email:";
            // 
            // pwdLabel1
            // 
            pwdLabel1.AutoSize = true;
            pwdLabel1.Location = new System.Drawing.Point(29, 109);
            pwdLabel1.Name = "pwdLabel1";
            pwdLabel1.Size = new System.Drawing.Size(35, 16);
            pwdLabel1.TabIndex = 26;
            pwdLabel1.Text = "pwd:";
            // 
            // role_idLabel1
            // 
            role_idLabel1.AutoSize = true;
            role_idLabel1.Location = new System.Drawing.Point(29, 139);
            role_idLabel1.Name = "role_idLabel1";
            role_idLabel1.Size = new System.Drawing.Size(47, 16);
            role_idLabel1.TabIndex = 28;
            role_idLabel1.Text = "role id:";
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(82, 50);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(196, 22);
            this.nomTxt.TabIndex = 23;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(82, 78);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(196, 22);
            this.emailTxt.TabIndex = 25;
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(82, 106);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.Size = new System.Drawing.Size(196, 22);
            this.pwdTxt.TabIndex = 27;
            // 
            // role_CheckBox
            // 
            this.role_CheckBox.Location = new System.Drawing.Point(82, 134);
            this.role_CheckBox.Name = "role_CheckBox";
            this.role_CheckBox.Size = new System.Drawing.Size(104, 24);
            this.role_CheckBox.TabIndex = 29;
            this.role_CheckBox.Text = "admin ?";
            this.role_CheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(466, 39);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 24;
            this.userDataGridView.Size = new System.Drawing.Size(300, 220);
            this.userDataGridView.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(nomLabel1);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(emailLabel1);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(pwdLabel1);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(role_idLabel1);
            this.Controls.Add(this.role_CheckBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.CheckBox role_CheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView userDataGridView;
    }
}

