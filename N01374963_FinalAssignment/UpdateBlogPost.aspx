<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.UpdateBlog" %>

<asp:Content ID="updateblog" ContentPlaceHolderID="body" runat="server">
    <div id="blog" runat="server">

    <div class="viewnav">
        <a class="left" href="ShowBlogPost.aspx?blogid=<%=Request.QueryString["blogid"] %>">Cancel</a>

    </div>
    <h2>Updating Blog Post: <span id="update_blog" runat="server"></span></h2>

    <div class="formrow">
        <label>Blog Title:</label>
        <asp:TextBox runat="server" ID="blog_title"></asp:TextBox>    
    </div>

    <div class="formrow">
        <label>Blog Post</label>
        <asp:TextBox runat="server" ID="blog_post"></asp:TextBox>
    </div>

    <asp:button text="Update Blog" Onclick="Update_Blog" runat="server" />

    </div>



</asp:Content>