<%@ Page Title="Детайли за продуктите" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Lab4.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         <section class="contacts">
             <article class="one-column">
                 <asp:FormView ID="productDetail" runat="server"
                 ItemType="Lab4.Models.Product" SelectMethod ="GetProduct"
                 RenderOuterTable="false">
                     <ItemTemplate>
                         <table>
                             <thead>
                                 <tr style="height:50px">
                                 <th colspan="2"> <h1><%#:Item.ProductName %></h1>
                                 </th>
                                 </tr>
                             </thead>
                             <tr>
                                 <td>
                                     <img src="/<%#:Item.ImagePath %>"
                                     style="border:solid; width:200px; height:300px"
                                    alt="<%#:Item.ProductName %>"/>
                                 </td>
                                <td style="vertical-align: top; text-align:left">
                                     <b>Описание:</b><br /><%#:Item.Description %>
                                    <br />
                                    <span><b>Цена:</b>&nbsp
                                     <%#:String.Format("{0:C}", Item.UnitPrice) %>
                                     </span>
                                     <br />
                                     <span><b>Номер на продукт:</b>&nbsp
                                     <%#:Item.ProductID %></span>
                                     <br />
                                 </td>
                             </tr>
                         </table>
                     </ItemTemplate>
                 </asp:FormView>
             </article>
         </section>
     </div>
</asp:Content>
