using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIAJES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //VARIABLES PRINCIPALES
        System.Data.OleDb.OleDbConnection conBD = new System.Data.OleDb.OleDbConnection();
        string sAccion = "";

        public void AbrirConexion()
        {
            //SE CREA EL STRING DE CONEXION A LA BASE DE DATOS
            conBD.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Alvaro Rivas\Documents\arcidito\Viajes.accdb; Persist Security Info = False ";


            try
            {
                //SE ABRE LA BASE DE DATOS 
                conBD.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion" + ex);
            }
        }

        public void CerrarConexion()
        {
            //SE CHEQUEA SI ESTA LA CONEXION ABIERTA
            if (conBD.State == ConnectionState.Open)
            {
                //SE CIERRRA LA CONEXION
                conBD.Close();
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

        private void LeerViajes()
        {
            try
            {
                //SE VACIA LA LISTA
                listViajes.Items.Clear();

                //SE REALIZA LA CONSULTA
                string sConsulta = "SELECT * " + "FROM VIAJE";
                OleDbCommand oleComando = new OleDbCommand(sConsulta, conBD);
                OleDbDataReader oleReader = oleComando.ExecuteReader();

                //SE LEE EL RESULTADO PARA VER SI HAY ALGUNO
                while (oleReader.Read())
                {
                    //SE GENERA LA LIA CON LOS DATOS DEL VIAJE
                    string sLinea = "Viaje de";
                    sLinea = sLinea + Convert.ToString(oleReader["viaOrigen"]);

                    sLinea = sLinea + "a ";
                    sLinea = sLinea + Convert.ToString(oleReader["viaDestino"]);

                    sLinea = sLinea + " (";
                    sLinea = sLinea + Convert.ToString(oleReader["viaDestino"]);

                    sLinea = sLinea + ") ";
                    sLinea = sLinea + Convert.ToString(oleReader["viaVehiculo"]);

                    //SE AÑADE LA LINEA A LA LISTA
                    listViajes.Items.Add(sLinea);
                }
            }
            catch(Exception ex)
            {
                //SI SALTA UNA EXCEPCION, SE MUESTRA EL ERROR
                MessageBox.Show("Error: " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SE ABRE LA CONEXION CON LA BASE DE DATOS
            AbrirConexion();
            LeerViajes();
        }

        private void listViajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SE OBTIENEN LOS DATOS DEL ELEMENTO SELECCIONADO
            string sViaje = listViajes.SelectedItems.ToString();
            sViaje = sViaje.Substring(9);

            txtOrigen.Text = sViaje.Substring(0, sViaje.IndexOf("a "));
            sViaje = sViaje.Substring(sViaje.IndexOf("a ") + 3);

            txtDestino.Text = sViaje.Substring(0, sViaje.IndexOf(" ("));
            sViaje = sViaje.Substring(sViaje.IndexOf(" (") + 2);

            txtVehiculo.Text = sViaje.Substring(0,sViaje.IndexOf(") "));
        }

        private void butAlta_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Alta";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butBaja_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Baja";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butModificacion_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Modificacion";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private void butConsulta_Click(object sender, EventArgs e)
        {
            //SE INDICA LA ACCION QUE HAY QUE REALIZAR
            sAccion = "Consulta";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            DesactivarAcciones();
        }

        private int LeerCodigo()
        {
            int iCodigo = -1;

            try
            {
                //SE OBTIENEN LOS DATOS DE LA LISTA
                string sViaje = listViajes.SelectedItems.ToString();
                sViaje = sViaje.Substring(9);

                String sOrigen = sViaje.Substring(0, sViaje.IndexOf(" a "));
                sViaje = sViaje.Substring(sViaje.IndexOf(" a ") + 3);

                String sDestino = sViaje.Substring(0, sViaje.IndexOf(" ("));
                sViaje = sViaje.Substring(sViaje.IndexOf(" (") + 2);

                String sVehiculo = sViaje.Substring(0, sViaje.IndexOf(") "));

                //SE REALIZA LA CONSULTA
                String sConsulta = "SELECT * "
                + "FROM VIAJE "
                + "WHERE viaOrigen ='" + sOrigen + "' "
                + "AND viaDestino ='" + sDestino + "' "
                + "AND viaVehiculo ='" + sVehiculo + "' ";

                OleDbCommand oleComando = new OleDbCommand(sConsulta, conBD);
                OleDbDataReader oleReader = oleComando.ExecuteReader();

                //SE LEE EL RESULTADO PARA VER SI HAY ALGUNO
                if (oleReader.Read())
                {
                    //SE OBTIENE EL CODIGO
                    iCodigo = Convert.ToInt32(oleReader["viaId"]);
                }
            }
            catch (Exception ex)
            {
            }
            return iCodigo;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            //SE CHEQUEA LA ACCION QUE HAY QUE EJECUTAR
            if (sAccion == "Consulta")
            {
                //SE CHEQUEA SI HAY ALGUN CODIGO METIDO
                try
                {
                    //SE OBTIENE EL CODIGO DEL VIAJE
                    int iCodigo = LeerCodigo();

                    //SE ABRE LA VENTANA DE ETAPAS
                    FrmEtapa FrmVentana = new FrmEtapa();

                    //SE ASIGNA EL CODIGO DE VIAJE A VISUALIZAR 
                    FrmVentana.iViaje = iCodigo;

                    //SE PASA TAMBIEN LA CONEXION CON LA BD PARA REUTILIZARLA
                    FrmVentana.conBD = conBD;

                    //SE MUESTRA LA VENTANA
                    FrmVentana.ShowDialog();
                }

                catch (Exception ex)
                {
                    //SE HA INTRODUCIDO UN CODIGO NO NUMERICO, SE SOLICITA OTRO
                    MessageBox.Show("Introducir un codigo antes de consultar" + ex);
                }
            }

            else
            {
                if (sAccion == "ALta")
                {
                    try
                    {
                        //SE REALIZA LA INSERCION
                        String sConsulta = "INSERT INTO VIAJE (viaOrigen,"
                        + "viaDestino, "viaVehiculo)"
                        + "VALUES ('" + txtOrigen.Text + "' , '"
                        + txtDestino.Text + "' , '"
                        + txtVehiculo.Text + "')";

                        OleDbCommand oleComando = new OleDbCommand();
                        oleComando.CommandType = CommandType.Text;
                        oleComando.CommandText = sConsulta;
                        oleComando.Connection = conBD;

                        //SE EJECUTA EL COMANDO DE INSERCION
                        oleComando.ExecuteNonQuery();

                        //SE BORRAN LAS CAJAS DE TEXTO
                        txtOrigen.Text = "";
                        txtDestino.Text = "";
                        txtVehiculo.Text = "";

                        //SE ACTUALIZAN LA LISTA DE VIAJES
                        LeerViajes();
                    }

                    catch (Exception ex)
                    {
                        //SI SE HA PRODUCIDO UN ERROR, SE MUESTRA UN MENSAJE
                        MessageBox.Show("Error en la insercion" + ex);
                    }
                }

                else
                {
                    try
                    {
                        //SE OBTIENE EL CODIGO DEL VIAJE
                        int iCodigo = LeerCodigo();

                        //SE REALIZA LA MODIFICACION
                        String sConsulta = "UPDATE VIAJE"
                        + "SET viaOrigen ='" + txtOrigen.Text
                        + "', " + "viaDestino ='"
                        + txtDestino.Text + "', "
                        + "viaVehiculo ='" + txtVehiculo.Text
                        + "' "
                        + "WHERE viaId ='" + iCodigo;

                        OleDbCommand oleComando = new OleDbCommand();
                        oleComando.CommandType = CommandType.Text;
                        oleComando.CommandText = sConsulta;
                        oleComando.Connection = conBD;

                        //SE EJECUTA EL COMANDO DE MODIFICACION
                        oleComando.ExecuteNonQuery();


                        //SE BORRAN LAS CAJAS DE TEXTO
                        txtOrigen.Text = "";
                        txtDestino.Text = "";
                        txtVehiculo.Text = "";

                        //SE ACTUALIZAN LA LISTA DE VIAJES
                        LeerViajes();
                    }

                    catch(Exception ex)
                    {
                        //SI SE HA PRODUCIDO UN ERROR SE MUESTRA UN MENSAJE
                        MessageBox.Show("Error al modificar");
                    }

                }
            }

            //SE TERMINA LA ACCCION REALIZADA
            sAccion = "";
            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            ActivarAcciones();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            //SE TERMINA LA ACCION REALIZADA
            sAccion = "";

            //SE ACTIVAN Y DESACTIVAN LOS BOTONES CORRESPONDIENTES
            ActivarAcciones();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            //SE CIERRA LA CONEXION ANTES DE TERMINAR
            CerrarConexion();

            //SE FINALIZA EL PROGRAMA
            Application.Exit();
        }
    }
}
