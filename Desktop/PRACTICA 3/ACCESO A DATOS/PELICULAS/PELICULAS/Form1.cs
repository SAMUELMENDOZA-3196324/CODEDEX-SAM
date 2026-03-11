using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PELICULAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //VARIABLES PRINCIPALES
        System.Data.OleDb.OleDbConnection conDB = new System.Data.OleDb.OleDbConnection();
        String sAccion = "";

        public void AbrirConexion()
        {
            //SE CREA EL STRING DE CONEXION A LA BASE DE DATOS
            conDB.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Alvaro Rivas\Documents\arcidito\Peliculas.accdb; Persist Security Info = False ";

            try
            {
                //SE ABRE LA BASE DE DATOS 
                conDB.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion" + ex);
            }

        }

        public void CerrarConexion()
        {
            //SE CHEQUEA SI ESTA LA CONEXION ABIERTA
            if (conDB.State == ConnectionState.Open)
            {
                //SE CIERRRA LA CONEXION
                conDB.Close();
            }
        }

        private void DesactivarAcciones()
        {
            butConsulta.Enabled = false;
            butAlta.Enabled = false;
            butBaja.Enabled = false;
            butModificacion.Enabled = false;
            butAceptar.Enabled = true;
            butCancelar.Enabled = true;
        }

        private void ActivarAcciones()
        {
            butConsulta.Enabled = true;
            butAlta.Enabled = true;
            butBaja.Enabled = true;
            butModificacion.Enabled = true;
            butAceptar.Enabled = false;
            butCancelar.Enabled = false;

            //SE CANCELA LA ACCION A REALIZAR
            sAccion = "";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //SE CIERRA LA CONEXION ANTES DE TERMINAR 
            CerrarConexion();

            //SE FINALIZA EL PROGRAMA
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SE ABRE LA CONEXION CON LA BASE DE DATOS
            AbrirConexion();
        }

        private void butConsulta_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Consulta";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butAlta_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HYA QUE REALIZAR
            sAccion = "Alta";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butBaja_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QU REALIZAR 
            sAccion = "Baja";

            //SE ACTUVAN Y DESACTUVAN LOS BOTOENES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butModificacion_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Modificacion";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            ActivarAcciones();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            //SE CHEQUEA LA ACCION QUE HAY QUE EJECUTAR
            if (sAccion == "Consulta")
            {
                //SE CHEQUEA SI HAY ALGUN CODIGO METIDO
                try
                {
                    if (Convert.ToInt32(txtCodigo.Text) > 0)
                    {
                        //SE REALIZA LA CONSULTA
                        string sConsulta = "SELECT * + " + "FROM PELICULA" + "WHERE Codigo =" + txtCodigo.Text;
                        OleDbCommand oleComando = new OleDbCommand(sConsulta, conDB);
                        OleDbDataReader oleReader = oleComando.ExecuteReader();

                        //SE LEE EL RESULTADO PARA VER SI HAY ALGUNO
                        if (oleReader.Read())
                        {
                            //SE MODIFICA LAS CAJAS DE TEXTO CON LOS DATOS DEL REGISTRO LEIDO
                            txtTitulo.Text = Convert.ToString(oleReader["Titulo"]);
                            txtDuracion.Text = Convert.ToString(oleReader["Duracion"]);
                        }

                        else
                        {
                            //SOMP HAY NINGUN REGISTRO, SE INDICA CON UN MENSAJE
                            MessageBox.Show("El codigo introducido no existe");
                        }
                    }

                    else
                    {
                        //SI SE HA METIDO UN CODIGO NEGATIVO, SE SOLICITA OTRO
                        MessageBox.Show("Introducir un codigo valido antes de consultar");
                    }
                }
                catch
                {
                    //SI SE HA INTRODUCIDO UN CODIGO NO NUMERO, SE SOLICITA OTRO
                    MessageBox.Show("Introducir un codigo antes de consultar");
                }
            }
            else
            {
                if (sAccion == "Alta")
                {
                    try
                    {
                        //SE REALIZA LA INSERCION
                        string sConsulta = "INSERT INTO PELICULA (Titulo, Duracion)"
                        + "VALUES('" + txtTitulo.Text + "', " + txtDuracion.Text + ")";

                        OleDbCommand oleCOmando = new OleDbCommand();
                        oleCOmando.CommandType = CommandType.Text;
                        oleCOmando.CommandText = sConsulta;
                        oleCOmando.Connection = conDB;

                        //SE EJECUTA EL COMANDO DE INSERCION
                        oleCOmando.ExecuteNonQuery();

                        //SE BORRAN LAS CAJAS DE TEXTO
                        txtCodigo.Text = "";
                        txtTitulo.Text = "";
                        txtDuracion.Text = "";

                    }

                    catch (Exception ex)
                    {
                        //SI SE HA PRODUCIDO UN ERROR, SE MUESTRA UN MENSAJE
                        MessageBox.Show("Error en la insercion" + ex);
                    }

                }

                else
                {
                    if (sAccion == "Baja")
                    {
                        try
                        {
                            //SE REALIZA LA ELIMINACION
                            string sConsulta = "DELETE FROM PELICULA" + "WHERE Codigo =" + txtCodigo.Text;
                            OleDbCommand oleComando = new OleDbCommand();

                            oleComando.CommandType = CommandType.Text;
                            oleComando.CommandText = sConsulta;
                            oleComando.Connection = conDB;

                            //SE EJECUTA EL COMANDO DE ELIMINACION
                            oleComando.ExecuteNonQuery();

                            //SE BORRAN LAS CAJAS DE TEXTO
                            txtCodigo.Text = "";
                            txtTitulo.Text = "";
                            txtDuracion.Text = "";
                        }

                        catch (Exception ex)
                        {
                            //SI SE HA PRODUCIDO UN ERROR SE MUESTRA UN MENSAJE
                            MessageBox.Show("Error en el borrado" + ex);
                        }
                    }

                    else
                    {
                        try
                        {
                            //SE RELIZA LA MODIFICACION
                            string sConsulta = "UPDATE PELICULA" + "SET Titulo='" + txtTitulo.Text
                            + "'," + "Duracion=" + txtDuracion.Text + "WHERE Codigo=" + txtCodigo.Text;

                            OleDbCommand oleComando = new OleDbCommand();
                            oleComando.CommandType = CommandType.Text;
                            oleComando.CommandText = sConsulta;
                            oleComando.Connection = conDB;

                            //SE EJECUTA EL COMANDO DE MODIFICACION
                            oleComando.ExecuteNonQuery();

                            //SE BORRAN LAS CAJAS DE TEXTO
                            txtCodigo.Text = "";
                            txtTitulo.Text = "";
                            txtDuracion.Text = "";
                        }

                        catch(Exception ex)
                        {
                            //SI SE MUESTRA UN ERROR SE MUESTRA UN MENSAJE
                            MessageBox.Show("Error al modificar" + ex);
                        }
                    }
                }
            }

            //SE DETERMINA LA ACCION REALIZADA
            sAccion = "";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            ActivarAcciones();
        }
    }
}