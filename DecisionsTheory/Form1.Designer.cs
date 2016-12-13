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
            this.columnCountNud = new System.Windows.Forms.NumericUpDown();
            this.columnCountLabel = new System.Windows.Forms.Label();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.rowCountNud = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openXlsButton = new System.Windows.Forms.Button();
            this.inputTableDgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AveragesTable = new System.Windows.Forms.DataGridView();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AveragesTable)).BeginInit();
            this.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
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
            this.tabPage1.Text = "Input";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
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
            // inputTableDgv
            // 
            this.inputTableDgv.AllowUserToAddRows = false;
            this.inputTableDgv.AllowUserToDeleteRows = false;
            this.inputTableDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inputTableDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inputTableDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inputTableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputTableDgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.inputTableDgv.Location = new System.Drawing.Point(170, 3);
            this.inputTableDgv.Name = "inputTableDgv";
            this.inputTableDgv.Size = new System.Drawing.Size(443, 409);
            this.inputTableDgv.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|AllFiles|*.*";
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AveragesTable);
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 166);
            this.panel3.TabIndex = 8;
            // 
            // AveragesTable
            // 
            this.AveragesTable.AllowUserToAddRows = false;
            this.AveragesTable.AllowUserToDeleteRows = false;
            this.AveragesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AveragesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AveragesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AveragesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AveragesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AveragesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Average,
            this.Dispersion});
            this.AveragesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AveragesTable.Location = new System.Drawing.Point(0, 0);
            this.AveragesTable.Name = "AveragesTable";
            this.AveragesTable.ReadOnly = true;
            this.AveragesTable.Size = new System.Drawing.Size(157, 164);
            this.AveragesTable.TabIndex = 8;
            // 
            // Average
            // 
            this.Average.HeaderText = "Avg";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            this.Average.Width = 51;
            // 
            // Dispersion
            // 
            this.Dispersion.HeaderText = "Disp";
            this.Dispersion.Name = "Dispersion";
            this.Dispersion.ReadOnly = true;
            this.Dispersion.Width = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Decisions Theory";
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AveragesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown columnCountNud;
        private System.Windows.Forms.Label columnCountLabel;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.NumericUpDown rowCountNud;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView inputTableDgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openXlsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView AveragesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispersion;
    }
}

