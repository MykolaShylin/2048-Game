namespace _2048WinFormsApp
{
    partial class UsersResultsTableForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersResultsTable = new System.Windows.Forms.DataGridView();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearTableButton = new System.Windows.Forms.Button();
            this.mainMenuBatton = new System.Windows.Forms.Button();
            this.bestResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // usersResultsTable
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usersResultsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersResultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.usersResultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersResultsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberColumn,
            this.nameColumn,
            this.resultColumn});
            this.usersResultsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersResultsTable.Location = new System.Drawing.Point(0, 0);
            this.usersResultsTable.Name = "usersResultsTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersResultsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersResultsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usersResultsTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersResultsTable.RowTemplate.Height = 29;
            this.usersResultsTable.Size = new System.Drawing.Size(409, 486);
            this.usersResultsTable.TabIndex = 0;
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "№";
            this.numberColumn.MinimumWidth = 6;
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.ReadOnly = true;
            this.numberColumn.Width = 55;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 68;
            // 
            // resultColumn
            // 
            this.resultColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resultColumn.HeaderText = "Результат";
            this.resultColumn.MinimumWidth = 6;
            this.resultColumn.Name = "resultColumn";
            this.resultColumn.ReadOnly = true;
            // 
            // clearTableButton
            // 
            this.clearTableButton.Location = new System.Drawing.Point(0, 547);
            this.clearTableButton.Name = "clearTableButton";
            this.clearTableButton.Size = new System.Drawing.Size(200, 48);
            this.clearTableButton.TabIndex = 1;
            this.clearTableButton.Text = "Очистить таблицу";
            this.clearTableButton.UseVisualStyleBackColor = true;
            this.clearTableButton.Click += new System.EventHandler(this.clearTableButton_Click);
            // 
            // mainMenuBatton
            // 
            this.mainMenuBatton.Location = new System.Drawing.Point(209, 547);
            this.mainMenuBatton.Name = "mainMenuBatton";
            this.mainMenuBatton.Size = new System.Drawing.Size(200, 48);
            this.mainMenuBatton.TabIndex = 2;
            this.mainMenuBatton.Text = "Меню";
            this.mainMenuBatton.UseVisualStyleBackColor = true;
            this.mainMenuBatton.Click += new System.EventHandler(this.mainMenuBatton_Click);
            // 
            // bestResultButton
            // 
            this.bestResultButton.Location = new System.Drawing.Point(0, 492);
            this.bestResultButton.Name = "bestResultButton";
            this.bestResultButton.Size = new System.Drawing.Size(409, 49);
            this.bestResultButton.TabIndex = 3;
            this.bestResultButton.Text = "Лучший результат";
            this.bestResultButton.UseVisualStyleBackColor = true;
            this.bestResultButton.Click += new System.EventHandler(this.bestResultButton_Click);
            // 
            // UsersResultsTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 595);
            this.Controls.Add(this.bestResultButton);
            this.Controls.Add(this.mainMenuBatton);
            this.Controls.Add(this.clearTableButton);
            this.Controls.Add(this.usersResultsTable);
            this.Name = "UsersResultsTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица результатов";
            this.Load += new System.EventHandler(this.UsersResultsTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersResultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView usersResultsTable;
        private DataGridViewTextBoxColumn numberColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn resultColumn;
        private Button clearTableButton;
        private Button mainMenuBatton;
        private Button bestResultButton;
    }
}