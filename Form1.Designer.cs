namespace Sentence_Capitalizer
{
    partial class frmSentenceCapitalizer
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
            this.tboxSentence = new System.Windows.Forms.TextBox();
            this.lblOutCapitalized = new System.Windows.Forms.Label();
            this.btnCapitalize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Special Elite", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Sentence:";
            // 
            // tboxSentence
            // 
            this.tboxSentence.Font = new System.Drawing.Font("Special Elite", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSentence.Location = new System.Drawing.Point(218, 26);
            this.tboxSentence.Name = "tboxSentence";
            this.tboxSentence.Size = new System.Drawing.Size(544, 26);
            this.tboxSentence.TabIndex = 1;
            // 
            // lblOutCapitalized
            // 
            this.lblOutCapitalized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutCapitalized.Font = new System.Drawing.Font("Special Elite", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutCapitalized.Location = new System.Drawing.Point(28, 64);
            this.lblOutCapitalized.Name = "lblOutCapitalized";
            this.lblOutCapitalized.Size = new System.Drawing.Size(734, 60);
            this.lblOutCapitalized.TabIndex = 2;
            this.lblOutCapitalized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapitalize
            // 
            this.btnCapitalize.Font = new System.Drawing.Font("Special Elite", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapitalize.Location = new System.Drawing.Point(28, 142);
            this.btnCapitalize.Name = "btnCapitalize";
            this.btnCapitalize.Size = new System.Drawing.Size(353, 47);
            this.btnCapitalize.TabIndex = 3;
            this.btnCapitalize.Text = "Capitalize";
            this.btnCapitalize.UseVisualStyleBackColor = true;
            this.btnCapitalize.Click += new System.EventHandler(this.btnCapitalize_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Special Elite", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(387, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(230, 47);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Special Elite", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(623, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSentenceCapitalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 221);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCapitalize);
            this.Controls.Add(this.lblOutCapitalized);
            this.Controls.Add(this.tboxSentence);
            this.Controls.Add(this.label1);
            this.Name = "frmSentenceCapitalizer";
            this.Text = "Sentence Capitalizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSentence;
        private System.Windows.Forms.Label lblOutCapitalized;
        private System.Windows.Forms.Button btnCapitalize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

