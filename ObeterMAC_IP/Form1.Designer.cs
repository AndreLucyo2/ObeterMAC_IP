namespace ObeterMAC_IP
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
            this.BTN_MAC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_MAC
            // 
            this.BTN_MAC.Location = new System.Drawing.Point(175, 51);
            this.BTN_MAC.Name = "BTN_MAC";
            this.BTN_MAC.Size = new System.Drawing.Size(75, 23);
            this.BTN_MAC.TabIndex = 0;
            this.BTN_MAC.Text = "Obter MAC";
            this.BTN_MAC.UseVisualStyleBackColor = true;
            this.BTN_MAC.Click += new System.EventHandler(this.BTN_MAC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAC:";
            // 
            // textMAC
            // 
            this.textMAC.Location = new System.Drawing.Point(24, 25);
            this.textMAC.Name = "textMAC";
            this.textMAC.ReadOnly = true;
            this.textMAC.Size = new System.Drawing.Size(226, 20);
            this.textMAC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(130, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "andre.lucy2@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_MAC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obter MAC PC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_MAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMAC;
        private System.Windows.Forms.Label label2;
    }
}

