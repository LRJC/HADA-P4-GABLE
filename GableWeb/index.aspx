<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GableWeb.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="HojaInicio.css"/>
  <ul class="menu">
      <li><a href="#sec1">Más vendidos</a></li>
      <li><a href="#sec2">Mejor Valorados</a></li>
      <li><a href="#sec3">Recomendados</a></li>
  </ul>

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
