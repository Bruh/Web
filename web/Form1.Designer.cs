namespace web
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.sair = new System.Windows.Forms.Button();
            this.setavoltar = new System.Windows.Forms.Button();
            this.setair = new System.Windows.Forms.Button();
            this.pginicial = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.favorito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(473, 263);
            this.webBrowser1.TabIndex = 2;
            // 
            // sair
            // 
            this.sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sair.BackgroundImage = global::web.Properties.Resources._1378493447_3206;
            this.sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sair.Location = new System.Drawing.Point(452, 15);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(33, 29);
            this.sair.TabIndex = 0;
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // setavoltar
            // 
            this.setavoltar.BackgroundImage = global::web.Properties.Resources.esquerda;
            this.setavoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setavoltar.Location = new System.Drawing.Point(12, 12);
            this.setavoltar.Name = "setavoltar";
            this.setavoltar.Size = new System.Drawing.Size(33, 32);
            this.setavoltar.TabIndex = 0;
            this.setavoltar.UseVisualStyleBackColor = true;
            this.setavoltar.Click += new System.EventHandler(this.setavoltar_Click);
            // 
            // setair
            // 
            this.setair.BackgroundImage = global::web.Properties.Resources.direit;
            this.setair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setair.Location = new System.Drawing.Point(51, 13);
            this.setair.Name = "setair";
            this.setair.Size = new System.Drawing.Size(33, 31);
            this.setair.TabIndex = 3;
            this.setair.UseVisualStyleBackColor = true;
            this.setair.Click += new System.EventHandler(this.setair_Click);
            // 
            // pginicial
            // 
            this.pginicial.BackgroundImage = global::web.Properties.Resources._1378493502_134213;
            this.pginicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pginicial.Location = new System.Drawing.Point(90, 13);
            this.pginicial.Name = "pginicial";
            this.pginicial.Size = new System.Drawing.Size(33, 31);
            this.pginicial.TabIndex = 4;
            this.pginicial.UseVisualStyleBackColor = true;
            this.pginicial.Click += new System.EventHandler(this.pginicial_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pesquisar.BackgroundImage = global::web.Properties.Resources._1378492638_175177;
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pesquisar.Location = new System.Drawing.Point(373, 15);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(33, 29);
            this.Pesquisar.TabIndex = 5;
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // favorito
            // 
            this.favorito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favorito.BackgroundImage = global::web.Properties.Resources._1378494689_33858;
            this.favorito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favorito.Location = new System.Drawing.Point(412, 15);
            this.favorito.Name = "favorito";
            this.favorito.Size = new System.Drawing.Size(34, 29);
            this.favorito.TabIndex = 6;
            this.favorito.UseVisualStyleBackColor = true;
            this.favorito.Click += new System.EventHandler(this.favorito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 361);
            this.Controls.Add(this.favorito);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.pginicial);
            this.Controls.Add(this.setair);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.setavoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pluzax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setavoltar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button setair;
        private System.Windows.Forms.Button pginicial;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Button favorito;
    }
}

