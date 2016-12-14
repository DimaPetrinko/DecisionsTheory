namespace DecisionsTheory
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.columnCountNud = new System.Windows.Forms.NumericUpDown();
            this.columnCountLabel = new System.Windows.Forms.Label();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.rowCountNud = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openXlsButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nextStepLabel1 = new System.Windows.Forms.Label();
            this.calcAvgsButton1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.averagesTable1 = new System.Windows.Forms.DataGridView();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DispersionRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.inputTableDgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.secondTable = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.calculateSecondTableButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nextStepLabel2 = new System.Windows.Forms.Label();
            this.calcAvgsButton2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.averagesTable2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averagesTable1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableDgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondTable)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averagesTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 441);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.inputTableDgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Step";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 409);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.columnCountNud);
            this.panel2.Controls.Add(this.columnCountLabel);
            this.panel2.Controls.Add(this.rowCountLabel);
            this.panel2.Controls.Add(this.rowCountNud);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 47);
            this.panel2.TabIndex = 6;
            // 
            // columnCountNud
            // 
            this.columnCountNud.Location = new System.Drawing.Point(79, 3);
            this.columnCountNud.Name = "columnCountNud";
            this.columnCountNud.Size = new System.Drawing.Size(62, 20);
            this.columnCountNud.TabIndex = 0;
            this.columnCountNud.ValueChanged += new System.EventHandler(this.columnCountNud_ValueChanged);
            // 
            // columnCountLabel
            // 
            this.columnCountLabel.AutoSize = true;
            this.columnCountLabel.Location = new System.Drawing.Point(23, 5);
            this.columnCountLabel.Name = "columnCountLabel";
            this.columnCountLabel.Size = new System.Drawing.Size(50, 13);
            this.columnCountLabel.TabIndex = 1;
            this.columnCountLabel.Text = "Columns:";
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(36, 23);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(37, 13);
            this.rowCountLabel.TabIndex = 3;
            this.rowCountLabel.Text = "Rows:";
            // 
            // rowCountNud
            // 
            this.rowCountNud.Location = new System.Drawing.Point(79, 21);
            this.rowCountNud.Name = "rowCountNud";
            this.rowCountNud.Size = new System.Drawing.Size(62, 20);
            this.rowCountNud.TabIndex = 2;
            this.rowCountNud.ValueChanged += new System.EventHandler(this.rowCountNud_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.openXlsButton);
            this.panel1.Location = new System.Drawing.Point(3, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 32);
            this.panel1.TabIndex = 8;
            // 
            // openXlsButton
            // 
            this.openXlsButton.Location = new System.Drawing.Point(3, 3);
            this.openXlsButton.Margin = new System.Windows.Forms.Padding(5);
            this.openXlsButton.Name = "openXlsButton";
            this.openXlsButton.Size = new System.Drawing.Size(151, 24);
            this.openXlsButton.TabIndex = 4;
            this.openXlsButton.Text = "Open xls";
            this.openXlsButton.UseVisualStyleBackColor = true;
            this.openXlsButton.Click += new System.EventHandler(this.openXlsButton_Click_1);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.nextStepLabel1);
            this.panel4.Controls.Add(this.calcAvgsButton1);
            this.panel4.Location = new System.Drawing.Point(3, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 52);
            this.panel4.TabIndex = 9;
            // 
            // nextStepLabel1
            // 
            this.nextStepLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.nextStepLabel1.Location = new System.Drawing.Point(0, 0);
            this.nextStepLabel1.Name = "nextStepLabel1";
            this.nextStepLabel1.Size = new System.Drawing.Size(157, 20);
            this.nextStepLabel1.TabIndex = 8;
            this.nextStepLabel1.Text = "Next Step:";
            this.nextStepLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcAvgsButton1
            // 
            this.calcAvgsButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcAvgsButton1.Location = new System.Drawing.Point(3, 21);
            this.calcAvgsButton1.Margin = new System.Windows.Forms.Padding(5);
            this.calcAvgsButton1.Name = "calcAvgsButton1";
            this.calcAvgsButton1.Size = new System.Drawing.Size(151, 24);
            this.calcAvgsButton1.TabIndex = 4;
            this.calcAvgsButton1.Text = "Calculate Avg and Disp";
            this.calcAvgsButton1.UseVisualStyleBackColor = true;
            this.calcAvgsButton1.Click += new System.EventHandler(this.calcAvgsButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.averagesTable1);
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 214);
            this.panel3.TabIndex = 8;
            // 
            // averagesTable1
            // 
            this.averagesTable1.AllowUserToAddRows = false;
            this.averagesTable1.AllowUserToDeleteRows = false;
            this.averagesTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.averagesTable1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.averagesTable1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.averagesTable1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averagesTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.averagesTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Average,
            this.DispersionRoot});
            this.averagesTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.averagesTable1.Location = new System.Drawing.Point(0, 0);
            this.averagesTable1.Name = "averagesTable1";
            this.averagesTable1.ReadOnly = true;
            this.averagesTable1.RowHeadersWidth = 50;
            this.averagesTable1.Size = new System.Drawing.Size(157, 212);
            this.averagesTable1.TabIndex = 8;
            // 
            // Average
            // 
            this.Average.HeaderText = "Avg";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            this.Average.Width = 51;
            // 
            // DispersionRoot
            // 
            this.DispersionRoot.HeaderText = "σ";
            this.DispersionRoot.Name = "DispersionRoot";
            this.DispersionRoot.ReadOnly = true;
            this.DispersionRoot.Width = 39;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.resetButton);
            this.panel5.Location = new System.Drawing.Point(3, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 32);
            this.panel5.TabIndex = 10;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(3, 3);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 24);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // inputTableDgv
            // 
            this.inputTableDgv.AllowUserToAddRows = false;
            this.inputTableDgv.AllowUserToDeleteRows = false;
            this.inputTableDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTableDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inputTableDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inputTableDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inputTableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputTableDgv.Location = new System.Drawing.Point(170, 3);
            this.inputTableDgv.Name = "inputTableDgv";
            this.inputTableDgv.RowHeadersWidth = 50;
            this.inputTableDgv.Size = new System.Drawing.Size(443, 409);
            this.inputTableDgv.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.secondTable);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Second Step";
            // 
            // secondTable
            // 
            this.secondTable.AllowUserToAddRows = false;
            this.secondTable.AllowUserToDeleteRows = false;
            this.secondTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.secondTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.secondTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.secondTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.secondTable.Location = new System.Drawing.Point(170, 3);
            this.secondTable.Name = "secondTable";
            this.secondTable.RowHeadersWidth = 50;
            this.secondTable.Size = new System.Drawing.Size(443, 409);
            this.secondTable.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Controls.Add(this.panel8);
            this.flowLayoutPanel2.Controls.Add(this.panel9);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(166, 409);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.calculateSecondTableButton);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 32);
            this.panel7.TabIndex = 8;
            // 
            // calculateSecondTableButton
            // 
            this.calculateSecondTableButton.Location = new System.Drawing.Point(3, 3);
            this.calculateSecondTableButton.Margin = new System.Windows.Forms.Padding(5);
            this.calculateSecondTableButton.Name = "calculateSecondTableButton";
            this.calculateSecondTableButton.Size = new System.Drawing.Size(151, 24);
            this.calculateSecondTableButton.TabIndex = 4;
            this.calculateSecondTableButton.Text = "Calculate the data";
            this.calculateSecondTableButton.UseVisualStyleBackColor = true;
            this.calculateSecondTableButton.Click += new System.EventHandler(this.calculateSecondTableButton_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.nextStepLabel2);
            this.panel8.Controls.Add(this.calcAvgsButton2);
            this.panel8.Location = new System.Drawing.Point(3, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 52);
            this.panel8.TabIndex = 9;
            // 
            // nextStepLabel2
            // 
            this.nextStepLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.nextStepLabel2.Location = new System.Drawing.Point(0, 0);
            this.nextStepLabel2.Name = "nextStepLabel2";
            this.nextStepLabel2.Size = new System.Drawing.Size(157, 20);
            this.nextStepLabel2.TabIndex = 8;
            this.nextStepLabel2.Text = "Next Step:";
            this.nextStepLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcAvgsButton2
            // 
            this.calcAvgsButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcAvgsButton2.Location = new System.Drawing.Point(3, 21);
            this.calcAvgsButton2.Margin = new System.Windows.Forms.Padding(5);
            this.calcAvgsButton2.Name = "calcAvgsButton2";
            this.calcAvgsButton2.Size = new System.Drawing.Size(151, 24);
            this.calcAvgsButton2.TabIndex = 4;
            this.calcAvgsButton2.Text = "Calculate Avg and Disp";
            this.calcAvgsButton2.UseVisualStyleBackColor = true;
            this.calcAvgsButton2.Click += new System.EventHandler(this.calcAvgsButton2_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.averagesTable2);
            this.panel9.Location = new System.Drawing.Point(3, 99);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(159, 304);
            this.panel9.TabIndex = 8;
            // 
            // averagesTable2
            // 
            this.averagesTable2.AllowUserToAddRows = false;
            this.averagesTable2.AllowUserToDeleteRows = false;
            this.averagesTable2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.averagesTable2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.averagesTable2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.averagesTable2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averagesTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.averagesTable2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.averagesTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.averagesTable2.Location = new System.Drawing.Point(0, 0);
            this.averagesTable2.Name = "averagesTable2";
            this.averagesTable2.ReadOnly = true;
            this.averagesTable2.RowHeadersWidth = 50;
            this.averagesTable2.Size = new System.Drawing.Size(157, 302);
            this.averagesTable2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Avg";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "σ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 39;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(616, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Final Step";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|AllFiles|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Decisions Theory";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.averagesTable1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputTableDgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondTable)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.averagesTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView inputTableDgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown columnCountNud;
        private System.Windows.Forms.Label columnCountLabel;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.NumericUpDown rowCountNud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openXlsButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView averagesTable1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label nextStepLabel1;
        private System.Windows.Forms.Button calcAvgsButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn DispersionRoot;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView secondTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button calculateSecondTableButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label nextStepLabel2;
        private System.Windows.Forms.Button calcAvgsButton2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView averagesTable2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

