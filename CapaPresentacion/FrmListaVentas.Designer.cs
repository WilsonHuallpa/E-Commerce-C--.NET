namespace CapaPresentacion
{
    partial class FrmListaVentas
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
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.lbListaEmpleado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvEmpleado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEmpleado.Location = new System.Drawing.Point(44, 105);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(1048, 399);
            this.dgvEmpleado.TabIndex = 0;
            this.dgvEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellDoubleClick);
            // 
            // lbListaEmpleado
            // 
            this.lbListaEmpleado.AutoSize = true;
            this.lbListaEmpleado.Location = new System.Drawing.Point(41, 547);
            this.lbListaEmpleado.Name = "lbListaEmpleado";
            this.lbListaEmpleado.Size = new System.Drawing.Size(25, 13);
            this.lbListaEmpleado.TabIndex = 1;
            this.lbListaEmpleado.Text = "lista";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(903, 554);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 52);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(490, 31);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(188, 52);
            this.btnRestablecer.TabIndex = 3;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // FrmListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1171, 693);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbListaEmpleado);
            this.Controls.Add(this.dgvEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaVentas";
            this.Text = "FrmListaCompras";
            this.Load += new System.EventHandler(this.FrmListaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label lbListaEmpleado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRestablecer;
    }
}