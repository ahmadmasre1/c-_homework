namespace pro1
{
    partial class Form2
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
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(424, 179);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 0;
            button1.Text = "معاملة بيع";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(225, 179);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 1;
            button2.Text = "معاملة شراء";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Akhbar MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(283, 131);
            label1.Name = "label1";
            label1.Size = new Size(222, 35);
            label1.TabIndex = 2;
            label1.Text = "الرجاء اختيار المعامله المراد القيام بها";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            RightToLeft = RightToLeft.Yes;
            Text = "واجهة اختيار المعاملة";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label1;
    }
}