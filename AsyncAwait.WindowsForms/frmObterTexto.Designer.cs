namespace AsyncAwait.WindowsForms
{
    partial class frmObterTexto
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
            this.txtExibeTexto = new System.Windows.Forms.TextBox();
            this.btnObterTexto = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtExibeTexto
            // 
            this.txtExibeTexto.Location = new System.Drawing.Point(23, 24);
            this.txtExibeTexto.Multiline = true;
            this.txtExibeTexto.Name = "txtExibeTexto";
            this.txtExibeTexto.Size = new System.Drawing.Size(502, 156);
            this.txtExibeTexto.TabIndex = 0;
            // 
            // btnObterTexto
            // 
            this.btnObterTexto.Location = new System.Drawing.Point(169, 202);
            this.btnObterTexto.Name = "btnObterTexto";
            this.btnObterTexto.Size = new System.Drawing.Size(182, 45);
            this.btnObterTexto.TabIndex = 1;
            this.btnObterTexto.Text = "Obter Texto";
            this.btnObterTexto.UseVisualStyleBackColor = true;
            this.btnObterTexto.Click += new System.EventHandler(this.btnObterTexto_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ObterTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.btnObterTexto);
            this.Controls.Add(this.txtExibeTexto);
            this.MaximizeBox = false;
            this.Name = "ObterTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obeter Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtExibeTexto;
        private Button btnObterTexto;
        private System.Windows.Forms.Timer timer;
    }
}