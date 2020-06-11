namespace dynamite
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
            this.picCount = new System.Windows.Forms.TextBox();
            this.picCapacity = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // picCount
            // 
            this.picCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picCount.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picCount.ForeColor = System.Drawing.Color.Purple;
            this.picCount.Location = new System.Drawing.Point(12, 12);
            this.picCount.Multiline = true;
            this.picCount.Name = "picCount";
            this.picCount.ReadOnly = true;
            this.picCount.Size = new System.Drawing.Size(163, 32);
            this.picCount.TabIndex = 0;
            this.picCount.Text = "COUNT = 0000";
            this.picCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picCapacity
            // 
            this.picCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picCapacity.Font = new System.Drawing.Font("Poplar Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picCapacity.ForeColor = System.Drawing.Color.Purple;
            this.picCapacity.Location = new System.Drawing.Point(181, 12);
            this.picCapacity.Multiline = true;
            this.picCapacity.Name = "picCapacity";
            this.picCapacity.ReadOnly = true;
            this.picCapacity.Size = new System.Drawing.Size(182, 32);
            this.picCapacity.TabIndex = 1;
            this.picCapacity.Text = "CAPACITY = 0000";
            this.picCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.picCapacity);
            this.Controls.Add(this.picCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox picCount;
        private System.Windows.Forms.TextBox picCapacity;
        private System.Windows.Forms.Timer timer1;
    }
}

