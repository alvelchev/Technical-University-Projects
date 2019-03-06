<%@ Page Title="Контакти" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="Lab4.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="background-color: white; width: 500px; height: 450px; margin-top: 2em; margin-bottom: 2em; margin-left: auto; margin-right: auto;">
     <header style="margin: 0; padding: 0.1em; height: auto; background: url(images/bg02.png) repeat;">
         <h1 style="text-align:center">Контакти</h1>
         <h3 style="text-align:center">Моля, попълнете формата!</h3>
     </header>
     <article style="margin-bottom: 10px; margin-top: 10px; margin-left: 20px; margin-right: 20px; height: auto; width: 430px;">
         <table style="border-spacing:0px;    align-content: center; height: 300px; width: 420px;">
             <tr>
                 <td style="width: 50px; height: 1px;"></td>
                 <td style="width: 190px; height: 1px; " >
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                 runat="server"
                ErrorMessage="Моля, въведете собствено име!"
                ControlToValidate="TextBox1" ForeColor="#BC1414"
                 Font-Size="XX-Small" Display="Dynamic" Height="1px"
                 Width="210px"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 10px;">Собствено име:</td>
                 <td style="width: 210px; height: 10px;">
                 <asp:TextBox ID="TextBox1" runat="server"
                 Width="210px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 1px; "></td>
                 <td style="width: 190px; height: 1px; ">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                 runat="server"
                ErrorMessage="Моля, въведете фамилно име!"
                 ControlToValidate="TextBox2" ForeColor="#BC1414"
                 Font-Size="XX-Small" Display="Dynamic" Height="1px"
                 Width="210px"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 10px;">Фамилно име:</td>
                 <td style="width: 210px; height: 10px;">
                 <asp:TextBox ID="TextBox2" runat="server"
                 Width="210px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 1px; "></td>
                 <td style="width: 190px; height: 1px; ">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                 runat="server"
                ErrorMessage="Моля, въведете адрес за електронна поща!"
                ControlToValidate="TextBox3" ForeColor="#BC1414"
                Font-Size="XX-Small" Display="Dynamic" Height="1px"
                 Width="210px"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 10px;">Електронна поща:</td>
                 <td style="width: 210px; height: 10px;">
                 <asp:TextBox ID="TextBox3" runat="server"
                 Width="210px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 1px; "></td>
                 <td style="width: 190px; height: 1px; ">
                 <asp:RegularExpressionValidator
                 ID="RegularExpressionValidator1" runat="server"
                ControlToValidate="TextBox3" ErrorMessage =
                 "Моля, въведете валиден адрес за електронна поща!"
                Font-Size="XX-Small" Display="Dynamic"
                 ForeColor="#BC1414" Height="1px" Width="190px"
                ValidationExpression=
                "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" >
                 </asp:RegularExpressionValidator>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 1px; "></td>
                 <td style="width: 190px; height: 1px; ">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                 runat="server"
                ErrorMessage="Моля, изберете вида на запитването!"
                ControlToValidate="DropDownList1" ForeColor="#BC1414"
                Font-Size="XX-Small" Display="Dynamic" Height="1px"
                 Width="210px" InitialValue="Избери">
                 </asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 10px;">Външни запитвания:</td>
                 <td style="width: 210px; height: 10px;">
                 <asp:DropDownList ID="DropDownList1" runat="server"
                 Width="217px">
                <asp:ListItem>Избери</asp:ListItem>
                 <asp:ListItem>Поръчки</asp:ListItem>
                 <asp:ListItem>Доставки</asp:ListItem>
                <asp:ListItem>Общи въпроси</asp:ListItem>
                <asp:ListItem>Други</asp:ListItem>
                 </asp:DropDownList>
                 </td>
             </tr>
             <tr>
                <td colspan="2" style="height: 14px">Коментари:</td>
             </tr>
             <tr>
                 <td style="width: 50px; height: 1px; "></td>
                 <td style="width: 190px; height: 1px; ">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                 runat="server" ErrorMessage="Моля, въведете коментар!"
                ControlToValidate="TextBox4" ForeColor="#BC1414"
                 Font-Size="XX-Small" Display="Dynamic" Height="1px"
                 Width="210px"></asp:RequiredFieldValidator>
                 </td>
             </tr>
             <tr>
                 <td colspan="2" style="height:10px">
                 <asp:TextBox ID="TextBox4" runat="server"
                 TextMode="MultiLine" Width="420px"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td colspan="2" >
                 <asp:Button ID="Button1" runat="server"
                 Text="Изпрати"
                 OnClick="Button1_Click" style="margin:0 150px; padding: 2px; background-color: #BC1414; color: white; border: none; width: 100px;" />
                 </td>
             </tr>
         </table>
     </article>
 </section>
</asp:Content>
