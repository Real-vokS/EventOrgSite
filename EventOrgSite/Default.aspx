<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EventOrgSite.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

    <!-- Login CSS -->
    <link rel="stylesheet" href="../CSS/Login.css">
    <link rel="stylesheet" href="../CSS/CenterLogin.css">

	<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
	<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="test">
        <div class="login-reg-panel">
		<div class="login-info-box">
			<h2>Have an account?</h2>
			<p></p>
			<label id="label-register" for="log-reg-show">Login</label>
			<input type="radio" name="active-log-panel" id="log-reg-show"  checked="checked">
		</div>
							
		<div class="register-info-box">
			<h2>Don't have an account?</h2>
			<p></p>
			<label id="label-login" for="log-login-show">Register</label>
			<input type="radio" name="active-log-panel" id="log-login-show">
		</div>
							
		<div class="white-panel">
			<div class="login-show">
				<h2>LOGIN</h2>
				<input type="text" placeholder="Username">
				<input type="password" placeholder="Password">
				<input type="button" value="Login">
				<a href="../ForgotPassword.aspx">Forgot password?</a>
			</div>
			<div class="register-show">
				<h2>REGISTER</h2>
				<div class="row">
					<div class="col">
						<input type="text" placeholder="First name">
					</div>
					<div class="col">
						<input type="text" placeholder="Last name">
					</div>
				</div>
				<input type="text" placeholder="Username">
				<input type="text" placeholder="Email">
				<input type="password" placeholder="Password">
				<input type="password" placeholder="Confirm Password">
				<input type="button" value="Register">
			</div>
		</div>
	</div>
		</div>
	<!-- Login JS -->
    <script src="./JS/Login.js"></script>

</asp:Content>
