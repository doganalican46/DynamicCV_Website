<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSkills.aspx.cs" Inherits="AdminSkills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form id="Form1" runat="server">

        <table class="table table-hover">
            <tr>
                <th>ID</th>
                <th>SKILLS</th>
         
                <th>PROCESS</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %> </td>
                        <td><%# Eval("Skills") %> </td>
                   
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminDeleteSkills.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink1" runat="server" CssClass="btn btn-danger">DELETE</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminUpdateSkills.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink2" runat="server" CssClass="btn btn-secondary">UPDATE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminAddNewSkills.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-primary">ADD SKILLS</asp:HyperLink>
    </form>
</asp:Content>

