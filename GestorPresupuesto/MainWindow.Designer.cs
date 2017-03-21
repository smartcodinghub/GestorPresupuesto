namespace GestorPresupuesto
{
    partial class MainWindow
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridMonths = new System.Windows.Forms.DataGridView();
            this.MonthTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMonthIsOverLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMonthNonFixedTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMonthFixedTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMonthTotal = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbFixed = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nCost = new System.Windows.Forms.NumericUpDown();
            this.tbConcept = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridExpenses = new System.Windows.Forms.DataGridView();
            this.dgcExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcExpenseCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcExpenseIsFixed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nMonthContinuosLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nMonthLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonths)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonthContinuosLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonthLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridMonths);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 657);
            this.panel1.TabIndex = 0;
            // 
            // dataGridMonths
            // 
            this.dataGridMonths.AllowUserToAddRows = false;
            this.dataGridMonths.AllowUserToDeleteRows = false;
            this.dataGridMonths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMonths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMonths.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthTitle,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column1,
            this.dgvcMonthIsOverLimit});
            this.dataGridMonths.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridMonths.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridMonths.Location = new System.Drawing.Point(15, 50);
            this.dataGridMonths.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.dataGridMonths.Name = "dataGridMonths";
            this.dataGridMonths.RowHeadersVisible = false;
            this.dataGridMonths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMonths.Size = new System.Drawing.Size(528, 592);
            this.dataGridMonths.TabIndex = 1;
            this.dataGridMonths.SelectionChanged += new System.EventHandler(this.dataGridMonths_SelectionChanged);
            // 
            // MonthTitle
            // 
            this.MonthTitle.DataPropertyName = "MonthTitle";
            this.MonthTitle.FillWeight = 28F;
            this.MonthTitle.HeaderText = "Month";
            this.MonthTitle.Name = "MonthTitle";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NonFixedExpensesTotalCost";
            this.Column3.FillWeight = 22F;
            this.Column3.HeaderText = "T. Caprichos";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ExpenseMax";
            this.Column6.FillWeight = 22F;
            this.Column6.HeaderText = "L. Caprichos";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FixedExpensesTotalCost";
            this.Column5.FillWeight = 18F;
            this.Column5.HeaderText = "Total Fijos";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ContinuosExpenseMax";
            this.Column7.FillWeight = 20F;
            this.Column7.HeaderText = "L. Fijos";
            this.Column7.Name = "Column7";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ExpensesTotalCost";
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            // 
            // dgvcMonthIsOverLimit
            // 
            this.dgvcMonthIsOverLimit.DataPropertyName = "IsOverLimit";
            this.dgvcMonthIsOverLimit.HeaderText = "IsOverLimit";
            this.dgvcMonthIsOverLimit.Name = "dgvcMonthIsOverLimit";
            this.dgvcMonthIsOverLimit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumen por Meses";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMonthNonFixedTotal);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblMonthFixedTotal);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblMonthTotal);
            this.panel2.Controls.Add(this.bSave);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbFixed);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nCost);
            this.panel2.Controls.Add(this.tbConcept);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dataGridExpenses);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nMonthContinuosLimit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nMonthLimit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(558, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 657);
            this.panel2.TabIndex = 1;
            // 
            // lblMonthNonFixedTotal
            // 
            this.lblMonthNonFixedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthNonFixedTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthNonFixedTotal.Location = new System.Drawing.Point(435, 622);
            this.lblMonthNonFixedTotal.Margin = new System.Windows.Forms.Padding(15);
            this.lblMonthNonFixedTotal.Name = "lblMonthNonFixedTotal";
            this.lblMonthNonFixedTotal.Size = new System.Drawing.Size(43, 20);
            this.lblMonthNonFixedTotal.TabIndex = 20;
            this.lblMonthNonFixedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 622);
            this.label12.Margin = new System.Windows.Forms.Padding(15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Caprichos:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonthFixedTotal
            // 
            this.lblMonthFixedTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthFixedTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthFixedTotal.Location = new System.Drawing.Point(515, 622);
            this.lblMonthFixedTotal.Margin = new System.Windows.Forms.Padding(15);
            this.lblMonthFixedTotal.Name = "lblMonthFixedTotal";
            this.lblMonthFixedTotal.Size = new System.Drawing.Size(41, 20);
            this.lblMonthFixedTotal.TabIndex = 18;
            this.lblMonthFixedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 622);
            this.label11.Margin = new System.Windows.Forms.Padding(15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Fijo:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMonthTotal
            // 
            this.lblMonthTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthTotal.Location = new System.Drawing.Point(621, 622);
            this.lblMonthTotal.Margin = new System.Windows.Forms.Padding(15);
            this.lblMonthTotal.Name = "lblMonthTotal";
            this.lblMonthTotal.Size = new System.Drawing.Size(46, 20);
            this.lblMonthTotal.TabIndex = 16;
            this.lblMonthTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(592, 83);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 26);
            this.bSave.TabIndex = 15;
            this.bSave.Text = "Guardar";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "¿Es fijo?";
            // 
            // cbFixed
            // 
            this.cbFixed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFixed.AutoSize = true;
            this.cbFixed.Location = new System.Drawing.Point(565, 89);
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.Size = new System.Drawing.Size(15, 14);
            this.cbFixed.TabIndex = 13;
            this.cbFixed.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Coste";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 10, 5, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Concepto";
            // 
            // nCost
            // 
            this.nCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCost.Location = new System.Drawing.Point(438, 84);
            this.nCost.Margin = new System.Windows.Forms.Padding(15);
            this.nCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nCost.Name = "nCost";
            this.nCost.Size = new System.Drawing.Size(51, 25);
            this.nCost.TabIndex = 10;
            // 
            // tbConcept
            // 
            this.tbConcept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConcept.Location = new System.Drawing.Point(84, 83);
            this.tbConcept.Name = "tbConcept";
            this.tbConcept.Size = new System.Drawing.Size(293, 25);
            this.tbConcept.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 622);
            this.label7.Margin = new System.Windows.Forms.Padding(15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridExpenses
            // 
            this.dataGridExpenses.AllowUserToAddRows = false;
            this.dataGridExpenses.AllowUserToDeleteRows = false;
            this.dataGridExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExpenses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcExpenseName,
            this.dgcExpenseCost,
            this.dgcExpenseIsFixed});
            this.dataGridExpenses.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridExpenses.Location = new System.Drawing.Point(15, 129);
            this.dataGridExpenses.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.dataGridExpenses.Name = "dataGridExpenses";
            this.dataGridExpenses.RowHeadersVisible = false;
            this.dataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExpenses.Size = new System.Drawing.Size(652, 461);
            this.dataGridExpenses.TabIndex = 7;
            // 
            // dgcExpenseName
            // 
            this.dgcExpenseName.DataPropertyName = "Name";
            this.dgcExpenseName.FillWeight = 70F;
            this.dgcExpenseName.HeaderText = "Concepto";
            this.dgcExpenseName.Name = "dgcExpenseName";
            // 
            // dgcExpenseCost
            // 
            this.dgcExpenseCost.DataPropertyName = "Cost";
            this.dgcExpenseCost.FillWeight = 15F;
            this.dgcExpenseCost.HeaderText = "Coste";
            this.dgcExpenseCost.Name = "dgcExpenseCost";
            // 
            // dgcExpenseIsFixed
            // 
            this.dgcExpenseIsFixed.DataPropertyName = "IsFixed";
            this.dgcExpenseIsFixed.FillWeight = 15F;
            this.dgcExpenseIsFixed.HeaderText = "Gasto Fijo?";
            this.dgcExpenseIsFixed.Name = "dgcExpenseIsFixed";
            this.dgcExpenseIsFixed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcExpenseIsFixed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gastos";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(15, 15, 5, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gastos fijos:";
            // 
            // nMonthContinuosLimit
            // 
            this.nMonthContinuosLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nMonthContinuosLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMonthContinuosLimit.Location = new System.Drawing.Point(619, 14);
            this.nMonthContinuosLimit.Margin = new System.Windows.Forms.Padding(15);
            this.nMonthContinuosLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nMonthContinuosLimit.Name = "nMonthContinuosLimit";
            this.nMonthContinuosLimit.Size = new System.Drawing.Size(48, 25);
            this.nMonthContinuosLimit.TabIndex = 4;
            this.nMonthContinuosLimit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nMonthContinuosLimit_Update);
            this.nMonthContinuosLimit.Leave += new System.EventHandler(this.nMonthContinuosLimit_Update);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 15, 5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caprichos";
            // 
            // nMonthLimit
            // 
            this.nMonthLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nMonthLimit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMonthLimit.Location = new System.Drawing.Point(417, 14);
            this.nMonthLimit.Margin = new System.Windows.Forms.Padding(15);
            this.nMonthLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nMonthLimit.Name = "nMonthLimit";
            this.nMonthLimit.Size = new System.Drawing.Size(48, 25);
            this.nMonthLimit.TabIndex = 1;
            this.nMonthLimit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nMonthLimit_Update);
            this.nMonthLimit.Leave += new System.EventHandler(this.nMonthLimit_Update);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle del Mes";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonths)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonthContinuosLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMonthLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridMonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nMonthLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nMonthContinuosLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridExpenses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcExpenseCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcExpenseIsFixed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nCost;
        private System.Windows.Forms.TextBox tbConcept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbFixed;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lblMonthTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMonthIsOverLimit;
        private System.Windows.Forms.Label lblMonthFixedTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMonthNonFixedTotal;
        private System.Windows.Forms.Label label12;
    }
}

