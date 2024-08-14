namespace Note_taking_app
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            Clock = new Label();
            FIleName = new TextBox();
            Save = new Button();
            Open = new Button();
            Save_to_location = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 150);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(431, 252);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "Text:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(449, 253);
            button1.Name = "button1";
            button1.Size = new Size(156, 50);
            button1.TabIndex = 6;
            button1.Text = "Folder Finder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(632, 253);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 7;
            button2.Text = "File Finder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += file_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Clock
            // 
            Clock.AutoSize = true;
            Clock.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clock.Location = new Point(611, 422);
            Clock.Name = "Clock";
            Clock.Size = new Size(84, 19);
            Clock.TabIndex = 8;
            Clock.Text = "00:00:00 AM";
            // 
            // FIleName
            // 
            FIleName.Location = new Point(449, 311);
            FIleName.Name = "FIleName";
            FIleName.Size = new Size(339, 27);
            FIleName.TabIndex = 10;
            // 
            // Save
            // 
            Save.Location = new Point(611, 377);
            Save.Name = "Save";
            Save.Size = new Size(159, 43);
            Save.TabIndex = 11;
            Save.Text = "Save to location";
            Save.UseVisualStyleBackColor = true;
            // 
            // Open
            // 
            Open.Location = new Point(449, 380);
            Open.Name = "Open";
            Open.Size = new Size(159, 40);
            Open.TabIndex = 12;
            Open.Text = "Open From location";
            Open.UseVisualStyleBackColor = true;
            // 
            // Save_to_location
            // 
            Save_to_location.Location = new Point(449, 344);
            Save_to_location.Name = "Save_to_location";
            Save_to_location.Size = new Size(339, 27);
            Save_to_location.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save_to_location);
            Controls.Add(Open);
            Controls.Add(Save);
            Controls.Add(FIleName);
            Controls.Add(Clock);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Note Taking app";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label Clock;
        private TextBox FIleName;
        private Button Save;
        private Button Open;
        private TextBox Save_to_location;
    }
}
