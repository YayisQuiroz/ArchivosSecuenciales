using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosSecuenciales
{
    internal class Archivo
    {
        public string matricula;
        public string nombre;
        public string apaterno;
        public string amaterno;
        public string especialidad;
        public string semestre;

        #region Contructor
        public string Matricula 
        {
            get {  return matricula; } 
            set { matricula = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apaterno
        {
            get { return apaterno; }
            set { apaterno = value; }
        }
        public string Amaterno
        {
            get { return amaterno; }
            set { amaterno = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }
        #endregion
        


    }
}
