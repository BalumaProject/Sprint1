<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdministrador.aspx.cs" Inherits="BalumaProject_Plantilla_Frontend.admin.LoginAdministrador" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href='http://fonts.googleapis.com/css?family=Maven+Pro:400,900,700,500' rel='stylesheet' type='text/css'>
    <link href="~/Content/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--- start-mmmenu-script---->
    <script src="~/Scripts/jquery.min.js" type="text/javascript"></script>
    <link type="text/css" rel="stylesheet" href="~/Content/css/jquery.mmenu.all.css" />
    <script type="text/javascript" src="~/Scripts/jquery.mmenu.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="registration_form">
		 <!-- Form -->
			<form id="login_admin" action="" method="post">
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
			</form>
			<!-- /Form -->
		</div>
    </div>
    </form>
</body>
</html>
