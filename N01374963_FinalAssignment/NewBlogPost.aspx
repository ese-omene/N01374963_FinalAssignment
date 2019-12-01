<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NewBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.NewBlogPost" %>

<asp:Content ID="newblogpost" ContentPlaceHolderID="body" runat="server">
    <h2>New Blog Post</h2>
    <label>Page Title</label>
    
    <div class="formrow">
    <asp:TextBox runat="server" ID="blog_title"></asp:TextBox>
    </div>

    <div class="formrow">
        <asp:TextBox runat="server" ID="blog_body"></asp:TextBox>
    </div>

    <asp:Button OnClick="AddPost" Text="Add Post" runat="server" />

    </asp:Content>