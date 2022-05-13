
namespace PuntoDeportes
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addProducto = new System.Windows.Forms.Button();
            this.eliminarProducto = new System.Windows.Forms.Button();
            this.actProducto = new System.Windows.Forms.Button();
            this.buscarProducto = new System.Windows.Forms.Button();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.txtnombreProducto = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.idProd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sgvProducto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addProducto
            // 
            this.addProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.addProducto.Image = ((System.Drawing.Image)(resources.GetObject("addProducto.Image")));
            this.addProducto.Location = new System.Drawing.Point(969, 264);
            this.addProducto.Name = "addProducto";
            this.addProducto.Size = new System.Drawing.Size(131, 123);
            this.addProducto.TabIndex = 1;
            this.addProducto.Text = "button1";
            this.addProducto.UseVisualStyleBackColor = false;
            this.addProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // eliminarProducto
            // 
            this.eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.eliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProducto.Image")));
            this.eliminarProducto.Location = new System.Drawing.Point(969, 393);
            this.eliminarProducto.Name = "eliminarProducto";
            this.eliminarProducto.Size = new System.Drawing.Size(131, 123);
            this.eliminarProducto.TabIndex = 3;
            this.eliminarProducto.UseVisualStyleBackColor = false;
            this.eliminarProducto.Click += new System.EventHandler(this.eliminarProducto_Click);
            // 
            // actProducto
            // 
            this.actProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.actProducto.Image = ((System.Drawing.Image)(resources.GetObject("actProducto.Image")));
            this.actProducto.Location = new System.Drawing.Point(12, 393);
            this.actProducto.Name = "actProducto";
            this.actProducto.Size = new System.Drawing.Size(158, 154);
            this.actProducto.TabIndex = 4;
            this.actProducto.UseVisualStyleBackColor = false;
            this.actProducto.Click += new System.EventHandler(this.actProducto_Click);
            // 
            // buscarProducto
            // 
            this.buscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.buscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("buscarProducto.Image")));
            this.buscarProducto.Location = new System.Drawing.Point(12, 264);
            this.buscarProducto.Name = "buscarProducto";
            this.buscarProducto.Size = new System.Drawing.Size(131, 123);
            this.buscarProducto.TabIndex = 5;
            this.buscarProducto.UseVisualStyleBackColor = false;
            this.buscarProducto.Click += new System.EventHandler(this.buscarProducto_Click);
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(39, 223);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(202, 22);
            this.txtidProducto.TabIndex = 6;
            this.txtidProducto.TextChanged += new System.EventHandler(this.idProducto_TextChanged);
            // 
            // txtnombreProducto
            // 
            this.txtnombreProducto.Location = new System.Drawing.Point(293, 223);
            this.txtnombreProducto.Name = "txtnombreProducto";
            this.txtnombreProducto.Size = new System.Drawing.Size(219, 22);
            this.txtnombreProducto.TabIndex = 7;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(808, 223);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(195, 22);
            this.txtcategoria.TabIndex = 8;
            this.txtcategoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // idProd
            // 
            this.idProd.AutoSize = true;
            this.idProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProd.Location = new System.Drawing.Point(34, 195);
            this.idProd.Name = "idProd";
            this.idProd.Size = new System.Drawing.Size(158, 25);
            this.idProd.TabIndex = 9;
            this.idProd.Text = "ID del producto";
            this.idProd.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(803, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria del producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(551, 223);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(195, 22);
            this.txtprecio.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio del producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sgvProducto
            // 
            this.sgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(86)))), ((int)(((byte)(122)))));
            this.sgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sgvProducto.Location = new System.Drawing.Point(176, 286);
            this.sgvProducto.Name = "sgvProducto";
            this.sgvProducto.RowHeadersWidth = 51;
            this.sgvProducto.RowTemplate.Height = 24;
            this.sgvProducto.Size = new System.Drawing.Size(770, 271);
            this.sgvProducto.TabIndex = 14;
            this.sgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sgvProducto_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1100, 87);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(149)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sgvProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idProd);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtnombreProducto);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.buscarProducto);
            this.Controls.Add(this.actProducto);
            this.Controls.Add(this.eliminarProducto);
            this.Controls.Add(this.addProducto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addProducto;
        private System.Windows.Forms.Button eliminarProducto;
        private System.Windows.Forms.Button actProducto;
        private System.Windows.Forms.Button buscarProducto;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.TextBox txtnombreProducto;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label idProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView sgvProducto;
        private System.Windows.Forms.Button button1;
    }
}