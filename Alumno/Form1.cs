using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumno
{
    public partial class Form1 : Form
    {
        Alumno A = new Alumno(); //Instanciando la clase "Alumno" como A

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ") //Condicion por si el TextBox esta vacio
            {
                Ep.SetError(textBox1, "No ha Ingresado Matricula"); //Mensaje de aviso
            }
            else if (textBox2.Text == " ") //Condicion por si el TextBox esta vacio
            {
                Ep.SetError(textBox2, "No se ha Ingresado el Nombre"); //Mensaje de aviso
            }
            else if (textBox3.Text == " ") //Condicion por si el TextBox esta vacio
            {
                Ep.SetError(textBox3, "No se ha Ingresado el Semestre"); //Mensaje de aviso
            }
            else if (textBox4.Text == " ") //Condicion por si el TextBox esta vacio
            {
                Ep.SetError(textBox4, "No se ha Ingresasddo la Carrera"); //Mensaje de aviso
            }
            else if (textBox5.Text == " ") //Condicion por si el TextBox esta vacio
            {
                Ep.SetError(textBox5, "No se ha Ingresado el Telefono"); //Mensaje de aviso
            }

            try //Try-Catch por si el TextBox de la matricula no es un valor numerico
            {
                A.Matricula = Convert.ToInt32(textBox1.Text); //Convertimos a Int la Matricula

                MessageBox.Show(Convert.ToString(A.Matricula)); //Mensaje de la matricula ingresada
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString()); //Mensaje con toda esa madre del error

                MessageBox.Show("Error, ingrese valores Numericos..."); //Mensaje de aviso
            }

            try //Try-Catch por si se crea el alumno con los valores que se deben o no
            {
                throw new Excepcion_Especial("¡Creado Correctamente!"); //Mensaje de aviso
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en registrar alumno... "+ex.Message); //Mensaje de aviso mas el error
            }
            catch (Excepcion_Especial espex)
            {
                MessageBox.Show(espex.Message); //Mensaje de aviso
            }
            finally
            {
                Ep.Clear(); //Limpiamos el eeror...
            }
        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            //Miss Click...
        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
            //Miss Click de nuevo...
        }

        private void textBox6_Validating(object sender, CancelEventArgs e) //Evento Validating...
        {
            try //Try-Catch por si la calificacion no se encunetra dentro del rango
            {
                int cal = Convert.ToInt32(textBox6.Text); //Creamos una variable "cal" y le asignamos el textbox de la calificacion (conviertiendolo a int)

                if (cal <1 && cal>10) //Condiciion por si "cal" es menor a 1 y mayor a 10
                {
                    MessageBox.Show("Introducir Numero del 1 al 10... ","Error"); //Mensaje de aviso
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Entradad de Datos... ","Error",MessageBoxButtons.YesNo, MessageBoxIcon.Error); //Mensaje de Aviso
            }
        }
    }
}
