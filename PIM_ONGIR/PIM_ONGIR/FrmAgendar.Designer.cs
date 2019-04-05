namespace PIM_ONGIR
{
    partial class FrmAgendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskRG = new System.Windows.Forms.MaskedTextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHora = new System.Windows.Forms.DateTimePicker();
            this.dateData = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.btnLocalVeicu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.lblFoto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mskCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.mskRG);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.pictureFoto);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolhendo o associado";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFoto.Location = new System.Drawing.Point(235, 158);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(39, 18);
            this.lblFoto.TabIndex = 39;
            this.lblFoto.Text = "Foto";
            this.lblFoto.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImage = global::PIM_ONGIR.Properties.Resources.user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(159, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 38;
            this.toolTip1.SetToolTip(this.button1, "Selecionar Associado");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Enabled = false;
            this.mskCPF.Location = new System.Drawing.Point(34, 109);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 21);
            this.mskCPF.TabIndex = 32;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.lblCPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCPF.Location = new System.Drawing.Point(31, 90);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(32, 16);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF";
            // 
            // mskRG
            // 
            this.mskRG.Enabled = false;
            this.mskRG.Location = new System.Drawing.Point(34, 158);
            this.mskRG.Mask = "00.000.000-0";
            this.mskRG.Name = "mskRG";
            this.mskRG.Size = new System.Drawing.Size(88, 21);
            this.mskRG.TabIndex = 30;
            this.mskRG.TextChanged += new System.EventHandler(this.mskRG_TextChanged);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.lblRG.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRG.Location = new System.Drawing.Point(31, 139);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(27, 16);
            this.lblRG.TabIndex = 31;
            this.lblRG.Text = "RG";
            // 
            // pictureFoto
            // 
            this.pictureFoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureFoto.Image = global::PIM_ONGIR.Properties.Resources.user__1_;
            this.pictureFoto.Location = new System.Drawing.Point(238, 37);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(188, 104);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFoto.TabIndex = 27;
            this.pictureFoto.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(34, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome  Completo";
            // 
            // dateHora
            // 
            this.dateHora.AllowDrop = true;
            this.dateHora.Checked = false;
            this.dateHora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateHora.CustomFormat = "HH:00 tt";
            this.dateHora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHora.Location = new System.Drawing.Point(248, 70);
            this.dateHora.Name = "dateHora";
            this.dateHora.ShowUpDown = true;
            this.dateHora.Size = new System.Drawing.Size(103, 21);
            this.dateHora.TabIndex = 28;
            this.dateHora.Value = new System.DateTime(2017, 5, 21, 15, 0, 0, 0);
            // 
            // dateData
            // 
            this.dateData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateData.Location = new System.Drawing.Point(133, 70);
            this.dateData.Name = "dateData";
            this.dateData.Size = new System.Drawing.Size(109, 21);
            this.dateData.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gray;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbServico);
            this.groupBox2.Controls.Add(this.btnLocalVeicu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateData);
            this.groupBox2.Controls.Add(this.dateHora);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(28, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 120);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviço e Agendamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Serviço";
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Items.AddRange(new object[] {
            "Psicologia",
            "Assistente Social",
            "Assistente Jurídico"});
            this.cmbServico.Location = new System.Drawing.Point(133, 39);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(174, 23);
            this.cmbServico.TabIndex = 36;
            this.cmbServico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbServico.TextChanged += new System.EventHandler(this.cmbServico_TextChanged);
            // 
            // btnLocalVeicu
            // 
            this.btnLocalVeicu.BackColor = System.Drawing.Color.Gray;
            this.btnLocalVeicu.BackgroundImage = global::PIM_ONGIR.Properties.Resources.Magnifying_Glass_icon;
            this.btnLocalVeicu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalVeicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalVeicu.ForeColor = System.Drawing.Color.Gray;
            this.btnLocalVeicu.Location = new System.Drawing.Point(391, 67);
            this.btnLocalVeicu.Name = "btnLocalVeicu";
            this.btnLocalVeicu.Size = new System.Drawing.Size(34, 30);
            this.btnLocalVeicu.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnLocalVeicu, "Consultar Agenda");
            this.btnLocalVeicu.UseVisualStyleBackColor = false;
            this.btnLocalVeicu.Click += new System.EventHandler(this.btnLocalVeicu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.5F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Data e Hora";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(28, 407);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(134, 18);
            this.lblInfo.TabIndex = 38;
            this.lblInfo.Text = "Informativo usuário";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::PIM_ONGIR.Properties.Resources.exit_icon_3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(419, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 51);
            this.btnSair.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::PIM_ONGIR.Properties.Resources.disksave_4a90b428_e98a_4189_82cc_fd6163c92f1a;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(291, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 51);
            this.btnSalvar.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAgendar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(528, 473);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHora;
        private System.Windows.Forms.DateTimePicker dateData;
        private System.Windows.Forms.Button btnLocalVeicu;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}