<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarEstaciones.aspx.cs" Inherits="EstacionesApp.RegistrarEstaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center mt-3">

        <div>
            <asp:Label ID="mensajeLbl" runat="server" CssClass="text-success h1"></asp:Label>
        </div>

        <div class="card">
            <div class="card-header bg-info text-white">
                Registrar Estacion
            </div>
            <div class="card-body">

                <div class="form-group p-3">

                    <label for="numeroTxt">Numero Estacion</label>
                    <asp:TextBox ID="numeroTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Debe ingresar el numero de la estacion"
                        ControlToValidate="numeroTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group p-3">

                    <label for="direccionTxt">Direccion Estacion</label>
                    <asp:TextBox ID="direccionTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="Debe ingresar la direccion de la estacion"
                        ControlToValidate="direccionTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group p-3">
                    <label for="tipoDdl">Tipo</label>

                    <asp:DropDownList ID="TipoDdl" runat="server" CssClass="form-control"></asp:DropDownList>

                </div>
                <div class="form-group p-3">
                <label for="regionDdl">Region</label>
                <asp:DropDownList ID="regionDdl" runat="server" CssClass="form-control"></asp:DropDownList>

            </div>
            </div>
            

            <div class="card-footer">
                <asp:Button ID="registrarBtn" runat="server" Text="Registrar" CssClass="btn btn-dark"
                    OnClick="registrarBtn_Click" />
            </div>
        </div>
    </div>

</asp:Content>

