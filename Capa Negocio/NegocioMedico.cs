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
    public class NegocioMedico
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
        public void insertarMedico(Medico_cargo medico)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.medico_cargo (rut,clave,nombre,apellido,especialidad) VALUES ('" + medico.Rut +
                                    "','" + medico.Clave +
                                    "','" + medico.Nombre +
                                    "','" + medico.Apellido +
                                    "','" + medico.Especialidad +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarMedico(Medico_cargo medico)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.,medico_cargo SET clave = '" + medico.Clave +
                "', nombre = '" + medico.Nombre +
                "', apellido = '" + medico.Apellido +
                "', telefono = '" + medico.Especialidad +
                "' WHERE rut = '" + medico.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarMedico(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.medico_cargo WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarMedico()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "cargo_medico";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.cargo_medico;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Medico_cargo buscaMedico(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "medico_cargo";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.medico_cargo WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Medico_cargo auxMedico = new Medico_cargo();
            try
            {
                auxMedico.Id = (int)dt.Rows[0]["id"];
                auxMedico.Rut = (String)dt.Rows[0]["rut"];
                auxMedico.Clave = (String)dt.Rows[0]["clave"];
                auxMedico.Nombre = (String)dt.Rows[0]["nombre"];
                auxMedico.Apellido = (String)dt.Rows[0]["apellido"];
                auxMedico.Especialidad = (String)dt.Rows[0]["especialidad"];
            }
            catch (Exception ex)
            {
                auxMedico.Id = 0;
                auxMedico.Rut = String.Empty;
                auxMedico.Clave = String.Empty;
                auxMedico.Nombre = String.Empty;
                auxMedico.Apellido = String.Empty;
                auxMedico.Especialidad = String.Empty;
                MessageBox.Show("Error al buscar tutor", "Mensaje de Sistema" + ex.Message);
            }

            return auxMedico;
        }


        //RetornaPosicion
        public Medico_cargo posicionMedico(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.medico_cargo ;";
            this.Conec.NombreTabla = "medico_cargo";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Medico_cargo auxMedico = new Medico_cargo();
            try
            {
                auxMedico.Id = (int)dt.Rows[fila]["id"];
                auxMedico.Rut = (String)dt.Rows[fila]["rut"];
                auxMedico.Clave = (String)dt.Rows[fila]["clave"];
                auxMedico.Nombre = (String)dt.Rows[fila]["nombre"];
                auxMedico.Apellido = (String)dt.Rows[fila]["apellido"];
                auxMedico.Especialidad = (String)dt.Rows[fila]["especialidad"];
            }
            catch
            {
                auxMedico.Id = 0;
                auxMedico.Rut = String.Empty;
                auxMedico.Clave = String.Empty;
                auxMedico.Nombre = String.Empty;
                auxMedico.Apellido = String.Empty;
                auxMedico.Especialidad = String.Empty;
            }

            return auxMedico;
        }
    }
}
