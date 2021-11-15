<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PretoOliveira1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label2" runat="server" Text="ID..: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;">
        <asp:TextBox ID="txt_id" runat="server" Width="100" Enabled="false">
        
        </asp:TextBox></asp:Label><asp:Label ID="Label1" runat="server" Text="Nome..:">
        </asp:Label><asp:TextBox ID="txt_nome" runat="server" Width="300"></asp:TextBox>
        <br />

        <asp:Label ID="Label3" runat="server" Text="Logradouro..:"></asp:Label>
        <asp:TextBox ID="txt_logradouro" runat="server" Width="500"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Numero..:"></asp:Label>
        <asp:TextBox ID="txt_numero" runat="server" Width="150"></asp:TextBox>
        <br />

        <asp:Label ID="Label5" runat="server" Text="Bairro..: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
        <asp:TextBox ID="txt_bairro" runat="server" Width="269"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Cidade..:  "></asp:Label>
        <asp:TextBox ID="txt_cidade" runat="server" Width="268"></asp:TextBox>
        <br />

        <asp:Label ID="Label7" runat="server" Text="Telefone..: &nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
        <asp:TextBox ID="txt_telefone" runat="server" Width="200"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="Email..:"></asp:Label>
        <asp:TextBox ID="txt_email" runat="server" Width="150"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="CPF..:"></asp:Label>
        <asp:TextBox ID="txt_cpf" runat="server" Width="150"></asp:TextBox>
        <br /> <br /> <br />

        <asp:Button ID="btn_adicionar" runat="server" Text="Adicionar" OnClick="btn_adicionar_Click" />

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Tabela de Clientes<asp:GridView ID="gvw_cliente" runat="server">
                </asp:GridView>
            </h2>
            
        </div>
        
    </div>

</asp:Content>
