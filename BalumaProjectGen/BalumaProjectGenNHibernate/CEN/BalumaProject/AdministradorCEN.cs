

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
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public string CrearAdministrador (string p_nombre, string p_apellidos, string p_password, string p_username, string p_NIF, int p_producto, int p_pedido)
{
        AdministradorEN administradorEN = null;
        string oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nombre = p_nombre;

        administradorEN.Apellidos = p_apellidos;

        administradorEN.Password = p_password;

        administradorEN.Username = p_username;

        administradorEN.NIF = p_NIF;


        if (p_producto != -1) {
                administradorEN.Producto = new BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN ();
                administradorEN.Producto.IdProducto = p_producto;
        }


        if (p_pedido != -1) {
                administradorEN.Pedido = new BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN ();
                administradorEN.Pedido.IdPedido = p_pedido;
        }

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.CrearAdministrador (administradorEN);
        return oid;
}
}
}
