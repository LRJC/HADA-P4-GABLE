<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="GableWeb.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="styles/Productos.css">

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important; margin-top: 1px solid #75777d!important;">
               <div class="container-fluid px-5 py-5">
                   <div class="row">
                        <!--Imagen  "src/game_images/parchis.png"-->
                       
                        <div class="col-xs-12 col-md-6">
                           <!-- <img ID="Image1" src="src/game_images/parchis.png" Height="300" Width="300" />-->
                            <asp:Image ID="Image1" runat="server" CssClass="img-fluid"  Height="300" Width="300"/>
                        </div>
                       <!--Titulo, precio, descripcion   maxlength-->
                        <div class="col-xs-12 col-md-6">
                           <!-- <h2>Parchis-chis-chis</h2> --> 
                            <asp:Label ID="nombreP" runat="server" Text="" Font-Size="250%"  ></asp:Label>
                            <!-- <div style="color: black; text-align:center;"><%# Eval("nombre") %></div>-->
                           <div class="form-group precio_elem row">
                               <label class="col-sm-3 form-control-lebel nopaddingtop">
                                   <font style="vertical-align:inherit;">
                                       <font style="vertical-align:inherit">Precio:</font>
                                   </font>
                               </label>
                               <div class="col-sm-8 col-md-9">
                                   <span class="precio-producto font-weight-bold" id="precio-producto">
                                       <font style="vertical-align:inherit;">
                                       <font style="vertical-align:inherit " ><asp:Label ID="Precio" runat="server" Text=""></asp:Label></font>
                                        </font>
                                   </span>
                               </div>
                           </div>
                            <div class="form-row">
                                <label for="Cantidad" class="col-sm-3 col-md-3 form-control-label">Cantidad:</label>
                                <div class="col-sm-8 col-md-9">
                                    <form>
                                  
                                         <input type="number" class="qty form-control"  id="Number1" name="qty"  UseSubmitBehavior="false" runat="server"  min="1" max="9999" value="1" />
                                    </form>
                                </div>
                            </div>
                            <div class="form-group row visible">
                                <label class="col-sm-3 col-md-3 form-control-label"></label>
                                <div class="col-sm-8 col-sm-offset-3 col-md-9 col-md-offset-3">
                                    <asp:Button id="btnLogout"  runat="server" Text="Añadir al carrito" OnClick="carrito"  CssClass="btn btn-block btn-order" style="text-align:center; background-color:Highlight;border-top: 1px solid #75777d!important;"></asp:Button>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label class="col-sm-3 col-md-3 form-control-label">Descripción:</label>
                                <div class="col-sm-8 col-md-9 descripcion">
                                    <!--<p>Tradicional juego de mesa, el parchis</p>-->
                                    <asp:Label ID="Desc" runat="server" Text=""></asp:Label>
                                    <!--<p><%# Eval("descripcion") %></p>-->
                                </div>
                            </div>
                            <div class="form-group row">
                                <label class="col-sm-3 form-control-label">Marca:</label>
                                <div class="col-sm-9 col-md-9">
                                    <asp:Label ID="Marca" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <!--Comentarios-->
                            <div class="form-group row">
                            <label class="col-sm-3 col-md-3 form-control-label"></label>
                            <div class="col-sm-8 col-sm-offset-3 col-md-9 col-md-offset-3">
                                
                                <div class="widget-area no-padding blank">
                                    <div class="status-upload">
                                        <form>
                                           <textarea placeholder="Comenta" cols="45" rows="5" id="msg" runat="server" name="cajaComent"></textarea>
                                            <!--<asp:TextBox ID="TextBox1" placeholder="Comenta" cols="75" runat="server"></asp:TextBox>-->
                                             <input type="number" class="qty form-control"  id="botC" name="qty"  UseSubmitBehavior="false" runat="server"  min="1" max="5" value="1" />

                                            <asp:Button ID="Button1" class="btn btn-success green" OnClick="comentario" runat="server" Text="Comentar" />
                                            <!--<button type="submit" class="btn btn-success green" OnClick="comentario"><i class="fa fa-share"></i> Comentar</button>-->
                                        </form>
                                    </div>
                                </div>
                            </div>
                            </div>
                        </div>
                  
                   </div>
                   <div class="row">
                       <div class="col-xs-12 col-md-6">
                     <asp:DataList ID="gv1" runat="server" RepeatColumns="1" CellPadding="2"  Width="100%" ItemStyle-HorizontalAlign="Left">
                                 
                         <ItemTemplate>
                            <table>

                                <tr>
                                    <td><p id="nombreUsu" style="text-align:left; font-family: Lucida Console, Courier New, monospace;"><%#Eval("nombre") %></p></td>
                                </tr>
                                <tr>
                                    <td><p id="comentar" style="text-align:center; font-family: Lucida Console, Courier New, monospace;"><%#Eval("texto") %></p></td>
                                </tr>
                                <tr>
                                   
                                    <td><asp:Image ID="estrella" runat="server" style="height: 20px; width: 90px; text-align:right;" ImageUrl='<%# Eval("estrella") %>'/></td>
                                </tr>

                                <td>
                                    <asp:Label ID="espacio" runat="server" Text=" ------ "></asp:Label>
                                </td>
                                

                            </table>
                        </ItemTemplate>
                               
                    </asp:DataList>
                           </div>
                       </div>
               </div>
            </div>
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
    
    
</asp:Content>