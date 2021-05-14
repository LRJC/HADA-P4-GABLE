<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GableWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/index.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" style="z-index: 1;">
        <div class="row align-content-center" style="text-align: center; z-index:1;">
            <asp:HyperLink id="most_sold" Text="Más vendidos" NavigateUrl="#sec1" CssClass="col-xs-12 col-sm-4 py-2 btn-sugerencias" runat="server"/>
            <asp:HyperLink id="most_valued" Text="Mejor valorados" NavigateUrl="#sec2" CssClass="col-xs-12 col-sm-4 py-2 btn-sugerencias" runat="server"/>
            <asp:HyperLink id="recommended" Text="Recomendados" NavigateUrl="#sec3" CssClass="col-xs-12 col-sm-4 py-2 btn-sugerencias" runat="server"/>
        </div>
    </div>
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important;">
                <section id="sec1">
                    <h2>MAS VENDIDOS</h2>
                    <asp:DataList ID="gv1" runat="server" RepeatColumns="3" CellPadding="2" Width="100%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td><image style="height: 200px; width: 200px;" src="<%#Eval("imagen") %>" /></td>
                                </tr>
                                <tr>
                                    <td><p style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("nombre") %></p></td>
                                </tr>
                                <tr>
                                    <td><p style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("precio") %>€</p></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </section>
                <section id="sec2">
                    <h2>MEJOR VALORADOS</h2>
                </section>
                <section id="sec3">
                    <h2>RECOMENDADOS</h2>
                    <asp:DataList ID="gv2" runat="server" RepeatColumns="3" CellPadding="2" Width="100%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td><image style="height: 200px; width: 200px;" src="<%#Eval("imagen") %>" /></td>
                                </tr>
                                <tr>
                                    <td><p style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("nombre") %></p></td>
                                </tr>
                                <tr>
                                    <td><p style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("precio") %>€</p></td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </section>
            </div>
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div> 
    </div>
</asp:Content>
