namespace PIM_ONGIR
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLogin
            // 
            this.cmbLogin.BackColor = System.Drawing.Color.White;
            this.cmbLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(25, 34);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(260, 24);
            this.cmbLogin.TabIndex = 24;
            this.cmbLogin.Text = "Digite o seu Login";
            this.cmbLogin.SelectedIndexChanged += new System.EventHandler(this.cmbLogin_SelectedIndexChanged);
            this.cmbLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbLogin_MouseClick);
            this.cmbLogin.MouseLeave += new System.EventHandler(this.cmbLogin_MouseLeave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSenha.Location = new System.Drawing.Point(25, 85);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(175, 22);
            this.txtSenha.TabIndex = 25;
            this.txtSenha.Text = "Digite a sua Senha";
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_click);
            this.txtSenha.MouseLeave += new System.EventHandler(this.txtSenha_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.BackgroundImage = global::PIM_ONGIR.Properties.Resources.kuba_arrow_button_set_2;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Lavender;
            this.btnLogin.Location = new System.Drawing.Point(246, 82);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(39, 29);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(319, 135);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbLogin);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ao CPIR";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;

    }
}

