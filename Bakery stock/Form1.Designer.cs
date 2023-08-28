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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // criar
            // 
            this.criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.criar.Location = new System.Drawing.Point(172, 319);
            this.criar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.criar.Name = "criar";
            this.criar.Size = new System.Drawing.Size(200, 49);
            this.criar.TabIndex = 0;
            this.criar.Text = "Criar nova tabela";
            this.criar.UseVisualStyleBackColor = false;
            this.criar.Click += new System.EventHandler(this.criar_Click);
            // 
            // carregar
            // 
            this.carregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(173)))), ((int)(((byte)(55)))));
            this.carregar.Location = new System.Drawing.Point(172, 392);
            this.carregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(200, 48);
            this.carregar.TabIndex = 1;
            this.carregar.Text = "Carregar tabela";
            this.carregar.UseVisualStyleBackColor = false;
            this.carregar.Click += new System.EventHandler(this.carregar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bakery_stock.Properties.Resources.MicrosoftTeams_image__1__removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(111, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bakery_stock.Properties.Resources.MicrosoftTeams_image_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(633, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(512, 387);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1217, 544);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.criar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criar;
        private System.Windows.Forms.Button carregar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

