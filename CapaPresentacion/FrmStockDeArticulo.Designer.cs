namespace CapaPresentacion
{
    partial class FrmStockDeArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockDeArticulo));
            this.dgvListaProducto = new System.Windows.Forms.DataGridView();
            this.btnListaProducto = new System.Windows.Forms.Button();
            this.btnMenorde10 = new System.Windows.Forms.Button();
            this.lbVolverMenu = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.AllowUserToAddRows = false;
            this.dgvListaProducto.AllowUserToDeleteRows = false;
            this.dgvListaProducto.AllowUserToResizeColumns = false;
            this.dgvListaProducto.AllowUserToResizeRows = false;
            this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaProducto.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProducto.Location = new System.Drawing.Point(36, 121);
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.ReadOnly = true;
            this.dgvListaProducto.Size = new System.Drawing.Size(865, 249);
            this.dgvListaProducto.TabIndex = 0;
            // 
            // btnListaProducto
            // 
            this.btnListaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProducto.Location = new System.Drawing.Point(36, 63);
            this.btnListaProducto.Name = "btnListaProducto";
            this.btnListaProducto.Size = new System.Drawing.Size(262, 30);
            this.btnListaProducto.TabIndex = 1;
            this.btnListaProducto.Text = "Lista de Producto";
            this.btnListaProducto.UseVisualStyleBackColor = true;
            this.btnListaProducto.Click += new System.EventHandler(this.btnListaProducto_Click);
            // 
            // btnMenorde10
            // 
            this.btnMenorde10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorde10.Location = new System.Drawing.Point(639, 63);
            this.btnMenorde10.Name = "btnMenorde10";
            this.btnMenorde10.Size = new System.Drawing.Size(262, 30);
            this.btnMenorde10.TabIndex = 2;
            this.btnMenorde10.Text = "Menor de 10 Unidades";
            this.btnMenorde10.UseVisualStyleBackColor = true;
            this.btnMenorde10.Click += new System.EventHandler(this.btnMenorde10_Click);
            // 
            // lbVolverMenu
            // 
            this.lbVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolverMenu.Location = new System.Drawing.Point(326, 468);
            this.lbVolverMenu.Name = "lbVolverMenu";
            this.lbVolverMenu.Size = new System.Drawing.Size(262, 30);
            this.lbVolverMenu.TabIndex = 3;
            this.lbVolverMenu.Text = "Salir";
            this.lbVolverMenu.UseVisualStyleBackColor = true;
            this.lbVolverMenu.Click += new System.EventHandler(this.lbVolverMenu_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(342, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(262, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar nuevo ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total de Stock:";
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblStockTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStockTotal.Location = new System.Drawing.Point(210, 398);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(56, 24);
            this.lblStockTotal.TabIndex = 6;
            this.lblStockTotal.Text = "Total";
            // 
            // FrmStockDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 546);
            this.Controls.Add(this.lblStockTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbVolverMenu);
            this.Controls.Add(this.btnMenorde10);
            this.Controls.Add(this.btnListaProducto);
            this.Controls.Add(this.dgvListaProducto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockDeArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.FrmStockDeArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.Button btnListaProducto;
        private System.Windows.Forms.Button btnMenorde10;
        private System.Windows.Forms.Button lbVolverMenu;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockTotal;
    }
}