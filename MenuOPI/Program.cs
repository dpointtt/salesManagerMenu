/*
 * Завдання MCCL9

Створити в окремому класі  колекцію об'єктів класу Laptop (ноутбук) та вивести інформацію щодо колекції на консоль.
Клас повинен мати такі властивості (поля): 
Id   LaptopBrand(бренд)   Model(модель)

Окремий клас повинен мати інтерфейс та такі методи:
-метод додавання елемента до колекції;
-пошуку елемента по Id;
-видалення елемента з колекції по елементу;

Створити окремий клас SalesManager (менеджер з продажу) з інтерфейсом, методи якого використовують методи класу з колекцією.
Створити дворівневе меню: MainMenu (основне меню) та SalesManagerMenu (меню менеджера з продажу). Кожне меню в окремому класі.

Цишевський Денис 372 група
 */

using MenuOPI;

DBItem<Laptop> laptops = new DBItem<Laptop>();
laptops.AddItem(new Laptop("Acer", "Aspire 5"));
laptops.AddItem(new Laptop("Asus", "VivoBook 15"));
laptops.AddItem(new Laptop("Lenovo", "IdeaPad 3"));
laptops.AddItem(new Laptop("Asus", "ROG Strix G15"));
laptops.AddItem(new Laptop("Acer", "Swift 1"));

SalesManager salesManager = new SalesManager(laptops);
SalesManagerMenu salesManagerMenu = new SalesManagerMenu(salesManager);
MainMenu mainMenu = new MainMenu(salesManagerMenu);
mainMenu.Open();
