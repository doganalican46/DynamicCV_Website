<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddNewHobby.aspx.cs" Inherits="AdminAddNewHobby" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Hobby:"></asp:Label>
                <asp:TextBox ID="txtHobby" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
            <asp:Button ID="btnSaveHobby" runat="server" Text="SAVE" CssClass="btn btn-primary"  OnClick="btnSaveSkills_Click"  />

        </div>
    </form>
</asp:Content>

