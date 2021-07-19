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
    public class NegocioPaciente
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
        public void insertarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.paciente (rut,nombre,apellido,antecedentes,stock_productos,disponibilidad,epicrisis,telefono,tutor_id,tutor_nombre,ubicacion_id) VALUES ('" + paciente.Rut +
                                    "','" + paciente.Nombre +
                                    "','" + paciente.Apellido +
                                    "','" + paciente.Antecedentes +
                                    "','" + paciente.Stock_productos +
                                    "','" + paciente.Disponibilidad +
                                    "','" + paciente.Epicrisis +
                                    "','" + paciente.Telefono +
                                    "','" + paciente.Tutor_id +
                                    "','" + paciente.Tutor_nombre +
                                    "','" + paciente.Ubicacion_id +
                                    "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Actualizar
        public void actualizarPaciente(Paciente paciente)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE dbo.paciente SET nombre = '" + paciente.Nombre +
                "', apellido = '" + paciente.Apellido +
                "', antecedentes = '" + paciente.Antecedentes +
                "', stock_productos = '" + paciente.Stock_productos +
                "', disponibilidad = '" + paciente.Disponibilidad +
                "', epicrisis = '" + paciente.Epicrisis +
                "', telefono = '" + paciente.Telefono +
                "', tutor_id = '" + paciente.Tutor_nombre +
                "', tutor_nombre = '" + paciente.Tutor_nombre +
                "', ubicacion_id = '" + paciente.Ubicacion_id +
                "' WHERE rut = '" + paciente.Rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Eliminar 
        public void eliminarPaciente(String rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE dbo.paciente WHERE rut = '" +
                rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }

        //Consultar 
        public DataSet consultarPaciente()
        {
            this.configurarConexion();
            //es necesario referenciar la tabla sino no se cae
            this.Conec.NombreTabla = "paciente";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente;";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }

        //Buscar
        public Paciente buscarPaciente(String rut)
        {
            this.configurarConexion();
            this.Conec.NombreTabla = "paciente";
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente WHERE rut = '" +
                                    rut + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Paciente auxPaciente = new Paciente();
            try
            {
                auxPaciente.Id = (int)dt.Rows[0]["id"];
                auxPaciente.Rut = (String)dt.Rows[0]["rut"];
                auxPaciente.Nombre = (String)dt.Rows[0]["nombre"];
                auxPaciente.Apellido = (String)dt.Rows[0]["apellido"];
                auxPaciente.Antecedentes = (String)dt.Rows[0]["antecedentes"];
                auxPaciente.Stock_productos = (String)dt.Rows[0]["stock_productos"];
                auxPaciente.Disponibilidad = (String)dt.Rows[0]["disponibilidad"];
                auxPaciente.Epicrisis = (String)dt.Rows[0]["epicrisis"];
                auxPaciente.Telefono = (String)dt.Rows[0]["telefono"];
                auxPaciente.Tutor_id = (int)dt.Rows[0]["tutor_id"];
                auxPaciente.Tutor_nombre = (String)dt.Rows[0]["tutor_nombre"];
                auxPaciente.Ubicacion_id = (int)dt.Rows[0]["ubicacion_id"];
            }
            catch (Exception ex)
            {
                auxPaciente.Id = 0;
                auxPaciente.Rut = String.Empty;
                auxPaciente.Nombre = String.Empty;
                auxPaciente.Apellido = String.Empty;
                auxPaciente.Antecedentes = String.Empty;
                auxPaciente.Stock_productos = String.Empty;
                auxPaciente.Disponibilidad = String.Empty;
                auxPaciente.Epicrisis = String.Empty;
                auxPaciente.Telefono = String.Empty;
                auxPaciente.Tutor_id = 0;
                auxPaciente.Tutor_nombre = String.Empty;
                auxPaciente.Ubicacion_id = 0;
                MessageBox.Show("Error al buscar paciente", "Mensaje de Sistema" + ex.Message);
            }

            return auxPaciente;
        }


        //RetornaPosicion
        public Paciente posicionPaciente(int fila)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "SELECT * FROM dbo.paciente ;";
            this.Conec.NombreTabla = "paciente";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec.DbDataSet.Tables[0];

            Paciente auxPaciente = new Paciente();
            try
            {
                auxPaciente.Id = (int)dt.Rows[fila]["id"];
                auxPaciente.Rut = (String)dt.Rows[fila]["rut"];
                auxPaciente.Nombre = (String)dt.Rows[fila]["nombre"];
                auxPaciente.Apellido = (String)dt.Rows[fila]["apellido"];
                auxPaciente.Antecedentes = (String)dt.Rows[fila]["antecedentes"];
                auxPaciente.Stock_productos = (String)dt.Rows[fila]["stock_productos"];
                auxPaciente.Disponibilidad = (String)dt.Rows[fila]["disponibilidad"];
                auxPaciente.Epicrisis = (String)dt.Rows[fila]["epicrisis"];
                auxPaciente.Telefono = (String)dt.Rows[fila]["telefono"];
                auxPaciente.Tutor_id = (int)dt.Rows[fila]["tutor_id"];
                auxPaciente.Tutor_nombre = (String)dt.Rows[fila]["tutor_nombre"];
                auxPaciente.Ubicacion_id = (int)dt.Rows[fila]["ubicacion_id"];
            }
            catch
            {
                auxPaciente.Id = 0;
                auxPaciente.Rut = String.Empty;
                auxPaciente.Nombre = String.Empty;
                auxPaciente.Apellido = String.Empty;
                auxPaciente.Antecedentes = String.Empty;
                auxPaciente.Stock_productos = String.Empty;
                auxPaciente.Disponibilidad = String.Empty;
                auxPaciente.Epicrisis = String.Empty;
                auxPaciente.Telefono = String.Empty;
                auxPaciente.Tutor_id = 0;
                auxPaciente.Tutor_nombre = String.Empty;
                auxPaciente.Ubicacion_id = 0;
            }

            return auxPaciente;
        }//fin posicion


    }
}
