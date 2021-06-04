<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Resultado_busqueda.aspx.cs" Inherits="GableWeb.Resultado_busqueda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important;">
                <asp:Label runat="server" ID="noProd"></asp:Label>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="2" Width="100%" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <div class="card btn-outline-dark" style="width: 18rem;">
                                <asp:ImageButton CssClass="card-img-top w-100" runat="server" CommandArgument='<%#Eval("id_producto") %>' OnCommand="clickado" style="height: 200px; width: 200px;" ImageUrl='<%# Eval("imagen") %>' />
                                    <div class="card-body">
                                     <h5 class="card-title"><%#Eval("nombre") %></h5>
                                        <p class="card-text"><strong><%#Eval("precio") %>€</strong></p>
                                    </div>
                            </div>
                        </ItemTemplate>
                </asp:DataList>
            </div>
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>       
        </div>
    </div>
</asp:Content>
