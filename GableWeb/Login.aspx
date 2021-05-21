<%@ Page Title="" Language="C#" MasterPageFile="~/Gable.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GableWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
        .my-row {
            height: 150px;
        }
    </style>
    <div class="container-fluid ">
        <div class="row">
            <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
            <div class="col-xs-12 col-sm-10" style="background-color:white; border-left: 1px solid #75777d!important; border-right: 1px solid #75777d!important; margin-top: 1px solid #75777d!important;">
                <div class="container-fluid px-5 py-5">
                    <div class="row my-row">
                        <div  class="col-xs-6 col-md-12 font-weight-bold text-center">
                            <img src="src/gable-logo.png" height="100"/>
                        </div>
                    </div>
                    <div  class="col-xs-6 col-md-12 font-weight-bold text-center">
                        <label for="user_login">Email</label>
                        <asp:TextBox ID="email" runat="server" Columns="30"></asp:TextBox>
                    </div>
                    <div  class="col-xs-6 col-md-12 font-weight-bold text-center">
                        <label for="password">Contraseña</label>
                        <asp:TextBox ID="pwd" TextMode="Password" runat="server" Columns="20"></asp:TextBox>
                    </div>
                    <div class="text-center">
                        <asp:Button ID="b_login" runat="server" Text="Login" OnClick="btnLogin_Click"/>
                        <asp:Button ID="b_register" runat="server" Text="Registrate Ahora" OnClick="btnRegister_Click"/>
                    </div>
                </div>
            </div>
    <div class="col-sm-1" style="background-color:#e0e0e0!important"></div>
        </div>
    </div>
</asp:Content>
