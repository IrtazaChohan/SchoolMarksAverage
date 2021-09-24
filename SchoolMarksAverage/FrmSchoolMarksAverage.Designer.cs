namespace SchoolMarksAverage
{
    partial class FrmSchoolMarksAverage
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
            this.LblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.txtTextbox1 = new System.Windows.Forms.TextBox();
            this.txtTextbox2 = new System.Windows.Forms.TextBox();
            this.txtTextbox3 = new System.Windows.Forms.TextBox();
            this.txtTextbox4 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMark1
            // 
            this.LblMark1.AutoSize = true;
            this.LblMark1.Location = new System.Drawing.Point(53, 65);
            this.LblMark1.Name = "LblMark1";
            this.LblMark1.Size = new System.Drawing.Size(53, 13);
            this.LblMark1.TabIndex = 0;
            this.LblMark1.Text = "First Mark";
            // 
            // lblMark2
            // 
            this.lblMark2.AutoSize = true;
            this.lblMark2.Location = new System.Drawing.Point(53, 105);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(71, 13);
            this.lblMark2.TabIndex = 1;
            this.lblMark2.Text = "Second Mark";
            // 
            // lblMark3
            // 
            this.lblMark3.AutoSize = true;
            this.lblMark3.Location = new System.Drawing.Point(53, 143);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(58, 13);
            this.lblMark3.TabIndex = 2;
            this.lblMark3.Text = "Third Mark";
            // 
            // lblMark4
            // 
            this.lblMark4.AutoSize = true;
            this.lblMark4.Location = new System.Drawing.Point(53, 188);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(58, 13);
            this.lblMark4.TabIndex = 3;
            this.lblMark4.Text = "Forth Mark";
            // 
            // txtTextbox1
            // 
            this.txtTextbox1.Location = new System.Drawing.Point(213, 65);
            this.txtTextbox1.Name = "txtTextbox1";
            this.txtTextbox1.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox1.TabIndex = 4;
            // 
            // txtTextbox2
            // 
            this.txtTextbox2.Location = new System.Drawing.Point(213, 105);
            this.txtTextbox2.Name = "txtTextbox2";
            this.txtTextbox2.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox2.TabIndex = 5;
            // 
            // txtTextbox3
            // 
            this.txtTextbox3.Location = new System.Drawing.Point(213, 143);
            this.txtTextbox3.Name = "txtTextbox3";
            this.txtTextbox3.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox3.TabIndex = 6;
            // 
            // txtTextbox4
            // 
            this.txtTextbox4.Location = new System.Drawing.Point(213, 188);
            this.txtTextbox4.Name = "txtTextbox4";
            this.txtTextbox4.Size = new System.Drawing.Size(100, 20);
            this.txtTextbox4.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(115, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 39);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mark Average Calculation";
            // 
            // FrmSchoolMarksAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTextbox4);
            this.Controls.Add(this.txtTextbox3);
            this.Controls.Add(this.txtTextbox2);
            this.Controls.Add(this.txtTextbox1);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.lblMark3);
            this.Controls.Add(this.lblMark2);
            this.Controls.Add(this.LblMark1);
            this.Name = "FrmSchoolMarksAverage";
            this.Text = "Calculate Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMark1;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.TextBox txtTextbox1;
        private System.Windows.Forms.TextBox txtTextbox2;
        private System.Windows.Forms.TextBox txtTextbox3;
        private System.Windows.Forms.TextBox txtTextbox4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
    }
}

