<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="GableWeb.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="ProductoValo.css">

      <div class="contenido">
          <div class="caja">
              <asp:Image ID="Image1" runat="server" src="src/parchis.png"  ImageAlign="Left"  />
          </div>
          <div class="caja">
              <asp:Label ID="Nombre" runat="server" Text=""></asp:Label>
          </div>
          <div class="caja">
              <asp:Label ID="Precio" runat="server" Text=""></asp:Label>
          </div>
           <div class="caja">
              <asp:Label ID="Marca" runat="server" Text=""></asp:Label>
          </div>
           <div class="caja">
              <asp:Label ID="Descripcion" runat="server" Text=""></asp:Label>
          </div>
         
             <a class="boton_personalizado" href="https://www.google.es/?gfe_rd=cr&ei=YWQDWY_kKozY8gfvza2YBg">Añadir al carrito</a>         
         
      </div>        
      <div class="comentarios">
         
              <textarea name="" id="" placeholder="Comentarios"></textarea>
               
           
        </div>
    
    
</asp:Content>

