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
    public partial class frmVerTodo : Form
    {
        categorias cat = new categorias();
        productos prod = new productos();
        public frmVerTodo()
        {
            InitializeComponent();
        }

        private void frmVerTodo_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = cat.getCategorias();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbCat.Items.Add(dt.Rows[i].ItemArray[0].ToString() + ". " + dt.Rows[i].ItemArray[1].ToString());
                }

                dgvProd.DataSource = prod.getProds();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (cbCat.Text!="")
                {

                    string auxStr = ObtenerNumeros(cbCat.SelectedItem.ToString());

                    int auxId;

                    if (int.TryParse(auxStr,out auxId))
                    {
                        if (prod.getProdCat(auxId)!=null && prod.getProdCat(auxId).Rows.Count>=1)
                        {
                            dgvProd.DataSource = prod.getProdCat(auxId);
                        }
                        else
                        {
                            MessageBox.Show("No se han encontrado productos con esa categoria!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al convertir la categoria. Intente nuevamente!");
                    }

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una categoria valida!");
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

        private void btnStockB_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod.getProdBajoSt()!=null && prod.getProdBajoSt().Rows.Count>=1)
                {
                    dgvProd.DataSource = prod.getProdBajoSt();
                }
                else
                {
                    MessageBox.Show("No se han encontrado productos con stock menor a 11 unidades");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerT_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProd.DataSource = prod.getProds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
