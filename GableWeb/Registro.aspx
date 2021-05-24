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
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<asp:TextBox ID="apellidos" runat="server" placeholder="Apellidos"></asp:TextBox>
			    					</div>
			    				</div>
			    			</div>

							<div class="row">
								<div class="col-xs-4 col-sm-4 col-md-4">
			    					<div class="form-group">
			    						<asp:TextBox ID="tlf" runat="server" placeholder="Telefono" Columns="15"></asp:TextBox>
			    					</div>
			    				</div>
								<div class="col-xs-4 col-sm-4 col-md-4">
			    					<div class="form-group">
			    						<asp:TextBox ID="dni" runat="server" placeholder="DNI" Columns="15"></asp:TextBox>
			    					</div>
			    				</div>
								<div class="col-xs-4 col-sm-4 col-md-4">
			    					<div class="form-group">
			    						<asp:TextBox ID="date" runat="server" TextMode="Date"></asp:TextBox>
			    					</div>
			    				</div>
							</div>


			    			<div class="form-group">
								<asp:TextBox ID="email" runat="server" placeholder="Email" Columns="55"></asp:TextBox>
			    			</div>

			    			<div class="row">
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
										<asp:TextBox ID="pwd" TextMode="Password" runat="server" placeholder="Contraseña"></asp:TextBox>
			    					</div>
			    				</div>
			    				<div class="col-xs-6 col-sm-6 col-md-6">
			    					<div class="form-group">
			    						<asp:TextBox ID="c_pwd" TextMode="Password" runat="server" placeholder="Confirmar Contraseña"></asp:TextBox>
			    					</div>
			    				</div>
			    			</div>
			    			<div class="confirm-button text-center">
			    				<asp:Button ID="b_register" runat="server" Text="Registrate Ahora" OnClick="btnRegister_Click"/>
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
