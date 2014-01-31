<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AntalVersaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Hur Många Versaler</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Textboxen för att skriva in sin text-->
        <h1> Skriv din text och se hur många Versaler den innehåller?</h1>
    <asp:TextBox ID="Textbox" runat="server" TextMode="MultiLine" Height="300px" Width="500px"></asp:TextBox>
    </div>
        
        <!--Skapar Placeholder för p-tagg följt av labeln där resultatet presenteras.-->
    <asp:PlaceHolder ID="PlaceHolder1" runat="server" Visible="False"> <p>Antal versaler i rutan:
        <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label></p></asp:PlaceHolder>
        
         <!--Knapp för bekräftelse av inmatning-->
    <asp:Button ID="Button" runat="server" Text="Visa Antal Versaler" OnClick="Button_Click"/>
    
        <!--Knapp för ny inmatning-->  
    <asp:Button ID="ClearButton" runat="server" Text="Rensa" Visible="false"/>
   
  
    </form>
</body>
</html>
