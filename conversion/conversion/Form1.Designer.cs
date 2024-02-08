namespace conversion
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
            meterinputupdown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Yard = new Label();
            label7 = new Label();
            inchoutput = new Label();
            footoutput = new Label();
            outputinch = new Label();
            outputfoot = new Label();
            outputyard = new Label();
            outputmile = new Label();
            ((System.ComponentModel.ISupportInitialize)meterinputupdown).BeginInit();
            SuspendLayout();
            // 
            // meterinputupdown
            // 
            meterinputupdown.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            meterinputupdown.Location = new Point(65, 69);
            meterinputupdown.Name = "meterinputupdown";
            meterinputupdown.Size = new Size(285, 43);
            meterinputupdown.TabIndex = 0;
            meterinputupdown.ValueChanged += meterinputupdown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 31);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Length in Meter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 156);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 2;
            label2.Text = "Conversion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(13, 187);
            label3.Name = "label3";
            label3.Size = new Size(402, 15);
            label3.TabIndex = 3;
            label3.Text = "_______________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 221);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "Inch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 273);
            label5.Name = "label5";
            label5.Size = new Size(36, 17);
            label5.TabIndex = 5;
            label5.Text = "Foot";
            // 
            // Yard
            // 
            Yard.AutoSize = true;
            Yard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yard.Location = new Point(65, 325);
            Yard.Name = "Yard";
            Yard.Size = new Size(31, 15);
            Yard.TabIndex = 6;
            Yard.Text = "Yard";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 370);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 7;
            label7.Text = "Mile";
            // 
            // inchoutput
            // 
            inchoutput.AutoSize = true;
            inchoutput.Location = new Point(298, 221);
            inchoutput.Name = "inchoutput";
            inchoutput.Size = new Size(0, 15);
            inchoutput.TabIndex = 8;
            // 
            // footoutput
            // 
            footoutput.AutoSize = true;
            footoutput.Location = new Point(298, 262);
            footoutput.Name = "footoutput";
            footoutput.Size = new Size(0, 15);
            footoutput.TabIndex = 9;
            // 
            // outputinch
            // 
            outputinch.AutoSize = true;
            outputinch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputinch.Location = new Point(321, 221);
            outputinch.Name = "outputinch";
            outputinch.Size = new Size(14, 15);
            outputinch.TabIndex = 10;
            outputinch.Text = "0";
            // 
            // outputfoot
            // 
            outputfoot.AutoSize = true;
            outputfoot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputfoot.Location = new Point(321, 275);
            outputfoot.Name = "outputfoot";
            outputfoot.Size = new Size(14, 15);
            outputfoot.TabIndex = 11;
            outputfoot.Text = "0";
            // 
            // outputyard
            // 
            outputyard.AutoSize = true;
            outputyard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputyard.Location = new Point(321, 325);
            outputyard.Name = "outputyard";
            outputyard.Size = new Size(14, 15);
            outputyard.TabIndex = 12;
            outputyard.Text = "0";
            // 
            // outputmile
            // 
            outputmile.AutoSize = true;
            outputmile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputmile.Location = new Point(321, 370);
            outputmile.Name = "outputmile";
            outputmile.Size = new Size(14, 15);
            outputmile.TabIndex = 13;
            outputmile.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(outputmile);
            Controls.Add(outputyard);
            Controls.Add(outputfoot);
            Controls.Add(outputinch);
            Controls.Add(footoutput);
            Controls.Add(inchoutput);
            Controls.Add(label7);
            Controls.Add(Yard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(meterinputupdown);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)meterinputupdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown meterinputupdown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Yard;
        private Label label7;
        private Label inchoutput;
        private Label footoutput;
        private Label outputinch;
        private Label outputfoot;
        private Label outputyard;
        private Label outputmile;
    }
}
