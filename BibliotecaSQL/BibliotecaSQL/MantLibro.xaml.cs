using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotecaSQL
{
    /// <summary>
    /// Lógica de interacción para MantLibro.xaml
    /// </summary>
    public partial class MantLibro : Window
    {
        string campoBusqueda;
        ADAT adat = new ADAT();
        string codigo = "0";
        public MantLibro()
        {
            InitializeComponent();
            bindingCombo();
            this.codigo = ADAT.ds.Libro.Count().ToString();
        }

        private void btn_buscarLibro_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(tbBusqueda.Text) && !String.IsNullOrEmpty(campoBusqueda))
            {
                adat.BuscarLibro(campoBusqueda, tbBusqueda.Text);

                if (ADAT.libroRow != null)
                {
                    mostraLibro();
                    mostrarEjemplares();
                }
                else MessageBox.Show("Libro no encontrado");
            }
            else { MessageBox.Show("Introduzca un " + campoBusqueda + " "); }
        }

        private void btn_registrar_Click(object sender, RoutedEventArgs e)
        {
            if ((!String.IsNullOrEmpty(txt_isbn.Text)) && (!String.IsNullOrEmpty(txt_titulo.Text)) &&
                (!String.IsNullOrEmpty(txt_editorial.Text)) && (!String.IsNullOrEmpty(txt_descripcion.Text)))
            {
                adat.InsertarLibro(this.codigo,txt_isbn.Text, txt_titulo.Text, txt_editorial.Text, txt_descripcion.Text);
                //this.codigo = ADAT.ds.Libro.Count.ToString();
                //if (ADAT.libroRow == null)
                //{
                //    mostrarEjemplares();
                //}
            }
            else { MessageBox.Show("Existen campos por cubrir"); }
        }

        private void btn_modificar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_isbn.Text))
            {
                adat.ModificarLibro(txt_isbn.Text, txt_titulo.Text, txt_editorial.Text, txt_descripcion.Text);

            }
        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_isbn.Text))
            {
                adat.EliminarLibro(txt_isbn.Text);
                LimpiarLibros();
            }
        }

        private void btn_buscarEjemplar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_GuardarEjemplar_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(dp_FechaPublicacion.Text) && !String.IsNullOrEmpty(txt_numEjemplar.Text))
            {
                adat.InsertarEjemplar(txt_isbn.Text, Convert.ToDateTime(dp_FechaPublicacion.Text), Convert.ToInt32(txt_numEjemplar.Text));
                if (ADAT.registrosAtualizados == 1)
                {
                    txt_numEjemplar.Text = "";
                    mostrarEjemplares();
                }
            }
        }

        public void mostrarEjemplares()
        {
            dgEjemplares.ItemsSource = "";
            if (ADAT.libroRow != null)
            {
                if (ADAT.ds.Ejemplar.Count() > 0)
                {
                    adat.BuscarEjemplar(ADAT.libroRow.CodigoLibro);
                    dgEjemplares.ItemsSource = ADAT.ds.Ejemplar;
                }
            }
        }

        public void mostraLibro()
        {
            txt_isbn.Text = ADAT.libroRow.Isbn.ToString();
            txt_titulo.Text = ADAT.libroRow.Titulo.ToString();
            txt_editorial.Text = ADAT.libroRow.Editorial.ToString();
            txt_descripcion.Text = ADAT.libroRow.Descripcion.ToString();
        }

        public void LimpiarLibros()
        {
            dgEjemplares.ItemsSource = "";
            txt_isbn.Text = "";
            txt_titulo.Text = "";
            txt_editorial.Text = "";
            txt_descripcion.Text = "";
            dp_FechaPublicacion.Text = "";
        }

        public void bindingCombo()
        {
            for (int i = 0; i < ADAT.ds.Libro.DefaultView.Table.Columns.Count; i++)
                cbCampos.Items.Add(ADAT.ds.Libro.DefaultView.Table.Columns[i].ColumnName);
        }

        private void cbCampos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                campoBusqueda = cbCampos.SelectedItem.ToString();
            }
            catch { }
        }

        private void btNuevo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarLibros();
        }
    }
}
