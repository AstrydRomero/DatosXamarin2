using System;
using System.Collections.Generic;
using System.Text;

namespace DatosXamarin2.Model
{
     public class EStudianteModel: NotifyModel
    {
        private int _ID;

        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string _NombredelEstudiantes;

        public string NombredelEstudiantes
        {
            get { return _NombredelEstudiantes; }
            set { _NombredelEstudiantes = value; }
        }

        private string _ApellidoEstudiante;


        public string ApellidoEstudiante
        {
            get { return _ApellidoEstudiante; }
            set { _ApellidoEstudiante = value; }
        }

        private string _Curso;


        public string Curso
        {
            get { return _Curso; }
            set { Curso = value; }
        }
        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        private double _Direccion;

        public double Direccion
        {
            get { return _Direccion; }
            set { Direccion = value; }
        }

        private string _Responsable;

        public string Responsable
        {
            get { return _Responsable; }
            set { Responsable = value; }
        }


    }
}
