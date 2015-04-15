
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class AdministradorEN                    :                           BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN


{
/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto;

/**
 *
 */

private BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido;





public virtual BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN Producto {
        get { return producto; } set { producto = value;  }
}


public virtual BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}





public AdministradorEN() : base ()
{
}



public AdministradorEN(string nIF, BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string nombre, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar)
{
        this.init (nIF, producto, pedido, nombre, apellidos, password, username, validar);
}


public AdministradorEN(AdministradorEN administrador)
{
        this.init (administrador.NIF, administrador.Producto, administrador.Pedido, administrador.Nombre, administrador.Apellidos, administrador.Password, administrador.Username, administrador.Validar);
}

private void init (string nIF, BalumaProjectGenNHibernate.EN.BalumaProject.ProductoEN producto, BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN pedido, string nombre, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar)
{
        this.NIF = NIF;


        this.Producto = producto;

        this.Pedido = pedido;

        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Username = username;

        this.Validar = validar;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdministradorEN t = obj as AdministradorEN;
        if (t == null)
                return false;
        if (NIF.Equals (t.NIF))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NIF.GetHashCode ();
        return hash;
}
}
}
