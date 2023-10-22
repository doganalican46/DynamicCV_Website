<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddEducation.aspx.cs" Inherits="AdminAddEducation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Tittle:"></asp:Label>
                <asp:TextBox ID="txtTittle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="SubTittle:"></asp:Label>
                <asp:TextBox ID="txtSubtittle" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Description:"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" Height="100px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="GPA:"></asp:Label>
                <asp:TextBox ID="txtGpa" runat="server" CssClass="form-control" Height="100px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Date:"></asp:Label>
                <asp:TextBox ID="txtDate" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <br />
            <asp:Button ID="btnSaveEducation" runat="server" Text="SAVE" CssClass="btn btn-primary" OnClick="btnSaveEducation_Click"  />

        </div>
    </form>


</asp:Content>

