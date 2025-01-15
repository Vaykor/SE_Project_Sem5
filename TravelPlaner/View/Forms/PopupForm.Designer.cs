namespace TravelPlaner.View.Forms
{
    partial class PopupForm
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(157, 85);
            button1.Name = "button1";
            button1.Size = new Size(142, 51);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Location = new Point(1, 8);
            label1.Name = "label1";
            label1.Size = new Size(459, 74);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // PopupForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(462, 166);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "PopupForm";
            Text = "PopupForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}