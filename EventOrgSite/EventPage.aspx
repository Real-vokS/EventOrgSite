<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="EventPage.aspx.cs" Inherits="EventOrgSite.EventPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <meta name="viewport" content="width=device-width, initial-scale=1">

    
    <link rel="stylesheet" type="text/css" href="/CSS/EventPage.css">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

	<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
	<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
	<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">

        <div class="col" id="Left-Side" style=" margin-left: 30px;">
            
            <h3 class="card-title">PlaceHolder</h3>
            <div class="card" style="width: 40rem;">
                <div class="card-body" id="EventDescription">
                    <p class="card-text">Some placeholder shit that can do other shit</p>
                </div>
            </div>

            <div style="margin-top: 40px; width: 40rem">
                <h5>Date created</h5>
                <asp:TextBox class="form-control" ID="EventStartDate" Type="date" placeholder="Start Date" runat="server" readonly="true"></asp:TextBox>
            </div>
            <div style="margin-top: 20px; width: 40rem">
                <h5>Sign-up deadline</h5>
                <asp:TextBox class="form-control" ID="EventDeadline" Type="date" placeholder="Deadline" runat="server" readonly="true"></asp:TextBox>
            </div>
        </div>



        <div class="col" id="RightSide" runat="server" style="margin-top: 144px; padding: 0px 80px 40px 0px">

            <!-- Event Options bliver lavet i Create Event -->




        </div>
        

    </div>

    
        <script src="./JS/EventOptions.js"></script>

</asp:Content>
