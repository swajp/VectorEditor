namespace VectorEditor_IT3B
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
            this.pboxCanvas = new System.Windows.Forms.PictureBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numRadius = new System.Windows.Forms.NumericUpDown();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCanvas
            // 
            this.pboxCanvas.BackColor = System.Drawing.Color.White;
            this.pboxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxCanvas.Location = new System.Drawing.Point(0, 0);
            this.pboxCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.pboxCanvas.Name = "pboxCanvas";
            this.pboxCanvas.Size = new System.Drawing.Size(857, 458);
            this.pboxCanvas.TabIndex = 0;
            this.pboxCanvas.TabStop = false;
            this.pboxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxCanvas_Paint);
            this.pboxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pboxCanvas_MouseClick);
            this.pboxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCanvas_MouseMove);
            // 
            // sfd
            // 
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numRadius);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnLanguage);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnPoint);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 458);
            this.panel1.TabIndex = 1;
            // 
            // numRadius
            // 
            this.numRadius.Location = new System.Drawing.Point(12, 394);
            this.numRadius.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadius.Name = "numRadius";
            this.numRadius.Size = new System.Drawing.Size(65, 23);
            this.numRadius.TabIndex = 1;
            this.numRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadius.ValueChanged += new System.EventHandler(this.numRadius_ValueChanged);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 70);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Kruh";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Location = new System.Drawing.Point(12, 423);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(37, 23);
            this.btnLanguage.TabIndex = 0;
            this.btnLanguage.Text = "CZ";
            this.btnLanguage.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 41);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Úsečka";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(12, 12);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 23);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Bod";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pboxCanvas);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCanvas;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.NumericUpDown numRadius;
    }
}

