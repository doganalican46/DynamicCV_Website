<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddNewSkills.aspx.cs" Inherits="AddNewSkills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Skill:"></asp:Label>
                <asp:TextBox ID="txtSkill" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
            <asp:Button ID="btnSaveSkills" runat="server" Text="SAVE" CssClass="btn btn-primary"  OnClick="btnSaveSkills_Click"  />

        </div>
    </form>

</asp:Content>

