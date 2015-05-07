<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="tubeystatus.tubestation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
    <title>TubeyStat.us</title>   
    </head>
<body>
    <form id="form1" runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script> 
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"/>
    <a href="https://github.com/olipicard/tubeystatus"><img style="position: absolute; top: 0; right: 0; border: 0;" src="https://camo.githubusercontent.com/38ef81f8aca64bb9a64448d0d70f1308ef5341ab/68747470733a2f2f73332e616d617a6f6e6177732e636f6d2f6769746875622f726962626f6e732f666f726b6d655f72696768745f6461726b626c75655f3132313632312e706e67" alt="Fork me on GitHub" data-canonical-src="https://s3.amazonaws.com/github/ribbons/forkme_right_darkblue_121621.png"></a>   
    <div>
        <h2 class="text-center">TubeyStat.us</h2>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Refresh feed" CssClass="btn btn-default center-block"/>
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="RowDataBound" CssClass="form-control-static" HorizontalAlign="Center">
        </asp:GridView>
    
        <p class="text-center">Created with <3 by <a href="http://github.com/olipicard">OliPicard</a></p>
        <p class="text-center">Many thanks to <a href="http://api.tfl.gov.uk">tfl</a> for providng the API.</p>
    </div>
    </form>
</body></html>
