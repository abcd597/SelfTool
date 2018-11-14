<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TraditionToSimple._Default" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
  <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server"></CKEditor:CKEditorControl>
    <asp:Button ID="Button1" runat="server" Text="轉換" style="width:200px;height:80px;" OnClick="Button1_Click" />
    <div id="MailCotentData" runat="server" style="width:100%;"></div>
    <script src="Scripts/ckeditor/ckeditor.js"></script>
    <script type="text/javascript">
        function btn() {
            console.log(document.getElementById("CKEditorControl1").innerText);
        }
    </script>

</asp:Content>
