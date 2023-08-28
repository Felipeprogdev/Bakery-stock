namespace Bakery_stock
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
            this.criar = new System.Windows.Forms.Button();
            this.carregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criar
            // 
            this.criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.criar.Location = new System.Drawing.Point(232, 208);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(75, 23);
            this.criar.TabIndex = 0;
            this.criar.Text = "Criar";
            this.criar.UseVisualStyleBackColor = false;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // carregar
            // 
            this.carregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.carregar.Location = new System.Drawing.Point(454, 208);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(75, 23);
            this.carregar.TabIndex = 1;
            this.carregar.Text = "Carregar";
            this.carregar.UseVisualStyleBackColor = false;
            this.carregar.Click += new System.EventHandler(this.carregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.criar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button carregar;
    }
}

