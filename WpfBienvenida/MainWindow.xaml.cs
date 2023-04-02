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

namespace WpfBienvenida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaración variable global
        string nomnbre;
        private void btmSalir_Click(object sender, RoutedEventArgs e)
        {
            //Cierra la aplicación
            this.Close();
        }

        private void btmLimpiar_Click(object sender, RoutedEventArgs e)
        {
            //Permite salir los controles
            this.txtNombre.Text = string.Empty;
            this.lblMensaje.Content = string.Empty;
        }

        private void btmMostrar_Click(object sender, RoutedEventArgs e)
        {
            //Variable local
            string mensaje;
            //Recuparar el valor del textbox
            nomnbre = this.txtNombre.Text;
            //Formar el mensaje
            mensaje = "Bienvenid@ al curso  " + nomnbre;
            //Mostrar el mensaje
            this.lblMensaje.Content += mensaje;
        }
    }
}
