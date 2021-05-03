<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GableWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid ">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important; margin-top: 1px solid #75777d!important;">
                <div class="container-fluid px-5 py-5">
                    <div  class="col-xs-6 col-md-12 font-weight-bold text-center">
                        <label for="user_login">Usuario o email</label>
                        <input type="text" />
                    </div>
                    <div  class="col-xs-6 col-md-12 font-weight-bold text-center">
                        <label for="password">Contraseña</label>
                        <input type="password" />
                    </div>
                    <div class="text-center">
                        <button type="submit" id="login">Login</button>
                        <button type="submit" id="register">Registrate Ahora</button>
                    </div>
                </div>
            </div>
    <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
</asp:Content>
