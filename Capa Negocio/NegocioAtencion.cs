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
    public class NegocioAtencion
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
        public void insertarAtencion(Atencion atencion)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.atencion (fecha,detalle,ingreso_id) VALUES ('" + atencion.Fecha +
                                    "','" + atencion.Detalle +
                                    "'," + atencion.Ingreso_id +
                                    ");";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarAtencion(Atencion atencion)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.atencion SET fecha = '" + atencion.Fecha +
                "', detalle = '" + atencion.Detalle +
                "', ingreso = " + atencion.Ingreso_id +
                " WHERE id = " + atencion.Id + ";";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarAtencion(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.atencion WHERE id = " +
                id + ";";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarAtencion()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "atencion";
            this.Conec.CadenaSQL = "SELECT * FROM atencion;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Atencion buscarAtencion(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "atencion";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.atencion WHERE id = " +
                                    id + ";";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Atencion auxAtencion = new Atencion();
            try
            {
                auxAtencion.Id = (int)dt.Rows[0]["id"];
                auxAtencion.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxAtencion.Detalle = (String)dt.Rows[0]["detalle"];
            }
            catch (Exception ex)
            {
                auxAtencion.Id = 0;
                auxAtencion.Fecha = DateTime.Now;
                auxAtencion.Detalle = "";
                MessageBox.Show("Error al buscar Atencion", "Mensaje de Sistema" + ex.Message);
            }

            return auxAtencion;
        }


        //RetornaPosicion
        public Atencion posicionAtencion(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.atencion ;";
            this.Conec.NombreTabla = "atencion";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Atencion auxAtencion = new Atencion();
            try
            {
                auxAtencion.Id = (int)dt.Rows[fila]["id"];
                auxAtencion.Fecha = (DateTime)dt.Rows[fila]["fecha"];
                auxAtencion.Detalle = (String)dt.Rows[fila]["detalle"];
            }
            catch
            {
                auxAtencion.Id = 0;
                auxAtencion.Fecha = DateTime.Now;
                auxAtencion.Detalle = "";
            }

            return auxAtencion;
        }//Fin posicionAtencion

    }
}
