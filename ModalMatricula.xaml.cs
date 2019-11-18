using System;
using System.Collections.Generic;
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



using Sistema_Academico.DAL.DataModels;
using Sistema_Academico.BL;
using System.Data.Entity;

namespace Sistema_Academico.UI.WPF
{
    /// <summary>
    /// Lógica de interacción para ModalMatricula.xaml
    /// </summary>
    public partial class ModalMatricula : Window
    {

        Matricula matriculas = new Matricula();
        MatriculaBL matriculaBL = new MatriculaBL();
        
        
        public ModalMatricula()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {

            dgmatricula.ItemsSource = matriculaBL.Get().ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            UpdateGrid();
        }

        private void dgmatricula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //sNotas no = new sNotas();
            //matricula = new Matricula();
            //matricula = dgmatricula.SelectedItem as Matricula;
            //if (matricula != null)
            //{



            //    matricula.Nie = textBlock.Text.ToString();
            //    this.Close();

             matriculas = new Matricula();
            matriculas = dgmatricula.SelectedItem as Matricula;
            MainWindow f = new MainWindow(matriculas);
            f.Show();
            this.Close();



            }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rbNIe.IsChecked == true)
            {
                dgmatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Nie.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbNombre.IsChecked == true)
            {
                dgmatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Nombre.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbApellido.IsChecked == true)
            {
                dgmatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Apellido.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
        }

    }
 }

