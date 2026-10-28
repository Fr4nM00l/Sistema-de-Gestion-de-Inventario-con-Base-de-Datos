namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    partial class frmBuscarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProd));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.dgvResID = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarNom = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrec1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBuscarID);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda por ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscarNom);
            this.groupBox2.Controls.Add(this.tbNom);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(425, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese el ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(129, 52);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(266, 25);
            this.tbID.TabIndex = 1;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarID.BackgroundImage")));
            this.btnBuscarID.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarID.Image")));
            this.btnBuscarID.Location = new System.Drawing.Point(218, 78);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(93, 40);
            this.btnBuscarID.TabIndex = 2;
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // dgvResID
            // 
            this.dgvResID.AllowUserToAddRows = false;
            this.dgvResID.AllowUserToDeleteRows = false;
            this.dgvResID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID1,
            this.colNom1,
            this.colPrec1,
            this.colStock1,
            this.colCat1,
            this.colDesc1});
            this.dgvResID.Location = new System.Drawing.Point(12, 247);
            this.dgvResID.Name = "dgvResID";
            this.dgvResID.ReadOnly = true;
            this.dgvResID.RowHeadersVisible = false;
            this.dgvResID.Size = new System.Drawing.Size(814, 182);
            this.dgvResID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // btnBuscarNom
            // 
            this.btnBuscarNom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarNom.BackgroundImage")));
            this.btnBuscarNom.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarNom.Image")));
            this.btnBuscarNom.Location = new System.Drawing.Point(252, 78);
            this.btnBuscarNom.Name = "btnBuscarNom";
            this.btnBuscarNom.Size = new System.Drawing.Size(93, 40);
            this.btnBuscarNom.TabIndex = 7;
            this.btnBuscarNom.UseVisualStyleBackColor = true;
            this.btnBuscarNom.Click += new System.EventHandler(this.btnBuscarNom_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(177, 52);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(218, 25);
            this.tbNom.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese el nombre";
            // 
            // colID1
            // 
            this.colID1.HeaderText = "ID";
            this.colID1.Name = "colID1";
            this.colID1.ReadOnly = true;
            // 
            // colNom1
            // 
            this.colNom1.HeaderText = "Nombre";
            this.colNom1.Name = "colNom1";
            this.colNom1.ReadOnly = true;
            // 
            // colPrec1
            // 
            this.colPrec1.HeaderText = "Precio";
            this.colPrec1.Name = "colPrec1";
            this.colPrec1.ReadOnly = true;
            // 
            // colStock1
            // 
            this.colStock1.HeaderText = "Stock";
            this.colStock1.Name = "colStock1";
            this.colStock1.ReadOnly = true;
            // 
            // colCat1
            // 
            this.colCat1.HeaderText = "Categoria";
            this.colCat1.Name = "colCat1";
            this.colCat1.ReadOnly = true;
            // 
            // colDesc1
            // 
            this.colDesc1.HeaderText = "Descripcion";
            this.colDesc1.Name = "colDesc1";
            this.colDesc1.ReadOnly = true;
            // 
            // frmBuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvResID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarProd";
            this.Text = "frmBuscarProd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResID;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrec1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc1;
    }
}