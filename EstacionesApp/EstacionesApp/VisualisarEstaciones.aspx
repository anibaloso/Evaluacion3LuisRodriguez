<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VisualisarEstaciones.aspx.cs" Inherits="EstacionesApp.VisualisarEstaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mt-5">
        <asp:GridView ID="estacionesGrid" runat="server" AutoGenerateColumns="false"
            EmptyDataText="No hay estaciones ingresadas" CssClass="table table-hover"
            OnRowCommand="estacionesGrid_RowCommand">

            <Columns>
                <asp:BoundField HeaderText="Numero de la estacion" DataField="numeroEstacion" />
                <asp:BoundField HeaderText="Direccion de la estacion" DataField="direccion" />
                <asp:BoundField HeaderText="Tipo de la estacion" DataField="tipo" />
                <asp:BoundField HeaderText="Region de la estacion" DataField="region" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Eliminar" CssClass="btn bg-danger"
                            CommandName="eliminar" CommandArgument='<%#Eval("numeroEstacion") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

        </asp:GridView>
    </div>

</asp:Content>
