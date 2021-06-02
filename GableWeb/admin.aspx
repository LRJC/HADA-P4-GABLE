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
                                 <h4><asp:Label ID="GestionMarcas" runat="server" Text="Gestionar marcas"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0 justify-content-center mb-5">
                                <div class="col-4">
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="TextBox1" runat="server" MaxLength="16" placeholder="Nombre" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="TextBox2" runat="server" MaxLength="16" placeholder="Origen" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row">
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="ButtonCambiarDatosPersonales" CssClass="btn-warning rounded" runat="server" Text="Crear" Columns="90" OnClick="ButtonCambiarDatosPersonales_Click" />
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="Button1" CssClass="btn-warning rounded" runat="server" Text="Eliminar" Width="90" OnClick="Button1_Click" />
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="Button2" CssClass="btn-warning rounded" runat="server" Text="Modificar" Width="90" OnClick="Button2_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="row-10 my-2 border-bottom">
                                 <h4><asp:Label ID="ElimUsu" runat="server" Text="Eliminar Usuarios"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0 justify-content-center mb-5">
                                <div class="col-4">
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="TextBox4" runat="server" MaxLength="16" placeholder="DNI" Columns="35"></asp:TextBox>
                                    </div>
                                    <asp:Button ID="Button3" CssClass="btn-warning rounded" runat="server" Text="Eliminar" Width="90" OnClick="Button3_Click" />
                                </div>
                            </div>
                            <div class="row-10 my-2 border-bottom">
                                 <h4><asp:Label ID="GestionProd" runat="server" Text="Gestionar Productos"></asp:Label></h4>
                            </div>
                            <div class="row my-2 mx-0 justify-content-center mb-5">
                                <div class="col-4">
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="IDProd" runat="server" MaxLength="16" placeholder="ID Producto" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="NombreProd" runat="server" MaxLength="50" placeholder="Nombre" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="DescProd" runat="server" MaxLength="100" placeholder="Descripcion" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="PrecioProd" runat="server" MaxLength="16" placeholder="Precio" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="imagenProd" runat="server" MaxLength="50" placeholder="URL imagen" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="TipoProd" runat="server" MaxLength="50" placeholder="Tipo/Categoría" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row-12 my-2 mx-0">
                                        <asp:TextBox ID="marcaProd" runat="server" MaxLength="16" placeholder="Marca" Columns="35"></asp:TextBox>
                                    </div>
                                    <div class="row">
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="crearProd" CssClass="btn-warning rounded" runat="server" Text="Crear" Width="90" OnClick="crearProd_Click"/>
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="elimProd" CssClass="btn-warning rounded" runat="server" Text="Eliminar" Width="90" />
                                        </div>
                                        <div class="col-4 px-1 mx-0">
                                            <asp:Button ID="modProd" CssClass="btn-warning rounded" runat="server" Text="Modificar" Width="90" />
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
