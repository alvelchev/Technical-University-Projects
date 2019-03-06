using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab5.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Грижа за тялото" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Грижа за кожата" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Грижа за косата" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "Мега доза, XXL 1000 мл", "images/b1.jpg", "Пяна за вана", 7.5 },
                    { 16, 3, "Балсами и шампоани за коса за блясък, обем, възстановяване и против пърхут", "images/h4.jpg", "Балсами и шампоани", 5.0 },
                    { 15, 3, "Четки за лесно разресване и изправяне на коса", "images/h3.jpg", "Четка за коса", 5.9 },
                    { 14, 3, "Аксесоари за оформяне на прическа", "images/h2.jpg", "Нова прическа", 2.9 },
                    { 13, 3, "Професионален ефект -дълготраен цвят, 100% покритие на белите коси", "images/h1.jpg", "Боя за коса", 8.9 },
                    { 12, 2, "Блестящ цвят без изсушване на устните", "images/f6.jpg", "Червила", 6.9 },
                    { 11, 2, "Диамантен блясък, матиран цвят и хидратиращо усещане", "images/f5.jpg", "Сенки за очи и грим", 4.9 },
                    { 10, 2, "Нежен блясък и хидратация, лек цвят и грижа", "images/f4.jpg", "Грим за лице", 5.9 },
                    { 9, 2, "Значително по-стегнат и по-младежки видна кожата само след две седмици", "images/f3.jpg", "Крем за лице", 26.0 },
                    { 8, 2, "Максимално обемни мигли - до 15x пъти повече обем", "images/f2.jpg", "Спирала", 9.9 },
                    { 7, 2, "Очертават прецизни линии и перфектно подчертават очите", "images/f1.jpg", "Течна очна линия", 6.9 },
                    { 6, 1, "Подранващи кремове за ръце", "images/b6.jpg", "Грижа за ръце", 4.9 },
                    { 5, 1, "11 различни ухания за сензационен душ", "images/b5.jpg", "Романтичен душ", 3.99 },
                    { 4, 1, "Козметика за оформяне на тялото", "images/b4.jpg", "Естествена грижа", 4.9 },
                    { 3, 1, "Сециални продукти с джинджифил и бял чай", "images/b3.jpg", "Грижа за крака", 4.9 },
                    { 2, 1, "Режим 'Събуди се', XL 500 мл", "images/b2.jpg", "Ободряваш душ", 2.79 },
                    { 17, 3, "Терапия с арганово масло", "images/h5.jpg", "Шампоан за здрава коса", 4.5 },
                    { 18, 3, "Най-добрата грижа за красива прическа", "images/h6.jpg", "Луксозна терапия", 5.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);
        }
    }
}
