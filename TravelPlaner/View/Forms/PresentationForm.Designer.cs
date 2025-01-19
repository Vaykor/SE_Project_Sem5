namespace TravelPlaner.View.Forms
{
    partial class PresentationForm
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
            photoPresenter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)photoPresenter).BeginInit();
            SuspendLayout();
            // 
            // photoPresenter
            // 
            photoPresenter.BorderStyle = BorderStyle.FixedSingle;
            photoPresenter.Location = new Point(12, 12);
            photoPresenter.Name = "photoPresenter";
            photoPresenter.Size = new Size(776, 426);
            photoPresenter.SizeMode = PictureBoxSizeMode.StretchImage;
            photoPresenter.TabIndex = 0;
            photoPresenter.TabStop = false;
            // 
            // PresentationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(photoPresenter);
            Name = "PresentationForm";
            Text = "PresentationForm";
            ((System.ComponentModel.ISupportInitialize)photoPresenter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox photoPresenter;
    }
}