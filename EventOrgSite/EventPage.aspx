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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col" id="leftSide" style="margin-left: 30px;">

            <h3 class="card-title">PlaceHolder</h3>
            <div style="width: 40rem;">
                <div id="EventDescription">
                    <label style="font-weight: bold; margin-top: 30px">Event Beskrivelse</label>
                    <textarea class="form-control" id="textArea" oninput='this.style.height = "";this.style.height = this.scrollHeight + "px"' style="overflow: hidden; resize: none; background-color: #FFF !important"></textarea>
                </div>
            </div>

            <div style="margin-top: 40px; width: 40rem">
                <h5>Date created</h5>
                <asp:TextBox class="form-control" ID="startDate" Type="date" placeholder="Start Date" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
            <div style="margin-top: 20px; width: 40rem">
                <h5>Sign-up deadline</h5>
                <asp:TextBox class="form-control" ID="deadline" Type="date" placeholder="Deadline" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
        </div>

        <div class="col" id="rightSide" runat="server" style="margin-top: 120px; padding: 0px 80px 40px 0px">
            <div class="container">
                <div class="row clearfix">
                    <div class="col-md-12 column">
                        <table class="table table-bordered table-hover" id="tablogic" runat="server">
                            <thead>
                                <tr>
                                    <th class="text-center">#</th>
                                    <th class="text-center">Option Name</th>
                                    <th class="text-center">Amount</th>
                                </tr>
                            </thead>

                            <tbody>
                                <tr id="addr0">
                                    <td class="text-center">1</td>
                                    <td>
                                        <input id="addr0_name" type="text" name="name0" placeholder="Name" class="form-control" />
                                    </td>
                                    <td>
                                        <input id="addr0_amount" type="number" name="amount0" class="form-control" placeholder="Amount" />
                                    </td>
                                </tr>

                                <tr id="addr1">
                                </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
                <div id="optionButtons" runat="server">
                    <a class="btn btn-default pull-left" id="addrow">Add Row</a>
                    <a class="btn btn-default pull-right" id="deleterow">Delete Row</a>
                </div>
            </div>

            <div id="eventButtons" runat="server" style="text-align: right; margin-top: 50px;">
                <div class="col">
                    <button id="participate" type="button" class="btn btn-primary" style="margin-right: 15px;" runat="server">Deltag</button>
                </div>
                <div class="col" style="margin-top: 10px;">
                    <button id="cEvent" type="button" class="btn btn-success" style="margin-right: 15px;" runat="server">Create Event</button>
                </div>

            </div>


        </div>


    </div>
    <script src="./JS/EventOptions.js"></script>
</asp:Content>
