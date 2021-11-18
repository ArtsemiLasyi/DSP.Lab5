namespace DSP.Lab5.Presentation
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
            this.BitmapOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FragmentLoadButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FragmentPictureBox = new System.Windows.Forms.PictureBox();
            this.FragmentLabel = new System.Windows.Forms.Label();
            this.OriginalLabel = new System.Windows.Forms.Label();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.OriginalLoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FragmentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BitmapOpenFileDialog
            // 
            this.BitmapOpenFileDialog.Filter = "Image File (*png; *jpg; *bmp;) | *png; *jpg; *bmp;";
            // 
            // FragmentLoadButton
            // 
            this.FragmentLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FragmentLoadButton.Location = new System.Drawing.Point(241, 420);
            this.FragmentLoadButton.Name = "FragmentLoadButton";
            this.FragmentLoadButton.Size = new System.Drawing.Size(290, 41);
            this.FragmentLoadButton.TabIndex = 1;
            this.FragmentLoadButton.Text = "Загрузить";
            this.FragmentLoadButton.UseVisualStyleBackColor = true;
            this.FragmentLoadButton.Click += new System.EventHandler(this.FragmentLoadButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(25, 62);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(181, 41);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FragmentPictureBox
            // 
            this.FragmentPictureBox.Location = new System.Drawing.Point(241, 62);
            this.FragmentPictureBox.Name = "FragmentPictureBox";
            this.FragmentPictureBox.Size = new System.Drawing.Size(290, 342);
            this.FragmentPictureBox.TabIndex = 3;
            this.FragmentPictureBox.TabStop = false;
            // 
            // FragmentLabel
            // 
            this.FragmentLabel.AutoSize = true;
            this.FragmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FragmentLabel.Location = new System.Drawing.Point(241, 30);
            this.FragmentLabel.Name = "FragmentLabel";
            this.FragmentLabel.Size = new System.Drawing.Size(106, 24);
            this.FragmentLabel.TabIndex = 4;
            this.FragmentLabel.Text = "Фрагмент:";
            // 
            // OriginalLabel
            // 
            this.OriginalLabel.AutoSize = true;
            this.OriginalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OriginalLabel.Location = new System.Drawing.Point(558, 30);
            this.OriginalLabel.Name = "OriginalLabel";
            this.OriginalLabel.Size = new System.Drawing.Size(103, 24);
            this.OriginalLabel.TabIndex = 7;
            this.OriginalLabel.Text = "Оригинал:";
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Location = new System.Drawing.Point(558, 62);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(290, 342);
            this.OriginalPictureBox.TabIndex = 6;
            this.OriginalPictureBox.TabStop = false;
            // 
            // OriginalLoadButton
            // 
            this.OriginalLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OriginalLoadButton.Location = new System.Drawing.Point(558, 420);
            this.OriginalLoadButton.Name = "OriginalLoadButton";
            this.OriginalLoadButton.Size = new System.Drawing.Size(290, 41);
            this.OriginalLoadButton.TabIndex = 5;
            this.OriginalLoadButton.Text = "Загрузить";
            this.OriginalLoadButton.UseVisualStyleBackColor = true;
            this.OriginalLoadButton.Click += new System.EventHandler(this.OriginalLoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 466);
            this.Controls.Add(this.OriginalLabel);
            this.Controls.Add(this.OriginalPictureBox);
            this.Controls.Add(this.OriginalLoadButton);
            this.Controls.Add(this.FragmentLabel);
            this.Controls.Add(this.FragmentPictureBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.FragmentLoadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Корреляция изображений";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FragmentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog BitmapOpenFileDialog;
        private System.Windows.Forms.Button FragmentLoadButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox FragmentPictureBox;
        private System.Windows.Forms.Label FragmentLabel;
        private System.Windows.Forms.Label OriginalLabel;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.Button OriginalLoadButton;
    }
}
