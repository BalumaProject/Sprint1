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
    public partial class LoginAdministrador : System.Web.UI.Page
    {
        AdministradorCEN admin = new AdministradorCEN();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs ev)
        {
            UsuarioCEN u = new UsuarioCEN();
            UsuarioEN us = new UsuarioEN();

            us = u.LeerPorNombreAdministrador();

            if (us.Password == password.Text)
            {
                AdministradorEN ad = new AdministradorEN();
                ad = (AdministradorEN)us;
            }
            else
            {
            }
        }
    }
}