namespace InClassWeek10
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
            this.btnClickHere = new System.Windows.Forms.Button();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.btnWhileLoop = new System.Windows.Forms.Button();
            this.txtXNumber = new System.Windows.Forms.TextBox();
            this.txtYNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(124, 87);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(142, 42);
            this.btnClickHere.TabIndex = 0;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Location = new System.Drawing.Point(124, 38);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(220, 20);
            this.lblMessage1.TabIndex = 1;
            this.lblMessage1.Text = "Click the button to start a loop";
            // 
            // btnWhileLoop
            // 
            this.btnWhileLoop.Location = new System.Drawing.Point(328, 87);
            this.btnWhileLoop.Name = "btnWhileLoop";
            this.btnWhileLoop.Size = new System.Drawing.Size(136, 42);
            this.btnWhileLoop.TabIndex = 2;
            this.btnWhileLoop.Text = "While Loop";
            this.btnWhileLoop.UseVisualStyleBackColor = true;
            this.btnWhileLoop.Click += new System.EventHandler(this.btnWhileLoop_Click);
            // 
            // txtXNumber
            // 
            this.txtXNumber.Location = new System.Drawing.Point(124, 203);
            this.txtXNumber.Name = "txtXNumber";
            this.txtXNumber.Size = new System.Drawing.Size(100, 26);
            this.txtXNumber.TabIndex = 3;
            // 
            // txtYNumber
            // 
            this.txtYNumber.Location = new System.Drawing.Point(263, 203);
            this.txtYNumber.Name = "txtYNumber";
            this.txtYNumber.Size = new System.Drawing.Size(100, 26);
            this.txtYNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(124, 321);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtYNumber);
            this.Controls.Add(this.txtXNumber);
            this.Controls.Add(this.btnWhileLoop);
            this.Controls.Add(this.lblMessage1);
            this.Controls.Add(this.btnClickHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Button btnWhileLoop;
        private System.Windows.Forms.TextBox txtXNumber;
        private System.Windows.Forms.TextBox txtYNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOutput;
    }
}

