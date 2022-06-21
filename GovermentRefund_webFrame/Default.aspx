<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GovermentRefund_webFrame._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <link href="Content/index.css" rel="stylesheet" />
    <div class="text-center">
        <p class="Ticket_Number">
            <b>
                Total Number of Tickets
            </b>
        </p>
        <%-- Number of tickets --%>
                <asp:TextBox class="form__input" id="form__input2" runat="server"/>

      
                <asp:Button class="enter" runat="server"  OnClick="btnSave_Click" Text="Enter" />
       
        <%-- message print --%>
                    <div class="msq">
                        <asp:Literal ID="Itmsq" runat="server" />
                    </div>
                <p class="Enter_Ticket_Number">
                    <b>Enter Tickets Number</b>
                </p>
        <!-- Add and remove Tickets -->
        <div class="wrapper">
            <div id="survey_options">
                <panel id="pnlTextBox" runat="server"></panel>
            </div>
 </div>
          
       
        <!-- Uplode the letter  -->
        <div class="uplode_letter">
            <p class="uplode_letter_text">
                <b>
                    Uplode the Letter
                </b>
            </p>
            <button class="uplode_button" > Uplode </button>
        </div>
        <div class="Cancle_Create">

            <%-- id="open-popup-btn --%>
             <asp:Button class="create_button" id="Create" runat="server"  OnClick="btnCreate_Click" Text="Create" /> 
            <%--<button class="create_button" id="Create"> Create </button>--%>

            <button class="cancle_button"> Cancle </button>
        </div>
    </div>

    <%--THANKS pop up message--%> 
    <div class="popup center">
        <div class="icon">
            <i class="fa fa-check" aria-hidden="true"></i>
        </div>
        <div class="title">
            Success!!
        </div>
        <div class="description">
            The request has been created successfully
        </div>
        <div class="dismiss-btn">
            <button id="dismiss-popup-btn">
                Dismiss
            </button>
        </div>
    </div>
    <script src="js/script.js" asp-append-version="true"></script>

<script type="text/javascript">
        var k = "The respective values are :";
        function Geeks() {
            var input = document.getElementsByName('survey_options[]');
  
            for (var i = 0; i < input.length; i++) {
                var a = input[i];
                k = k + "array[" + i + "].value= "  + a.value + " ";
            }
  
            document.getElementById("par").innerHTML = k;
            document.getElementById("po").innerHTML = "Output";
        }
</script>

</asp:Content>
