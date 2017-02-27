namespace command
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
            this.Execute = new System.Windows.Forms.Button();
            this.UnExecute = new System.Windows.Forms.Button();
            this.First = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.DrawDots = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(16, 215);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(131, 25);
            this.Execute.TabIndex = 27;
            this.Execute.Text = "Закрасить";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // UnExecute
            // 
            this.UnExecute.Location = new System.Drawing.Point(16, 246);
            this.UnExecute.Name = "UnExecute";
            this.UnExecute.Size = new System.Drawing.Size(131, 25);
            this.UnExecute.TabIndex = 27;
            this.UnExecute.Text = "Отменить действие";
            this.UnExecute.UseVisualStyleBackColor = true;
            this.UnExecute.Click += new System.EventHandler(this.UnExecute_Click);
            // 
            // First
            // 
            this.First.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First.Location = new System.Drawing.Point(16, 176);
            this.First.Multiline = true;
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(78, 24);
            this.First.TabIndex = 28;
            this.First.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(218, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 174);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 166);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(19, 58);
            this.Count.Multiline = true;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(78, 24);
            this.Count.TabIndex = 28;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DrawDots
            // 
            this.DrawDots.Location = new System.Drawing.Point(19, 88);
            this.DrawDots.Name = "DrawDots";
            this.DrawDots.Size = new System.Drawing.Size(128, 25);
            this.DrawDots.TabIndex = 27;
            this.DrawDots.Text = "Нарисовать вершины";
            this.DrawDots.UseVisualStyleBackColor = true;
            this.DrawDots.Click += new System.EventHandler(this.DrawDots_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow",
            "Green"});
            this.comboBox1.Location = new System.Drawing.Point(100, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 558);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.First);
            this.Controls.Add(this.UnExecute);
            this.Controls.Add(this.DrawDots);
            this.Controls.Add(this.Execute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button UnExecute;
        private System.Windows.Forms.TextBox First;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button DrawDots;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

