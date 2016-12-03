namespace TicTacToe
{
    partial class frmPvP
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
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Label();
            this.P1_Win_Count = new System.Windows.Forms.Label();
            this.P2_Win_Count = new System.Windows.Forms.Label();
            this.Draw_Count = new System.Windows.Forms.Label();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.txtSignP1 = new System.Windows.Forms.TextBox();
            this.txtSignP2 = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(16, 68);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 6;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.fieldClick);
            this.A1.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.A1.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(97, 68);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 7;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.fieldClick);
            this.B1.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.B1.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C1.Location = new System.Drawing.Point(178, 68);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.fieldClick);
            this.C1.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.C1.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A2.Location = new System.Drawing.Point(16, 149);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 9;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.fieldClick);
            this.A2.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.A2.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B2.Location = new System.Drawing.Point(97, 149);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 10;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.fieldClick);
            this.B2.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.B2.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C2.Location = new System.Drawing.Point(178, 149);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 11;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.fieldClick);
            this.C2.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.C2.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(16, 230);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 12;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.fieldClick);
            this.A3.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.A3.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B3.Location = new System.Drawing.Point(97, 230);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 13;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.fieldClick);
            this.B3.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.B3.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C3.Location = new System.Drawing.Point(178, 230);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 14;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.fieldClick);
            this.C3.MouseEnter += new System.EventHandler(this.MouseEnterButton);
            this.C3.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(111, 32);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(44, 13);
            this.Draw.TabIndex = 11;
            this.Draw.Text = "Remisy:";
            // 
            // P1_Win_Count
            // 
            this.P1_Win_Count.AutoSize = true;
            this.P1_Win_Count.Location = new System.Drawing.Point(47, 52);
            this.P1_Win_Count.Name = "P1_Win_Count";
            this.P1_Win_Count.Size = new System.Drawing.Size(13, 13);
            this.P1_Win_Count.TabIndex = 13;
            this.P1_Win_Count.Text = "0";
            // 
            // P2_Win_Count
            // 
            this.P2_Win_Count.AutoSize = true;
            this.P2_Win_Count.Location = new System.Drawing.Point(208, 52);
            this.P2_Win_Count.Name = "P2_Win_Count";
            this.P2_Win_Count.Size = new System.Drawing.Size(13, 13);
            this.P2_Win_Count.TabIndex = 14;
            this.P2_Win_Count.Text = "0";
            // 
            // Draw_Count
            // 
            this.Draw_Count.AutoSize = true;
            this.Draw_Count.Location = new System.Drawing.Point(125, 51);
            this.Draw_Count.Name = "Draw_Count";
            this.Draw_Count.Size = new System.Drawing.Size(13, 13);
            this.Draw_Count.TabIndex = 15;
            this.Draw_Count.Text = "0";
            // 
            // txtNameP2
            // 
            this.txtNameP2.Location = new System.Drawing.Point(190, 29);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(73, 20);
            this.txtNameP2.TabIndex = 4;
            this.txtNameP2.Text = "Gracz 2";
            this.txtNameP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameP1
            // 
            this.txtNameP1.Location = new System.Drawing.Point(7, 29);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(73, 20);
            this.txtNameP1.TabIndex = 1;
            this.txtNameP1.Text = "Gracz 1";
            this.txtNameP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignP1
            // 
            this.txtSignP1.Location = new System.Drawing.Point(81, 29);
            this.txtSignP1.Name = "txtSignP1";
            this.txtSignP1.Size = new System.Drawing.Size(24, 20);
            this.txtSignP1.TabIndex = 2;
            this.txtSignP1.Text = "X";
            this.txtSignP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignP2
            // 
            this.txtSignP2.Location = new System.Drawing.Point(165, 29);
            this.txtSignP2.Name = "txtSignP2";
            this.txtSignP2.Size = new System.Drawing.Size(24, 20);
            this.txtSignP2.TabIndex = 3;
            this.txtSignP2.Text = "O";
            this.txtSignP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(7, 3);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(83, 23);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPvP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.txtSignP2);
            this.Controls.Add(this.txtSignP1);
            this.Controls.Add(this.txtNameP1);
            this.Controls.Add(this.txtNameP2);
            this.Controls.Add(this.Draw_Count);
            this.Controls.Add(this.P2_Win_Count);
            this.Controls.Add(this.P1_Win_Count);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.MaximizeBox = false;
            this.Name = "frmPvP";
            this.ShowIcon = false;
            this.Text = "Kółko krzyżyk -> PvP";
            this.Load += new System.EventHandler(this.frmPvP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label P1_Win_Count;
        private System.Windows.Forms.Label P2_Win_Count;
        private System.Windows.Forms.Label Draw_Count;
        private System.Windows.Forms.TextBox txtNameP2;
        private System.Windows.Forms.TextBox txtNameP1;
        private System.Windows.Forms.TextBox txtSignP1;
        private System.Windows.Forms.TextBox txtSignP2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

