namespace WindowsFormsControlLibrary2
{
    partial class HistoryControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbMedical = new System.Windows.Forms.ListBox();
            this.radListControl1 = new Telerik.WinControls.UI.RadListControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbMedical, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radListControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbMedical
            // 
            this.lbMedical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMedical.FormattingEnabled = true;
            this.lbMedical.Location = new System.Drawing.Point(3, 3);
            this.lbMedical.Name = "lbMedical";
            this.lbMedical.Size = new System.Drawing.Size(252, 113);
            this.lbMedical.TabIndex = 0;
            // 
            // radListControl1
            // 
            this.radListControl1.AutoSizeItems = true;
            this.radListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListControl1.Location = new System.Drawing.Point(3, 122);
            this.radListControl1.Name = "radListControl1";
            this.radListControl1.Size = new System.Drawing.Size(252, 372);
            this.radListControl1.TabIndex = 1;
            this.radListControl1.Text = "radListControl1";
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(258, 497);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radListControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbMedical;
        private Telerik.WinControls.UI.RadListControl radListControl1;

    }
}
