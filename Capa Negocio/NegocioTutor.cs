using Capa_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Capa_Conexion.Clase_Conexion;

namespace Capa_Negocio
{
    public class NegocioTutor
    {
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }

        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "TPH_MVP";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=TPH_MVP;Integrated Security=True";
        }

        //Insertar
        public void insertarTutor(Tutor tutor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.tutor (rut,clave,nombre,apellido,telefono,correo) VALUES ('" + tutor.Rut +
                                    "','" + tutor.Clave +
                                    "','" + tutor.Nombre +
                                    "','" + tutor.Apellido +
                                    "','" + tutor.Telefono +
                                    "','" + tutor.Correo +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarTutor(Tutor tutor)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.tutor SET rut = '" + tutor.Rut +
                ", clave = '" + tutor.Clave +
                ", nombre = '" + tutor.Nombre +
                ", apellido = '" + tutor.Apellido +
                ", telefono = '" + tutor.Telefono +
                ", correo = '" + tutor.Correo +

                "' WHERE rut = '" + tutor.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarTutor(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.tutor WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarTutor()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "tutor";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Tutor buscaTutor(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "tutor";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Tutor auxTutor = new Tutor();
            try
            {
                auxTutor.Id = (int)dt.Rows[0]["id"];
                auxTutor.Rut = (String)dt.Rows[0]["rut"];
                auxTutor.Nombre = (String)dt.Rows[0]["nombre"];
                auxTutor.Apellido = (String)dt.Rows[0]["apellido"];
                auxTutor.Correo = (String)dt.Rows[0]["correo"];
                auxTutor.Telefono = (String)dt.Rows[0]["telefono"];
                auxTutor.Clave = (String)dt.Rows[0]["clave"];
            }
            catch (Exception ex)
            {
                auxTutor.Id = 0;
                auxTutor.Rut = String.Empty;
                auxTutor.Nombre = String.Empty;
                auxTutor.Apellido = String.Empty;
                auxTutor.Correo = String.Empty;
                auxTutor.Telefono = String.Empty;
                auxTutor.Clave = String.Empty;
                MessageBox.Show("Error al buscar tutor", "Mensaje de Sistema" + ex.Message);
            }

            return auxTutor;
        }


        public Tutor posicionTutor(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.tutor ;";
            this.Conec.NombreTabla = "tutor";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Tutor auxTutor = new Tutor();
            try
            {
                auxTutor.Id = (int)dt.Rows[fila]["id"];
                auxTutor.Rut = (String)dt.Rows[fila]["rut"];
                auxTutor.Nombre = (String)dt.Rows[fila]["nombre"];
                auxTutor.Apellido = (String)dt.Rows[fila]["apellido"];
                auxTutor.Correo = (String)dt.Rows[fila]["correo"];
                auxTutor.Telefono = (String)dt.Rows[fila]["telefono"];
                auxTutor.Clave = (String)dt.Rows[fila]["clave"];
            }
            catch
            {
                auxTutor.Id = 0;
                auxTutor.Rut = String.Empty;
                auxTutor.Nombre = String.Empty;
                auxTutor.Apellido = String.Empty;
                auxTutor.Correo = String.Empty;
                auxTutor.Telefono = String.Empty;
                auxTutor.Clave = String.Empty;
            }

            return auxTutor;
        }

    }
}
