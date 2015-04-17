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


namespace BalumaProject_Plantilla_Frontend.admin
{
    public partial class editar_perfil : System.Web.UI.Page
    {
        UsuarioCEN admin = new UsuarioCEN();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void edit_admin(object sender, EventArgs ev)
        {
            String nom = nombre.Text;
            String primer_apellido = prapellido.Text;
            String segundo_apellido = sgapellido.Text;
            String apellidos = primer_apellido + " " + segundo_apellido;
            String password = pass.Text;
        }
    }
}