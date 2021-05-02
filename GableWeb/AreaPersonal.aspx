<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="AreaPersonal.aspx.cs" Inherits="GableWeb.AreaPersonal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid row">
        <div class="col-sm-12 col-md-5">
            <h1 class="ml-1 mt-2"><asp:Label ID="lab_AreaPersonal" runat="server" Text="Área Personal" class="row mx-0 my-0"></asp:Label></h1>
            <div class="row ml-1">
                <div class="col ml-3">
                    <div class="row">
                        <strong><asp:Label ID="lab_NombreApellidos_AreaPersonal" runat="server" Text="[Nombre y apellidos]" class="row"></asp:Label></strong>
                    </div>
                    <div class="row">
                        <asp:Label ID="lab_Correo_AreaPersonal" runat="server" Text="[correo]" class="row"></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Label ID="lab_Dni_AreaPersonal" runat="server" Text="[dni]" class="row"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col ml-3 mt-3">
                    <div class="row">
                        <asp:LinkButton ID="LinkButton1" runat="server">
                            <asp:Image ID="misPedidosImg" runat="server" /> Mis pedidos
                        </asp:LinkButton>
                    </div>
                    <div class="row">
                        <asp:LinkButton ID="LinkButton2" runat="server">
                            <asp:Image ID="Image1" runat="server" />  Editar datos de la cuenta
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-12 col-md-7">
            <h1 class="mt-1">Ultimos pedidos</h1>
            <div class="row my-1">
                <asp:Label ID="prod1" runat="server" Text="[Producto]"></asp:Label>
            </div>
            <div class="row my-1">
                <asp:Label ID="prod2" runat="server" Text="[Producto]"></asp:Label>
            </div>
            <div class="row my-1">
                <asp:Label ID="prod3" runat="server" Text="[Producto]"></asp:Label>
            </div>
            <div class="row my-1">
                <asp:Label ID="prod4" runat="server" Text="[Producto]"></asp:Label>
            </div>
            <div class="row my-1">
                <asp:Label ID="prod5" runat="server" Text="[Producto]"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
