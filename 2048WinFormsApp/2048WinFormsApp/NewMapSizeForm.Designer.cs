namespace _2048WinFormsApp
{
    partial class NewMapSizeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mapSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aceptChangesButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите новый размер игрового поля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapSizeTextBox
            // 
            this.mapSizeTextBox.Location = new System.Drawing.Point(233, 57);
            this.mapSizeTextBox.Name = "mapSizeTextBox";
            this.mapSizeTextBox.PlaceholderText = "Введите число";
            this.mapSizeTextBox.Size = new System.Drawing.Size(171, 27);
            this.mapSizeTextBox.TabIndex = 1;
            this.mapSizeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.mapSizeTextBox_Validating);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Размер сетки высота х ширина";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aceptChangesButton
            // 
            this.aceptChangesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aceptChangesButton.Location = new System.Drawing.Point(0, 109);
            this.aceptChangesButton.Name = "aceptChangesButton";
            this.aceptChangesButton.Size = new System.Drawing.Size(439, 49);
            this.aceptChangesButton.TabIndex = 5;
            this.aceptChangesButton.Text = "Принять и начать игру";
            this.aceptChangesButton.UseVisualStyleBackColor = true;
            this.aceptChangesButton.Click += new System.EventHandler(this.aceptChangesButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewMapSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 158);
            this.Controls.Add(this.aceptChangesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mapSizeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewMapSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки игры";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox mapSizeTextBox;
        private Label label2;
        private Button aceptChangesButton;
        private ErrorProvider errorProvider;
    }
}