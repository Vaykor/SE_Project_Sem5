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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)photoPresenter).BeginInit();
            SuspendLayout();
            // 
            // photoPresenter
            // 
            photoPresenter.BorderStyle = BorderStyle.FixedSingle;
            photoPresenter.Location = new Point(35, 24);
            photoPresenter.Name = "photoPresenter";
            photoPresenter.Size = new Size(1181, 604);
            photoPresenter.SizeMode = PictureBoxSizeMode.Zoom;
            photoPresenter.TabIndex = 0;
            photoPresenter.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(514, 643);
            button1.Name = "button1";
            button1.Size = new Size(223, 38);
            button1.TabIndex = 1;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PresentationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 693);
            Controls.Add(button1);
            Controls.Add(photoPresenter);
            Name = "PresentationForm";
            Text = "PresentationForm";
            Load += PresentationForm_Load;
            ((System.ComponentModel.ISupportInitialize)photoPresenter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox photoPresenter;
        private Button button1;
    }
}