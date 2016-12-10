namespace DemoCS
{
    partial class FrmDemo2
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
            this.BtnSelect1004 = new System.Windows.Forms.Button();
            this.BtnSwitchTheme = new System.Windows.Forms.Button();
            this.ChkBoxHide2 = new System.Windows.Forms.CheckBox();
            this.ChkBoxDisable1 = new System.Windows.Forms.CheckBox();
            this.ChkBoxHideStore = new System.Windows.Forms.CheckBox();
            this.ChkBoxDisableStore = new System.Windows.Forms.CheckBox();
            this.BtnAdd = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.BtnSelect1004);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSwitchTheme);
            this.splitContainer1.Panel2.Controls.Add(this.ChkBoxHide2);
            this.splitContainer1.Panel2.Controls.Add(this.ChkBoxDisable1);
            this.splitContainer1.Panel2.Controls.Add(this.ChkBoxHideStore);
            this.splitContainer1.Panel2.Controls.Add(this.ChkBoxDisableStore);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAdd);
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
            // BtnSelect1004
            // 
            this.BtnSelect1004.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect1004.Location = new System.Drawing.Point(99, 310);
            this.BtnSelect1004.Name = "BtnSelect1004";
            this.BtnSelect1004.Size = new System.Drawing.Size(181, 35);
            this.BtnSelect1004.TabIndex = 48;
            this.BtnSelect1004.Text = "Select Desktop >> My blogs";
            this.BtnSelect1004.UseVisualStyleBackColor = true;
            this.BtnSelect1004.Click += new System.EventHandler(this.BtnSelect1004_Click);
            // 
            // BtnSwitchTheme
            // 
            this.BtnSwitchTheme.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwitchTheme.Location = new System.Drawing.Point(286, 310);
            this.BtnSwitchTheme.Name = "BtnSwitchTheme";
            this.BtnSwitchTheme.Size = new System.Drawing.Size(75, 35);
            this.BtnSwitchTheme.TabIndex = 47;
            this.BtnSwitchTheme.Text = "Switch theme";
            this.BtnSwitchTheme.UseVisualStyleBackColor = true;
            this.BtnSwitchTheme.Click += new System.EventHandler(this.BtnSwitchTheme_Click);
            // 
            // ChkBoxHide2
            // 
            this.ChkBoxHide2.AutoSize = true;
            this.ChkBoxHide2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxHide2.Location = new System.Drawing.Point(18, 245);
            this.ChkBoxHide2.Name = "ChkBoxHide2";
            this.ChkBoxHide2.Size = new System.Drawing.Size(202, 21);
            this.ChkBoxHide2.TabIndex = 46;
            this.ChkBoxHide2.Text = "Hide Desktop >> NewItem #2";
            this.ChkBoxHide2.UseVisualStyleBackColor = true;
            this.ChkBoxHide2.CheckedChanged += new System.EventHandler(this.ChkBoxHide2_CheckedChanged);
            // 
            // ChkBoxDisable1
            // 
            this.ChkBoxDisable1.AutoSize = true;
            this.ChkBoxDisable1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxDisable1.Location = new System.Drawing.Point(18, 171);
            this.ChkBoxDisable1.Name = "ChkBoxDisable1";
            this.ChkBoxDisable1.Size = new System.Drawing.Size(218, 21);
            this.ChkBoxDisable1.TabIndex = 45;
            this.ChkBoxDisable1.Text = "Disable Desktop >> NewItem #1";
            this.ChkBoxDisable1.UseVisualStyleBackColor = true;
            this.ChkBoxDisable1.CheckedChanged += new System.EventHandler(this.ChkBoxDisable1_CheckedChanged);
            // 
            // ChkBoxHideStore
            // 
            this.ChkBoxHideStore.AutoSize = true;
            this.ChkBoxHideStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxHideStore.Location = new System.Drawing.Point(18, 272);
            this.ChkBoxHideStore.Name = "ChkBoxHideStore";
            this.ChkBoxHideStore.Size = new System.Drawing.Size(89, 21);
            this.ChkBoxHideStore.TabIndex = 44;
            this.ChkBoxHideStore.Text = "Hide Store";
            this.ChkBoxHideStore.UseVisualStyleBackColor = true;
            this.ChkBoxHideStore.CheckedChanged += new System.EventHandler(this.ChkBoxHideStore_CheckedChanged);
            // 
            // ChkBoxDisableStore
            // 
            this.ChkBoxDisableStore.AutoSize = true;
            this.ChkBoxDisableStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBoxDisableStore.Location = new System.Drawing.Point(18, 198);
            this.ChkBoxDisableStore.Name = "ChkBoxDisableStore";
            this.ChkBoxDisableStore.Size = new System.Drawing.Size(105, 21);
            this.ChkBoxDisableStore.TabIndex = 43;
            this.ChkBoxDisableStore.Text = "Disable Store";
            this.ChkBoxDisableStore.UseVisualStyleBackColor = true;
            this.ChkBoxDisableStore.CheckedChanged += new System.EventHandler(this.ChkBoxDisableStore_CheckedChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(18, 119);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(297, 35);
            this.BtnAdd.TabIndex = 42;
            this.BtnAdd.Text = "Add new Item: Desktop >> NewItem #1";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUnselect
            // 
            this.BtnUnselect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnselect.Location = new System.Drawing.Point(18, 310);
            this.BtnUnselect.Name = "BtnUnselect";
            this.BtnUnselect.Size = new System.Drawing.Size(75, 35);
            this.BtnUnselect.TabIndex = 41;
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
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Demo #2";
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.Location = new System.Drawing.Point(13, 61);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(146, 25);
            this.LblInfo.TabIndex = 39;
            this.LblInfo.Text = "Content Sample";
            // 
            // FrmDemo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDemo2";
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
        internal System.Windows.Forms.Button BtnSelect1004;
        internal System.Windows.Forms.Button BtnSwitchTheme;
        internal System.Windows.Forms.CheckBox ChkBoxHide2;
        internal System.Windows.Forms.CheckBox ChkBoxDisable1;
        internal System.Windows.Forms.CheckBox ChkBoxHideStore;
        internal System.Windows.Forms.CheckBox ChkBoxDisableStore;
        internal System.Windows.Forms.Button BtnAdd;
        internal System.Windows.Forms.Button BtnUnselect;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LblInfo;
    }
}