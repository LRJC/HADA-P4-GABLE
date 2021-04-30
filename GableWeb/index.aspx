<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GableWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="styles/index.css"/>
    <div class="container-fluid">
        <div class="row align-content-center" style="text-align: center;">
            <asp:HyperLink id="most_sold" Text="Más vendidos" NavigateUrl="#sec1" CssClass="col-xs-12 col-sm-4 py-2" runat="server" style="background-color:#285ab5; color: #fff !important; border: 0; text-decoration: none;"/>
            <asp:HyperLink id="most_valued" Text="Mejor valorados" NavigateUrl="#sec2" CssClass="col-xs-12 col-sm-4 py-2" runat="server" style="background-color:#285ab5; color: #fff !important; border: 0; text-decoration: none;"/>
            <asp:HyperLink id="recommended" Text="Recomendados" NavigateUrl="#sec3" CssClass="col-xs-12 col-sm-4 py-2" runat="server" style="background-color:#285ab5; color: #fff !important; border: 0; text-decoration: none;"/>
        </div>
    </div>

    <div style="margin-top: 20px;" class="div1">
        <section id="sec1">
            <h2 style="color: cadetblue; font-style: italic;">MÁS VENDIDOS</h2>
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
        </section>

        <section id="sec2">
            <h2 style="color: cadetblue; font-style: italic;">MEJOR VALORADOS</h2>
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
        </section>

        <section id="sec3">
            <h2 style="color: cadetblue; font-style: italic;">RECOMENDADOS</h2>
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
            <br />
            <img src="src/old_gable-logo.png"/>
            <img src="src/gable-logo.png"/>
        </section>
    </div>
</asp:Content>
