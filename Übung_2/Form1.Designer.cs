namespace Übung_2;

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
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dagPrimeNumbers = new System.Windows.Forms.DataGridView();
            this.PrimeNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSart = new System.Windows.Forms.Label();
            this.lblEnde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dagPrimeNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 27);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 23);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(118, 27);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 23);
            this.txtInput2.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(224, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // dagPrimeNumbers
            // 
            this.dagPrimeNumbers.AllowUserToAddRows = false;
            this.dagPrimeNumbers.AllowUserToDeleteRows = false;
            this.dagPrimeNumbers.AllowUserToResizeColumns = false;
            this.dagPrimeNumbers.AllowUserToResizeRows = false;
            this.dagPrimeNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagPrimeNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimeNumbers});
            this.dagPrimeNumbers.Location = new System.Drawing.Point(12, 56);
            this.dagPrimeNumbers.Name = "dagPrimeNumbers";
            this.dagPrimeNumbers.ReadOnly = true;
            this.dagPrimeNumbers.RowTemplate.Height = 25;
            this.dagPrimeNumbers.Size = new System.Drawing.Size(287, 185);
            this.dagPrimeNumbers.TabIndex = 3;
            // 
            // PrimeNumbers
            // 
            this.PrimeNumbers.HeaderText = "Prime numbers";
            this.PrimeNumbers.Name = "PrimeNumbers";
            this.PrimeNumbers.ReadOnly = true;
            this.PrimeNumbers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrimeNumbers.Width = 225;
            // 
            // lblSart
            // 
            this.lblSart.AutoSize = true;
            this.lblSart.Location = new System.Drawing.Point(12, 9);
            this.lblSart.Name = "lblSart";
            this.lblSart.Size = new System.Drawing.Size(31, 15);
            this.lblSart.TabIndex = 4;
            this.lblSart.Text = "Start";
            // 
            // lblEnde
            // 
            this.lblEnde.AutoSize = true;
            this.lblEnde.Location = new System.Drawing.Point(118, 9);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(33, 15);
            this.lblEnde.TabIndex = 5;
            this.lblEnde.Text = "Ende";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 251);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.lblSart);
            this.Controls.Add(this.dagPrimeNumbers);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.MaximumSize = new System.Drawing.Size(327, 290);
            this.MinimumSize = new System.Drawing.Size(327, 290);
            this.Name = "Form1";
            this.Text = "Übung_2";
            ((System.ComponentModel.ISupportInitialize)(this.dagPrimeNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox txtInput1;
    private TextBox txtInput2;
    private Button btnCalculate;
    private DataGridView dagPrimeNumbers;
    private DataGridViewTextBoxColumn PrimeNumbers;
    private Label lblSart;
    private Label lblEnde;
}
