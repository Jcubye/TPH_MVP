using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Conexion
{
    public class Clase_Conexion
    {
        public class ConexionSQLSERVER
        {
            //instance values
            private string nombreBaseDatos;
            private string nombreTabla;
            private string cadenaConexion;
            private string cadenaSQL;
            private SqlConnection dbConnection;
            private DataSet dbDataSet;
            private SqlDataAdapter dbDataAdapter;
            private Boolean esSelect;

            public string NombreBaseDatos { get => nombreBaseDatos; set => nombreBaseDatos = value; }
            //public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
            public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
            public string CadenaSQL { get => cadenaSQL; set => cadenaSQL = value; }
            public SqlConnection DbConnection { get => dbConnection; set => dbConnection = value; }
            public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
            public SqlDataAdapter DbDataAdapter { get => dbDataAdapter; set => dbDataAdapter = value; }
            public bool EsSelect { get => esSelect; set => esSelect = value; }
            public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }

            //abrir conexion
            public void abrir()
            {
                try
                {
                    this.DbConnection.Open();

                }
                catch (Exception ex)
                {
                    //agregar referencia Windows Form System
                    MessageBox.Show("Error al abrir la conexion", "Mensaje de Sistema" + ex.Message);
                }
            }//fin abrir conexion

            //cerrar conexion
            public void cerrar()
            {
                try
                {
                    this.DbConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir la conexion", "Mensaje de Sistema" + ex.Message);
                }
            }//fin cerrar conexion

            //metodo de conexion
            public void conectar()
            {
                //Verificación de variables de instancias
                if (String.IsNullOrEmpty(this.NombreBaseDatos))
                {
                    MessageBox.Show("Error en la nombre de base de datos", "Mensaje de Sistema");
                    return;
                }

                //if (String.IsNullOrEmpty(this.NombreTabla))
                //{
                //    MessageBox.Show("Error en el nombre de tabla", "Mensaje de Sistema");
                //    return;
                //}


                if (String.IsNullOrEmpty(this.CadenaConexion))
                {
                    MessageBox.Show("Error en la conexion", "Mensaje de Sistema");
                    return;
                }


                if (String.IsNullOrEmpty(this.CadenaSQL))
                {
                    MessageBox.Show("Error en la consulta", "Mensaje de Sistema");
                    return;
                }

                //Instanciar la conexion

                try
                {
                    //conexion
                    this.DbConnection = new SqlConnection(this.CadenaConexion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar", "Mensaje de Sistema" + ex.Message);
                    return;
                }

                this.abrir();

                //preguntar si es un select
                if (this.EsSelect)
                {
                    //cargar dataset
                    this.DbDataSet = new DataSet();
                    try
                    {
                        this.DbDataAdapter = new SqlDataAdapter(this.CadenaSQL, this.DbConnection);
                        //Fill nos permite cargar nuestro dataset
                        //Fill permite cargar más de una tabla
                        this.DbDataAdapter.Fill(this.DbDataSet, this.NombreTabla);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el Data Set", "Mensaje de Sistema" + ex.Message);
                    }
                }
                else
                {
                    //INSERT DELETE UPDATE
                    try
                    {
                        SqlCommand variableSQL = new SqlCommand(this.CadenaSQL, this.DbConnection);
                        variableSQL.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Mensaje de Sistema");
                    }
                    //FIN INSERT DELETE UPDATE
                    this.cerrar();
                }
            }//Fin EsSelect

            ////Testing
            //public static void Main(String[] args)
            //{
            //    ConexionSQLSERVER connect = new ConexionSQLSERVER();
            //    connect.NombreBaseDatos = "TPH_MVP";
            //    connect.NombreTabla = "dbo.tutor";
            //    connect.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=TPH_MVP ;Integrated Security=True";

            //    //Los campos id autoincrementados no necesitan ser declarados
            //    connect.CadenaSQL = "INSERT INTO tutor (rut,clave,nombre,apellido,telefono,correo) VALUES (12345-6,'clave','Jona','cubillos','11223344','johnna@cubillos.cl') ";
            //    connect.EsSelect = false;
            //    connect.conectar();
            //    Console.WriteLine("wiwiwiwi");
            //    Console.ReadKey();
            //}//Fin Testing

        }
    }
    }
