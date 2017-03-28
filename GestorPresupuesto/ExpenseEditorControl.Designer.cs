namespace GestorPresupuesto
{
    partial class ExpenseEditorControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.cbFixed = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nCost = new System.Windows.Forms.NumericUpDown();
            this.tbConcept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "¿Es fijo?";
            // 
            // cbFixed
            // 
            this.cbFixed.AutoSize = true;
            this.cbFixed.Location = new System.Drawing.Point(482, 6);
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.Size = new System.Drawing.Size(15, 14);
            this.cbFixed.TabIndex = 20;
            this.cbFixed.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Coste";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-3, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Concepto";
            // 
            // nCost
            // 
            this.nCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCost.Location = new System.Drawing.Point(338, 1);
            this.nCost.Margin = new System.Windows.Forms.Padding(15);
            this.nCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCost.Name = "nCost";
            this.nCost.Size = new System.Drawing.Size(51, 25);
            this.nCost.TabIndex = 17;
            // 
            // tbConcept
            // 
            this.tbConcept.Location = new System.Drawing.Point(69, 3);
            this.tbConcept.Name = "tbConcept";
            this.tbConcept.Size = new System.Drawing.Size(162, 20);
            this.tbConcept.TabIndex = 16;
            // 
            // ExpenseEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbFixed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nCost);
            this.Controls.Add(this.tbConcept);
            this.Name = "ExpenseEditorControl";
            this.Size = new System.Drawing.Size(498, 26);
            ((System.ComponentModel.ISupportInitialize)(this.nCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbFixed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nCost;
        private System.Windows.Forms.TextBox tbConcept;
    }
}
