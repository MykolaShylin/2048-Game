namespace _2048WinFormsApp
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GameRulesButton = new System.Windows.Forms.Button();
            this.AllScoresTable = new System.Windows.Forms.Button();
            this.AndGameButton = new System.Windows.Forms.Button();
            this.mapSizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "2048";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartGameButton.Location = new System.Drawing.Point(0, 100);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(322, 54);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GameRulesButton
            // 
            this.GameRulesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameRulesButton.Location = new System.Drawing.Point(0, 219);
            this.GameRulesButton.Name = "GameRulesButton";
            this.GameRulesButton.Size = new System.Drawing.Size(322, 54);
            this.GameRulesButton.TabIndex = 2;
            this.GameRulesButton.Text = "Правила игры";
            this.GameRulesButton.UseVisualStyleBackColor = true;
            this.GameRulesButton.Click += new System.EventHandler(this.GameRulesButton_Click);
            // 
            // AllScoresTable
            // 
            this.AllScoresTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllScoresTable.Location = new System.Drawing.Point(0, 279);
            this.AllScoresTable.Name = "AllScoresTable";
            this.AllScoresTable.Size = new System.Drawing.Size(322, 54);
            this.AllScoresTable.TabIndex = 4;
            this.AllScoresTable.Text = "Таблица результатов";
            this.AllScoresTable.UseVisualStyleBackColor = true;
            this.AllScoresTable.Click += new System.EventHandler(this.AllScoresTable_Click);
            // 
            // AndGameButton
            // 
            this.AndGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AndGameButton.Location = new System.Drawing.Point(0, 339);
            this.AndGameButton.Name = "AndGameButton";
            this.AndGameButton.Size = new System.Drawing.Size(322, 54);
            this.AndGameButton.TabIndex = 5;
            this.AndGameButton.Text = "Выход";
            this.AndGameButton.UseVisualStyleBackColor = true;
            this.AndGameButton.Click += new System.EventHandler(this.AndGameButton_Click);
            // 
            // mapSizeButton
            // 
            this.mapSizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapSizeButton.Location = new System.Drawing.Point(0, 159);
            this.mapSizeButton.Name = "mapSizeButton";
            this.mapSizeButton.Size = new System.Drawing.Size(322, 54);
            this.mapSizeButton.TabIndex = 6;
            this.mapSizeButton.Text = "Изменить размер сетки игры";
            this.mapSizeButton.UseVisualStyleBackColor = true;
            this.mapSizeButton.Click += new System.EventHandler(this.mapSizeButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 409);
            this.Controls.Add(this.mapSizeButton);
            this.Controls.Add(this.AndGameButton);
            this.Controls.Add(this.AllScoresTable);
            this.Controls.Add(this.GameRulesButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        private Label label1;
        private Button StartGameButton;
        private Button GameRulesButton;
        private Button AllScoresTable;
        private Button AndGameButton;
        private Button mapSizeButton;
    }

    #endregion
}