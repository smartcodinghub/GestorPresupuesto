namespace GestorPresupuesto.Forms
{
    partial class NewMonthForm
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
            this.nMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nYear = new System.Windows.Forms.NumericUpDown();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nMonth
            // 
            this.nMonth.Location = new System.Drawing.Point(74, 22);
            this.nMonth.Margin = new System.Windows.Forms.Padding(15);
            this.nMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMonth.Name = "nMonth";
            this.nMonth.Size = new System.Drawing.Size(70, 22);
            this.nMonth.TabIndex = 0;
            this.nMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año:";
            // 
            // nYear
            // 
            this.nYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nYear.Location = new System.Drawing.Point(224, 22);
            this.nYear.Margin = new System.Windows.Forms.Padding(15);
            this.nYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nYear.Name = "nYear";
            this.nYear.Size = new System.Drawing.Size(70, 22);
            this.nYear.TabIndex = 2;
            this.nYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(219, 62);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancelar";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(138, 62);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 5;
            this.bOk.Text = "Aceptar";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // NewMonthForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(318, 99);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nMonth);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewMonthForm";
            this.Text = "Nuevo Mes";
            this.Load += new System.EventHandler(this.NewMonthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nYear;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOk;
    }
}