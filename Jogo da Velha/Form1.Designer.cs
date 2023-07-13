namespace Jogo_da_Velha
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnRecomecar = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 35);
            btn1.Name = "btn1";
            btn1.Size = new Size(188, 70);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(246, 35);
            btn2.Name = "btn2";
            btn2.Size = new Size(188, 70);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(473, 35);
            btn3.Name = "btn3";
            btn3.Size = new Size(188, 70);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(12, 147);
            btn4.Name = "btn4";
            btn4.Size = new Size(188, 70);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(246, 147);
            btn5.Name = "btn5";
            btn5.Size = new Size(188, 70);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(473, 147);
            btn6.Name = "btn6";
            btn6.Size = new Size(188, 70);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(12, 260);
            btn7.Name = "btn7";
            btn7.Size = new Size(188, 70);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(246, 260);
            btn8.Name = "btn8";
            btn8.Size = new Size(188, 70);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(473, 260);
            btn9.Name = "btn9";
            btn9.Size = new Size(188, 70);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnRecomecar
            // 
            btnRecomecar.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecomecar.Location = new Point(68, 368);
            btnRecomecar.Name = "btnRecomecar";
            btnRecomecar.Size = new Size(528, 70);
            btnRecomecar.TabIndex = 9;
            btnRecomecar.Text = "Recomeçar";
            btnRecomecar.UseVisualStyleBackColor = true;
            btnRecomecar.Click += btnRecomecar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(btnRecomecar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Velha";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnRecomecar;
    }
}