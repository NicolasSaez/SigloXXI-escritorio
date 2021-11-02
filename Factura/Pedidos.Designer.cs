
namespace Factura
{
    partial class Pedidos
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
            this.gvpedidos = new System.Windows.Forms.DataGridView();
            this.btnpedidos = new System.Windows.Forms.Button();
            this.btnentregado = new System.Windows.Forms.Button();
            this.txtidpedido = new System.Windows.Forms.TextBox();
            this.LBLTITULO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvpedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvpedidos
            // 
            this.gvpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvpedidos.Location = new System.Drawing.Point(12, 12);
            this.gvpedidos.Name = "gvpedidos";
            this.gvpedidos.Size = new System.Drawing.Size(674, 361);
            this.gvpedidos.TabIndex = 0;
            // 
            // btnpedidos
            // 
            this.btnpedidos.Location = new System.Drawing.Point(611, 379);
            this.btnpedidos.Name = "btnpedidos";
            this.btnpedidos.Size = new System.Drawing.Size(75, 38);
            this.btnpedidos.TabIndex = 1;
            this.btnpedidos.Text = "Cargar Pedidos";
            this.btnpedidos.UseVisualStyleBackColor = true;
            this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
            // 
            // btnentregado
            // 
            this.btnentregado.Location = new System.Drawing.Point(692, 54);
            this.btnentregado.Name = "btnentregado";
            this.btnentregado.Size = new System.Drawing.Size(75, 37);
            this.btnentregado.TabIndex = 2;
            this.btnentregado.Text = "Entregar";
            this.btnentregado.UseVisualStyleBackColor = true;
            this.btnentregado.Click += new System.EventHandler(this.btnentregado_Click);
            // 
            // txtidpedido
            // 
            this.txtidpedido.Location = new System.Drawing.Point(692, 28);
            this.txtidpedido.Name = "txtidpedido";
            this.txtidpedido.Size = new System.Drawing.Size(100, 20);
            this.txtidpedido.TabIndex = 3;
            // 
            // LBLTITULO
            // 
            this.LBLTITULO.AutoSize = true;
            this.LBLTITULO.Location = new System.Drawing.Point(692, 12);
            this.LBLTITULO.Name = "LBLTITULO";
            this.LBLTITULO.Size = new System.Drawing.Size(137, 13);
            this.LBLTITULO.TabIndex = 4;
            this.LBLTITULO.Text = "INGRESE ID DEL PEDIDO";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 453);
            this.Controls.Add(this.LBLTITULO);
            this.Controls.Add(this.txtidpedido);
            this.Controls.Add(this.btnentregado);
            this.Controls.Add(this.btnpedidos);
            this.Controls.Add(this.gvpedidos);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.gvpedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvpedidos;
        private System.Windows.Forms.Button btnpedidos;
        private System.Windows.Forms.Button btnentregado;
        private System.Windows.Forms.TextBox txtidpedido;
        private System.Windows.Forms.Label LBLTITULO;
    }
}