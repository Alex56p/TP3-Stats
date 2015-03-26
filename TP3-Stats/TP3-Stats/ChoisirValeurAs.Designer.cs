namespace TP3_Stats
{
    partial class ChoisirValeurAs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_1 = new System.Windows.Forms.RadioButton();
            this.RB_11 = new System.Windows.Forms.RadioButton();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_11);
            this.groupBox1.Controls.Add(this.RB_1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valeur de l\'As";
            // 
            // RB_1
            // 
            this.RB_1.AutoSize = true;
            this.RB_1.Location = new System.Drawing.Point(7, 20);
            this.RB_1.Name = "RB_1";
            this.RB_1.Size = new System.Drawing.Size(31, 17);
            this.RB_1.TabIndex = 0;
            this.RB_1.TabStop = true;
            this.RB_1.Text = "1";
            this.RB_1.UseVisualStyleBackColor = true;
            this.RB_1.CheckedChanged += new System.EventHandler(this.RB_1_CheckedChanged);
            // 
            // RB_11
            // 
            this.RB_11.AutoSize = true;
            this.RB_11.Location = new System.Drawing.Point(7, 43);
            this.RB_11.Name = "RB_11";
            this.RB_11.Size = new System.Drawing.Size(37, 17);
            this.RB_11.TabIndex = 1;
            this.RB_11.TabStop = true;
            this.RB_11.Text = "11";
            this.RB_11.UseVisualStyleBackColor = true;
            this.RB_11.CheckedChanged += new System.EventHandler(this.RB_11_CheckedChanged);
            // 
            // BTN_OK
            // 
            this.BTN_OK.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_OK.Location = new System.Drawing.Point(37, 99);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 1;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = false;
            this.BTN_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoisirValeurAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 133);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChoisirValeurAs";
            this.Text = "Choisir...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_11;
        private System.Windows.Forms.RadioButton RB_1;
        private System.Windows.Forms.Button BTN_OK;
    }
}