namespace Sum200
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDirect1 = new System.Windows.Forms.Label();
            this.lblTopNum = new System.Windows.Forms.Label();
            this.txtTopNum = new System.Windows.Forms.TextBox();
            this.txtMidSum = new System.Windows.Forms.TextBox();
            this.lblMidSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblDirect2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDirect1
            // 
            this.lblDirect1.AutoSize = true;
            this.lblDirect1.Location = new System.Drawing.Point(131, 29);
            this.lblDirect1.Name = "lblDirect1";
            this.lblDirect1.Size = new System.Drawing.Size(274, 13);
            this.lblDirect1.TabIndex = 1;
            this.lblDirect1.Text = "Enter a number in the top number box and press the start";
            // 
            // lblTopNum
            // 
            this.lblTopNum.AutoSize = true;
            this.lblTopNum.Location = new System.Drawing.Point(147, 70);
            this.lblTopNum.Name = "lblTopNum";
            this.lblTopNum.Size = new System.Drawing.Size(66, 13);
            this.lblTopNum.TabIndex = 2;
            this.lblTopNum.Text = "Top Number";
            // 
            // txtTopNum
            // 
            this.txtTopNum.Location = new System.Drawing.Point(12, 67);
            this.txtTopNum.Name = "txtTopNum";
            this.txtTopNum.Size = new System.Drawing.Size(86, 20);
            this.txtTopNum.TabIndex = 3;
            // 
            // txtMidSum
            // 
            this.txtMidSum.Location = new System.Drawing.Point(12, 128);
            this.txtMidSum.Name = "txtMidSum";
            this.txtMidSum.ReadOnly = true;
            this.txtMidSum.Size = new System.Drawing.Size(86, 20);
            this.txtMidSum.TabIndex = 5;
            this.txtMidSum.TabStop = false;
            // 
            // lblMidSum
            // 
            this.lblMidSum.AutoSize = true;
            this.lblMidSum.Location = new System.Drawing.Point(147, 131);
            this.lblMidSum.Name = "lblMidSum";
            this.lblMidSum.Size = new System.Drawing.Size(69, 13);
            this.lblMidSum.TabIndex = 4;
            this.lblMidSum.Text = "Halfway Sum";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(12, 168);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(86, 20);
            this.txtSum.TabIndex = 7;
            this.txtSum.TabStop = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(147, 171);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(55, 13);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "Total Sum";
            // 
            // lblDirect2
            // 
            this.lblDirect2.AutoSize = true;
            this.lblDirect2.Location = new System.Drawing.Point(131, 45);
            this.lblDirect2.Name = "lblDirect2";
            this.lblDirect2.Size = new System.Drawing.Size(280, 13);
            this.lblDirect2.TabIndex = 8;
            this.lblDirect2.Text = " button to add up all numbers between 0 and that number.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 299);
            this.Controls.Add(this.lblDirect2);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtMidSum);
            this.Controls.Add(this.lblMidSum);
            this.Controls.Add(this.txtTopNum);
            this.Controls.Add(this.lblTopNum);
            this.Controls.Add(this.lblDirect1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDirect1;
        private System.Windows.Forms.Label lblTopNum;
        private System.Windows.Forms.TextBox txtTopNum;
        private System.Windows.Forms.TextBox txtMidSum;
        private System.Windows.Forms.Label lblMidSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblDirect2;
    }
}

