<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="GableWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid ">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important; margin-top: 1px solid #75777d!important;">
                <div class="container px-5 py-5">
                    <div class="row justify-content-center">
					<div class="col-md-6">
        				<div class="panel panel-default">
        					<div class="panel-heading text-center">
			    				<h3 class="panel-title">Formulario de Registro</h3>
			 				</div>
			 			<div class="panel-body">
			    		<form role="form">
			    			<div class="row">
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
									<asp:TextBox ID="nombre" runat="server" placeholder="Nombre"></asp:TextBox>
										<asp:RequiredFieldValidator ID="NombreReq" runat="server" ControlToValidate="nombre" ErrorMessage="*"></asp:RequiredFieldValidator>
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<asp:TextBox ID="apellidos" runat="server" placeholder="Apellidos"></asp:TextBox>
										<asp:RequiredFieldValidator ID="ApellidosReq" runat="server" ControlToValidate="apellidos" ErrorMessage="*"></asp:RequiredFieldValidator>
			    					</div>
			    				</div>
			    			</div>

							<div class="row">
								<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
										<asp:TextBox ID="date" runat="server" TextMode="Date"></asp:TextBox>
										<asp:RangeValidator runat="server" ID="rngDate" ControlToValidate="date" type="Date" MinimumValue="01-01-1900" MaximumValue="01-06-2021" ErrorMessage="¡Fecha no Válida!"></asp:RangeValidator>
			    					</div>
			    				</div>
								<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<asp:TextBox ID="dni" runat="server" placeholder="DNI" Columns="20"></asp:TextBox>
										<asp:RequiredFieldValidator ID="DniReq" runat="server" ControlToValidate="dni" ErrorMessage="*"></asp:RequiredFieldValidator>
										<asp:RegularExpressionValidator ID="RegDni" runat="server" ControlToValidate="dni" ErrorMessage="¡Demasiado largo! 9 máximo" ValidationExpression="[0-9]{8}[A-Z]{1}"></asp:RegularExpressionValidator>
			    					</div>
			    				</div>
							</div>


			    			<div class="form-group">
								<asp:TextBox ID="email" runat="server" placeholder="Email" Columns="55"></asp:TextBox>
								<asp:RequiredFieldValidator ID="EmailReq" runat="server" ControlToValidate="email" ErrorMessage="*"></asp:RequiredFieldValidator>
								<asp:RegularExpressionValidator ID="EmailControl" runat="server" ControlToValidate="email" ErrorMessage="Formato Inválido" ValidationExpression="\S+@\S+.\S+"></asp:RegularExpressionValidator>
			    			</div>

			    			<div class="row">
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
										<asp:TextBox ID="pwd" TextMode="Password" runat="server" placeholder="Contraseña"></asp:TextBox>
										<asp:RequiredFieldValidator ID="PwdReq" runat="server" ControlToValidate="pwd" ErrorMessage="*"></asp:RequiredFieldValidator>
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<asp:TextBox ID="tlf" runat="server" placeholder="Telefono" Columns="20"></asp:TextBox>
										<asp:RegularExpressionValidator ID="RegTlf" runat="server" ControlToValidate="tlf" ErrorMessage="¡Demasiado largo! 9 máximo" ValidationExpression="[0-9]{9}"></asp:RegularExpressionValidator>
			    					</div>
			    				</div>
			    			</div>
							<div class="row">
			    				<div class="confirm-button text-center">
			    					<asp:Button ID="b_register" runat="server" Text="Registrate Ahora" OnClick="btnRegister_Click"/>
									<asp:Label ID="campoObligatorio" runat="server">(*) Campo obligatorio</asp:Label>
			    				</div>
							</div>
							<div class="output-text text-center">
								<asp:Label ID="outputMsg" runat="server"></asp:Label>
			    			</div>
			    		</form>
			    	</div>
	    		</div>
    		</div>
    	</div>
                </div>
            </div>
    <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
</asp:Content>
