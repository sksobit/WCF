<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get Public Informationi" />
        <asp:Label ID="Label1" runat="server" Text="LabelPublic"></asp:Label>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Confidential Information" />
        <asp:Label ID="Label2" runat="server" Text="LabelConfidential"></asp:Label>
    </form>
</body>
</html>
