using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btoIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nupEdad.Value;
            string cuit = mtbCUIT.Text.Trim();
            if (Funciones.ValidaCuit(cuit))
            {
                string genero = "";
                if (rbFemenino.Checked) genero = rbFemenino.Text.Trim();
                if (rbMasculino.Checked) genero = rbMasculino.Text.Trim();
                if (rbNoBinario.Checked) genero = rbNoBinario.Text.Trim();

                string c1 = chkc.Checked ? chkc.Text.Trim() : "";
                string c2 = chkCplus.Checked ? chkCplus.Text.Trim() : "";
                string c3 = chkJavaScript.Checked ? chkJavaScript.Text.Trim() : "";

                string[] curso = new string[3];
                if (c1 == "" && c2 == "" && c3 == "")
                {
                    MessageBox.Show("Seleccione una opción para curso");
                }
                else
                {
                    curso[0] = c1;
                    curso[1] = c2;
                    curso[2] = c3;
                }

                string pais = lbPais.Text.Trim();

                Ingresante ing = new Ingresante(nombre, direccion, edad, cuit, genero, pais, curso);


                if (Funciones.mConsulta(this, "Datos Ingresante \n" + ing.ToString()))
                {
                    if (MessageBox.Show(ing.ToStringCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        bool datos = ing.Guardar();
                        if(datos == true)
                        {
                        GuardarEnBaseDeDatos(ing);

                        }
                        this.Vaciar();
                    }
                    else
                    {
                        MessageBox.Show("verifique los datos e intente nuevamente");
                    }

                }
                else
                {
                    MessageBox.Show("Datos Descartados");

                    this.Vaciar();

                }

            }
            else
            {
                MessageBox.Show("Ingrese un Cuit Valido");
            }
        }
        private void GuardarEnBaseDeDatos(Ingresante ingresante)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["proyectoWinForms.Properties.Settings.Test_programacion3ConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [test_programacion3].[dbo].[ingresante] (nombre, direccion, edad, [cuit/l], genero, pais, curso) " +
                               "VALUES (@nombre, @direccion, @edad, @cuit, @genero, @pais, @curso)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", ingresante.Nombre);
                command.Parameters.AddWithValue("@direccion", ingresante.Direccion);
                command.Parameters.AddWithValue("@edad", ingresante.Edad);
                command.Parameters.AddWithValue("@cuit", ingresante.Cuit);
                command.Parameters.AddWithValue("@genero", ingresante.Genero);
                command.Parameters.AddWithValue("@pais", ingresante.Pais);
                if (ingresante.Curso[0] == "C#")
                {
                    command.Parameters.AddWithValue("@curso", ingresante.Curso[0]);
                }else if(ingresante.Curso[1] == "C++")
                {
                    command.Parameters.AddWithValue("@curso", ingresante.Curso[1]);
                }
                else
                {
                    command.Parameters.AddWithValue("@curso", ingresante.Curso[2]);
                }
              
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente en la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
            }
        }
        public List<Ingresante> ObtenerIngresantesPorCurso(string curso)
        {
            List<Ingresante> ingresantesCurso = new List<Ingresante>();


            foreach (Ingresante ingresante in ingresantesCurso)
            {
                if (ingresante.Curso.Contains(curso))
                {
                    ingresantesCurso.Add(ingresante);
                }
            }

            return ingresantesCurso;
        }

        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nupEdad.Value = 18;
            mtbCUIT.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkc.Checked = false;
            chkCplus.Checked = false;
            chkJavaScript.Checked = false;
            lbPais.Text = "";
        }
        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
