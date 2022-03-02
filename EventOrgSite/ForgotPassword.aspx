<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="EventOrgSite.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Reset Password</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300i,400,700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">

    <!-- Reset Password CSS -->
    <link rel="stylesheet" href="../CSS/ForgotPassword.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container d-flex justify-content-center align-items-center vh-100">
         <div class="bg-white text-center p-5 mt-3 center">
            <h3>Forgot Password </h3>
            <p>Enter your E-mail to get a reset password link</p>
            <form class="pb-3" action="#">
               <div class="form-group">
                  <input type="text" class="form-control" placeholder="Your Email *" required>
               </div>
            </form>
            <button type="button" class="btn">Send link to email</button>
         </div>
      </div>

</asp:Content>
