namespace QeydlerWinForms
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
            this.txtQeyd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxQeydler = new System.Windows.Forms.ListBox();
            this.txtAcarSoz = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQeyd
            // 
            this.txtQeyd.Location = new System.Drawing.Point(22, 45);
            this.txtQeyd.Name = "txtQeyd";
            this.txtQeyd.Size = new System.Drawing.Size(134, 22);
            this.txtQeyd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yeni qeyd elave et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxQeydler
            // 
            this.listBoxQeydler.FormattingEnabled = true;
            this.listBoxQeydler.ItemHeight = 16;
            this.listBoxQeydler.Location = new System.Drawing.Point(192, 94);
            this.listBoxQeydler.Name = "listBoxQeydler";
            this.listBoxQeydler.Size = new System.Drawing.Size(299, 148);
            this.listBoxQeydler.TabIndex = 2;
            this.listBoxQeydler.SelectedIndexChanged += new System.EventHandler(this.ListBoxQeydler_SelectedIndexChanged);
            // 
            // txtAcarSoz
            // 
            this.txtAcarSoz.Location = new System.Drawing.Point(22, 296);
            this.txtAcarSoz.Name = "txtAcarSoz";
            this.txtAcarSoz.Size = new System.Drawing.Size(100, 22);
            this.txtAcarSoz.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Qeyd axtar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(610, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Qeydleri sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAcarSoz);
            this.Controls.Add(this.listBoxQeydler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQeyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQeyd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxQeydler;
        private System.Windows.Forms.TextBox txtAcarSoz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

