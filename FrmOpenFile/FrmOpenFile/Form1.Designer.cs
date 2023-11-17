namespace FrmOpenFile
{
    partial class FrmOpenTextFile
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxShowText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(376, 442);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOpen.Size = new System.Drawing.Size(104, 39);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxShowText
            // 
            this.listBoxShowText.FormattingEnabled = true;
            this.listBoxShowText.Location = new System.Drawing.Point(50, 33);
            this.listBoxShowText.Name = "listBoxShowText";
            this.listBoxShowText.Size = new System.Drawing.Size(761, 394);
            this.listBoxShowText.TabIndex = 1;
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(859, 505);
            this.Controls.Add(this.listBoxShowText);
            this.Controls.Add(this.btnOpen);
            this.Name = "FrmOpenTextFile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxShowText;
    }
}

