﻿namespace HexExExample {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new Label();
            this.txtValue = new TextBox();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.txtBase16 = new TextBox();
            this.txtBaseA = new TextBox();
            this.txtBaseB = new TextBox();
            this.radioButton16 = new RadioButton();
            this.radioButtonA = new RadioButton();
            this.radioButtonB = new RadioButton();
            this.radioButton10 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.txtBase10 = new TextBox();
            this.label5 = new Label();
            this.txtBase2 = new TextBox();
            this.label7 = new Label();
            this.txtBase8 = new TextBox();
            this.label6 = new Label();
            this.button1 = new Button();
            this.cmdRandom = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtValue
            // 
            this.txtValue.Location = new Point(12, 286);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new Size(282, 33);
            this.txtValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(371, 137);
            this.label2.Name = "label2";
            this.label2.Size = new Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base 16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(371, 176);
            this.label3.Name = "label3";
            this.label3.Size = new Size(76, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Base 35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(371, 215);
            this.label4.Name = "label4";
            this.label4.Size = new Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Base 56";
            // 
            // txtBase16
            // 
            this.txtBase16.Location = new Point(453, 133);
            this.txtBase16.Name = "txtBase16";
            this.txtBase16.ReadOnly = true;
            this.txtBase16.Size = new Size(427, 33);
            this.txtBase16.TabIndex = 5;
            // 
            // txtBaseA
            // 
            this.txtBaseA.Location = new Point(453, 172);
            this.txtBaseA.Name = "txtBaseA";
            this.txtBaseA.ReadOnly = true;
            this.txtBaseA.Size = new Size(427, 33);
            this.txtBaseA.TabIndex = 7;
            // 
            // txtBaseB
            // 
            this.txtBaseB.Location = new Point(453, 211);
            this.txtBaseB.Name = "txtBaseB";
            this.txtBaseB.ReadOnly = true;
            this.txtBaseB.Size = new Size(427, 33);
            this.txtBaseB.TabIndex = 8;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new Point(29, 82);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new Size(94, 29);
            this.radioButton16.TabIndex = 9;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "Base 16";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new Point(29, 117);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new Size(94, 29);
            this.radioButtonA.TabIndex = 10;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "Base 35";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new Point(29, 153);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new Size(94, 29);
            this.radioButtonB.TabIndex = 11;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Base 56";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new Point(29, 47);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new Size(94, 29);
            this.radioButton10.TabIndex = 12;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Base 10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new Point(29, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(84, 29);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Base 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtBase10
            // 
            this.txtBase10.Location = new Point(453, 94);
            this.txtBase10.Name = "txtBase10";
            this.txtBase10.ReadOnly = true;
            this.txtBase10.Size = new Size(427, 33);
            this.txtBase10.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(371, 98);
            this.label5.Name = "label5";
            this.label5.Size = new Size(76, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Base 10";
            // 
            // txtBase2
            // 
            this.txtBase2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBase2.Location = new Point(453, 16);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.ReadOnly = true;
            this.txtBase2.Size = new Size(427, 33);
            this.txtBase2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(371, 20);
            this.label7.Name = "label7";
            this.label7.Size = new Size(66, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Base 2";
            // 
            // txtBase8
            // 
            this.txtBase8.Location = new Point(453, 55);
            this.txtBase8.Name = "txtBase8";
            this.txtBase8.ReadOnly = true;
            this.txtBase8.Size = new Size(427, 33);
            this.txtBase8.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(371, 59);
            this.label6.Name = "label6";
            this.label6.Size = new Size(66, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Base 8";
            // 
            // button1
            // 
            this.button1.Location = new Point(190, 70);
            this.button1.Name = "button1";
            this.button1.Size = new Size(126, 76);
            this.button1.TabIndex = 24;
            this.button1.Text = "NOT READY YET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new Point(300, 286);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new Size(99, 33);
            this.cmdRandom.TabIndex = 25;
            this.cmdRandom.Text = "RND";
            this.cmdRandom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(892, 331);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBase8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBase2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBase10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.radioButton16);
            this.Controls.Add(this.txtBaseB);
            this.Controls.Add(this.txtBaseA);
            this.Controls.Add(this.txtBase16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "HexEx Example v2.00";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValue;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBase16;
        private TextBox txtBaseA;
        private TextBox txtBaseB;
        private RadioButton radioButton16;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private RadioButton radioButton10;
        private RadioButton radioButton2;
        private TextBox txtBase10;
        private Label label5;
        private TextBox txtBase2;
        private Label label7;
        private TextBox txtBase8;
        private Label label6;
        private Button button1;
        private Button cmdRandom;
    }
}
