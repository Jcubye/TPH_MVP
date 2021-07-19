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
    public class NegocioUbicacion
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
        public void insertarUbicacion(Ubicacion ubicacion)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.ubicacion (area,camas) VALUES ('" + ubicacion.Area +
                                    "'," + ubicacion.Camas +
                                    ");";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarUbicacion(Ubicacion ubicacion)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.ubicacion SET camas = '" + ubicacion.Camas +
                "' WHERE area = '" + ubicacion.Area + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarUbicacion(String area)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.ubicacion WHERE area = '" +
                area + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarUbicacion()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "ubicacion";
            this.Conec.CadenaSQL = "SELECT * FROM ubicacion;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Ubicacion buscaUbicacion(String area)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "ubicacion";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.ubicacion WHERE area = '" +
                                    area + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Ubicacion auxUbicacion = new Ubicacion();
            try
            {
                auxUbicacion.Id = (int)dt.Rows[0]["id"];
                auxUbicacion.Area = (String)dt.Rows[0]["area"];
                auxUbicacion.Camas = (int)dt.Rows[0]["camas"]; 
            }
            catch (Exception ex)
            {
                auxUbicacion.Id = 0;
                auxUbicacion.Area = String.Empty;
                auxUbicacion.Camas = 0;
                MessageBox.Show("Error al buscar Ubicacion", "Mensaje de Sistema" + ex.Message);
            }

            return auxUbicacion;
        }


        //RetornaPosicion
        public Ubicacion posicionUbicacion(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.ubicacion ;";
            this.Conec.NombreTabla = "ubicacion";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Ubicacion auxUbicacion = new Ubicacion();
            try
            {
                auxUbicacion.Id = (int)dt.Rows[fila]["id"];
                auxUbicacion.Area = (String)dt.Rows[fila]["area"];
                auxUbicacion.Camas = (int)dt.Rows[fila]["camas"];
            }
            catch
            {
                auxUbicacion.Id = 0;
                auxUbicacion.Area = String.Empty;
                auxUbicacion.Camas = 0;
            }

            return auxUbicacion;
        }
    }
}
