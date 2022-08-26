namespace AsyncAwait.WindowsForms
{
    partial class frmBaixarArquivo
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
            this.lbEsquerda = new System.Windows.Forms.ListBox();
            this.lbDireita = new System.Windows.Forms.ListBox();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnBaixarArquivo = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEsquerda
            // 
            this.lbEsquerda.FormattingEnabled = true;
            this.lbEsquerda.ItemHeight = 15;
            this.lbEsquerda.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbEsquerda.Location = new System.Drawing.Point(98, 68);
            this.lbEsquerda.Name = "lbEsquerda";
            this.lbEsquerda.Size = new System.Drawing.Size(174, 184);
            this.lbEsquerda.TabIndex = 0;
            // 
            // lbDireita
            // 
            this.lbDireita.FormattingEnabled = true;
            this.lbDireita.ItemHeight = 15;
            this.lbDireita.Location = new System.Drawing.Point(437, 68);
            this.lbDireita.Name = "lbDireita";
            this.lbDireita.Size = new System.Drawing.Size(174, 184);
            this.lbDireita.TabIndex = 1;
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(321, 101);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(75, 23);
            this.btnDireita.TabIndex = 2;
            this.btnDireita.Text = ">";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(321, 130);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(75, 23);
            this.btnEsquerda.TabIndex = 3;
            this.btnEsquerda.Text = "<";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnBaixarArquivo
            // 
            this.btnBaixarArquivo.Location = new System.Drawing.Point(275, 306);
            this.btnBaixarArquivo.Name = "btnBaixarArquivo";
            this.btnBaixarArquivo.Size = new System.Drawing.Size(158, 46);
            this.btnBaixarArquivo.TabIndex = 4;
            this.btnBaixarArquivo.Text = "Baixar Arquivo";
            this.btnBaixarArquivo.UseVisualStyleBackColor = true;
            this.btnBaixarArquivo.Click += new System.EventHandler(this.btnBaixarArquivo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensagem.Location = new System.Drawing.Point(4, 390);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(692, 27);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            // 
            // frmBaixarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnBaixarArquivo);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.lbDireita);
            this.Controls.Add(this.lbEsquerda);
            this.MaximizeBox = false;
            this.Name = "frmBaixarArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbEsquerda;
        private ListBox lbDireita;
        private Button btnDireita;
        private Button btnEsquerda;
        private Button btnBaixarArquivo;
        private Label lblMensagem;
    }
}