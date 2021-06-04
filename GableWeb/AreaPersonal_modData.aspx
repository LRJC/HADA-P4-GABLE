﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="AreaPersonal_modData.aspx.cs" Inherits="GableWeb.AreaPersonal_modData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid row">
        <div class="col-sm-12 col-md-3">
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
                        <asp:LinkButton ID="LinkButtonMisPedidos_mod" runat="server" PostBackUrl="~/AreaPersonal_ped.aspx" CausesValidation="False">
                            <asp:Image ID="misPedidosImg" runat="server" /> Mis pedidos
                        </asp:LinkButton>
                    </div>
                    <div class="row">
                        <asp:LinkButton ID="modDataBtn_mod" runat="server" PostBackUrl="~/AreaPersonal_modData.aspx" CausesValidation="False">
                            <asp:Image ID="modDataImg_mod" runat="server" />  Editar datos de la cuenta
                        </asp:LinkButton>
                    </div>
                    <div class="row">
                        <asp:Button ID="btnLogOut" runat="server" Text="Cerrar Sesión" OnClick="btnLogOut_Click" BorderStyle="None" BackColor="White" CausesValidation="False" />
                    </div>
                    <div class="row">
                        <asp:Button ID="btnDeleteAccount" runat="server" style="color:red" Text="Eliminar cuenta" BorderStyle="None" OnClick="btnDeleteAccount_Click" BackColor="White" CausesValidation="False" />
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-12 col-md-9 pl-xs-0 pl-md-5">
            <div class="row border-bottom">
                <h1 class="mt-2 mb-0 text-center">Datos de la Cuenta</h1>
                
            </div>
            <div class="row">
                <div class="col-12 px-4">
                    <div class="row mt-xs-2 mt-md-5">
                        <div class="col-12">
                            <div class="row-10 my-2 border-bottom">
                                <h4><asp:Label ID="CambiarContra" runat="server" Text="Cambiar Contraseña"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0">
                                <div class="col no-gutters px-0">
                                    <asp:TextBox ID="oldPasswd" runat="server" MaxLength="16" placeholder="Contraseña antigua" TextMode="Password" Columns="30"></asp:TextBox>
                                </div>
                                <div class="col no-gutters"
                                    <asp:Label ID="checkOldPwd" runat="server" Text=""></asp:Label>
                                </div>
                                <asp:RequiredFieldValidator ID="requiredOldPwd" runat="server" ErrorMessage="Campo obligatorio!" ControlToValidate="oldPasswd"></asp:RequiredFieldValidator>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="newPasswd" runat="server" MaxLength="16" placeholder="Nueva contraseña" TextMode="Password" Columns="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="requiredNewPwd" runat="server" ErrorMessage="Campo obligatorio!" ControlToValidate="newPasswd"></asp:RequiredFieldValidator>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="confirmNewPasswd" runat="server" MaxLength="16" placeholder="Confirmar contraseña" TextMode="Password" Columns="30"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="requiredConfirmPwd" runat="server" ErrorMessage="Campo obligatorio!" ControlToValidate="confirmNewPasswd"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="compareContras" runat="server" ErrorMessage="Las contraseñas no coinciden" ControlToValidate="confirmNewPasswd" ControlToCompare="newPasswd"></asp:CompareValidator>
                            </div>
                            <div class="row-2 mt-3 mx-0">
                                <asp:Button ID="ButtonCambiarContra" runat="server" Text="Guardar" OnClick="ButtonCambiarContra_Click" CausesValidation="False" />
                            </div>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-12">
                            <div class="row-10 border-bottom my-2">
                                <h4><asp:Label ID="modPersonalData" runat="server" Text="Editar datos personales"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="TextBoxModEmail" runat="server" placeholder="Email" Columns="30"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="regexEmail" runat="server" ErrorMessage="Introduce un correo válido" ControlToValidate="TextBoxModEmail" ValidationExpression="\S+@\S+.\S+"></asp:RegularExpressionValidator>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="TextBoxModNombre" runat="server" placeholder="Nombre" Columns="30"></asp:TextBox>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="TextBoxModApellidos" runat="server" placeholder="Apellidos" Columns="30"></asp:TextBox>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="TextBoxModFecNac" runat="server" placeholder="Fecha nacimiento(dd/mm/yyyy)" Columns="30"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="regexFecNac" runat="server" ErrorMessage="Formato de fecha incorrecto, debe ser dd/mm/yyyy." ControlToValidate="TextBoxModFecNac" ValidationExpression="[0-9]{2}/[0-9]{2}/[0-9]{4}"></asp:RegularExpressionValidator>
                            </div>
                            <div class="row my-2 mx-0">
                                <asp:TextBox ID="TextBoxModTlf" runat="server" placeholder="Teléfono" Columns="30"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="regexTlf" runat="server" ErrorMessage="Introduce un teléfono válido." ControlToValidate="TextBoxModTlf" ValidationExpression="[0-9]{9}"></asp:RegularExpressionValidator>
                            </div>
                            <div class="row-2 mt-3 mx-0">
                                <asp:Button ID="ButtonCambiarDatosPersonales" runat="server" Text="Guardar" OnClick="ButtonCambiarDatosPersonales_Click" CausesValidation="False" />
                            </div>
                        </div>
                    </div>
                    <div class="row my-3">
                        <div class="col-12">
                            <div class="row-10 border-bottom my-2">
                                <h4><asp:Label ID="LabelCambiarInfoPagos" runat="server" Text="Cambiar información de pago"></asp:Label></h4>
                            </div>
                            <div class="row no-gutters">
                                <div class="col-8 border-bottom mb-3">
                                    <h4><asp:Label ID="LabelTarjetaActual" runat="server" Text="Tarjeta Actual:"></asp:Label></h4>
                                </div>
                                <div class="col-8 pl-3 border-top border-bottom">
                                    <asp:Label ID="LabelTarjeta" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-8 pl-3 border-top border-bottom">
                                    <asp:Label ID="fechaTarjeta" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="row-2 mt-3 align-self-end">
                                <asp:Button ID="ButtonCambiarInfoPagos" runat="server" Text="Añadir tarjeta" OnClick="ButtonCambiarInfoPagos_Click" CausesValidation="False" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
