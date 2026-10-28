using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_de_inventario_con_Base_de_datos
{
    public partial class frmBuscarProd : Form
    {
        public frmBuscarProd()
        {
            InitializeComponent();
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text!="" && int.TryParse(tbID.Text,out int o)==true)
                {
                    productos prod = new productos();

                    if (prod.buscarProd(int.Parse(tbID.Text))!=null)
                    {
                        
                        prod = prod.buscarProd(int.Parse(tbID.Text));

                        dgvResID.Rows.Clear();
                        dgvResID.Rows.Add(prod.id, prod.nombre, prod.precio, prod.stock, prod.categoria, prod.descripcion);
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado un producto en el indice especificado");
                    }

                }
                else
                {
                    MessageBox.Show("El campo debe ser rellenado con un numero ID para realizar la busqueda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscarNom_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNom.Text!="")
                {
                    productos prod = new productos();
                    DataTable dt = new DataTable();
                    dt = prod.buscarProd(tbNom.Text);

                    MessageBox.Show($"Se han encontrado {dt.Rows.Count.ToString()} resultados similares");

                    dgvResID.Rows.Clear();

                    for (global::System.Int32 i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvResID.Rows.Add(dt.Rows[i].ItemArray[0], dt.Rows[i].ItemArray[1],
                            dt.Rows[i].ItemArray[2], dt.Rows[i].ItemArray[3], dt.Rows[i].ItemArray[4], dt.Rows[i].ItemArray[5]);
                    }
                }
                else
                {
                    MessageBox.Show("Debe rellenar el campo NOMBRE para realizar la busqueda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
