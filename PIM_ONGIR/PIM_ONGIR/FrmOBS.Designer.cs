namespace PIM_ONGIR
{
    partial class FrmOBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOBS));
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.docPrint = new System.Drawing.Printing.PrintDocument();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtOBS
            // 
            this.txtOBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOBS.Location = new System.Drawing.Point(0, 1);
            this.txtOBS.MaxLength = 400;
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.Size = new System.Drawing.Size(231, 165);
            this.txtOBS.TabIndex = 0;
            this.txtOBS.TextChanged += new System.EventHandler(this.txtOBS_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::PIM_ONGIR.Properties.Resources.disksave_4a90b428_e98a_4189_82cc_fd6163c92f1a;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(181, 130);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(38, 27);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dlgPrint
            // 
            this.dlgPrint.Document = this.docPrint;
            this.dlgPrint.UseEXDialog = true;
            // 
            // docPrint
            // 
            this.docPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.docPrint_PrintPage);
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPrintPreview.Document = this.docPrint;
            this.dlgPrintPreview.Enabled = true;
            this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
            this.dlgPrintPreview.Name = "dlgPrintPreview";
            this.dlgPrintPreview.Visible = false;
            // 
            // FrmOBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(231, 169);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtOBS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OBS";
            this.Load += new System.EventHandler(this.FrmOBS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Drawing.Printing.PrintDocument docPrint;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
    }
}