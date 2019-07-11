namespace MemoryGame
{
    partial class frm_MemoryGame
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
            this.components = new System.ComponentModel.Container();
            this.FreezeTime = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Timer(this.components);
            this.NotMatch = new System.Windows.Forms.Timer(this.components);
            this.lbl_ScoreCounter = new System.Windows.Forms.Label();
            this.lbl_FreezeTime = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_PlayerName = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_moves = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_s = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FreezeTime
            // 
            this.FreezeTime.Interval = 1000;
            this.FreezeTime.Tick += new System.EventHandler(this.FreezeTime_Tick);
            // 
            // Start
            // 
            this.Start.Interval = 5000;
            this.Start.Tick += new System.EventHandler(this.Start_Tick);
            // 
            // NotMatch
            // 
            this.NotMatch.Interval = 500;
            this.NotMatch.Tick += new System.EventHandler(this.NotMatch_Tick);
            // 
            // lbl_ScoreCounter
            // 
            this.lbl_ScoreCounter.AutoSize = true;
            this.lbl_ScoreCounter.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScoreCounter.Location = new System.Drawing.Point(178, 212);
            this.lbl_ScoreCounter.Name = "lbl_ScoreCounter";
            this.lbl_ScoreCounter.Size = new System.Drawing.Size(14, 18);
            this.lbl_ScoreCounter.TabIndex = 15;
            this.lbl_ScoreCounter.Text = "0";
            // 
            // lbl_FreezeTime
            // 
            this.lbl_FreezeTime.AutoSize = true;
            this.lbl_FreezeTime.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FreezeTime.Location = new System.Drawing.Point(95, 359);
            this.lbl_FreezeTime.Name = "lbl_FreezeTime";
            this.lbl_FreezeTime.Size = new System.Drawing.Size(33, 33);
            this.lbl_FreezeTime.TabIndex = 14;
            this.lbl_FreezeTime.Text = "5";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(178, 152);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(14, 18);
            this.lbl_size.TabIndex = 13;
            this.lbl_size.Text = "0";
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerName.Location = new System.Drawing.Point(149, 92);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(35, 18);
            this.lbl_PlayerName.TabIndex = 12;
            this.lbl_PlayerName.Text = "name";
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAgain.Location = new System.Drawing.Point(50, 444);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(142, 35);
            this.btn_PlayAgain.TabIndex = 17;
            this.btn_PlayAgain.Text = "PLAY AGAIN";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbl_s);
            this.panel1.Controls.Add(this.lbl_min);
            this.panel1.Controls.Add(this.lbl_moves);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_PlayAgain);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_FreezeTime);
            this.panel1.Controls.Add(this.lbl_ScoreCounter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_PlayerName);
            this.panel1.Controls.Add(this.lbl_size);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(763, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 561);
            this.panel1.TabIndex = 18;
            // 
            // lbl_moves
            // 
            this.lbl_moves.AutoSize = true;
            this.lbl_moves.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moves.Location = new System.Drawing.Point(178, 272);
            this.lbl_moves.Name = "lbl_moves";
            this.lbl_moves.Size = new System.Drawing.Size(14, 18);
            this.lbl_moves.TabIndex = 19;
            this.lbl_moves.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Moves :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Playground size :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Player Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Game Details";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(9, 316);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(13, 13);
            this.lbl_min.TabIndex = 21;
            this.lbl_min.Text = "0";
            // 
            // lbl_s
            // 
            this.lbl_s.AutoSize = true;
            this.lbl_s.Location = new System.Drawing.Point(47, 316);
            this.lbl_s.Name = "lbl_s";
            this.lbl_s.Size = new System.Drawing.Size(13, 13);
            this.lbl_s.TabIndex = 22;
            this.lbl_s.Text = "0";
            // 
            // frm_MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "frm_MemoryGame";
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.frm_MemoryGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FreezeTime;
        private System.Windows.Forms.Timer Start;
        private System.Windows.Forms.Timer NotMatch;
        private System.Windows.Forms.Label lbl_ScoreCounter;
        private System.Windows.Forms.Label lbl_FreezeTime;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_PlayerName;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_moves;
        private System.Windows.Forms.Label lbl_s;
        private System.Windows.Forms.Label lbl_min;
    }
}