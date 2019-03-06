<%@ Page Title="Продукти" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="Lab4.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <section id="galleries">
         <br />
        <h1 id="productHead"><%: Page.Title %></h1>
        <asp:ListView ID="productList" runat="server" DataKeyNames="ProductID" GroupItemCount="6" ItemType="Lab4.Models.Product" SelectMethod="GetProducts">
            <LayoutTemplate>
                <table>
                <tr id="groupPlaceholder" runat="server"></tr >
                </table >
            </LayoutTemplate>
            <GroupTemplate>
                <tr>
                <td runat="server" id="itemPlaceholder"></td>
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;<a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                    <img src="/<%#:Item.ImagePath%>"
                    style="width:130px; height:200px; border: solid" />
                    </a>&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;<a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>">
                    <span ><%#:Item.ProductName%></span>
                    </a>
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;
                    <span><b>Цена: </b>
                    <%#:String.Format("{0:C}", Item.UnitPrice)%></span>
                </td>

            </ItemTemplate>
         </asp:ListView>
         <br />
     </section>
     <br />
</asp:Content>
