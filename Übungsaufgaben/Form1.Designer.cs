namespace Übung_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.ddn = new System.Windows.Forms.ComboBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.bntCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 12);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 23);
            this.txtInput1.TabIndex = 0;
            // 
            // ddn
            // 
            this.ddn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddn.FormattingEnabled = true;
            this.ddn.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ddn.Location = new System.Drawing.Point(118, 12);
            this.ddn.Name = "ddn";
            this.ddn.Size = new System.Drawing.Size(35, 23);
            this.ddn.TabIndex = 1;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(159, 12);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 23);
            this.txtInput2.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 38);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 15);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "lable";
            this.lblResult.Visible = false;
            // 
            // bntCalculate
            // 
            this.bntCalculate.Location = new System.Drawing.Point(265, 12);
            this.bntCalculate.Name = "bntCalculate";
            this.bntCalculate.Size = new System.Drawing.Size(75, 23);
            this.bntCalculate.TabIndex = 4;
            this.bntCalculate.Text = "Berechnen";
            this.bntCalculate.UseVisualStyleBackColor = true;
            this.bntCalculate.Click += new System.EventHandler(this.BntCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 61);
            this.Controls.Add(this.bntCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.ddn);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = " Übung 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput1;
        private ComboBox ddn;
        private TextBox txtInput2;
        private Label lblResult;
        private Button bntCalculate;
    }
}