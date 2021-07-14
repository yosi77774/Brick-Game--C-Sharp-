namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.Point_lbl2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Point_lbl = new System.Windows.Forms.Label();
            this.Losses_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.White;
            this.playground.Controls.Add(this.Point_lbl2);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.hScrollBar1);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.start);
            this.playground.Controls.Add(this.Point_lbl);
            this.playground.Controls.Add(this.Losses_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.Racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1254, 545);
            this.playground.TabIndex = 0;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            this.playground.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.playground_PreviewKeyDown);
            // 
            // Point_lbl2
            // 
            this.Point_lbl2.AutoSize = true;
            this.Point_lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Point_lbl2.Location = new System.Drawing.Point(145, 61);
            this.Point_lbl2.Name = "Point_lbl2";
            this.Point_lbl2.Size = new System.Drawing.Size(32, 36);
            this.Point_lbl2.TabIndex = 11;
            this.Point_lbl2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "points :";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hScrollBar1.Location = new System.Drawing.Point(459, 112);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(342, 49);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(453, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecting a difficulty level";
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.BackColor = System.Drawing.Color.DarkTurquoise;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start.Location = new System.Drawing.Point(595, 24);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(80, 49);
            this.start.TabIndex = 7;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Point_lbl
            // 
            this.Point_lbl.AutoSize = true;
            this.Point_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Point_lbl.Location = new System.Drawing.Point(145, 13);
            this.Point_lbl.Name = "Point_lbl";
            this.Point_lbl.Size = new System.Drawing.Size(32, 36);
            this.Point_lbl.TabIndex = 3;
            this.Point_lbl.Text = "0";
            // 
            // Losses_lbl
            // 
            this.Losses_lbl.AutoSize = true;
            this.Losses_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Losses_lbl.Location = new System.Drawing.Point(13, 13);
            this.Losses_lbl.Name = "Losses_lbl";
            this.Losses_lbl.Size = new System.Drawing.Size(126, 36);
            this.Losses_lbl.TabIndex = 2;
            this.Losses_lbl.Text = "Losses :";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.RoyalBlue;
            this.ball.Image = global::WindowsFormsApp2.Properties.Resources.כדור_של_כדורגל_זהב_איקון_איור_סטוק_csp17905268;
            this.ball.Location = new System.Drawing.Point(358, 24);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Racket.BackColor = System.Drawing.Color.Black;
            this.Racket.Location = new System.Drawing.Point(228, 418);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(150, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 545);
            this.Controls.Add(this.playground);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Point_lbl;
        private System.Windows.Forms.Label Losses_lbl;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Point_lbl2;
    }
}

