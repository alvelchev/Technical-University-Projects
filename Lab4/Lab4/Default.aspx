<%@ Page Title="Начало" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab4.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="banner">
        <img src="images/logo.jpg" width="1300" height="264" alt="" />
     </div>
     <section>
         <article class="three-column">
             <h1>Грижа за тялото</h1>
             <p>
             Avon е любима марка, която предлага разнообразни лосиони за тяло,
             миещи и почистващи препарати, душ гелове и крем за ръце.
             <br />
             Също така в категорията на Avon за лична хигиена е Naturals,
             популярна серия от ценни продукти за баня и грижа за тялото.
             </p>
             <a class="button" href="/ProductList.aspx?id=1"><b>Виж още</b></a>
         </article>
         <article class="three-column">
             <h1>Грижа за кожата</h1>
             <p>
             Avon предизвика революция в света на грижата за кожата с пускането
             на своята марка ANEW, която използва иновативни технологии за борба
             със стареенето и помага на жените да изглеждат по-млади.
             <br />
             Това е първият продукт за грижа за кожата, съдържащ технологията
             Alpha Hydroxy Acid.
             </p>
             <a class="button" href="/ProductList.aspx?id=2"><b>Виж още</b></a>
         </article>
         <article class="three-column">
             <h1>Грижа за косата</h1>
             <p>
             Продуктите на Avon придават изискан вид на косата на достъпни цени.
             Включват пълна гама от висококачествени шампоани, балсами и
             Стилизиращи продукти - създадени, за да задоволят разнообразната
             Потребителска база и да посрещнат нуждите на жени от различни
             възрасти.
             </p>
             <a class="button" href="/ProductList.aspx?id=3"><b>Виж още</b></a>
         </article>
     </section>
</asp:Content>
