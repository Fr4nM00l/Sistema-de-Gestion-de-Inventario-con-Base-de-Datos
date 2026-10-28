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
    public partial class frmAgregarProd : Form
    {
        productos prod = new productos();
        categorias cat = new categorias();
        public frmAgregarProd()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = cat.getCategorias();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbCat.Items.Add(dt.Rows[i].ItemArray[0].ToString()+". "+ dt.Rows[i].ItemArray[1].ToString());               
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (tbNom.Text!="" && tbPrecio.Text!="" && tbStock.Text!="" && tbDesc.Text!="" && cbCat.SelectedItem.ToString()!="" && float.TryParse(tbPrecio.Text,out float o)==true && int.TryParse(tbStock.Text,out int a))
                {
                    string auxCat = cbCat.SelectedItem.ToString();
                    productos pr = new productos(tbNom.Text,float.Parse(tbPrecio.Text),int.Parse(tbStock.Text),int.Parse(ObtenerNumeros(auxCat)),tbDesc.Text);

                    if (pr.agregarProd(pr)==true)
                    {
                        MessageBox.Show("El producto ha sido añadido correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error y no se pudo agregar el producto!");
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos deben ser rellenados con el formato correcto!");
                }
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
