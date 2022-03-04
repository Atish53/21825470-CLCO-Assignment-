<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_21825470_CLCO_Assignment_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome. Pick a plan and click on submit to proceed.</h1>
        <p class="lead">&nbsp;</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-sm-4">Option 1
            <br />
            <asp:Label ID="Label1" runat="server" Text="300 minutes of talk time"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="500 MB data"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="R 50"></asp:Label>            
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </div>
       <div class="col-sm-4">Option 2
            <br />
            <asp:Label ID="Label2" runat="server" Text="500 minutes of talk time"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="700 MB data"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="R 75"></asp:Label>
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" />
        </div>
        <div class="col-sm-4">Option 3
            <br />
            <asp:Label ID="Label7" runat="server" Text="1000 minutes of talk time"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="1 GB data"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="R 100"></asp:Label>
            <br />
            <asp:CheckBox ID="CheckBox3" runat="server" />
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="Label10" runat="server" Text="Please do not select more than one option. Please select one option." Visible="false"></asp:Label>
        </div>      
        <br />
        <div class="col-lg-1">
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
            <br />
    </div>
     </div>   

    
    
    

</asp:Content>
