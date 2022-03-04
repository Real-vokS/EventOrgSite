<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="EventOrgSite.Events" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

	<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
	<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Event CSS -->
    <link rel="stylesheet" href="../CSS/Event.css">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <!-- Navbar er i UserMaterPage.Master -->
            
            <div class="row" id="SiteContent" style="overflow-x:hidden">
                <div class="col-2">

                </div>

                <div class="col-8" id="ContentDiv" runat="server">
                    <!-- Alle events bliver lavet i Events.aspx.cs -->                

                </div>

                <div class="col-2">
                    <button type="button" class="btn btn-primary sticky-top" style="top: 10%; transform:translateX(50%); position: fixed"  id="CreateEvent" runat="server">Create Event</button>
                </div>
            </div>

</asp:Content>
