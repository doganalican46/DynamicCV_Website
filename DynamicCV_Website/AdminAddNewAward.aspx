<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddNewAward.aspx.cs" Inherits="AdminAddNewAward" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Award:"></asp:Label>
                <asp:TextBox ID="txtAward" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <br />
            <asp:Button ID="btnSaveAward" runat="server" Text="SAVE" CssClass="btn btn-primary" OnClick="btnSaveAward_Click"    />

        </div>
    </form>
</asp:Content>

