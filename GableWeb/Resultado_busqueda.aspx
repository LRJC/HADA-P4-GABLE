<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Resultado_busqueda.aspx.cs" Inherits="GableWeb.Resultado_busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
                    <asp:DataList ID="gv1" runat="server" RepeatColumns="3" CellPadding="2" Width="100%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td><asp:ImageButton ID="im1" runat="server" CommandArgument='<%#Eval("nombre") %>' OnCommand="click_productos" style="height: 200px; width: 200px;" ImageUrl='<%# Eval("imagen") %>' /></td>
                                </tr>
                                <tr>
                                    <td><p id="nombre1" style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("nombre") %></p></td>
                                </tr>
                                <tr>
                                    <td><p id="precio1" style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("precio") %>€</p></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
        </div>
    </div>

    

</asp:Content>
