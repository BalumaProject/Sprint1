<%@ Page Language="C#" MasterPageFile="~/admin/Administrador.Master" AutoEventWireup="true" CodeBehind="editar_perfil.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.editar_perfil" %>
<%@ Register TagPrefix="uc" TagName="Footer" Src="~/_footer.ascx"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="headAdmin" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script>
        (function () {

            // Create input element for testing
            var inputs = document.createElement('input');

            // Create the supports object
            var supports = {};

            supports.autofocus = 'autofocus' in inputs;
            supports.required = 'required' in inputs;
            supports.placeholder = 'placeholder' in inputs;

            // Fallback for autofocus attribute
            if (!supports.autofocus) {

            }

            // Fallback for required attribute
            if (!supports.required) {

            }

            // Fallback for placeholder attribute
            if (!supports.placeholder) {

            }

            // Change text inside send button on submit
            var send = document.getElementById('register-submit');
            if (send) {
                send.onclick = function () {
                    this.innerHTML = '...Sending';
                }
            }

        })();
		</script>

    <div class="registration_left medio-tam">
        <div class="registration_form">
		 <!-- Form -->
			<form id="registration_form" action="contact.php" method="post">
				<div>
					<label>
						<input placeholder="Nombre:" type="text" tabindex="1" required="" autofocus="">
					</label>
				</div>
				<div>
					<label>
						<input placeholder="Primer apellido:" type="text" tabindex="2" required="" autofocus="">
					</label>
				</div>

				<div>
					<label>
						<input placeholder="Segundo apellido:" type="text" tabindex="3" required="" autofocus="">
					</label>
				</div>

				
				<div>
					<label>
						<input placeholder="Email:" type="email" tabindex="4" required="">
					</label>
				</div>

				<div>
					<label>
						<input placeholder="contraseña" type="password" tabindex="5" required="">
					</label>
				</div>						
				<div>
					<label>
						<input placeholder="repite la contraseña" type="password" tabindex="5" required="">
					</label>
				</div>	
				<div>
					<input type="submit" value="Actualiza tus datos" id="register-submit">
				</div>
			</form>
			<!-- /Form -->
		</div>
    </div>
    
    
    <form runat="server">
        <uc:Footer id="footer"
            runat="server" />
    </form>
</asp:Content>


