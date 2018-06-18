namespace NumberView
{
    partial class View
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
            this.lbl_Range = new System.Windows.Forms.Label();
            this.btn_Brown = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.txt_Guess = new System.Windows.Forms.TextBox();
            this.btn_Guess = new System.Windows.Forms.Button();
            this.btn_Retry = new System.Windows.Forms.Button();
            this.pnl_Paint = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Hint = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_PaintZone = new System.Windows.Forms.Label();
            this.pnl_Paint.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Range
            // 
            this.lbl_Range.AutoSize = true;
            this.lbl_Range.Location = new System.Drawing.Point(17, 49);
            this.lbl_Range.Name = "lbl_Range";
            this.lbl_Range.Size = new System.Drawing.Size(90, 13);
            this.lbl_Range.TabIndex = 0;
            this.lbl_Range.Text = "Range 1 - 50000:";
            // 
            // btn_Brown
            // 
            this.btn_Brown.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Brown.Location = new System.Drawing.Point(15, 3);
            this.btn_Brown.Name = "btn_Brown";
            this.btn_Brown.Size = new System.Drawing.Size(27, 23);
            this.btn_Brown.TabIndex = 1;
            this.btn_Brown.UseVisualStyleBackColor = false;
            this.btn_Brown.Click += new System.EventHandler(this.btn_Brown_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Location = new System.Drawing.Point(48, 3);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(27, 23);
            this.btn_Red.TabIndex = 2;
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // txt_Guess
            // 
            this.txt_Guess.Location = new System.Drawing.Point(113, 46);
            this.txt_Guess.Name = "txt_Guess";
            this.txt_Guess.Size = new System.Drawing.Size(100, 20);
            this.txt_Guess.TabIndex = 3;
            // 
            // btn_Guess
            // 
            this.btn_Guess.Location = new System.Drawing.Point(20, 107);
            this.btn_Guess.Name = "btn_Guess";
            this.btn_Guess.Size = new System.Drawing.Size(75, 23);
            this.btn_Guess.TabIndex = 4;
            this.btn_Guess.Text = "Guess";
            this.btn_Guess.UseVisualStyleBackColor = true;
            this.btn_Guess.Click += new System.EventHandler(this.btn_Guess_Click);
            // 
            // btn_Retry
            // 
            this.btn_Retry.Location = new System.Drawing.Point(138, 107);
            this.btn_Retry.Name = "btn_Retry";
            this.btn_Retry.Size = new System.Drawing.Size(75, 23);
            this.btn_Retry.TabIndex = 5;
            this.btn_Retry.Text = "Retry";
            this.btn_Retry.UseVisualStyleBackColor = true;
            this.btn_Retry.Click += new System.EventHandler(this.btn_Retry_Click);
            // 
            // pnl_Paint
            // 
            this.pnl_Paint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Paint.Controls.Add(this.lbl_PaintZone);
            this.pnl_Paint.Location = new System.Drawing.Point(214, -11);
            this.pnl_Paint.Name = "pnl_Paint";
            this.pnl_Paint.Size = new System.Drawing.Size(173, 144);
            this.pnl_Paint.TabIndex = 6;
            this.pnl_Paint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint_Paint);
            this.pnl_Paint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Paint_MouseMove);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Main.Controls.Add(this.lbl_Temp);
            this.pnl_Main.Controls.Add(this.lbl_Hint);
            this.pnl_Main.Controls.Add(this.txt_Guess);
            this.pnl_Main.Controls.Add(this.btn_Retry);
            this.pnl_Main.Controls.Add(this.lbl_Range);
            this.pnl_Main.Controls.Add(this.btn_Guess);
            this.pnl_Main.Location = new System.Drawing.Point(-5, -11);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(220, 144);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_Hint
            // 
            this.lbl_Hint.AutoSize = true;
            this.lbl_Hint.Location = new System.Drawing.Point(17, 75);
            this.lbl_Hint.Name = "lbl_Hint";
            this.lbl_Hint.Size = new System.Drawing.Size(29, 13);
            this.lbl_Hint.TabIndex = 6;
            this.lbl_Hint.Text = "Hint:";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Location = new System.Drawing.Point(50, 75);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(0, 13);
            this.lbl_Temp.TabIndex = 7;
            // 
            // lbl_PaintZone
            // 
            this.lbl_PaintZone.AutoSize = true;
            this.lbl_PaintZone.Location = new System.Drawing.Point(6, 12);
            this.lbl_PaintZone.Name = "lbl_PaintZone";
            this.lbl_PaintZone.Size = new System.Drawing.Size(62, 13);
            this.lbl_PaintZone.TabIndex = 0;
            this.lbl_PaintZone.Text = "Paint Zone:";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 124);
            this.Controls.Add(this.pnl_Paint);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Brown);
            this.Controls.Add(this.pnl_Main);
            this.Name = "View";
            this.Text = "View";
            this.pnl_Paint.ResumeLayout(false);
            this.pnl_Paint.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Range;
        private System.Windows.Forms.Button btn_Brown;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.TextBox txt_Guess;
        private System.Windows.Forms.Button btn_Guess;
        private System.Windows.Forms.Button btn_Retry;
        private System.Windows.Forms.Panel pnl_Paint;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Hint;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.Label lbl_PaintZone;
    }
}