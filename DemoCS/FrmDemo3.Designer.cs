namespace DemoCS
{
    partial class FrmDemo3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.z80_Navigation1 = new DemoCS.Z80_NavBar.Z80_Navigation();
            this.BtnSwitchTheme = new System.Windows.Forms.Button();
            this.BtnUnselect = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.z80_Navigation1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BtnSwitchTheme);
            this.splitContainer1.Panel2.Controls.Add(this.BtnUnselect);
            this.splitContainer1.Panel2.Controls.Add(this.Label1);
            this.splitContainer1.Panel2.Controls.Add(this.LblInfo);
            this.splitContainer1.Size = new System.Drawing.Size(784, 561);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // z80_Navigation1
            // 
            this.z80_Navigation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.z80_Navigation1.Location = new System.Drawing.Point(0, 0);
            this.z80_Navigation1.Name = "z80_Navigation1";
            this.z80_Navigation1.Size = new System.Drawing.Size(160, 561);
            this.z80_Navigation1.TabIndex = 0;
            // 
            // BtnSwitchTheme
            // 
            this.BtnSwitchTheme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwitchTheme.Location = new System.Drawing.Point(107, 119);
            this.BtnSwitchTheme.Name = "BtnSwitchTheme";
            this.BtnSwitchTheme.Size = new System.Drawing.Size(75, 35);
            this.BtnSwitchTheme.TabIndex = 43;
            this.BtnSwitchTheme.Text = "Switch theme";
            this.BtnSwitchTheme.UseVisualStyleBackColor = true;
            this.BtnSwitchTheme.Click += new System.EventHandler(this.BtnSwitchTheme_Click);
            // 
            // BtnUnselect
            // 
            this.BtnUnselect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnselect.Location = new System.Drawing.Point(18, 119);
            this.BtnUnselect.Name = "BtnUnselect";
            this.BtnUnselect.Size = new System.Drawing.Size(75, 35);
            this.BtnUnselect.TabIndex = 42;
            this.BtnUnselect.Text = "Unselect all";
            this.BtnUnselect.UseVisualStyleBackColor = true;
            this.BtnUnselect.Click += new System.EventHandler(this.BtnUnselect_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 25);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Demo #3";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(13, 61);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(146, 25);
            this.LblInfo.TabIndex = 40;
            this.LblInfo.Text = "Content Sample";
            // 
            // FrmDemo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDemo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zilog80 NavigationControl Demo C#";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Z80_NavBar.Z80_Navigation z80_Navigation1;
        internal System.Windows.Forms.Button BtnSwitchTheme;
        internal System.Windows.Forms.Button BtnUnselect;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblInfo;
    }
}