<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminUpdateSkills.aspx.cs" Inherits="AdminUpdateSkills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
            </div>
            
            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Skill:"></asp:Label>
                <asp:TextBox ID="txtSkill" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
            <asp:Button ID="btnUpdateSkills" runat="server" Text="UPDATE" CssClass="btn btn-primary" OnClick="btnUpdateSkills_Click"   />

        </div>
    </form>

</asp:Content>

