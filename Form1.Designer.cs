
namespace Calculadora
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Valor1 = new System.Windows.Forms.Label();
            this.Valor2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(224, 75);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(224, 171);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 1;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Valor1
            // 
            this.Valor1.AutoSize = true;
            this.Valor1.Location = new System.Drawing.Point(36, 46);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(53, 17);
            this.Valor1.TabIndex = 3;
            this.Valor1.Text = "Valor 1";
            this.Valor1.Click += new System.EventHandler(this.Valor1_Click);
            // 
            // Valor2
            // 
            this.Valor2.AutoSize = true;
            this.Valor2.Location = new System.Drawing.Point(36, 100);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(53, 17);
            this.Valor2.TabIndex = 4;
            this.Valor2.Text = "Valor 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label3.Location = new System.Drawing.Point(36, 177);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 17);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Resultado";
            this.Label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbResultado.Location = new System.Drawing.Point(125, 177);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 17);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "0";
            this.lbResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(114, 46);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(36, 22);
            this.textbox1.TabIndex = 7;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(114, 100);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(36, 22);
            this.textbox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 241);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Valor1;
        private System.Windows.Forms.Label Valor2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
    }
}

