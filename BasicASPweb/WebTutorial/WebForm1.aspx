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
            <form runat="server" id="form1" >

                <div class="row">
                    <div class="col my-3">
                        <asp:Label ID="lblsession" runat="server" CssClass="h1"></asp:Label><br />
                        <asp:Label ID="lblstr" runat="server" Text="Enter your name" ></asp:Label><br />
                        <input id="txtstr" runat="server" type="text"/>
                        <asp:Button ID="btnstr"  UseSubmitBehavior="false" type="button" runat="server" CssClass="btn btn-primary"  Text="Submit your name" onclick="btnstr_Click"/>
                        <br />
                        <button onclick="function(){l ocation.reload() }" class="btn btn-primary">Refresh page</button>
                    </div>
                </div>

                <%--Conversion text to Upper Case Example--%>
                <div class="row">
                    <div class="col my-3">
                        <h3>Conversion text to Upper Case</h3>
                        <label for="text">Input your text : </label>
                        <input runat="server" type="text" id="myTxt" />
                        <asp:Button id="Button1"  UseSubmitBehavior="false" type="button" runat="server" Text="Enter" onclick="convertToUpper" class="btn btn-primary mx-2"/>
                        <br /><br />

                        <label>Result : </label>
                        <span runat="server" id="txtLog"></span>
                        <br /><br />
                    </div>
                </div>

                <%--Event Handler Example--%>
                <div class="row">
                    <div class="col-12">
                        <label class="h3 ">Event Handler Example</label>
                        <asp:Button ID="btnShow" runat="server" CssClass="btn btn-danger mx-2" Text="Hide" onclick="btnclick_Show" />
                    </div>
                    <div class="col-12">
                            <asp:Label ID="lblmessage" CssClass=" " runat="server" ></asp:Label>
                            <asp:Button ID="btnclick"  UseSubmitBehavior="false" CssClass="btn btn-primary mx-1 my-3" runat="server" Text="Click" onclick="btnclick_Click" />
                            <asp:Button ID="btnReset"  UseSubmitBehavior="false" CssClass="btn btn-danger mx-1 my-3" runat="server" Text="Reset" onclick="btnclick_Reset" />
                    </div>
                </div>
                
                <div class="row">
                    
                </div>
            </form>
        </div>
        
    </div>
</body>
    <script type="text/javascript">
        $.ajax({
            type: "POST",
            url: '<%= ResolveUrl("/WebTutorial/WebForm1.aspx/CreateDataSet") %>',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
            },
            failure: function (response) {
                alert(response.d);
            }
        });
    </script>
</html>
