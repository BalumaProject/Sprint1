

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

namespace BalumaProjectGenNHibernate.CEN.BalumaProject
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string CrearUsuario (string p_apellidos, string p_password, string p_username, string p_NIF, string p_nombre)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Password = p_password;

        usuarioEN.Username = p_username;

        usuarioEN.NIF = p_NIF;

        usuarioEN.Nombre = p_nombre;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.CrearUsuario (usuarioEN);
        return oid;
}

public void ModificarUsuario (string p_Usuario_OID, string p_apellidos, string p_password, string p_username, string p_nombre)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.NIF = p_Usuario_OID;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Password = p_password;
        usuarioEN.Username = p_username;
        usuarioEN.Nombre = p_nombre;
        //Call to UsuarioCAD

        _IUsuarioCAD.ModificarUsuario (usuarioEN);
}

public BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreCliente ()
{
        return _IUsuarioCAD.LeerPorNombreCliente ();
}
public BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN LeerPorNombreAdministrador ()
{
        return _IUsuarioCAD.LeerPorNombreAdministrador ();
}
}
}
