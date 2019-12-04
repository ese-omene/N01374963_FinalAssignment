﻿<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="NewBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.NewBlogPost" %>

<asp:Content ID="newblogpost" ContentPlaceHolderID="body" runat="server">
    <h2>New Blog Post</h2>
    <div id="newblogpost-main">

        <div id="newblogpost-title">
     <label>Blog Title</label> 
    <asp:TextBox runat="server" ID="blog_title">please enter blog title</asp:TextBox>
    </div>
    
    <div id="newblogpost-body">
    <label style="display:block">Blog Body</label>
    <asp:TextBox runat="server" ID="blog_body" Height="200px" Width="80%" TextMode="MultiLine"></asp:TextBox>
    </div>

    </div>
        
    <br /><br />
    <div>
    <asp:Button OnClick="AddPost" Text="Add Post" runat="server" />
</div>
    </asp:Content>