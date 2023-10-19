namespace T3_FUNDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> Lista_Numeros = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (int.TryParse(txt_numero.Text, out int numero))
                {
                    int G_n = dgv_numero.Rows.Add();
                    dgv_numero.Rows[G_n].Cells[0].Value = numero;
                    Lista_Numeros.Add(numero);
                }

                else
                {
                    throw new Exception("Ingrese un Número.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Validación de Número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_numero.Clear();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string num_eliminar = txt_numero.Text;

            if (!string.IsNullOrEmpty(num_eliminar))
            {
                if (int.TryParse(num_eliminar, out int numero))
                {
                    if (Lista_Numeros.Contains(numero))
                    {
                        Lista_Numeros.Remove(numero);

                        foreach (DataGridViewRow fila in dgv_numero.Rows)
                        {
                            if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == num_eliminar)
                            {
                                dgv_numero.Rows.Remove(fila);
                                MessageBox.Show("Número eliminado.");
                                txt_numero.Clear();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número no se encuentra en lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número para eliminar.");
            }
            txt_numero.Clear();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lista_Numeros.LongCount(); i++)
            {
                MessageBox.Show(Lista_Numeros[i].ToString());
            }
        }

        private void OrdenarListaAscendente()
        {
            Lista_Numeros.Sort();
        }

        private void OrdenarListaDescendente()
        {
            Lista_Numeros.Sort((a, b) => b.CompareTo(a));
        }

        private void ActualizarDataGridViewDesdeLista()
        {
            dgv_numero.Rows.Clear();
            foreach (int numero in Lista_Numeros)
            {
                int rowIndex = dgv_numero.Rows.Add();
                dgv_numero.Rows[rowIndex].Cells[0].Value = numero;
            }
        }

        private void btn_ascendente_Click(object sender, EventArgs e)
        {
            OrdenarListaAscendente();
            ActualizarDataGridViewDesdeLista();
        }

        private void btn_descendente_Click(object sender, EventArgs e)
        {
            OrdenarListaDescendente();
            ActualizarDataGridViewDesdeLista();
        }
    }
}
