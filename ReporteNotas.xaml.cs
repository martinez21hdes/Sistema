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
using System.Data;
using Microsoft.Reporting.WinForms;
using Sistema_Academico.DAL.DSNotasTableAdapters;
using Sistema_Academico.DAL;
using Sistema_Academico.BL;

namespace Sistema_Academico.UI.WPF
{
    /// <summary>
    /// Lógica de interacción para ReporteNotas.xaml
    /// </summary>
    public partial class ReporteNotas : Window
    {
        public ReporteNotas()
        {
            InitializeComponent();
        }

    }
}
