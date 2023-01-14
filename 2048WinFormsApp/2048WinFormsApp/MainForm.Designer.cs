namespace _2048WinFormsApp
{
    partial class MainForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.cancelMoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(58, 11);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(17, 20);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "0";
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restartButton.BackColor = System.Drawing.Color.Snow;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.restartButton.Location = new System.Drawing.Point(226, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(94, 33);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Рестарт";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endGameButton.BackColor = System.Drawing.SystemColors.Window;
            this.endGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endGameButton.Enabled = false;
            this.endGameButton.ForeColor = System.Drawing.Color.Blue;
            this.endGameButton.Location = new System.Drawing.Point(126, 12);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(94, 33);
            this.endGameButton.TabIndex = 3;
            this.endGameButton.Text = "Выйти";
            this.endGameButton.UseVisualStyleBackColor = false;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // cancelMoveButton
            // 
            this.cancelMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelMoveButton.BackColor = System.Drawing.SystemColors.Info;
            this.cancelMoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelMoveButton.Enabled = false;
            this.cancelMoveButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.cancelMoveButton.Location = new System.Drawing.Point(126, 60);
            this.cancelMoveButton.Name = "cancelMoveButton";
            this.cancelMoveButton.Size = new System.Drawing.Size(194, 33);
            this.cancelMoveButton.TabIndex = 4;
            this.cancelMoveButton.Text = "Отменить ход";
            this.cancelMoveButton.UseVisualStyleBackColor = false;
            this.cancelMoveButton.Click += new System.EventHandler(this.cancelMoveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(this.cancelMoveButton);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private Button restartButton;
        private Button endGameButton;
        private Button cancelMoveButton;
    }
}