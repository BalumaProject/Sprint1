using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;
using BalumaProjectGenNHibernate.Enumerated.BalumaProject;

namespace BalumaProject_Plantilla_Frontend
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClienteCEN cliente = new ClienteCEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            //necesario un leer por email o leer por nombre

            cliente.get_IClienteCAD().ReadOIDDefault(nif.Text);

            //si es válido, se carga la vista de cliente


        }

        protected void register_submit(object sender, EventArgs e)
        {
            String nom = nombre.Text;
            String primer_apellido = papellido.Text;
            String segundo_apellido = sapellido.Text;
            String apellidos = primer_apellido + " " +segundo_apellido;
            String password = pass.Text;
            String NIF = nif.Text;
            String localidad = local.Text;
            String numtelf = telf.Text;
            String cuentaBancaria = cuenta.Text;


            cliente.CrearCliente(nom, apellidos, password, nom, NIF, localidad, "", cuentaBancaria, numtelf, null, null);
        }

    }
}