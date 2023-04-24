namespace WinFormsApp4
{
    partial class Form1
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
            Estado = new Label();
            button2 = new Button();
            panelCalc = new Panel();
            Remove = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 15);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Location = new Point(18, 424);
            Estado.Name = "Estado";
            Estado.Size = new Size(38, 15);
            Estado.TabIndex = 2;
            Estado.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(170, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelCalc
            // 
            panelCalc.Location = new Point(39, 139);
            panelCalc.Name = "panelCalc";
            panelCalc.Size = new Size(341, 252);
            panelCalc.TabIndex = 4;
            // 
            // Remove
            // 
            Remove.AllowDrop = true;
            Remove.Location = new Point(266, 15);
            Remove.Name = "Remove";
            Remove.Size = new Size(75, 23);
            Remove.TabIndex = 5;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Remove);
            Controls.Add(panelCalc);
            Controls.Add(button2);
            Controls.Add(Estado);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label Estado;
        private Button button2;
        private Panel panelCalc;
        private Button Remove;
    }
}