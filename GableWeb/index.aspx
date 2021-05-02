<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GableWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/index.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row align-content-center btn-sugerencias" style="text-align: center;">
            <asp:HyperLink id="most_sold" Text="Más vendidos" NavigateUrl="#sec1" CssClass="col-xs-12 col-sm-4 py-2" runat="server"/>
            <asp:HyperLink id="most_valued" Text="Mejor valorados" NavigateUrl="#sec2" CssClass="col-xs-12 col-sm-4 py-2" runat="server"/>
            <asp:HyperLink id="recommended" Text="Recomendados" NavigateUrl="#sec3" CssClass="col-xs-12 col-sm-4 py-2" runat="server"/>
        </div>
    </div>
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-1" style="background-color:darkgrey"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white;">
                <section id="sec1">
                    <h2>MAS VENDIDOS</h2>
                    <div class="container-fluid">
                         <div class="row">
                            <div class="col-xs-12 col-md-6">
                                <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div>
                            <div class="col-xs-12 col-md-6">
                                 <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div> 
                         </div> 
                    </div>
                </section>
                <section id="sec2">
                    <h2>MEJOR VALORADOS</h2>
                    <div class="container-fluid">
                         <div class="row">
                            <div class="col-xs-12 col-md-6">
                                <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div>
                            <div class="col-xs-12 col-md-6">
                                 <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div> 
                         </div> 
                    </div>
                </section>
                <section id="sec3">
                    <h2>RECOMENDADOS</h2>
                    <div class="container-fluid">
                         <div class="row">
                            <div class="col-xs-12 col-md-6">
                                <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div>
                            <div class="col-xs-12 col-md-6">
                                 <asp:ImageButton runat="server" ImageUrl="src/parchis.png" OnClick="img_prueba" Height="300" Width="300"/>
                            </div> 
                         </div> 
                    </div>
                </section>
            </div>
            <div class="col-sm-1" style="background-color:darkgrey"></div>
        </div> 
    </div>
</asp:Content>
