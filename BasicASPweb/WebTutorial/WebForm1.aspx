<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BasicASPweb.WebTutorial.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Home</title>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link rel="stylesheet" href="../Content/bootstrap.min.css" />
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
</head>
<body class="bg-dark">

    <div class="container mt-3">
        <div class="row text-white">
            <form runat="server" id="form1" class="col">
                <label for="text">Input your text : </label>
                <input runat="server" type="text" id="myTxt" />
                <asp:Button id="Button1" runat="server" Text="Enter" onclick="convertToUpper" class="btn btn-primary mx-2"/>
                <br /><br />

                <h3>Conversion text to Upper Case</h3>
                <label>Result : </label>
                <span runat="server" id="txtLog"></span>
                <br /><br />

                <div class="row">
                    <div class="col-12">
                        <label class="h3 ">Event Handler Example</label>
                        <asp:Button ID="btnShow" runat="server" CssClass="btn btn-danger mx-2" Text="Hide" onclick="btnclick_Show" />
                    </div>
                    <div class="col-12">
                            <asp:Label ID="lblmessage" CssClass=" " runat="server" ></asp:Label>
                            <asp:Button ID="btnclick" CssClass="btn btn-primary mx-1 my-3" runat="server" Text="Click" onclick="btnclick_Click" />
                            <asp:Button ID="btnReset" CssClass="btn btn-danger mx-1 my-3" runat="server" Text="Reset" onclick="btnclick_Reset" />
                    </div>
                </div>
            </form>
        </div>
        
    </div>
</body>
</html>
