<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="main_bg">
<div class="wrap">
<div class="main">
	<div class="login_left">
		<h3>login</h3>
		<p>Si ya tienes una cuenta con nosotros, loguéate.</p>
	<!-- start registration -->
	<div class="registration">
		
		<script type="text/javascript">
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
	<div class="registration_left">
		
		 <div class="registration_form">
		 <!-- Form -->
			<form id="registration_form" action="contact.php" method="post">
				<div>
					<label>
						<input placeholder="usuario" type="email" tabindex="3" required="">
					</label>
				</div>
				<div>
					<label>
						<input placeholder="contraseña" type="password" tabindex="4" required="">
					</label>
				</div>						
				<div>
					<input type="submit" value="¡Entra!" id="register-submit">
				</div>
				<div class="forget">
					<a href="#">¿No recuerdas tu contraseña?</a>
				</div>
			</form>
			<!-- /Form -->
		</div>
	</div>
	</div>
	<!-- end registration -->
	</div>
	<div class="login_left">
		<h3>Regístrate</h3>
		<p>Si creas una cuenta cliente, podrás comprar nuestros productos de la tienda, hacer un seguimiento de los pedidos y encargar productos que ya no se encuentren en stock.</p>
		<div class="registration_left">
		
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
					<input type="submit" value="Crea tu cuenta" id="register-submit">
				</div>
				<div class="sky_form">
					<label class="checkbox"><input type="checkbox" name="checkbox"><i>Estoy de acuerdo con los <a class="terms" href="#"> términos de servicio</a> </i></label>
				</div>
			</form>
			<!-- /Form -->
		</div>
	</div>
	</div>
	<div class="clear"></div>
</div>
</div>
</div>
<!-- start footer -->
<div class="footer_bg">
<div class="wrap">
<div class="footer">

	<div class="f_nav1">
		<ul>
			<li><a href="indice.aspx">Inicio/</a></li>
			<li><a href="#">Términos y condiciones /</a></li>
			<li><a href="#">Contáctanos</a></li>
		</ul>
		</div>
	
	<div class="clear"></div>
</div>
</div>
</div>
</asp:Content>
