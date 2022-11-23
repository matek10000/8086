namespace CPUproject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wykonbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.wybor2 = new System.Windows.Forms.RadioButton();
            this.wybor1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ax1 = new System.Windows.Forms.RadioButton();
            this.bx1 = new System.Windows.Forms.RadioButton();
            this.cx1 = new System.Windows.Forms.RadioButton();
            this.dx1 = new System.Windows.Forms.RadioButton();
            this.ax2 = new System.Windows.Forms.RadioButton();
            this.bx2 = new System.Windows.Forms.RadioButton();
            this.cx2 = new System.Windows.Forms.RadioButton();
            this.dx2 = new System.Windows.Forms.RadioButton();
            this.resetbut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wynik1 = new System.Windows.Forms.Label();
            this.wynik2 = new System.Windows.Forms.Label();
            this.wynik3 = new System.Windows.Forms.Label();
            this.wynik4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wykonbut
            // 
            this.wykonbut.BackColor = System.Drawing.SystemColors.Menu;
            this.wykonbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wykonbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wykonbut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wykonbut.ForeColor = System.Drawing.Color.DarkGreen;
            this.wykonbut.Location = new System.Drawing.Point(318, 185);
            this.wykonbut.Name = "wykonbut";
            this.wykonbut.Size = new System.Drawing.Size(89, 34);
            this.wykonbut.TabIndex = 0;
            this.wykonbut.Text = "WYKONAJ";
            this.wykonbut.UseVisualStyleBackColor = false;
            this.wykonbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(-4, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(729, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "8086 Simulator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wybor2
            // 
            this.wybor2.Appearance = System.Windows.Forms.Appearance.Button;
            this.wybor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wybor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wybor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wybor2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wybor2.Location = new System.Drawing.Point(393, 47);
            this.wybor2.Name = "wybor2";
            this.wybor2.Size = new System.Drawing.Size(95, 38);
            this.wybor2.TabIndex = 4;
            this.wybor2.TabStop = true;
            this.wybor2.Text = "XCHG";
            this.wybor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wybor2.UseVisualStyleBackColor = false;
            // 
            // wybor1
            // 
            this.wybor1.Appearance = System.Windows.Forms.Appearance.Button;
            this.wybor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.wybor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wybor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wybor1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wybor1.Location = new System.Drawing.Point(236, 47);
            this.wybor1.Name = "wybor1";
            this.wybor1.Size = new System.Drawing.Size(95, 38);
            this.wybor1.TabIndex = 5;
            this.wybor1.TabStop = true;
            this.wybor1.Text = "MOV";
            this.wybor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wybor1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "FROM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(192, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "TO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ax1
            // 
            this.ax1.Appearance = System.Windows.Forms.Appearance.Button;
            this.ax1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ax1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ax1.Location = new System.Drawing.Point(107, 162);
            this.ax1.Name = "ax1";
            this.ax1.Size = new System.Drawing.Size(48, 37);
            this.ax1.TabIndex = 8;
            this.ax1.TabStop = true;
            this.ax1.Text = "AX";
            this.ax1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ax1.UseVisualStyleBackColor = true;
            // 
            // bx1
            // 
            this.bx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.bx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bx1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bx1.Location = new System.Drawing.Point(107, 217);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(48, 37);
            this.bx1.TabIndex = 9;
            this.bx1.TabStop = true;
            this.bx1.Text = "BX";
            this.bx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bx1.UseVisualStyleBackColor = true;
            // 
            // cx1
            // 
            this.cx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.cx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cx1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cx1.Location = new System.Drawing.Point(107, 270);
            this.cx1.Name = "cx1";
            this.cx1.Size = new System.Drawing.Size(48, 37);
            this.cx1.TabIndex = 10;
            this.cx1.TabStop = true;
            this.cx1.Text = "CX";
            this.cx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cx1.UseVisualStyleBackColor = true;
            // 
            // dx1
            // 
            this.dx1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dx1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dx1.Location = new System.Drawing.Point(107, 322);
            this.dx1.Name = "dx1";
            this.dx1.Size = new System.Drawing.Size(48, 37);
            this.dx1.TabIndex = 11;
            this.dx1.TabStop = true;
            this.dx1.Text = "DX";
            this.dx1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dx1.UseVisualStyleBackColor = true;
            // 
            // ax2
            // 
            this.ax2.Appearance = System.Windows.Forms.Appearance.Button;
            this.ax2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ax2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ax2.Location = new System.Drawing.Point(208, 162);
            this.ax2.Name = "ax2";
            this.ax2.Size = new System.Drawing.Size(48, 37);
            this.ax2.TabIndex = 12;
            this.ax2.TabStop = true;
            this.ax2.Text = "AX";
            this.ax2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ax2.UseVisualStyleBackColor = true;
            // 
            // bx2
            // 
            this.bx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.bx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bx2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bx2.Location = new System.Drawing.Point(208, 217);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(48, 37);
            this.bx2.TabIndex = 13;
            this.bx2.TabStop = true;
            this.bx2.Text = "BX";
            this.bx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bx2.UseVisualStyleBackColor = true;
            // 
            // cx2
            // 
            this.cx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cx2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cx2.Location = new System.Drawing.Point(208, 270);
            this.cx2.Name = "cx2";
            this.cx2.Size = new System.Drawing.Size(48, 37);
            this.cx2.TabIndex = 14;
            this.cx2.TabStop = true;
            this.cx2.Text = "CX";
            this.cx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cx2.UseVisualStyleBackColor = true;
            // 
            // dx2
            // 
            this.dx2.Appearance = System.Windows.Forms.Appearance.Button;
            this.dx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dx2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dx2.Location = new System.Drawing.Point(208, 322);
            this.dx2.Name = "dx2";
            this.dx2.Size = new System.Drawing.Size(48, 37);
            this.dx2.TabIndex = 15;
            this.dx2.TabStop = true;
            this.dx2.Text = "DX";
            this.dx2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dx2.UseVisualStyleBackColor = true;
            // 
            // resetbut
            // 
            this.resetbut.BackColor = System.Drawing.SystemColors.Menu;
            this.resetbut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetbut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetbut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetbut.ForeColor = System.Drawing.Color.Crimson;
            this.resetbut.Location = new System.Drawing.Point(318, 270);
            this.resetbut.Name = "resetbut";
            this.resetbut.Size = new System.Drawing.Size(89, 34);
            this.resetbut.TabIndex = 16;
            this.resetbut.Text = "RESETUJ";
            this.resetbut.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(443, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "WARTOŚCI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(461, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 206);
            this.label5.TabIndex = 18;
            this.label5.Text = "   AX:\r\n\r\n   BX:\r\n\r\n   CX:\r\n\r\n   DX:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wynik1
            // 
            this.wynik1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wynik1.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wynik1.Location = new System.Drawing.Point(527, 173);
            this.wynik1.Name = "wynik1";
            this.wynik1.Size = new System.Drawing.Size(28, 33);
            this.wynik1.TabIndex = 19;
            this.wynik1.Text = "1";
            this.wynik1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wynik2
            // 
            this.wynik2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wynik2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wynik2.Location = new System.Drawing.Point(524, 219);
            this.wynik2.Name = "wynik2";
            this.wynik2.Size = new System.Drawing.Size(30, 39);
            this.wynik2.TabIndex = 20;
            this.wynik2.Text = "2";
            this.wynik2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wynik2.Click += new System.EventHandler(this.label7_Click);
            // 
            // wynik3
            // 
            this.wynik3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wynik3.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wynik3.Location = new System.Drawing.Point(524, 270);
            this.wynik3.Name = "wynik3";
            this.wynik3.Size = new System.Drawing.Size(30, 37);
            this.wynik3.TabIndex = 21;
            this.wynik3.Text = "3";
            this.wynik3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wynik3.Click += new System.EventHandler(this.label8_Click);
            // 
            // wynik4
            // 
            this.wynik4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.wynik4.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wynik4.Location = new System.Drawing.Point(518, 323);
            this.wynik4.Name = "wynik4";
            this.wynik4.Size = new System.Drawing.Size(41, 33);
            this.wynik4.TabIndex = 22;
            this.wynik4.Text = "4";
            this.wynik4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wynik4.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 405);
            this.Controls.Add(this.wynik4);
            this.Controls.Add(this.wynik3);
            this.Controls.Add(this.wynik2);
            this.Controls.Add(this.wynik1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resetbut);
            this.Controls.Add(this.dx2);
            this.Controls.Add(this.cx2);
            this.Controls.Add(this.bx2);
            this.Controls.Add(this.ax2);
            this.Controls.Add(this.dx1);
            this.Controls.Add(this.cx1);
            this.Controls.Add(this.bx1);
            this.Controls.Add(this.ax1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wybor1);
            this.Controls.Add(this.wybor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wykonbut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symulator procesora 8086 (by Mateusz Dybaś)";
            this.ResumeLayout(false);

        }

        #endregion

        private Button wykonbut;
        private Label label2;
        private RadioButton wybor2;
        private RadioButton wybor1;
        private Label label1;
        private Label label3;
        private RadioButton ax1;
        private RadioButton bx1;
        private RadioButton cx1;
        private RadioButton dx1;
        private RadioButton ax2;
        private RadioButton bx2;
        private RadioButton cx2;
        private RadioButton dx2;
        private Button resetbut;
        private Label label4;
        private Label label5;
        private Label wynik1;
        private Label wynik2;
        private Label wynik3;
        private Label wynik4;
    }
}