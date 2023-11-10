namespace Creating_texting_File
{
    partial class FrmFileName
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(30, 72);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(358, 45);
            this.txtFileName.TabIndex = 0;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.Red;
            this.btnOkay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOkay.FlatAppearance.BorderSize = 5;
            this.btnOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOkay.Location = new System.Drawing.Point(171, 165);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 41);
            this.btnOkay.TabIndex = 1;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(428, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.txtFileName);
            this.Name = "FrmFileName";
            this.Text = "FrmFileName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label label1;
    }
}