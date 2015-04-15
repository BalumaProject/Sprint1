
using System;
using BalumaProjectGenNHibernate.EN.BalumaProject;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string NIF);

string CrearUsuario (UsuarioEN usuario);

void ModificarUsuario (UsuarioEN usuario);
}
}
