<%@ Page Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="editar_perfil.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.editar_perfil" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/_footer.ascx"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="registration_left">
        <div class="registration_form">
		 <!-- Form -->
				<div>
					<label>
						<asp:TextBox ID = "nombre" type="text" tabindex="1" placeholder="Nombre:" runat = "server"  />
					</label>
				</div>
				<div>
					<label>
						<asp:TextBox ID = "prapellido" type="text" tabindex="2" placeholder="Primer apellido:" runat = "server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "sgapellido" placeholder="Segundo apellido:" type="text" tabindex="3" runat="server" />
					</label>
				</div>

				
				<div>
					<label>
						<asp:TextBox ID = "email" placeholder="Email:" type="email" tabindex="4" runat="server" />
					</label>
				</div>

				<div>
					<label>
						<asp:TextBox ID = "pass" placeholder="Contraseña:" type="password" tabindex="10" runat="server" />
					</label>
				</div>						
				<div>
					<label>
						<asp:TextBox ID="TextBox1" placeholder="Repite la contraseña:" type="password" tabindex="11" runat="server" />
					</label>
				</div>	
				<div>
					<asp:Button ID="Button1" OnClick = "submit" type="submit" text="Modificar"  runat = "server" />
				</div>
			<!-- /Form -->
		</div>
    </div>
    
    
    <form runat="server">
        <uc:Footer id="footer"
            runat="server" />
    </form>
</asp:Content>


