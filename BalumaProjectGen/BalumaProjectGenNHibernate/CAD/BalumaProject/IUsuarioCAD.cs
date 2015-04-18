
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string NIF);

string CrearUsuario (UsuarioEN usuario);

void ModificarUsuario (UsuarioEN usuario);



BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreCliente ();


BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreAdministrador ();
}
}
