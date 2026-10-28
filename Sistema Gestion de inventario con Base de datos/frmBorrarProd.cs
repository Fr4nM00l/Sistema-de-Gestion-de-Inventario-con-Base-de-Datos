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
    public partial class frmBorrarProd : Form
    {
        categorias cat = new categorias();
        public frmBorrarProd()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = cat.getCategorias();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCat.Items.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString());
            }
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter && tbID.Text != "" && int.TryParse(tbID.Text, out int o) == true)
                {
                    productos prod = new productos();
                    if (prod.buscarProd(int.Parse(tbID.Text)) != null)
                    {
                        prod = prod.buscarProd(int.Parse(tbID.Text));
                        tbNom.Text = prod.nombre;
                        tbPrecio.Text = prod.precio.ToString();
                        tbStock.Text = prod.stock.ToString();
                        tbDesc.Text = prod.descripcion;
                        cbCat.SelectedIndex = prod.categoria - 1;

                        tbID.Enabled = false;
                        btnEliminar.Enabled=true;
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado un producto con ese indice");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limpiarCampos()
        {
            tbID.Clear();
            tbDesc.Clear();
            tbNom.Clear();
            tbPrecio.Clear();
            tbStock.Clear();
            cbCat.SelectedItem = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                var decision = MessageBox.Show($"Esta seguro de eliminar el producto: {tbNom.Text}?","Confirme la accion!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (decision==DialogResult.Yes)
                {
                    productos prod = new productos();
                    if (prod.borrarProd(int.Parse(tbID.Text)) == true)
                    {
                        MessageBox.Show("El producto ha sido eliminado correctamente");

                        limpiarCampos();

                        tbID.Enabled = true;
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el producto. Intentelo nuevamente!");

                        limpiarCampos();

                        tbID.Enabled = true;
                        btnEliminar.Enabled = false;
                    }
                }
                else
                {
                    limpiarCampos();

                    tbID.Enabled = true;
                    btnEliminar.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
