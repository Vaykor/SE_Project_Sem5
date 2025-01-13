namespace TravelPlaner.View.Forms
{
    partial class MainForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button = new Button();
            APITestBox = new TextBox();
            listView1 = new ListView();
            Name = new ColumnHeader();
            Country = new ColumnHeader();
            City = new ColumnHeader();
            Street = new ColumnHeader();
            Phone = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 38);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 149);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 111);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Text";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 229);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 6;
            label5.Text = "Text";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 190);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Text";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 266);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 4;
            label7.Text = "Text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(85, 301);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 7;
            label8.Text = "Text";
            // 
            // button
            // 
            button.Location = new Point(1228, 13);
            button.Margin = new Padding(2);
            button.Name = "button";
            button.Size = new Size(146, 70);
            button.TabIndex = 8;
            button.Text = "Click me:)";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // APITestBox
            // 
            APITestBox.Location = new Point(157, 66);
            APITestBox.Name = "APITestBox";
            APITestBox.Size = new Size(1066, 27);
            APITestBox.TabIndex = 9;
            APITestBox.TextChanged += textBox1_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Name, Country, City, Street, Phone });
            listView1.Location = new Point(157, 111);
            listView1.Name = "listView1";
            listView1.Size = new Size(1217, 564);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Country
            // 
            Country.Text = "Country";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 704);
            Controls.Add(listView1);
            Controls.Add(APITestBox);
            Controls.Add(button);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button;
        private TextBox APITestBox;
        private ListView listView1;
        private ColumnHeader Name;
        private ColumnHeader Country;
        private ColumnHeader City;
        private ColumnHeader Street;
        private ColumnHeader Phone;
    }
}