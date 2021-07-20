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
    public class NegocioIngreso
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
        public void insertarIngreso(Ingreso ingreso)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.ingreso (fecha,prioridad,paciente_id,medico_cargo_id) VALUES ('" + ingreso.Fecha +
                                    "','" + ingreso.Prioridad +
                                    "'," + ingreso.Paciente_id +
                                    "," + ingreso.Medico_cargo_id +
                                    ");";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarIngreso(Ingreso ingreso)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.ingreso SET fecha = '" + ingreso.Fecha +
                "', prioridad = '" + ingreso.Prioridad +
                "', paciente_id = " + ingreso.Paciente_id +
                "', medico_cargo_id = " + ingreso.Medico_cargo_id +
                " WHERE id = " + ingreso.Id + ";";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarIngreso(int id)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.ingreso WHERE id = " +
                id + ";";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarIngreso()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "ingreso";
            this.Conec.CadenaSQL = "SELECT * FROM ingreso;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Ingreso buscarIngreso(int id)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "ingreso";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.ingreso WHERE id = " +
                                    id + ";";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Ingreso auxIngreso = new Ingreso();
            try
            {
                auxIngreso.Id = (int)dt.Rows[0]["id"];
                auxIngreso.Fecha = (DateTime)dt.Rows[0]["fecha"];
                auxIngreso.Prioridad = (String)dt.Rows[0]["detalle"];
                auxIngreso.Paciente_id = (int)dt.Rows[0]["paciente_id"];
                auxIngreso.Medico_cargo_id = (int)dt.Rows[0]["medico_cargo_id"];
            }
            catch (Exception ex)
            {
                auxIngreso.Id = 0;
                auxIngreso.Fecha = DateTime.Now;
                auxIngreso.Paciente_id = 0;
                auxIngreso.Medico_cargo_id = 0;
                MessageBox.Show("Error al buscar Ingreso", "Mensaje de Sistema" + ex.Message);
            }

            return auxIngreso;
        }


        //RetornaPosicion
        public Ingreso posicionIngreso(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.ingreso ;";
            this.Conec.NombreTabla = "ingreso";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Ingreso auxIngreso = new Ingreso();
            try
            {
                auxIngreso.Id = (int)dt.Rows[fila]["id"];
                auxIngreso.Fecha = (DateTime)dt.Rows[fila]["fecha"];
                auxIngreso.Prioridad = (String)dt.Rows[fila]["prioridad"];
                auxIngreso.Paciente_id = (int)dt.Rows[fila]["paciente_id"];
                auxIngreso.Medico_cargo_id = (int)dt.Rows[fila]["medico_cargo_id"];
            }
            catch
            {
                auxIngreso.Id = 0;
                auxIngreso.Fecha = DateTime.Now;
                auxIngreso.Prioridad = "";
                auxIngreso.Paciente_id = 0;
                auxIngreso.Medico_cargo_id = 0;
            }

            return auxIngreso;
        }//Fin posicion
    }
}
