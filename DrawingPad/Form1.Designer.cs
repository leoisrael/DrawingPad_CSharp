
namespace DrawingPad
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.limeBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.yellowBox = new System.Windows.Forms.PictureBox();
            this.aquaBox = new System.Windows.Forms.PictureBox();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 450);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.blackBox);
            this.panel1.Controls.Add(this.pinkBox);
            this.panel1.Controls.Add(this.aquaBox);
            this.panel1.Controls.Add(this.yellowBox);
            this.panel1.Controls.Add(this.blueBox);
            this.panel1.Controls.Add(this.limeBox);
            this.panel1.Controls.Add(this.redBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 80);
            this.panel1.TabIndex = 0;
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(9, 10);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(18, 63);
            this.redBox.TabIndex = 1;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // limeBox
            // 
            this.limeBox.BackColor = System.Drawing.Color.Lime;
            this.limeBox.Location = new System.Drawing.Point(33, 10);
            this.limeBox.Name = "limeBox";
            this.limeBox.Size = new System.Drawing.Size(18, 63);
            this.limeBox.TabIndex = 1;
            this.limeBox.TabStop = false;
            this.limeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(57, 10);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(18, 63);
            this.blueBox.TabIndex = 1;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // yellowBox
            // 
            this.yellowBox.BackColor = System.Drawing.Color.Yellow;
            this.yellowBox.Location = new System.Drawing.Point(81, 10);
            this.yellowBox.Name = "yellowBox";
            this.yellowBox.Size = new System.Drawing.Size(18, 63);
            this.yellowBox.TabIndex = 1;
            this.yellowBox.TabStop = false;
            this.yellowBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // aquaBox
            // 
            this.aquaBox.BackColor = System.Drawing.Color.Aqua;
            this.aquaBox.Location = new System.Drawing.Point(105, 10);
            this.aquaBox.Name = "aquaBox";
            this.aquaBox.Size = new System.Drawing.Size(18, 63);
            this.aquaBox.TabIndex = 1;
            this.aquaBox.TabStop = false;
            this.aquaBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // pinkBox
            // 
            this.pinkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pinkBox.Location = new System.Drawing.Point(129, 10);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(18, 63);
            this.pinkBox.TabIndex = 1;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(153, 10);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(18, 63);
            this.blackBox.TabIndex = 1;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox blackBox;
        private System.Windows.Forms.PictureBox pinkBox;
        private System.Windows.Forms.PictureBox aquaBox;
        private System.Windows.Forms.PictureBox yellowBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox limeBox;
        private System.Windows.Forms.PictureBox redBox;
    }
}

