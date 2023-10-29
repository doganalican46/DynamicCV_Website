<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminHobbies.aspx.cs" Inherits="AdminHobbies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="Form1" runat="server">

        <table class="table table-hover">
            <tr>
                <th>ID</th>
                <th>HOBBY</th>
                <th>PROCESS</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %> </td>
                        <td><%# Eval("Hobby") %> </td>
                   
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminDeleteHobby.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink1" runat="server" CssClass="btn btn-danger">DELETE</asp:HyperLink>
                        </td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "AdminUpdateHobby.Aspx?ID=" + Eval("ID") %>'
                                ID="HyperLink2" runat="server" CssClass="btn btn-secondary">UPDATE</asp:HyperLink>
                        </td>

                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminAddNewHobby.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-primary">ADD HOBBY</asp:HyperLink>
    </form>
</asp:Content>

