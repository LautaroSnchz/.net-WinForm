using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TrabajoFinal
{
    public partial class MDI : Form
    {
        private Form1 form1Instance;
        private static readonly string rutaBaseLogs = @"C:\Users\usuario\Documents\lautaro\proyectoWinForms\logs";

        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form1Instance = new Form1();
            form1Instance.MdiParent = this;
            form1Instance.Show();
        }
        private void ExportarDatos(string formato, string curso)
        {

            var archivos = Directory.GetFiles(rutaBaseLogs, $"{curso}.txt");

            foreach (var archivo in archivos)
            {
                string curso_ = Path.GetFileNameWithoutExtension(archivo);

                List<Ingresante> ingresantesCurso = LeerIngresantesDesdeTxt(archivo);

                if (ingresantesCurso.Count > 0)
                {
                    string rutaBaseJSON = @"C:\Users\usuario\Documents\lautaro\proyectoWinForms\json";
                    string rutaArchivoJSON = Path.Combine(rutaBaseJSON, $"{curso}.json");
                    string rutaBaseXML = @"C:\Users\usuario\Documents\lautaro\proyectoWinForms\xml";
                    string rutaArchivoXML = Path.Combine(rutaBaseXML, $"{curso}.xml");

                    try
                    {
                        if (formato.Equals("XML", StringComparison.OrdinalIgnoreCase))
                        {
                            SerializarEnXML(ingresantesCurso, rutaArchivoXML);
                            MessageBox.Show($"Se ha generado el archivo {curso}.xml en la ubicación:\n{rutaArchivoXML}",
                                "Archivo XML Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (formato.Equals("JSON", StringComparison.OrdinalIgnoreCase))
                        {
                            SerializarEnJSON(ingresantesCurso, rutaArchivoJSON);
                            MessageBox.Show($"Se ha generado el archivo {curso}.json en la ubicación:\n{rutaArchivoJSON}",
                                "Archivo JSON Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error de I/O al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"No hay ingresantes para exportar en el curso {curso}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private List<Ingresante> LeerIngresantesDesdeTxt(string archivo)
        {
            List<Ingresante> ingresantesCurso = new List<Ingresante>();

            if (File.Exists(archivo))
            {
                var lineas = File.ReadAllLines(archivo);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split('|').Select(d => d.Trim()).ToArray();
                    if (datos.Length == 6)
                    {
                        var ingresante = new Ingresante(
                            datos[0], // Nombre
                            datos[1], // Dirección
                            int.Parse(datos[2]), // Edad
                            datos[3], // CUIT
                            datos[4], // Género
                            datos[5], // País
                            new string[] { Path.GetFileNameWithoutExtension(archivo) }
                        );
                        ingresantesCurso.Add(ingresante);
                    }
                }
            }

            return ingresantesCurso;
        }

        private void SerializarEnXML(List<Ingresante> ingresantes, string rutaArchivo)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ingresante>));
            using (TextWriter writer = new StreamWriter(rutaArchivo))
            {
                serializer.Serialize(writer, ingresantes);
            }
        }

        private void SerializarEnJSON(List<Ingresante> ingresantes, string rutaArchivo)
        {
            string jsonString = JsonSerializer.Serialize(ingresantes);
            File.WriteAllText(rutaArchivo, jsonString);
        }

        //para XML
        //checkbox c#
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDatos("XML", "C#");
        }
        //checkbox c++
        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportarDatos("XML", "C++");
        }
        //checkbox javascript
        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDatos("XML", "Javascript");
        }
        //JSON
        //CHeckbox en c#
        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ExportarDatos("JSON", "C#");
        }
        //checkbox de c++
        private void cToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ExportarDatos("JSON", "C++");
        }
        //checkbox javasscriptos
        private void javaScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExportarDatos("JSON", "Javascript");
        }
    }
}
