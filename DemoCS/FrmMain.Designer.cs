namespace DemoCS
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnDemo3 = new System.Windows.Forms.Button();
            this.BtnDemo2 = new System.Windows.Forms.Button();
            this.BtnDemo1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(93, 153);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(111, 13);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "\'Complex\' tree-node";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(93, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(129, 13);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "\'Standard\' 1 level depth";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(93, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(145, 13);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "Only root nodes. No childs";
            // 
            // BtnDemo3
            // 
            this.BtnDemo3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDemo3.Location = new System.Drawing.Point(12, 142);
            this.BtnDemo3.Name = "BtnDemo3";
            this.BtnDemo3.Size = new System.Drawing.Size(75, 35);
            this.BtnDemo3.TabIndex = 53;
            this.BtnDemo3.Text = "Demo #3";
            this.BtnDemo3.UseVisualStyleBackColor = true;
            this.BtnDemo3.Click += new System.EventHandler(this.BtnDemo3_Click);
            // 
            // BtnDemo2
            // 
            this.BtnDemo2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDemo2.Location = new System.Drawing.Point(12, 101);
            this.BtnDemo2.Name = "BtnDemo2";
            this.BtnDemo2.Size = new System.Drawing.Size(75, 35);
            this.BtnDemo2.TabIndex = 52;
            this.BtnDemo2.Text = "Demo #2";
            this.BtnDemo2.UseVisualStyleBackColor = true;
            this.BtnDemo2.Click += new System.EventHandler(this.BtnDemo2_Click);
            // 
            // BtnDemo1
            // 
            this.BtnDemo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDemo1.Location = new System.Drawing.Point(12, 60);
            this.BtnDemo1.Name = "BtnDemo1";
            this.BtnDemo1.Size = new System.Drawing.Size(75, 35);
            this.BtnDemo1.TabIndex = 51;
            this.BtnDemo1.Text = "Demo #1";
            this.BtnDemo1.UseVisualStyleBackColor = true;
            this.BtnDemo1.Click += new System.EventHandler(this.BtnDemo1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnDemo3);
            this.Controls.Add(this.BtnDemo2);
            this.Controls.Add(this.BtnDemo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zilog80 NavigationControl Demo C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnDemo3;
        internal System.Windows.Forms.Button BtnDemo2;
        internal System.Windows.Forms.Button BtnDemo1;
    }
}

