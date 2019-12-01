<%@ Page Language="C#" MasterPageFile="~/Layout.Master"   AutoEventWireup="true" CodeBehind="ListBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.ListBlogPost" %>

<asp:Content ID="blogpost_list" ContentPlaceHolderID="body" runat="server">
    <h1>Blog Post</h1>
    <div id="blogpost_nav">
        <asp:Label for="blogpost_search" runat="server">Search</asp:Label>
        <asp:TextBox ID="blogpost_search" runat="server"></asp:TextBox>
    <asp:Button runat="server" Text="search" />
  </div>

<a href="NewBlogPost.aspx"> New Blog Posts</a>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col2"> Blog Title</div>
            <div class="col2last">Blog Body</div>
        </div>
        <div id="blogpost_result" runat="server"></div>
    </div>

</asp:Content>