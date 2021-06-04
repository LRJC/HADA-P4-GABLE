<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="DatosPago.aspx.cs" Inherits="GableWeb.DatosPago" %>
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
			    				<h3 class="panel-title font-weight-bold">Introducir Datos de Pago</h3>
			 			</div>
                            <div class="row justify-content-center">
                                <div class="col-md-3 col-sm-3 col-xs-3 py-3 px-3">
                                    <asp:TextBox ID="numTarjeta" runat="server" placeHolder="Número Tarjeta"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ReqNumTarjeta" ControlToValidate="numTarjeta" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegNumTarjeta" runat="server" ControlToValidate="numTarjeta" ErrorMessage="Formato 8 números" ValidationExpression="[0-9]{8}"></asp:RegularExpressionValidator>
                                </div>
                                <div class="col-md-3 col-sm-3 col-xs-3 py-3">
                                    <asp:TextBox ID="cvv" runat="server" placeHolder="CVV"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ReqCvv" ControlToValidate="cvv" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegCvv" runat="server" ControlToValidate="cvv" ErrorMessage="Formato XXX" ValidationExpression="[0-9]{3}"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="row justify-content-center">
                                <div class="fecha-vencimiento">
                                    <asp:TextBox ID="fechaExp" runat="server" placeHolder="Fecha de Expiración"></asp:TextBox> 
                                    <asp:RequiredFieldValidator ID="ReqFechaExp" ControlToValidate="fechaExp" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="RegFechaExp" runat="server" ControlToValidate="fechaExp" ErrorMessage="Formato MM/YY" ValidationExpression="[0-9]{2}/[0-9]{2}"></asp:RegularExpressionValidator>
                                </div>  
                             </div>
                             <div class="row justify-content-center ">
                                <div class="col-md-4 col-sm-4 col-xs-4">
                                    
                                    <asp:Button ID="cancel" runat="server" OnClick="btnCancel_Click" CausesValidation="false" Text="CANCEL" BackColor="RED" ></asp:Button>
                                </div>
                                <div class="col-md-2 col-sm-2 col-xs-2 offset-1">
                                    <asp:Button ID="confirm" runat="server" OnClick="btnConfirm_Click" Text="CONFIRMAR" BackColor="Gold"></asp:Button>
                                </div>
                            </div>
                            <div class="output-text text-center">
								<asp:Label ID="outputMsg" runat="server"></asp:Label>
			    			</div>
                    </div>
                </div>
            </div>
    <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
</asp:Content>
