namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    partial class frmVerTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerTodo));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCons = new System.Windows.Forms.Button();
            this.btnStockB = new System.Windows.Forms.Button();
            this.btnVerT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos los productos";
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(12, 57);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.Size = new System.Drawing.Size(1240, 431);
            this.dgvProd.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnVerT);
            this.groupBox1.Controls.Add(this.btnStockB);
            this.groupBox1.Controls.Add(this.btnCons);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas personalizadas";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(6, 63);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(221, 25);
            this.cbCat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por categoria";
            // 
            // btnCons
            // 
            this.btnCons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCons.BackgroundImage")));
            this.btnCons.Image = ((System.Drawing.Image)(resources.GetObject("btnCons.Image")));
            this.btnCons.Location = new System.Drawing.Point(52, 94);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(119, 43);
            this.btnCons.TabIndex = 4;
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // btnStockB
            // 
            this.btnStockB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStockB.BackgroundImage")));
            this.btnStockB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockB.Location = new System.Drawing.Point(337, 35);
            this.btnStockB.Name = "btnStockB";
            this.btnStockB.Size = new System.Drawing.Size(222, 102);
            this.btnStockB.TabIndex = 5;
            this.btnStockB.Text = "Con stock bajo (<=10 unidades)";
            this.btnStockB.UseVisualStyleBackColor = true;
            this.btnStockB.Click += new System.EventHandler(this.btnStockB_Click);
            // 
            // btnVerT
            // 
            this.btnVerT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerT.BackgroundImage")));
            this.btnVerT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerT.Image = ((System.Drawing.Image)(resources.GetObject("btnVerT.Image")));
            this.btnVerT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerT.Location = new System.Drawing.Point(659, 35);
            this.btnVerT.Name = "btnVerT";
            this.btnVerT.Size = new System.Drawing.Size(222, 102);
            this.btnVerT.TabIndex = 6;
            this.btnVerT.Text = "Ver Todo";
            this.btnVerT.UseVisualStyleBackColor = true;
            this.btnVerT.Click += new System.EventHandler(this.btnVerT_Click);
            // 
            // frmVerTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.label1);
            this.Name = "frmVerTodo";
            this.Text = "frmVerTodo";
            this.Load += new System.EventHandler(this.frmVerTodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStockB;
        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Button btnVerT;
    }
}