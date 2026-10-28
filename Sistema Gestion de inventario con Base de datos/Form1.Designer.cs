namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestion de Inventario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnVerTodo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnBorrarProd);
            this.groupBox1.Controls.Add(this.btnActualizarProd);
            this.groupBox1.Controls.Add(this.btnAgregarProd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 502);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerTodo.BackgroundImage")));
            this.btnVerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerTodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnVerTodo.Image")));
            this.btnVerTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTodo.Location = new System.Drawing.Point(171, 397);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(249, 99);
            this.btnVerTodo.TabIndex = 4;
            this.btnVerTodo.Text = "Ver todos los productos";
            this.btnVerTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(330, 232);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(249, 99);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Producto";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarProd.BackgroundImage")));
            this.btnBorrarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrarProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarProd.Image")));
            this.btnBorrarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarProd.Location = new System.Drawing.Point(330, 19);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(249, 99);
            this.btnBorrarProd.TabIndex = 2;
            this.btnBorrarProd.Text = "Borrar Producto";
            this.btnBorrarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarProd.UseVisualStyleBackColor = true;
            this.btnBorrarProd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarProd.BackgroundImage")));
            this.btnActualizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizarProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarProd.Image")));
            this.btnActualizarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarProd.Location = new System.Drawing.Point(6, 232);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(249, 99);
            this.btnActualizarProd.TabIndex = 1;
            this.btnActualizarProd.Text = "Actualizar Productos";
            this.btnActualizarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarProd.UseVisualStyleBackColor = true;
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.BackgroundImage")));
            this.btnAgregarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Image")));
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.Location = new System.Drawing.Point(6, 19);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(249, 99);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar Productos";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrarProd;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.Button btnAgregarProd;
    }
}

