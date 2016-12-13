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
            ((System.ComponentModel.ISupportInitialize)(this.columnCountNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowCountNud)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // columnCountNud
            // 
            this.columnCountNud.Location = new System.Drawing.Point(57, 3);
            this.columnCountNud.Name = "columnCountNud";
            this.columnCountNud.Size = new System.Drawing.Size(38, 20);
            this.columnCountNud.TabIndex = 0;
            this.columnCountNud.ValueChanged += new System.EventHandler(this.columnCountNud_ValueChanged);
            // 
            // columnCountLabel
            // 
            this.columnCountLabel.AutoSize = true;
            this.columnCountLabel.Location = new System.Drawing.Point(3, 5);
            this.columnCountLabel.Name = "columnCountLabel";
            this.columnCountLabel.Size = new System.Drawing.Size(50, 13);
            this.columnCountLabel.TabIndex = 1;
            this.columnCountLabel.Text = "Columns:";
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Location = new System.Drawing.Point(16, 23);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(37, 13);
            this.rowCountLabel.TabIndex = 3;
            this.rowCountLabel.Text = "Rows:";
            // 
            // rowCountNud
            // 
            this.rowCountNud.Location = new System.Drawing.Point(57, 21);
            this.rowCountNud.Name = "rowCountNud";
            this.rowCountNud.Size = new System.Drawing.Size(38, 20);
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
            this.flowLayoutPanel1.Controls.Add(this.openXlsButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 409);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.columnCountNud);
            this.panel2.Controls.Add(this.columnCountLabel);
            this.panel2.Controls.Add(this.rowCountLabel);
            this.panel2.Controls.Add(this.rowCountNud);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 47);
            this.panel2.TabIndex = 6;
            // 
            // openXlsButton
            // 
            this.openXlsButton.Location = new System.Drawing.Point(3, 56);
            this.openXlsButton.Name = "openXlsButton";
            this.openXlsButton.Size = new System.Drawing.Size(75, 23);
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
            this.inputTableDgv.Location = new System.Drawing.Point(110, 3);
            this.inputTableDgv.Name = "inputTableDgv";
            this.inputTableDgv.Size = new System.Drawing.Size(503, 409);
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
    }
}

