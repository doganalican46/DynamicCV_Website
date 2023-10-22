<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEducations.aspx.cs" Inherits="AdminEducations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <form id="Form1" runat="server">

        <table class="table table-hover">
            <tr>
                <th>ID</th>
                <th>TITTLE</th>
                <th>SUBTITTLE</th>
                <th>DESCRIPTION</th>
                <th>GPA</th>
                <th>DATE</th>
                <th>PROCESS</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %> </td>
                        <td><%# Eval("Tittle") %> </td>
                        <td><%# Eval("Subtittle") %> </td>
                        <td><%# Eval("Description") %> </td>
                        <td><%# Eval("GPA") %> </td>
                        <td><%# Eval("Date") %> </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminDeleteEducation.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink1" runat="server" CssClass="btn btn-danger">DELETE</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminUpdateEducation.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink2" runat="server" CssClass="btn btn-secondary">UPDATE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminAddEducation.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-primary">ADD EDUCATION</asp:HyperLink>
    </form>
</asp:Content>

