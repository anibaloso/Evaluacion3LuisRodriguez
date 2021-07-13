<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VisualisarPuntoDeCarga.aspx.cs" Inherits="EstacionesApp.VisualisarPuntoDeCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="mt-5">
        <asp:GridView ID="puntoDeCargaGrid" runat="server" AutoGenerateColumns="false"
            EmptyDataText="No hay Puntos de Carga ingresados" CssClass="table table-hover"
            OnRowCommand="puntoDeCargaGrid_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Numero del punto de Carga" DataField="numeroPuntoDeCarga" />
                <asp:BoundField HeaderText="Encargado" DataField="encargado" />
                <asp:BoundField HeaderText="Tipo del Punto de Carga" DataField="tipo" />
                <asp:BoundField HeaderText="Region" DataField="region" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Eliminar" CssClass="btn bg-danger"
                            CommandName="eliminar" CommandArgument='<%#Eval("numeroPuntoDeCarga") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
