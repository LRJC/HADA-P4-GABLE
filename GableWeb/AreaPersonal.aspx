<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="AreaPersonal.aspx.cs" Inherits="GableWeb.AreaPersonal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid row">
        <div class="col-4 mx-3 my-1 pl-3">
            <h1 class="display-4"><asp:Label ID="lab_AreaPersonal" runat="server" Text="Área Personal" class="row mx-0 my-0"></asp:Label></h1>
            <div class="ml-3">
                <ul class="list-unstyled ml-3">
                    <li>
                        <strong><asp:Label ID="lab_NombreApellidos_AreaPersonal" runat="server" Text="[Nombre y apellidos]" class="row"></asp:Label></strong>
                    </li>
                    <li>
                        <asp:Label ID="lab_Correo_AreaPersonal" runat="server" Text="[correo]" class="row"></asp:Label>
                    </li>
                    <li>
                        <asp:Label ID="lab_Dni_AreaPersonal" runat="server" Text="[dni]" class="row"></asp:Label>
                    </li>
                </ul>
                <br />
                <br />
                <ul class="list-unstyled">
                    <li class="mb-1">
                        <asp:LinkButton ID="LinkButton1" runat="server">
                            <asp:Image ID="misPedidosImg" runat="server" /> Mis pedidos
                        </asp:LinkButton>
                    </li>
                    <li class="mb-1">
                        <asp:LinkButton ID="LinkButton2" runat="server">
                            <asp:Image ID="Image1" runat="server" />  Editar datos de la cuenta
                        </asp:LinkButton>
                    </li>
                </ul>
            </div>
        </div>
        <div class="col-6 px-4 my-1">
            <h2 class="align-content-center display-4">Ultimos pedidos</h2>
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
