using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public class Ingresante
    {
        string nombre;
        string direccion;
        int edad;
        string cuit;
        string genero;
        string pais;
        string[] curso;

        string rutaBase = @"C:\Users\usuario\Documents\lautaro\proyectoWinForms\logs";
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public Ingresante(string nombre, string direccion, int edad, string cuit, string genero, string pais, string[] curso)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Curso = curso;
            this.Pais = pais;
        }
        public Ingresante()
        {

        }
        public override String ToString()
        {
            return Nombre + "\n" + Direccion + "\n" + "edad: " + Edad + "\n" + " Cuit:" + Cuit + "\n" + "Genero :" + Genero + "\n" + Pais;
        }

        public String ToStringCursos()
        {
            return "Los cursos seleccionados son: \n" + curso[0] + "\n" + curso[1] + "\n" + curso[2];
        }


        public bool Guardar()
        {
            foreach (var c in curso)
            {
                if (!string.IsNullOrEmpty(c))
                {
                    var guardarDatos = GuardarCurso(c);
                    if(guardarDatos == false)
                    {
                        return false;
                    }
                    
                    
                }
            }
            return true;
        }

        private  bool GuardarCurso(string curso)
        {
            if (!Directory.Exists(rutaBase))
            {
                Directory.CreateDirectory(rutaBase);
            }
            string archivo = Path.Combine(rutaBase, $"{curso}.txt");
            string linea = $"{Nombre} | {Direccion} | {Edad} | {Cuit} | {Genero} | {Pais}";
            int cuenta = 0;
            bool encontrado = false;
            List<string> lineas = new List<string>();

            try
            {
                if (File.Exists(archivo))
                {
                    lineas = File.ReadAllLines(archivo).ToList();
                    cuenta = lineas.Count;

                    foreach (var l in lineas)
                    {
                        if (l.Contains(Cuit))
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }

                if (cuenta >= 40)
                {
                    MessageBox.Show($"El curso {curso} ya tiene 40 inscritos.");
                    return false;
                }

                if (!encontrado)
                {
                    lineas.Add(linea);
                    File.WriteAllLines(archivo, lineas);
                    
                }
                else
                {
                    MessageBox.Show($"El CUIT {Cuit} ya está inscrito en el curso {curso}.");
                    return false;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error de I/O: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el curso {curso}: {ex.Message}");
            }
            return true;
        }

    }
}
