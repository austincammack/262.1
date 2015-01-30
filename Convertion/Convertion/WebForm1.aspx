<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Convertion.WebForm1" %>

<!DOCTYPE html>

<html>
    <head>
        <title>Currency Converter</title>
    </head>
    <body>
        <form runat="server">
          <div>
            Convert: &nbsp;
                <input type="text" ID="US" runat="server"/>
                &nbsp; U.S. dollars to Euros.
                <br /><br />
               <input type="submit" value="OK" runat="server" />
              &nbsp; U.S. dollars to &nbsp;
              <select ID ="Currency" runat="server"/> 
               <input type="submit" value="OK" ID="Convert" runat="server"
                  OnServerClick="Convert_ServerClick" />
               <br /><br />
              <p style="font-weight: bold" id="Result" runat="server">
              </p>
          </div>
        </form>
    </body>
</html>