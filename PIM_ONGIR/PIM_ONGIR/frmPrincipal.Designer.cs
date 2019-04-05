namespace PIM_ONGIR
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.novoLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool1 = new System.Windows.Forms.ToolStripLabel();
            this.toolUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripCadastrarAssociados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConsultarAssociados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAgendamento = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripAgendar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConsultarAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPerfil = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tool1,
            this.toolUsuario,
            this.toolStripSeparator2,
            this.toolPerfil});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(887, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoLoginToolStripMenuItem,
            this.encerrarToolStripMenuItem});
            this.toolStripButton2.Image = global::PIM_ONGIR.Properties.Resources.black_key_symbol_icon_6;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton2.Text = "Login";
            // 
            // novoLoginToolStripMenuItem
            // 
            this.novoLoginToolStripMenuItem.Name = "novoLoginToolStripMenuItem";
            this.novoLoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novoLoginToolStripMenuItem.Text = "Novo Login";
            this.novoLoginToolStripMenuItem.Click += new System.EventHandler(this.novoLoginToolStripMenuItem_Click);
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            this.encerrarToolStripMenuItem.Click += new System.EventHandler(this.encerrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tool1
            // 
            this.tool1.Name = "tool1";
            this.tool1.Size = new System.Drawing.Size(50, 22);
            this.tool1.Text = "Usuário:";
            // 
            // toolUsuario
            // 
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(47, 22);
            this.toolUsuario.Text = "Usuário";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.toolAgendamento});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(81, 403);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastrarAssociados,
            this.toolStripMenuConsultarAssociados});
            this.toolStripSplitButton1.Image = global::PIM_ONGIR.Properties.Resources.add_user__3_;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(78, 68);
            this.toolStripSplitButton1.ToolTipText = "Gerenciamento de associados";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick_1);
            // 
            // toolStripCadastrarAssociados
            // 
            this.toolStripCadastrarAssociados.BackColor = System.Drawing.Color.Transparent;
            this.toolStripCadastrarAssociados.Image = global::PIM_ONGIR.Properties.Resources.user__1_;
            this.toolStripCadastrarAssociados.Name = "toolStripCadastrarAssociados";
            this.toolStripCadastrarAssociados.Size = new System.Drawing.Size(187, 22);
            this.toolStripCadastrarAssociados.Text = "Cadastrar Associados";
            this.toolStripCadastrarAssociados.Click += new System.EventHandler(this.toolStripCadastrarClientes_Click);
            // 
            // toolStripMenuConsultarAssociados
            // 
            this.toolStripMenuConsultarAssociados.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuConsultarAssociados.Image = global::PIM_ONGIR.Properties.Resources.user;
            this.toolStripMenuConsultarAssociados.Name = "toolStripMenuConsultarAssociados";
            this.toolStripMenuConsultarAssociados.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuConsultarAssociados.Text = "Consultar Associados";
            this.toolStripMenuConsultarAssociados.Click += new System.EventHandler(this.toolStripMenuConsultarAssociados_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(78, 6);
            // 
            // toolAgendamento
            // 
            this.toolAgendamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAgendamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgendar,
            this.toolConsultarAgendamentos});
            this.toolAgendamento.Image = global::PIM_ONGIR.Properties.Resources.calendar;
            this.toolAgendamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAgendamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAgendamento.Name = "toolAgendamento";
            this.toolAgendamento.Size = new System.Drawing.Size(78, 68);
            this.toolAgendamento.Text = "toolStripSplitButton2";
            this.toolAgendamento.ToolTipText = "Agendamentos";
            this.toolAgendamento.ButtonClick += new System.EventHandler(this.toolAgendamento_ButtonClick);
            // 
            // toolStripAgendar
            // 
            this.toolStripAgendar.Image = global::PIM_ONGIR.Properties.Resources.calendar;
            this.toolStripAgendar.Name = "toolStripAgendar";
            this.toolStripAgendar.Size = new System.Drawing.Size(209, 22);
            this.toolStripAgendar.Text = "Agendar";
            this.toolStripAgendar.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolConsultarAgendamentos
            // 
            this.toolConsultarAgendamentos.Image = global::PIM_ONGIR.Properties.Resources.calendar_;
            this.toolConsultarAgendamentos.Name = "toolConsultarAgendamentos";
            this.toolConsultarAgendamentos.Size = new System.Drawing.Size(209, 22);
            this.toolConsultarAgendamentos.Text = "Consultar Agendamentos";
            this.toolConsultarAgendamentos.Click += new System.EventHandler(this.toolConsultarAgendamentos_Click);
            // 
            // toolPerfil
            // 
            this.toolPerfil.Name = "toolPerfil";
            this.toolPerfil.Size = new System.Drawing.Size(42, 22);
            this.toolPerfil.Text = "PERFIL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PIM_ONGIR.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(887, 428);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema do Gerenciamento do CPIR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem novoLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tool1;
        private System.Windows.Forms.ToolStripLabel toolUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripCadastrarAssociados;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConsultarAssociados;
        private System.Windows.Forms.ToolStripSplitButton toolAgendamento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripAgendar;
        private System.Windows.Forms.ToolStripMenuItem toolConsultarAgendamentos;
        private System.Windows.Forms.ToolStripLabel toolPerfil;
    }
}