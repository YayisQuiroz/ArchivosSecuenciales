using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ArchivosSecuenciales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string matricula, nombre, apaterno, amaterno, especialidad, semestre;

        private void altasDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("ArchivoSecuencial.txt", true, Encoding.ASCII);
            DialogBoxAltas Altas = new DialogBoxAltas();
            Altas.Text = "Lista de Alumnos";
            if(Altas.ShowDialog() == DialogResult.OK)
            {
                sw.WriteLine(Altas.matricula);
                sw.WriteLine(Altas.nombre);
                sw.WriteLine(Altas.apaterno);
                sw.WriteLine(Altas.amaterno);
                sw.WriteLine(Altas.especialidad);
                sw.WriteLine(Altas.semestre);
                MessageBox.Show("Los datos del alumno se guardaron correctamente","altas de alumnos",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sw.Close();
                listView1.Items.Clear();
                using (StreamReader sr = new StreamReader("ArchivoSecuencial.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        Lectura(sr);
                        AgregarLv();
                    }
                }
            }
        }

        #region Busquedas
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            Lectura(sr);

            while (matricula != null)
            {
                AgregarLv();
                Lectura(sr);
            }
            sr.Close();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxConsulta busquedas = new DialogBoxConsulta();
            busquedas.Text = "Busquedas por Matricula";
            busquedas.TextoLabel = "Matricula del Alumno";
            if (busquedas.ShowDialog() == DialogResult.OK)
            {
                bool bandera = true;
                Lectura(sr);
                matricula.ToLower();
                while (matricula != null && bandera == true)
                {
                    if (matricula == busquedas.Parametro.ToLower())
                    {
                        bandera = false;
                        AgregarLv();

                    }
                    Lectura(sr);
                    
                }
                sr.Close();
                if (bandera == true)
                {
                    MessageBox.Show("La matricula del alumno no existe","Problema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void apellidoPaternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxConsulta busquedas = new DialogBoxConsulta();
            busquedas.Text = "Busqueda por Apellido Paterno";
            busquedas.TextoLabel = "Apellido Paterno del Alumno";
            if (busquedas.ShowDialog() == DialogResult.OK)
            {
                bool bandera = false;
                Lectura(sr);
                while (matricula != null)
                {
                    if (apaterno.ToLower() == busquedas.Parametro.ToLower())
                    {
                        bandera = true;
                        AgregarLv();
                    }
                    Lectura(sr);
                }
                sr.Close();
                if (!bandera)
                {
                    MessageBox.Show("No existe alumno con esta apellido", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sr.Close();

            }
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxConsulta busquedas = new DialogBoxConsulta();
            busquedas.Text = "Busquedas por Especialidad";
            busquedas.Especialidades = true;
            busquedas.TextoLabel = "Especialidad del Alumno";
            if (busquedas.ShowDialog() == DialogResult.OK)
            {
                bool encontrado = false;
                Lectura(sr);
                while (matricula != null)
                {
                    if (especialidad.ToLower() == busquedas.Parametro.ToLower())
                    {
                        encontrado = true;
                        AgregarLv();
                    }
                    Lectura(sr);
                }
                if (!encontrado)
                {
                    MessageBox.Show("Especialidad no encontrada", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sr.Close();
            }
        }

        private void semestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            StreamReader sr = new StreamReader("ArchivoSecuencial.txt");
            DialogBoxConsulta busquedas = new DialogBoxConsulta();
            busquedas.Text = "Busqueda por Semestre";
            busquedas.TextoLabel = "Semestre del Alumno";
            busquedas.SoloNumeros = true;
            if (busquedas.ShowDialog() == DialogResult.OK)
            {
                bool bandera = true;
                Lectura(sr);
                while (matricula != null)
                {
                    if (semestre == busquedas.Parametro)
                    {
                        bandera = false;
                        AgregarLv();

                    }
                    Lectura(sr);
                }
                if (bandera == true)
                {
                    MessageBox.Show("Semestre no encontrado", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sr.Close();
            }
        }
        #endregion
        private void modificacionesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string archivoOriginal = "ArchivoSecuencial.txt";
            string archivoAuxiliar = "Auxiliar.txt";

            DialogBoxEliminar modificar = new DialogBoxEliminar();
            modificar.Text = "Modificar";
            if (modificar.ShowDialog() == DialogResult.OK)
            {
                
                string matriculaAmodificar = modificar.Parametro;
                bool Modificado = true;
                bool encontrado = false;

                try
                {
                    using (StreamReader sr = new StreamReader(archivoOriginal))
                    using (StreamWriter sw = new StreamWriter(archivoAuxiliar))
                    {
                        while (!sr.EndOfStream)
                        {
                            Lectura(sr);

                            if (matricula.Trim().ToLower() == matriculaAmodificar.Trim().ToLower())
                            {
                                encontrado = true;
                                DialogBoxAltas modificacion = new DialogBoxAltas();
                                modificacion.Text = "Alumno a Modificar";
                                modificacion.matricula = matricula;
                                modificacion.nombre = nombre;
                                modificacion.apaterno = apaterno;
                                modificacion.amaterno = amaterno;
                                modificacion.especialidad = especialidad;
                                modificacion.semestre = semestre;

                                if (modificacion.ShowDialog() == DialogResult.OK)
                                {
                                    sw.WriteLine(modificacion.matricula);
                                    sw.WriteLine(modificacion.nombre);
                                    sw.WriteLine(modificacion.apaterno);
                                    sw.WriteLine(modificacion.amaterno);
                                    sw.WriteLine(modificacion.especialidad);
                                    sw.WriteLine(modificacion.semestre);
                                    
                                    listView1.Items.Clear();
                                }
                                else
                                {
                                    Escritura(sw);
                                }
                            }
                            else
                            {
                                Escritura(sw);
                            }

                        }

                        sr.Close();
                        sw.Close();
                    }
                    File.Delete(archivoOriginal);
                    File.Move(archivoAuxiliar, archivoOriginal);

                    if (encontrado && Modificado)
                    {
                        MessageBox.Show("Registro modificado correctamente.");
                        listView1.Items.Clear();
                        using (StreamReader sr = new StreamReader("ArchivoSecuencial.txt"))
                        {
                            while (!sr.EndOfStream)
                            {
                                Lectura(sr);
                                AgregarLv();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Matrícula no encontrada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Operacion cancelada");
            }

        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string archivoOriginal = "ArchivoSecuencial.txt";
            string archivoAuxiliar = "Auxiliar.txt";

            DialogBoxEliminar eliminar = new DialogBoxEliminar();

            if (eliminar.ShowDialog() == DialogResult.OK)
            {
                string matriculaAEliminar = eliminar.Parametro;

                try
                {
                    using (StreamReader sr = new StreamReader(archivoOriginal))
                    using (StreamWriter sw = new StreamWriter(archivoAuxiliar))
                    {
                        while (!sr.EndOfStream)
                        {
                            Lectura(sr);
                            if (matricula.Trim().ToLower() == matriculaAEliminar.Trim().ToLower())
                                continue;
                            Escritura(sw);
                        }
                        sr.Close();
                        sw.Close();
                    }

                    
                    File.Delete(archivoOriginal);
                    File.Move(archivoAuxiliar, archivoOriginal);

                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    using (StreamReader sr = new StreamReader("ArchivoSecuencial.txt"))
                    {
                        while (!sr.EndOfStream)
                        {
                            Lectura(sr);
                            AgregarLv(); 
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        #region Metodos
        private void Lectura(StreamReader sr)
        {
            matricula = sr.ReadLine();
            nombre = sr.ReadLine();
            apaterno = sr.ReadLine();
            amaterno = sr.ReadLine();
            especialidad = sr.ReadLine();
            semestre = sr.ReadLine();
        }
        private void Escritura(StreamWriter sw)
        {
            sw.WriteLine(matricula);
            sw.WriteLine(nombre);
            sw.WriteLine(apaterno);
            sw.WriteLine(amaterno);
            sw.WriteLine(especialidad);
            sw.WriteLine(semestre);
        }
        private void AgregarLv()
        {
            ListViewItem Datos = new ListViewItem(matricula);
            Datos.SubItems.Add(nombre);
            Datos.SubItems.Add(apaterno);
            Datos.SubItems.Add(amaterno);
            Datos.SubItems.Add(especialidad);
            Datos.SubItems.Add(semestre);
            listView1.Items.Add(Datos);
        }
        #endregion
    }
}
