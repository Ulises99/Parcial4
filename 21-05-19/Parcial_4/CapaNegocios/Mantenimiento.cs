using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class Mantenimiento
    {
        bdConex test = new bdConex();
        private string Doctor_No, Hospital_Cod, Apellido, Especialidad;
        public DataTable dt = new DataTable();

        public string Especialidad1
        {
            get { return Especialidad; }
            set { Especialidad = value; }
        }

        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string Hospital_Cod1
        {
            get { return Hospital_Cod; }
            set { Hospital_Cod = value; }
        }

        public string Doctor_No1
        {
            get { return Doctor_No; }
            set { Doctor_No = value; }
        }

        public void insertDoctor()
        {
            try
            {
                String insert = "INSERT INTO (NUMERO,CODIGO,APELLIDO,ESPECIALIDAD)VALUES('" + Doctor_No + "','" + Hospital_Cod + "','" + Apellido + "','" + Especialidad +"')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void updateDoctor()
        {
            try
            {
                String insert = "UPDATE DOCTOR NUMERO,CODIGO,APELLIDO,ESPECIALIDAD)VALUES('" + Doctor_No + "','" + Hospital_Cod + "','" + Apellido + "','" + Especialidad + "')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deleteDoctor()
        {
            try
            {
                String insert = "DELETE DOCTOR NUMERO = '" + Doctor_No + "', CODIGO = '" + Hospital_Cod + "', APELLIDO = '" + Apellido + "', ESPECIALIDAD = '" + Especialidad + "'";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }

       
    }
}
