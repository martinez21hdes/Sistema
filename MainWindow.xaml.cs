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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.Data;
using System.Data.Entity;
using Sistema_Academico.BL;
using Sistema_Academico.DAL.DataModels;

namespace Sistema_Academico.UI.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Years year = new Years();
        YearsBL yearBL = new YearsBL();
        Ciclo ciclo = new Ciclo();
        CicloBL cicloBL = new CicloBL();
        Grado grado = new Grado();
        GradoBL gradoBL = new GradoBL();
        Materia materia = new Materia();
        Valores valores = new Valores();
        ValoresBL valoresBL = new ValoresBL();
        MateriaBL materiaBL = new MateriaBL();
        Matricula matricula = new Matricula();
        MatriculaBL matriculaBL = new MatriculaBL();
        Notas notas = new Notas();
        NotasBL notasBL = new NotasBL();
        NotasValores notasvalores = new NotasValores();
        NotasValoresBL notasvaloresBL = new NotasValoresBL();
        //variable que se crea para poder guardar el cliente
        Int64 id = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Matricula matricula)
        {
            InitializeComponent();

            //se llama la variable con el Id de la tabla clientes
            id = matricula.Id;
            txtmatriculas.Text = matricula.Nie + "" + matricula.Primer_Apellido + "" + matricula.Segundo_Apellido + "" + matricula.Primer_Nombre + "" +
                matricula.Segundo_Nombre +""+matricula.Tercer_Nombre ;

            //se llama la variable con el Id de la tabla clientes
            id = matricula.Id;
            textBlock.Text = matricula.Nie + "" + matricula.Primer_Apellido + "" + matricula.Segundo_Apellido + "" + matricula.Primer_Apellido + "" +
                matricula.Tercer_Nombre +""+ matricula.Segundo_Nombre + "" + matricula.Tercer_Nombre;

        }

        private void UpdateGrid()
        {
            //Año
            dgYer.ItemsSource = yearBL.Get().ToList();
            //Ciclo
            dgCiclo.ItemsSource = cicloBL.Get().Include(c => c.years).ToList();
            //Grado
            dgGrado.ItemsSource = gradoBL.Get().Include(c => c.ciclo).ToList();
            //Materia
            dgMateria.ItemsSource = materiaBL.Get().ToList();
            //Valores
            dgvalor.ItemsSource = valoresBL.Get().ToList();
            //Matricula
            dgMatricula.ItemsSource = matriculaBL.Get().Include(g => g.grado).ToList();
            //Notas
            dgNotas.ItemsSource = notasBL.Get().Include(m => m.materia).Include(ma => ma.matricula).ToList();
            //NotasValores
            dgnotasV.ItemsSource = notasvaloresBL.Get().ToList();

        }
        private void Enable(bool val)
        {
            if (val)
            {
                //año
                btnGuardaraño.IsEnabled = false;
                btnModificaraño.IsEnabled = true;
                btnModificaraño.IsEnabled = true;
           
                //ciclo
                btnGuardarciclo.IsEnabled = false;
                btnModificarciclo.IsEnabled = true;
                btnEliminarciclo.IsEnabled = true;
            
                
                //grado
                btnGuardargrado.IsEnabled = false;
                btnModificargrado.IsEnabled = true;
                btnEliminargrado.IsEnabled = true;
                //Materia
                btnGuardarmateria.IsEnabled = false;
                btnModificarmateria.IsEnabled = true;
                btnEliminarmateria.IsEnabled = true;
            }
            else
            {
                //Valores
                btnGuardarvalores.IsEnabled = true;
                btnEliminarvalores.IsEnabled = false;
                btnEliminarvalores.IsEnabled = false;
                //Matricula
                btnGuardar.IsEnabled = true;
                btnModificar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                //Notas
                btnGuardarnotas.IsEnabled = true;
                btnModificarnotas.IsEnabled = false;
                btnEliminarnotas.IsEnabled = false;
                //Notas Valores
                btnGuardarnotasvalores.IsEnabled = true;
                btnModificarnotasvalores.IsEnabled = false;
                btnEliminarnotasvalores.IsEnabled = false;
            }
        }

        private void Clear()
        {
            //producto
            txtYearaño.Clear();
            //Ciclo
            txtCiclo.Clear();
            cbYear.Text = "";

            //grado
            txtGrado.Clear();
           
            //materia
           txtMateria.Clear();
            //valores
            txtvalor.Clear();
            //matricula
            txtNie.Clear();
            txtprimerN.Clear();
            txtSegundoN.Clear();
            txtTercerN.Clear();
            txtPrimerA.Clear();
            txtSegundoA.Clear();
            txtDireccion.Clear();
            txtNombreResponsable.Clear();
            txtDUI.Clear();
            cbTurno.Text = "";
            cbSexo.Text = "";
            cbSeccion.Text = "";
            dpnacimiento.Text = "";
            //notas
           
            txtPrimerT.Clear();
            txtSegundoT.Clear();
            txtTercerT.Clear();
            textBlock.Text = "";
            cbMateria.Text = "";

            //NotasValores
            cb1TV.Text = "";
            cb2TV.Text = "";
            cb3TV.Text = "";
            cbValores.Text = "";
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Nombre de la tabla valor
            cbValores.ItemsSource = valoresBL.Get().ToList();
            cbValores.DisplayMemberPath = "Nombre";
            cbValores.SelectedValuePath = "Id";
            //Nombre de la tabla materia
            cbMateria.ItemsSource = materiaBL.Get().ToList();
            cbMateria.DisplayMemberPath = "Nombre_Materia";
            cbMateria.SelectedValuePath = "Id";
            //Nombre de la tabla grado
            cbGrado.ItemsSource = gradoBL.Get().ToList();
            cbGrado.DisplayMemberPath = "Nombre_Grado";
            cbGrado.SelectedValuePath = "Id";
            //Nombre de la tabla ciclo
            cbCiclo.ItemsSource = cicloBL.Get().ToList();
            cbCiclo.DisplayMemberPath = "Nombre_Ciclo";
            cbCiclo.SelectedValuePath = "Id";
            //Nombre de la tabla año
            cbYear.ItemsSource = yearBL.Get().ToList();
            cbYear.DisplayMemberPath = "Nombre_Year";
            cbYear.SelectedValuePath = "Id";
            UpdateGrid();
        }


        //INICIA LA PROGMACION DE AÑO
        private void btnGuardaraño_Click(object sender, RoutedEventArgs e)
        {
            if (txtYearaño.Text != "")
            {
                Years _year = new Years();
                _year.Nombre_Year = txtYearaño.Text;
                yearBL.Create(_year);
                UpdateGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnModificaraño_Click(object sender, RoutedEventArgs e)
        {
            if (txtYearaño.Text != "")
            {
                year.Nombre_Year = txtYearaño.Text;
                yearBL.Update(year);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminaraño_Click(object sender, RoutedEventArgs e)
        {

            if (txtYearaño.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    yearBL.Delete(year);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgYer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            year = new Years();
            year = dgYer.SelectedItem as Years;
            if (year != null)
            {
                txtYearaño.Text = year.Nombre_Year;
            }
        }
        // FINALIZA LA PROGRAMACION DE AÑO
        //INICIA LA PROGMACION DE CICLO
        private void btnGuardarciclo_Click(object sender, RoutedEventArgs e)
        {

            if (txtCiclo.Text != "")
            {
                Ciclo _ciclo = new Ciclo();
                _ciclo.Nombre_Ciclo = txtCiclo.Text;
                _ciclo.YearsId = Convert.ToInt64(cbYear.SelectedValue);
                cicloBL.Create(_ciclo);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione el registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btnModificarciclo_Click(object sender, RoutedEventArgs e)
        {
            if (txtCiclo.Text != "")
            {

                ciclo.Nombre_Ciclo = txtCiclo.Text;
                ciclo.YearsId = Convert.ToInt64(cbYear.SelectedValue);
                cicloBL.Update(ciclo);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione el registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarciclo_Click(object sender, RoutedEventArgs e)
        {
            if (txtCiclo.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    cicloBL.Delete(ciclo);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el registro a eliminar", "Eliminar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgCiclo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            ciclo = new Ciclo();
            ciclo = dgCiclo.SelectedItem as Ciclo;
            if (ciclo != null)
            {
                txtCiclo.Text = ciclo.Nombre_Ciclo;
                cbYear.SelectedValue = ciclo.YearsId;
            }
        }
        // FINALIZA LA PROGRAMACION DE CICLO
        //INICIA LA PROGMACION DE GRADO
        private void btnGuardargrado_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrado.Text != "")
            {
                Grado _grado = new Grado();
                _grado.Nombre_Grado = txtGrado.Text;
                _grado.CicloId = Convert.ToInt64(cbCiclo.SelectedValue);
                gradoBL.Create(_grado);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnModificargrado_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrado.Text != "")
            {
                grado.Nombre_Grado = txtGrado.Text;
                grado.CicloId = Convert.ToInt64(cbCiclo.SelectedValue);
                gradoBL.Update(grado);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminargrado_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrado.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    gradoBL.Delete(grado);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgGrado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            grado = new Grado();
            grado = dgGrado.SelectedItem as Grado;
            if (grado != null)
            {
                txtGrado.Text = grado.Nombre_Grado;
                cbCiclo.SelectedValue = grado.CicloId;
            }
        }
        // FINALIZA LA PROGRAMACION DE GRADO
        //INICIA LA PROGMACION DE MATERIA
        private void btnGuardarmateria_Click(object sender, RoutedEventArgs e)
        {

            if (txtMateria.Text != "")
            {
                Materia _materia = new Materia();
                _materia.Nombre_Materia = txtMateria.Text;
                materiaBL.Create(_materia);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnModificarmateria_Click(object sender, RoutedEventArgs e)
        {
            if (txtMateria.Text != "")
            {
                materia.Nombre_Materia = txtMateria.Text;
                materiaBL.Update(materia);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarmateria_Click(object sender, RoutedEventArgs e)
        {

            if (txtMateria.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    materiaBL.Delete(materia);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgMateria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            materia = new Materia();
            materia = dgMateria.SelectedItem as Materia;
            if (materia != null)
            {
                txtMateria.Text = materia.Nombre_Materia;
            }
        }
        // FINALIZA LA PROGRAMACION DE MATERIA
        //INICIA LA PROGMACION DE VALORES
        private void btnGuardarvalores_Click(object sender, RoutedEventArgs e)
        {

            if (txtvalor.Text != "")
            {
                Valores _Valor = new Valores();
                _Valor.Nombre = txtvalor.Text;
                valoresBL.Create(_Valor);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void btnModificavaloresr_Click(object sender, RoutedEventArgs e)
        {
            if (txtvalor.Text != "")
            {
                valores.Nombre = txtvalor.Text;
                valoresBL.Update(valores);
                UpdateGrid();
                Clear();
                Enable(false);
            }
            else
            {
                MessageBox.Show("Seleccione registro a modificar", "Modificar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarvalores_Click(object sender, RoutedEventArgs e)
        {
            if (txtvalor.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    valoresBL.Delete(valores);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgvalor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            valores = new Valores();
            valores = dgvalor.SelectedItem as Valores;
            if (valores != null)
            {
                txtvalor.Text = valores.Nombre;
            }
        }

        // FINALIZA LA PROGRAMACION DE VALORES
        //INICIA LA PROGMACION DE MATRICULA

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            //if (txtNie.Text != "" && txtprimerN.Text != "" && txtSegundoN.Text != "" && txtTercerN.Text != ""
            //    && txtPrimerA.Text != "" && txtSegundoA.Text != "" && dpnacimiento.Text != "" && txtDireccion.Text != ""
            //    && txtNombreResponsable.Text != "" && txtDUI.Text != "")
            {
                matricula.Nie = txtNie.Text;
                matricula.Primer_Nombre = txtprimerN.Text;
                matricula.Segundo_Nombre = txtSegundoN.Text;
                matricula.Tercer_Nombre = txtTercerN.Text;
                matricula.Primer_Apellido = txtPrimerA.Text;
                matricula.Segundo_Apellido = txtSegundoA.Text;
                matricula.Fecha_Nacimiento = dpnacimiento.Text;
                matricula.Direccion = txtDireccion.Text;
                matricula.Nombre_Responsable = txtNombreResponsable.Text;
                matricula.Sexo = cbSexo.Text;
                matricula.Turno = cbTurno.Text;
                matricula.DUI = txtDUI.Text;
                matricula.Seccion = cbSeccion.Text;
                matricula.GradoId = Convert.ToInt64(cbGrado.SelectedValue);
                matriculaBL.Create(matricula);
                UpdateGrid();
                Clear();
                Enable(false);
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            //if (txtNie.Text != "" && txtprimerN.Text != "" && txtSegundoN.Text != "" && txtTercerN.Text != ""
            //    && txtPrimerA.Text != "" && txtSegundoA.Text != "" && dpnacimiento.Text != "" && txtDireccion.Text != ""
            //    && txtNombreResponsable.Text != "" && txtDUI.Text != "")
            {

                matricula.Nie = txtNie.Text;
                matricula.Primer_Nombre = txtprimerN.Text;
                matricula.Segundo_Nombre = txtSegundoN.Text;
                matricula.Tercer_Nombre = txtTercerN.Text;
                matricula.Primer_Apellido = txtPrimerA.Text;
                matricula.Segundo_Apellido = txtSegundoA.Text;
                matricula.Fecha_Nacimiento = dpnacimiento.Text;
                matricula.Direccion = txtDireccion.Text;
                matricula.Nombre_Responsable = txtNombreResponsable.Text;
                matricula.Sexo = cbSexo.Text;
                matricula.Turno = cbTurno.Text;
                matricula.DUI = txtDUI.Text;
                matricula.Seccion = cbSeccion.Text;
                matricula.GradoId = Convert.ToInt64(cbGrado.SelectedValue);
                matriculaBL.Update(matricula);
                UpdateGrid();
                Clear();
                Enable(false);

            }

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            //if (txtNie.Text != "" && txtprimerN.Text != "" && txtSegundoN.Text != "" && txtTercerN.Text != ""
            //    && txtPrimerA.Text != "" && txtSegundoA.Text != "" && dpnacimiento.Text != "" && txtDireccion.Text != ""
            //    && txtNombreResponsable.Text != "" && txtDUI.Text != "" && cbTurno.Text != "" && cbSexo.Text != "")

            MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (r == MessageBoxResult.Yes)
            {
                matriculaBL.Delete(matricula);
                UpdateGrid();
                Clear();
                Enable(false);
            }

            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgMatricula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            matricula = new Matricula();
            matricula = dgMatricula.SelectedItem as Matricula;
            if (matricula != null)
            {
                txtNie.Text = matricula.Nie;
                txtprimerN.Text = matricula.Primer_Nombre;
                txtSegundoN.Text = matricula.Segundo_Nombre;
                txtTercerN.Text = matricula.Tercer_Nombre;
                txtPrimerA.Text = matricula.Primer_Apellido;
                txtSegundoA.Text = matricula.Segundo_Apellido;
                dpnacimiento.Text = matricula.Fecha_Nacimiento;
                txtDireccion.Text = matricula.Direccion;
                txtNombreResponsable.Text = matricula.Nombre_Responsable;
                cbSeccion.Text = matricula.Seccion;
                cbSexo.Text = matricula.Sexo;
                cbTurno.Text = matricula.Turno;
                txtDUI.Text = matricula.DUI;
                cbGrado.SelectedValue = matricula.GradoId;
            }
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rbNIe.IsChecked == true)
            {
                dgMatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Nie == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbNombre.IsChecked == true)
            {
                dgMatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Nombre == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbApellido.IsChecked == true)
            {
                dgMatricula.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Apellido == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }

        }
        // FINALIZA LA PROGRAMACION DE MATRICULA
        //INICIA LA PROGMACION DE NOTAS
        private void btnGuardarnotas_Click(object sender, RoutedEventArgs e)
        {

            if (cbMateria.Text != "")
            {



                Notas _notas = new Notas();

                //Notas notafinal = new Notas();
                //_notas = notasBL.Get().FirstOrDefault(n => n.matricula.Primer_Nombre == cbAlumno.Text);

                if (txtPrimerT.Text != "" && txtSegundoT.Text == "" && txtTercerT.Text == "")
                {

                    _notas.Primer_Trimestre = txtPrimerT.Text;
                    _notas.MatriculaId = id;
                    _notas.MateriaId = Convert.ToInt64(cbMateria.SelectedValue);
                    notasBL.Create(_notas);
                    UpdateGrid();
                    Clear();
                    Enable(false);



                }


            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnModificarnotas_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrimerT.Text != "" && txtSegundoT.Text == "" && txtTercerT.Text == "")
            {

                notas.Primer_Trimestre = txtPrimerT.Text;
                notas.MatriculaId = id;
                notas.MateriaId = Convert.ToInt64(cbMateria.SelectedValue);
                notasBL.Update(notas);
                UpdateGrid();
                Clear();
                Enable(false);



            }
            else if (cbMateria.Text != "")
            {



                //Notas _notas = new Notas();

                //Notas notafinal = new Notas();
                //_notas = notasBL.Get().FirstOrDefault(n => n.matricula.Primer_Nombre == cbAlumno.Text);


                if (txtPrimerT.Text != "" && txtSegundoT.Text != "" && txtTercerT.Text == "")
                {

                    notas.Segundo_Trimestre = txtSegundoT.Text;
                    notas.MatriculaId = id;
                    notas.MateriaId = Convert.ToInt64(cbMateria.SelectedValue);
                    notasBL.Update(notas);
                    UpdateGrid();
                    Clear();
                    Enable(false);

                }
                else if (txtPrimerT.Text != "" && txtSegundoT.Text != "" && txtTercerT.Text != "")
                {

                    notas.Tercer_Trimestre = txtTercerT.Text;
                    notas.MatriculaId = id;
                    notas.MateriaId = Convert.ToInt64(cbMateria.SelectedValue);
                    notasBL.Update(notas);
                    UpdateGrid();
                    Clear();
                    Enable(false);

                }




                int notafin = (Convert.ToInt32(notas.Primer_Trimestre) + Convert.ToInt32(notas.Segundo_Trimestre) + Convert.ToInt32(notas.Tercer_Trimestre)) / 3;
                notas.Promedio_Final = Convert.ToString(notafin);




                if (Convert.ToInt32(notas.Promedio_Final) >= 0 && Convert.ToInt32(notas.Promedio_Final) <= 5)
                {
                    notas.Estado = "Reprobado";
                }
                else if (Convert.ToInt32(notas.Promedio_Final) > 5 && Convert.ToInt32(notas.Promedio_Final) <= 10)
                {
                    notas.Estado = "Aprobado";
                }

            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarnotas_Click(object sender, RoutedEventArgs e)
        {

            if (txtPrimerT.Text != "" && txtSegundoT.Text != "" && txtTercerT.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    notasBL.Delete(notas);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgNotas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            notas = new Notas();
            notas = dgNotas.SelectedItem as Notas;
            if (notas != null)
            {
                txtPrimerT.Text = notas.Primer_Trimestre;
                txtSegundoT.Text = notas.Segundo_Trimestre;
                txtTercerT.Text = notas.Tercer_Trimestre;


                cbMateria.SelectedValue = notas.MateriaId;
            }
        }

        private void txtBuscarnotas_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (rbNIe.IsChecked == true)
            {
                dgNotas.ItemsSource = matriculaBL.Get().Where(pp => pp.Nie.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbNombre.IsChecked == true)
            {
                dgNotas.ItemsSource = matriculaBL.Get().Where(pp => pp.Segundo_Nombre.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbApellido.IsChecked == true)
            {
                dgNotas.ItemsSource = matriculaBL.Get().Where(pp => pp.Segundo_Apellido.Contains(txtBuscar.Text)).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
        }

        private void sm_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ModalMatricula list = new ModalMatricula();
            list.Show();
        }
        // FINALIZA LA PROGRAMACION DE NOTAS
        //INICIA LA PROGMACION DE NOTAS VALORES
        private void btnGuardarnotasvalores_Click(object sender, RoutedEventArgs e)
        {


            if (cb1TV.Text != "")
            {
                NotasValores _valor = new NotasValores();
                _valor.Primer_Trimestre = cb1TV.Text;
                _valor.Segundo_Trimestre = cb2TV.Text;
                _valor.Tercer_Trimestre = cb3TV.Text;
                _valor.MatriculaId = id;
                _valor.ValoresId = Convert.ToInt64(cbValores.SelectedValue);
                notasvaloresBL.Create(_valor);
                UpdateGrid();

                Enable(false);
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnModificarnotasvalores_Click(object sender, RoutedEventArgs e)
        {
            {

                notasvalores.Primer_Trimestre = cb1TV.Text;
                notasvalores.Segundo_Trimestre = cb2TV.Text;
                notasvalores.Tercer_Trimestre = cb3TV.Text;
                notasvalores.MatriculaId = id;
                notasvalores.ValoresId = Convert.ToInt64(cbValores.SelectedValue);
                notasvaloresBL.Update(notasvalores);
                UpdateGrid();

                Enable(false);

            }
        }

        private void btnEliminarnotasvalores_Click(object sender, RoutedEventArgs e)
        {
            if (cb1TV.Text != "" && cb2TV.Text != "" && cb3TV.Text != "")
            {
                MessageBoxResult r = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    valoresBL.Delete(valores);
                    UpdateGrid();
                    Clear();
                    Enable(false);
                }
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios", "Guardar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgnotasV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Enable(true);
            notasvalores = new NotasValores();
            notasvalores = dgnotasV.SelectedItem as NotasValores;
            if (notasvalores != null)
            {
                cb1TV.Text = notasvalores.Primer_Trimestre;
                cb2TV.Text = notasvalores.Segundo_Trimestre;
                cb3TV.Text = notasvalores.Tercer_Trimestre;

                cbValores.SelectedValue = notasvalores.ValoresId;
            }
        }

        private void txtBuscarnotasvalores_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rbNIe.IsChecked == true)
            {
                dgnotasV.ItemsSource = matriculaBL.Get().Where(pp => pp.Nie == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbNombre.IsChecked == true)
            {
                dgnotasV.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Nombre == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
            if (rbApellido.IsChecked == true)
            {
                dgnotasV.ItemsSource = matriculaBL.Get().Where(pp => pp.Primer_Apellido == txtBuscar.Text).ToList();
                if (txtBuscar.Text == "")
                {
                    UpdateGrid();
                }
            }
        }

        private void btnalum_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ModalMatricula22 list = new ModalMatricula22();
            list.Show();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }






        // FINALIZA LA PROGRAMACION DE NOTAS VALORES


    }
}
