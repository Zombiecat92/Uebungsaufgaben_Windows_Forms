namespace Übung_3;

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
            this.dagPrimeNumbers = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblEnde = new System.Windows.Forms.Label();
            this.lblSart = new System.Windows.Forms.Label();
            this.Differenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dagPrimeNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dagPrimeNumbers
            // 
            this.dagPrimeNumbers.AllowUserToAddRows = false;
            this.dagPrimeNumbers.AllowUserToDeleteRows = false;
            this.dagPrimeNumbers.AllowUserToResizeColumns = false;
            this.dagPrimeNumbers.AllowUserToResizeRows = false;
            this.dagPrimeNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagPrimeNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Differenz,
            this.Anzahl});
            this.dagPrimeNumbers.Location = new System.Drawing.Point(12, 56);
            this.dagPrimeNumbers.Name = "dagPrimeNumbers";
            this.dagPrimeNumbers.ReadOnly = true;
            this.dagPrimeNumbers.RowTemplate.Height = 25;
            this.dagPrimeNumbers.Size = new System.Drawing.Size(287, 185);
            this.dagPrimeNumbers.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(224, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(118, 27);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 23);
            this.txtInput2.TabIndex = 7;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 27);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 23);
            this.txtInput1.TabIndex = 6;
            // 
            // lblEnde
            // 
            this.lblEnde.AutoSize = true;
            this.lblEnde.Location = new System.Drawing.Point(118, 9);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(33, 15);
            this.lblEnde.TabIndex = 11;
            this.lblEnde.Text = "Ende";
            // 
            // lblSart
            // 
            this.lblSart.AutoSize = true;
            this.lblSart.Location = new System.Drawing.Point(12, 9);
            this.lblSart.Name = "lblSart";
            this.lblSart.Size = new System.Drawing.Size(31, 15);
            this.lblSart.TabIndex = 10;
            this.lblSart.Text = "Start";
            // 
            // Differenz
            // 
            this.Differenz.HeaderText = "Differenz";
            this.Differenz.Name = "Differenz";
            this.Differenz.ReadOnly = true;
            this.Differenz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Differenz.Width = 113;
            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            this.Anzahl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Anzahl.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 251);
            this.Controls.Add(this.dagPrimeNumbers);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.lblSart);
            this.MaximumSize = new System.Drawing.Size(327, 290);
            this.MinimumSize = new System.Drawing.Size(327, 290);
            this.Name = "Form1";
            this.Text = "Übung_3";
            ((System.ComponentModel.ISupportInitialize)(this.dagPrimeNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DataGridView dagPrimeNumbers;
    private Button btnCalculate;
    private TextBox txtInput2;
    private TextBox txtInput1;
    private Label lblEnde;
    private Label lblSart;
    private DataGridViewTextBoxColumn Differenz;
    private DataGridViewTextBoxColumn Anzahl;
}
