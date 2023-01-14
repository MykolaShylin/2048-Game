namespace _2048WinFormsApp
{
    partial class GameRulesForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okButton.Location = new System.Drawing.Point(0, 325);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(1054, 67);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Понятно";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // rulesLabel
            // 
            this.rulesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesLabel.Location = new System.Drawing.Point(0, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(1054, 325);
            this.rulesLabel.TabIndex = 1;
            this.rulesLabel.Text = "label1";
            // 
            // GameRulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 392);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.okButton);
            this.Location = new System.Drawing.Point(1500, 400);
            this.Name = "GameRulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Правила игры";
            this.Load += new System.EventHandler(this.GameRulesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button okButton;
        private Label rulesLabel;
    }
}