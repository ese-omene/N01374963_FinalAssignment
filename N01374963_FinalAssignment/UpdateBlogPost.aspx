<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdateBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.UpdateBlog" %>

<asp:Content ID="updateblog" ContentPlaceHolderID="body" runat="server">
    <div id="blog" runat="server">
            
    <h2>Updating Blog Post -  <span ID="update_title" runat="server"></span></h2>

    <div class="formrow1">
        <label>Blog Title</label>
        <asp:TextBox runat="server" ID="blog_title" Height="20px"></asp:TextBox>    
        <br />
        <br />
    </div>

    <div class="formrow">
        <label>Blog Post</label>
        <asp:TextBox runat="server" ID="blog_post" Height="100px" Width="184px"></asp:TextBox>
    </div>

    <div class="formrow">
    <asp:button text="Update Blog" Onclick="Update_Blog" runat="server" />
    </div>
           
  </div>
  
    <div class="formrow">
        <a class="left" href="ShowBlogPost.aspx?blogid=<%=Request.QueryString["blogid"] %>">Cancel</a>

    </div>


</asp:Content>