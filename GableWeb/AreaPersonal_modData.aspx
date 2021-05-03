<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="AreaPersonal_modData.aspx.cs" Inherits="GableWeb.AreaPersonal_modData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid row">
        <div class="col-sm-12 col-md-5">
            <h1 class="ml-1 mt-2"><asp:Label ID="lab_AreaPersonal_mod" runat="server" Text="Área Personal" class="row mx-0 my-0"></asp:Label></h1>
            <div class="row ml-1">
                <div class="col ml-3">
                    <div class="row">
                        <strong><asp:Label ID="lab_NombreApellidos_AreaPersonal_mod" runat="server" Text="[Nombre y apellidos]" class="row"></asp:Label></strong>
                    </div>
                    <div class="row">
                        <asp:Label ID="lab_Correo_AreaPersonal_mod" runat="server" Text="[correo]" class="row"></asp:Label>
                    </div>
                    <div class="row">
                        <asp:Label ID="lab_Dni_AreaPersonal_mod" runat="server" Text="[dni]" class="row"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col ml-3 mt-3">
                    <div class="row">
                        <asp:LinkButton ID="LinkButtonMisPedidos_mod" runat="server" PostBackUrl="~/AreaPersonal_prod.aspx">
                            <asp:Image ID="misPedidosImg" runat="server" /> Mis pedidos
                        </asp:LinkButton>
                    </div>
                    <div class="row">
                        <asp:LinkButton ID="modDataBtn_mod" runat="server" PostBackUrl="~/AreaPersonal_modData.aspx">
                            <asp:Image ID="modDataImg_mod" runat="server" />  Editar datos de la cuenta
                        </asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-12 col-md-7">
            <h1 class="mt-1">Datos de la cuenta</h1>
        </div>
    </div>
</asp:Content>
