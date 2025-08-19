namespace CalculadoraIMC
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
            this.components = new System.ComponentModel.Container();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.ptbTabelaIMC = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblIMC = new System.Windows.Forms.Label();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.lblCondicao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabelaIMC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(168, 89);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(231, 81);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 20);
            this.txbPeso.TabIndex = 1;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(171, 148);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(231, 140);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(231, 199);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // ptbTabelaIMC
            // 
            this.ptbTabelaIMC.Image = global::CalculadoraIMC.Properties.Resources.TabelaIMC;
            this.ptbTabelaIMC.Location = new System.Drawing.Point(431, 81);
            this.ptbTabelaIMC.Name = "ptbTabelaIMC";
            this.ptbTabelaIMC.Size = new System.Drawing.Size(344, 257);
            this.ptbTabelaIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTabelaIMC.TabIndex = 5;
            this.ptbTabelaIMC.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(174, 251);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(29, 13);
            this.lblIMC.TabIndex = 7;
            this.lblIMC.Text = "IMC:";
            // 
            // txbIMC
            // 
            this.txbIMC.Enabled = false;
            this.txbIMC.Location = new System.Drawing.Point(231, 251);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.Size = new System.Drawing.Size(100, 20);
            this.txbIMC.TabIndex = 8;
            // 
            // lblCondicao
            // 
            this.lblCondicao.AutoSize = true;
            this.lblCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicao.Location = new System.Drawing.Point(231, 324);
            this.lblCondicao.Name = "lblCondicao";
            this.lblCondicao.Size = new System.Drawing.Size(30, 25);
            this.lblCondicao.TabIndex = 9;
            this.lblCondicao.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCondicao);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.ptbTabelaIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTabelaIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox ptbTabelaIMC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txbIMC;
        private System.Windows.Forms.Label lblCondicao;
    }
}

