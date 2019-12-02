<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowBlogPost.aspx.cs" Inherits="N01374963_FinalAssignment.ShowBlogPost" %>

<asp:Content ID="blogpost_view" ContentPlaceHolderID="body" runat="server">

    
    <div>
        <div id="blog" runat="server">
            <div>
            <h2>Details for <span id="blogpost_title_head" runat="server"></span></h2>
            Blog Title: <span id="blogpost_title" runat="server"></span><br />
            Blog Body:  <span id="blogpost_body" runat="server"></span><br />
            
            <br />
            <br />
            </div>
            <div>
    <asp:Button OnClientClick="if(!confirm('are you sure you want to delete this?')) return false;" 
     OnClick="Delete_BlogPost" CssClass="right spaced" Text="Delete" runat="server" />
           
        </div>
            </div>
        <div class="viewnav">
        <a class="left" href="ListBlogPost.aspx">Back to List</a>
        <a class="right" href="UpdateBlogPost.aspx?blogid=<%= Request.QueryString["blogid"] %>">Edit</a>
    </div>


    </div>






</asp:Content>
