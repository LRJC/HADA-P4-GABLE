<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Cesta.aspx.cs" Inherits="GableWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="styles/index.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-0 col-md-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-12 col-md-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important;">
                <asp:Repeater ID="itemsCesta" runat="server">
                    <HeaderTemplate>
                        <div class="container-fluid px-5 py-5" style="min-height: 80vh!important;">
                            <div class="row">
                                <div class="col-12 col-lg-8 px-0 px-lg-2">
                                    <div class="row">
                                        <div class="col-5 font-weight-bold text-left" style="color: #5e5e5e!important;">ARTÍCULO</div>
                                        <div class="col-2 font-weight-bold text-center" style="color: #5e5e5e!important;">PRECIO</div>
                                        <div class="col-2 font-weight-bold text-center" style="color: #5e5e5e!important;">UDS.</div>
                                        <div class="col-2 font-weight-bold text-center" style="color: #5e5e5e!important;">TOTAL</div>
                                        <div class="col-1"></div>
                                    </div>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="row py-3 align-items-center">
                            <div class="col-3 text-center"><asp:ImageButton CssClass="img-fluid" id="game_img" runat="server" ImageUrl='<%# Eval("imagen") %>'/></div>
                            <div class="col-2 font-weight-bold" style="color: black; text-align:center;"><%# Eval("nombre") %></div>
                            <div class="col-2" style="color: #5e5e5e!important; text-align:center;"><%# Eval("importe") %></div>
                            <div class="col-2">
                                <div class="row align-items-center">
                                    <div class="col-4 p-0 m-0 text-right">
                                        <asp:ImageButton ID="substr_item" style="width: 24px;" ImageUrl="src/btns/substr.png" ImageAlign="Top" OnCommand="ItemQuery" CommandName="SubstractItemQuantity" CommandArgument='<%# String.Format("{0},{1}", Eval("numCesta"), Eval("linea")) %>' runat="server"/>
                                    </div>
                                    <div class="col-4 p-0 m-0" style="color: #5e5e5e!important; text-align:center;"><%# Eval("cantidad") %></div>
                                    <div class="col-4 p-0 m-0 text-left">
                                        <asp:ImageButton ID="add_item" style="width: 24px;" ImageUrl="src/btns/add.png" ImageAlign="Top" OnCommand="ItemQuery" CommandName="AddItemQuantity" CommandArgument='<%# String.Format("{0},{1}", Eval("numCesta"), Eval("linea")) %>' runat="server"/>
                                    </div>
                                </div>
                            </div>
                            <div class="col-2" style="color: #5e5e5e!important; text-align:center;"><%# Eval("total") %></div>
                            <div class="col-1 text-left px-0">
                                <asp:ImageButton ID="RemoveItem" style="width: 16px;" ImageUrl="src/btns/cross.png" ImageAlign="AbsMiddle" OnCommand="ItemQuery" CommandName="RemoveItemFromBasket" CommandArgument='<%# String.Format("{0},{1}", Eval("numCesta"), Eval("linea")) %>' runat="server"/>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                                </div>
                                <div class="col-12 col-lg-4 leftborder-lg pl-0 pl-lg-5 pt-3 pt-lg-0">
                                    <div class="row justify-content-center">
                                        <div class="col-6 col-lg-12 px-0 text-justify" style="color:#7a7a7a!important;">
                                            Recibe el paquete mañana con una compra superior a 30€
                                        </div>
                                    </div>
                                    <div class="row justify-content-center">
                                        <div class="col-12 px-0 mt-3 text-center">
                                            <span class="h4 font-weight-bold pr-2" style="color:black!important;">TOTAL:</span> <asp:Label ID="totalPrice" runat="server" CssClass="h4 font-weight-bold" style="color:#5e5e5e!important;" Text="23.96€"/>
                                        </div>
                                    </div>
                                    <div class="row justify-content-center">
                                        <div class="col-4 col-lg-12 px-0 mt-2">
                                             <!--TO DO: Use session's user id in CommandArgument -->
                                            <asp:Button id="btnProceed"  runat="server" OnCommand="ProceedToBuy" CommandArgument='<%# Eval("numCesta") %>' Text="Realizar pedido" CssClass="btn btn-block btn-order" style="text-align:center;"></asp:Button>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div class="col-0 col-md-1" style="background-color:#e0e0e0!important"></div>
        </div> 
    </div>
</asp:Content>
