namespace Vectors
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAx = new System.Windows.Forms.TextBox();
            this.TxtAy = new System.Windows.Forms.TextBox();
            this.TxtAz = new System.Windows.Forms.TextBox();
            this.TxtBz = new System.Windows.Forms.TextBox();
            this.TxtBy = new System.Windows.Forms.TextBox();
            this.TxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // TxtAx
            // 
            this.TxtAx.Location = new System.Drawing.Point(33, 10);
            this.TxtAx.Name = "TxtAx";
            this.TxtAx.Size = new System.Drawing.Size(43, 20);
            this.TxtAx.TabIndex = 1;
            // 
            // TxtAy
            // 
            this.TxtAy.Location = new System.Drawing.Point(82, 10);
            this.TxtAy.Name = "TxtAy";
            this.TxtAy.Size = new System.Drawing.Size(43, 20);
            this.TxtAy.TabIndex = 2;
            // 
            // TxtAz
            // 
            this.TxtAz.Location = new System.Drawing.Point(131, 10);
            this.TxtAz.Name = "TxtAz";
            this.TxtAz.Size = new System.Drawing.Size(43, 20);
            this.TxtAz.TabIndex = 3;
            // 
            // TxtBz
            // 
            this.TxtBz.Location = new System.Drawing.Point(131, 36);
            this.TxtBz.Name = "TxtBz";
            this.TxtBz.Size = new System.Drawing.Size(43, 20);
            this.TxtBz.TabIndex = 7;
            // 
            // TxtBy
            // 
            this.TxtBy.Location = new System.Drawing.Point(82, 36);
            this.TxtBy.Name = "TxtBy";
            this.TxtBy.Size = new System.Drawing.Size(43, 20);
            this.TxtBy.TabIndex = 6;
            // 
            // TxtBx
            // 
            this.TxtBx.Location = new System.Drawing.Point(33, 36);
            this.TxtBx.Name = "TxtBx";
            this.TxtBx.Size = new System.Drawing.Size(43, 20);
            this.TxtBx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // BtnSwap
            // 
            this.BtnSwap.Location = new System.Drawing.Point(197, 36);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(75, 23);
            this.BtnSwap.TabIndex = 8;
            this.BtnSwap.Text = "Swap";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(16, 80);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(66, 13);
            this.LblResult.TabIndex = 9;
            this.LblResult.Text = "Results here";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(197, 7);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 10;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.TxtBz);
            this.Controls.Add(this.TxtBy);
            this.Controls.Add(this.TxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAz);
            this.Controls.Add(this.TxtAy);
            this.Controls.Add(this.TxtAx);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAx;
        private System.Windows.Forms.TextBox TxtAy;
        private System.Windows.Forms.TextBox TxtAz;
        private System.Windows.Forms.TextBox TxtBz;
        private System.Windows.Forms.TextBox TxtBy;
        private System.Windows.Forms.TextBox TxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnCalc;
    }
}

