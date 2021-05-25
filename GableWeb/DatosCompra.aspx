<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="DatosCompra.aspx.cs" Inherits="GableWeb.DatosCompra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container-fluid ">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important; margin-top: 1px solid #75777d!important;">
                <div class="container-fluid px-5 py-5">
                    <div class="panel panel-default" >
                        <div class="panel-heading text-center">
			    				<h3 class="panel-title font-weight-bold">Introducir Datos de Compra</h3>
			 			</div>
                            <div class="row justify-content-center">
                                <div class="col-md-3 col-sm-3 col-xs-3">
                                    <span class="help-block text-muted small-font" > Numero Tarjeta</span>
                                    <asp:TextBox ID="numTarjeta" runat="server" ></asp:TextBox>
                                </div>
                                <div class="col-md-3 col-sm-3 col-xs-3">
                                    <span class="help-block text-muted small-font" > Card Verification Value (CVV)</span>
                                    <asp:TextBox ID="ccv" runat="server" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="row justify-content-center">
                                <div class="col-md-3 col-sm-3 col-xs-3">
                                    <span class="help-block text-muted small-font" > Mes de Vencimiento</span>
                                    <asp:TextBox ID="mesExp" runat="server" placeholder="MM"></asp:TextBox>
                            </div>
                                <div class="col-md-3 col-sm-3 col-xs-3">
                                    <span class="help-block text-muted small-font" > Año de Vencimiento</span>
                                    <asp:TextBox ID="yearExp" runat="server" placeholder="YYYY"></asp:TextBox>
                                </div>
                            </div>
                             <div class="row justify-content-center ">
                                <div class="col-md-4 col-sm-4 col-xs-4">
                                    
                                    <asp:Button ID="cancel" runat="server" OnClick="btnCancel_Click" Text="CANCEL" BackColor="RED" ></asp:Button>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2 offset-1">
                                    <asp:Button ID="confirm" runat="server" OnClick="btnConfirm_Click" Text="CONFIRMAR" BackColor="Gold"></asp:Button>
                                </div>
                            </div>
                    </div>
                </div>
            </div>
    <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
</asp:Content>
