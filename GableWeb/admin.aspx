<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="GableWeb.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container-fluid">
        <div class="row">
            <div class="col-sm-2" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-8 text-center" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important;">
                <div class="row">
                <div class="col-12 px-4">
                    <div class="row mt-xs-2 mt-md-5">
                        <div class="col-12">
                            <div class="row-10 my-2 border-bottom">
                                        <h4><asp:Label ID="CambiarContra" runat="server" Text="Gestionar marcas"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0 justify-content-center">
                                <div class="col-4">
                                    <div class="row my-2 mx-0">
                                        <asp:TextBox ID="TextBox1" runat="server" MaxLength="16" placeholder="Nombre" TextMode="Password" Columns="30"></asp:TextBox>
                                    </div>
                                    <div class="row my-2 mx-0">
                                        <asp:TextBox ID="TextBox2" runat="server" MaxLength="16" placeholder="Origen" TextMode="Password" Columns="30"></asp:TextBox>
                                    </div>
                                    <div class="row my-2 mx-0">
                                        <asp:TextBox ID="TextBox3" runat="server" MaxLength="16" placeholder="URL logo" TextMode="Password" Columns="30"></asp:TextBox>
                                    </div>
                                    <div class="row">
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="ButtonCambiarDatosPersonales" runat="server" Text="Crear" />
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="Button1" runat="server" Text="Eliminar" />
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="Button2" runat="server" Text="Modificar" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>   
            </div>
            <div class="col-sm-2" style="background-color:#e0e0e0!important"></div>
        </div> 
    </div>
</asp:Content>
