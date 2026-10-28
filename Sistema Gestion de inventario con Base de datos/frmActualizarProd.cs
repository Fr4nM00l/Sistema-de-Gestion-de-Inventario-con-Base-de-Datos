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
    public partial class frmActualizarProd : Form
    {
        categorias cat = new categorias();

        public void limpiarCampos()
        {
            tbID.Clear();
            tbDesc.Clear();
            tbNom.Clear();
            tbPrecio.Clear();
            tbStock.Clear();
            cbCat.SelectedItem="";
        }
        public frmActualizarProd()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = cat.getCategorias();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCat.Items.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString());
            }
        }

        private void frmActualizarProd_Load(object sender, EventArgs e)
        {

        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter && tbID.Text!="" && int.TryParse(tbID.Text,out int o)==true)
            {
                productos prod = new productos();
                if (prod.buscarProd(int.Parse(tbID.Text))!=null)
                {
                    prod = prod.buscarProd(int.Parse(tbID.Text));
                    tbNom.Text = prod.nombre;
                    tbPrecio.Text = prod.precio.ToString();
                    tbStock.Text = prod.stock.ToString();
                    tbDesc.Text = prod.descripcion;
                    cbCat.SelectedIndex = prod.categoria-1;

                    tbNom.Enabled = true;
                    tbPrecio.Enabled = true;
                    tbStock.Enabled = true;
                    tbDesc.Enabled = true;
                    cbCat.Enabled = true;
                    btnActualizar.Enabled = true;
                    tbID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado un producto con ese indice");
                }

            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                productos prod = new productos(tbNom.Text,float.Parse(tbPrecio.Text),int.Parse(tbStock.Text),int.Parse(ObtenerNumeros(cbCat.SelectedItem.ToString())),tbDesc.Text);
                if (prod.actualizarProd(prod, int.Parse(tbID.Text)))
                {
                    MessageBox.Show("El producto ha sido actualizado con exito");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error y no se pudo actualizar el producto");
                }


                tbNom.Enabled = false;
                tbPrecio.Enabled = false;
                tbStock.Enabled = false;
                tbDesc.Enabled = false;
                cbCat.Enabled = false;
                btnActualizar.Enabled = false;
                tbID.Enabled = true;

                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static string ObtenerNumeros(string input)
        {
            int i = 0;
            while (i < input.Length && char.IsDigit(input[i]))
            {
                i++;
            }
            return input.Substring(0, i);
        }
    }
}
