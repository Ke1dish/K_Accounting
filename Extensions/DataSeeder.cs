using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Data;
using K_Accounting.Models;

namespace K_Accounting.Extensions
{
    public static class DataSeeder
    {
        public static void SeedCategoriesAndSubCategories(AppDbContext db)
        {
            if (!db.Categories.Any())
            {
                // Создаем категории с явным указанием Comment
                var category1 = new Category("Авто") { Comment = "" };  // Авто
                var category2 = new Category("Бизнес") { Comment = "" };  // Бизнес
                var category3 = new Category("Вредные привычки") { Comment = "" };  // Вредные привычки
                var category4 = new Category("Гигиена и красота") { Comment = "" };  // Гигиена и красота
                var category5 = new Category("Дети") { Comment = "" };  // Дети
                var category6 = new Category("Животные") { Comment = "" };  // Животные
                var category7 = new Category("Кафе и рестораны") { Comment = "" };  // Кафе и рестораны
                var category8 = new Category("Комиссии и налоги") { Comment = "" };  // Комиссии и налоги
                var category9 = new Category("Коммунальные платежи") { Comment = "" };  // Коммунальные платежи
                var category10 = new Category("Кредиты и долги") { Comment = "" }; // Кредиты и долги
                var category11 = new Category("Мебель") { Comment = "" }; // Мебель
                var category12 = new Category("Медицина") { Comment = "" }; // Медицина
                var category13 = new Category("Недвижимость") { Comment = "" }; // Недвижимость
                var category14 = new Category("Образование") { Comment = "" }; // Образование
                var category15 = new Category("Огород и дача") { Comment = "" }; // Огород и дача
                var category16 = new Category("Одежда и обувь") { Comment = "" }; // Одежда и обувь
                var category17 = new Category("Подарки") { Comment = "" }; // Подарки
                var category18 = new Category("Продукты питания") { Comment = "" }; // Продукты питания
                var category19 = new Category("Путешествия и отпуск") { Comment = "" }; // Путешествия и отпуск
                var category20 = new Category("Развлечение") { Comment = "" }; // Развлечение
                var category21 = new Category("Спорт") { Comment = "" }; // Спорт
                var category22 = new Category("Строительство и ремонт") { Comment = "" }; // Строительство и ремонт
                var category23 = new Category("Техника и электроника") { Comment = "" }; // Техника и электроника
                var category24 = new Category("Транспорт") { Comment = "" }; // Транспорт
                var category25 = new Category("Услуги") { Comment = "" }; // Услуги
                var category26 = new Category("Хозтовары") { Comment = "" }; // Хозтовары

                db.Categories.AddRange(category1,  category2,  category3,  category4,  category5,
                                       category6,  category7,  category8,  category9,  category10,
                                       category11, category12, category13, category14, category15,
                                       category16, category17, category18, category19, category20,
                                       category21, category22, category23, category24, category25,
                                       category26);
                db.SaveChanges();

                // Создаем подкатегории с Comment
                var subCategories = new[]
                {
#region Авто
                    new SubCategory("Автомойка", category1.Id) { Comment = "" },
                    new SubCategory("Автосервис", category1.Id) { Comment = "" },
                    new SubCategory("Автотовары", category1.Id) { Comment = "" },
                    new SubCategory("Запчасти", category1.Id) { Comment = "" },
                    new SubCategory("Масла и жидкости", category1.Id) { Comment = "" },
                    new SubCategory("Налоги", category1.Id) { Comment = "" },
                    new SubCategory("Парковка", category1.Id) { Comment = "" },
                    new SubCategory("Ремонт", category1.Id) { Comment = "" },
                    new SubCategory("Страховка", category1.Id) { Comment = "" },
                    new SubCategory("Техобслуживание", category1.Id) { Comment = "" },
                    new SubCategory("Техосмотр", category1.Id) { Comment = "" },
                    new SubCategory("Топливо", category1.Id) { Comment = "" },
                    new SubCategory("Шиномонтаж", category1.Id) { Comment = "" },
                    new SubCategory("Штрафы", category1.Id) { Comment = "" },
                    new SubCategory("Эвакуатор", category1.Id) { Comment = "" },
#endregion

#region Бизнес
                    new SubCategory("Аренда", category2.Id) { Comment = "" },
                    new SubCategory("Банкеты и приемы", category2.Id) { Comment = "" },
                    new SubCategory("Банковское обслуживание", category2.Id) { Comment = "" },
                    new SubCategory("Безопасность", category2.Id) { Comment = "" },
                    new SubCategory("Бухгалтерские услуги", category2.Id) { Comment = "" },
                    new SubCategory("Зарплата", category2.Id) { Comment = "" },
                    new SubCategory("Коммунальные платежи", category2.Id) { Comment = "" },
                    new SubCategory("Кредит", category2.Id) { Comment = "" },
                    new SubCategory("Маркетинг и реклама", category2.Id) { Comment = "" },
                    new SubCategory("Мебель", category2.Id) { Comment = "" },
                    new SubCategory("Налоги", category2.Id) { Comment = "" },
                    new SubCategory("Оборудование", category2.Id) { Comment = "" },
                    new SubCategory("Офисные принадлежности", category2.Id) { Comment = "" },
                    new SubCategory("Профессиональные сборы", category2.Id) { Comment = "" },
                    new SubCategory("Ремонт и обслуживание", category2.Id) { Comment = "" },
                    new SubCategory("Сайт и соцсети", category2.Id) { Comment = "" },
                    new SubCategory("Связь и интернет", category2.Id) { Comment = "" },
                    new SubCategory("Транспортные расходы", category2.Id) { Comment = "" },
                    new SubCategory("Услуги", category2.Id) { Comment = "" },
#endregion

#region Вредные привычки
                    new SubCategory("Алкоголь", category3.Id) { Comment = "" },
                    new SubCategory("Веселящие средства", category3.Id) { Comment = "" },
                    new SubCategory("Вино", category3.Id) { Comment = "" },
                    new SubCategory("Виски", category3.Id) { Comment = "" },
                    new SubCategory("Водка", category3.Id) { Comment = "" },
                    new SubCategory("Игромания", category3.Id) { Comment = "" },
                    new SubCategory("Коктели", category3.Id) { Comment = "" },
                    new SubCategory("Коньяк", category3.Id) { Comment = "" },
                    new SubCategory("Пиво", category3.Id) { Comment = "" },
                    new SubCategory("Ром", category3.Id) { Comment = "" },
                    new SubCategory("Сигареты", category3.Id) { Comment = "" },
                    new SubCategory("Сигары", category3.Id) { Comment = "" },
                    new SubCategory("Текила", category3.Id) { Comment = "" },
                    new SubCategory("Фастфуд", category3.Id) { Comment = "" },
#endregion

#region Гигиена и красота
                    new SubCategory("Гели и лосьоны", category4.Id) { Comment = "" },
                    new SubCategory("Косметика", category4.Id) { Comment = "" },
                    new SubCategory("Косметолог", category4.Id) { Comment = "" },
                    new SubCategory("Крема и жидкости", category4.Id) { Comment = "" },
                    new SubCategory("Маникур, педикур", category4.Id) { Comment = "" },
                    new SubCategory("Массаж", category4.Id) { Comment = "" },
                    new SubCategory("Народные средства", category4.Id) { Comment = "" },
                    new SubCategory("Парикмахерская", category4.Id) { Comment = "" },
                    new SubCategory("Пишевые добавки", category4.Id) { Comment = "" },
                    new SubCategory("Процедуры", category4.Id) { Comment = "" },
                    new SubCategory("Салон красоты", category4.Id) { Comment = "" },
                    new SubCategory("Сауна", category4.Id) { Comment = "" },
                    new SubCategory("Средства гигиены", category4.Id) { Comment = "" },
                    new SubCategory("Шампуни и гели", category4.Id) { Comment = "" },
#endregion

#region Дети
                    new SubCategory("Безопасность", category5.Id) { Comment = "" },
                    new SubCategory("Выплаты", category5.Id) { Comment = "" },
                    new SubCategory("Гигиена и уход", category5.Id) { Comment = "" },
                    new SubCategory("Детский сад", category5.Id) { Comment = "" },
                    new SubCategory("Здоровье", category5.Id) { Comment = "" },
                    new SubCategory("Игрушки", category5.Id) { Comment = "" },
                    new SubCategory("Карманные деньги", category5.Id) { Comment = "" },
                    new SubCategory("Кружки и секции", category5.Id) { Comment = "" },
                    new SubCategory("Мебель", category5.Id) { Comment = "" },
                    new SubCategory("Няня", category5.Id) { Comment = "" },
                    new SubCategory("Обучение", category5.Id) { Comment = "" },
                    new SubCategory("Одежда и обувь", category5.Id) { Comment = "" },
                    new SubCategory("Питание", category5.Id) { Comment = "" },
                    new SubCategory("Подарки", category5.Id) { Comment = "" },
                    new SubCategory("Проезд", category5.Id) { Comment = "" },
                    new SubCategory("Спорт", category5.Id) { Comment = "" },
                    new SubCategory("Учебное заведение", category5.Id) { Comment = "" },
                    new SubCategory("Школа", category5.Id) { Comment = "" },
#endregion

#region Животные
                    new SubCategory("Ветеринар", category6.Id) { Comment = "" },
                    new SubCategory("Гигиена", category6.Id) { Comment = "" },
                    new SubCategory("Инвентарь", category6.Id) { Comment = "" },
                    new SubCategory("Корм", category6.Id) { Comment = "" },
                    new SubCategory("Лекарства", category6.Id) { Comment = "" },
                    new SubCategory("Покупка", category6.Id) { Comment = "" },
                    new SubCategory("Содержание", category6.Id) { Comment = "" },
#endregion

#region Кафе и рестораны
                    new SubCategory("Бар", category7.Id) { Comment = "" },
                    new SubCategory("Буфет", category7.Id) { Comment = "" },
                    new SubCategory("Кафе", category7.Id) { Comment = "" },
                    new SubCategory("Обеды", category7.Id) { Comment = "" },
                    new SubCategory("Ресторан", category7.Id) { Comment = "" },
                    new SubCategory("Столовая", category7.Id) { Comment = "" },
                    new SubCategory("Фастфуд", category7.Id) { Comment = "" },
#endregion

#region Комиссии и налоги
                    new SubCategory("Банковское обслуживание", category8.Id) { Comment = "" },
                    new SubCategory("Брокерские услуги", category8.Id) { Comment = "" },
                    new SubCategory("Выплата алиментов", category8.Id) { Comment = "" },
                    new SubCategory("Комиссии банка", category8.Id) { Comment = "" },
                    new SubCategory("Комиссионные", category8.Id) { Comment = "" },
                    new SubCategory("Налоги", category8.Id) { Comment = "" },
                    new SubCategory("Обмен валюты", category8.Id) { Comment = "" },
                    new SubCategory("Штрафы", category8.Id) { Comment = "" },
#endregion

#region Коммунальные платежи
                    new SubCategory("Аренда", category9.Id) { Comment = "" },
                    new SubCategory("Видеонаблюдение", category9.Id) { Comment = "" },
                    new SubCategory("Газ", category9.Id) { Comment = "" },
                    new SubCategory("Домофон", category9.Id) { Comment = "" },
                    new SubCategory("Интернет", category9.Id) { Comment = "" },
                    new SubCategory("Квартплата", category9.Id) { Comment = "" },
                    new SubCategory("Мусор", category9.Id) { Comment = "" },
                    new SubCategory("Охрана", category9.Id) { Comment = "" },
                    new SubCategory("Связь", category9.Id) { Comment = "" },
                    new SubCategory("Смартфон", category9.Id) { Comment = "" },
                    new SubCategory("Содержание", category9.Id) { Comment = "" },
                    new SubCategory("Телевидение", category9.Id) { Comment = "" },
                    new SubCategory("Телефон", category9.Id) { Comment = "" },
                    new SubCategory("Уборка", category9.Id) { Comment = "" },
                    new SubCategory("Электричество", category9.Id) { Comment = "" },
#endregion

#region Кредиты и долги 
                    new SubCategory("Автокредит", category10.Id) { Comment = "" },
                    new SubCategory("Быстрый займ", category10.Id) { Comment = "" },
                    new SubCategory("Выплата долга", category10.Id) { Comment = "" },
                    new SubCategory("Ипотека", category10.Id) { Comment = "" },
                    new SubCategory("Кредит", category10.Id) { Comment = "" },
                    new SubCategory("Потребительский кредит", category10.Id) { Comment = "" },
                    new SubCategory("Товары в кредит", category10.Id) { Comment = "" },
#endregion

#region Мебель 
                    new SubCategory("Ванная", category11.Id) { Comment = "" },
                    new SubCategory("Гостиная", category11.Id) { Comment = "" },
                    new SubCategory("Детская", category11.Id) { Comment = "" },
                    new SubCategory("Диван", category11.Id) { Comment = "" },
                    new SubCategory("Зеркало", category11.Id) { Comment = "" },
                    new SubCategory("Комод", category11.Id) { Comment = "" },
                    new SubCategory("Кресло", category11.Id) { Comment = "" },
                    new SubCategory("Кровать", category11.Id) { Comment = "" },
                    new SubCategory("Кухня", category11.Id) { Comment = "" },
                    new SubCategory("Матрас", category11.Id) { Comment = "" },
                    new SubCategory("Прихожая", category11.Id) { Comment = "" },
                    new SubCategory("Стенка", category11.Id) { Comment = "" },
                    new SubCategory("Стол", category11.Id) { Comment = "" },
                    new SubCategory("Стул", category11.Id) { Comment = "" },
                    new SubCategory("Тумба", category11.Id) { Comment = "" },
                    new SubCategory("Шкаф", category11.Id) { Comment = "" },
#endregion

#region Медицина
                    new SubCategory("Анализы", category12.Id) { Comment = "" },
                    new SubCategory("Больница", category12.Id) { Comment = "" },
                    new SubCategory("Врач", category12.Id) { Comment = "" },
                    new SubCategory("Консультации", category12.Id) { Comment = "" },
                    new SubCategory("Лекарства", category12.Id) { Comment = "" },
                    new SubCategory("Обследование", category12.Id) { Comment = "" },
                    new SubCategory("Поликлиника", category12.Id) { Comment = "" },
                    new SubCategory("Приборы", category12.Id) { Comment = "" },
                    new SubCategory("Прививки", category12.Id) { Comment = "" },
                    new SubCategory("Процедуры", category12.Id) { Comment = "" },
                    new SubCategory("Психоаналитик", category12.Id) { Comment = "" },
                    new SubCategory("Справка", category12.Id) { Comment = "" },
                    new SubCategory("Стоматолог", category12.Id) { Comment = "" },
                    new SubCategory("Страховка", category12.Id) { Comment = "" },
#endregion

#region Недвижимость
                    new SubCategory("Аренда", category13.Id) { Comment = "" },
                    new SubCategory("Дача", category13.Id) { Comment = "" },
                    new SubCategory("Дом", category13.Id) { Comment = "" },
                    new SubCategory("Квартира", category13.Id) { Comment = "" },
                    new SubCategory("Недвижимость", category13.Id) { Comment = "" },
                    new SubCategory("Оформление", category13.Id) { Comment = "" },
                    new SubCategory("Риэлтор", category13.Id) { Comment = "" },
                    new SubCategory("Содержание", category13.Id) { Comment = "" },
                    new SubCategory("Страховка", category13.Id) { Comment = "" },
                    new SubCategory("Услуги", category13.Id) { Comment = "" },
                    new SubCategory("Участок", category13.Id) { Comment = "" },
#endregion

#region Образование
                    new SubCategory("Информация", category14.Id) { Comment = "" },
                    new SubCategory("Книги", category14.Id) { Comment = "" },
                    new SubCategory("Консультации", category14.Id) { Comment = "" },
                    new SubCategory("Курсы", category14.Id) { Comment = "" },
                    new SubCategory("Обучение", category14.Id) { Comment = "" },
                    new SubCategory("Тренинг", category14.Id) { Comment = "" },
                    new SubCategory("Учебное заведение", category14.Id) { Comment = "" },
#endregion

#region Огород и дача
                    new SubCategory("Благоустройство", category15.Id) { Comment = "" },
                    new SubCategory("Вода", category15.Id) { Comment = "" },
                    new SubCategory("Животные", category15.Id) { Comment = "" },
                    new SubCategory("Инвентарь", category15.Id) { Comment = "" },
                    new SubCategory("Инструмент", category15.Id) { Comment = "" },
                    new SubCategory("Корма", category15.Id) { Comment = "" },
                    new SubCategory("Мусор", category15.Id) { Comment = "" },
                    new SubCategory("Одежда", category15.Id) { Comment = "" },
                    new SubCategory("Охрана", category15.Id) { Comment = "" },
                    new SubCategory("Платежи и взносы", category15.Id) { Comment = "" },
                    new SubCategory("Поездки", category15.Id) { Comment = "" },
                    new SubCategory("Полив", category15.Id) { Comment = "" },
                    new SubCategory("Рабочие", category15.Id) { Comment = "" },
                    new SubCategory("Рассада", category15.Id) { Comment = "" },
                    new SubCategory("Растения", category15.Id) { Comment = "" },
                    new SubCategory("Семена", category15.Id) { Comment = "" },
                    new SubCategory("Строительство", category15.Id) { Comment = "" },
                    new SubCategory("Стройматериалы", category15.Id) { Comment = "" },
                    new SubCategory("Тара и емкости", category15.Id) { Comment = "" },
                    new SubCategory("Удобрения и жидкости", category15.Id) { Comment = "" },
                    new SubCategory("Электричесткво", category15.Id) { Comment = "" },
                    new SubCategory("Электроника", category15.Id) { Comment = "" },
#endregion

#region Одежда и обувь
                    new SubCategory("Аксуссуары", category16.Id) { Comment = "" },
                    new SubCategory("Блузка", category16.Id) { Comment = "" },
                    new SubCategory("Брюки", category16.Id) { Comment = "" },
                    new SubCategory("Верхняя одежда", category16.Id) { Comment = "" },
                    new SubCategory("Джинсы", category16.Id) { Comment = "" },
                    new SubCategory("Жакет", category16.Id) { Comment = "" },
                    new SubCategory("Колготки", category16.Id) { Comment = "" },
                    new SubCategory("Костюм", category16.Id) { Comment = "" },
                    new SubCategory("Кофта", category16.Id) { Comment = "" },
                    new SubCategory("Куртка", category16.Id) { Comment = "" },
                    new SubCategory("Нижнее белье", category16.Id) { Comment = "" },
                    new SubCategory("Носки", category16.Id) { Comment = "" },
                    new SubCategory("Обувь", category16.Id) { Comment = "" },
                    new SubCategory("Платье", category16.Id) { Comment = "" },
                    new SubCategory("Ремонт", category16.Id) { Comment = "" },
                    new SubCategory("Рубашка", category16.Id) { Comment = "" },
                    new SubCategory("Сарафан", category16.Id) { Comment = "" },
                    new SubCategory("Свитер", category16.Id) { Comment = "" },
                    new SubCategory("Футболка", category16.Id) { Comment = "" },
                    new SubCategory("Шапка", category16.Id) { Comment = "" },
                    new SubCategory("Шуба", category16.Id) { Comment = "" },
#endregion

#region Подарки
                    new SubCategory("Близкий человек", category17.Id) { Comment = "" },
                    new SubCategory("Дети", category17.Id) { Comment = "" },
                    new SubCategory("Дни рождения", category17.Id) { Comment = "" },
                    new SubCategory("Клиенты", category17.Id) { Comment = "" },
                    new SubCategory("Коллеги", category17.Id) { Comment = "" },
                    new SubCategory("Родители", category17.Id) { Comment = "" },
                    new SubCategory("Родственники", category17.Id) { Comment = "" },
                    new SubCategory("Себе", category17.Id) { Comment = "" },
#endregion

#region Продукты питания
                    new SubCategory("Бакалея", category18.Id) { Comment = "" },
                    new SubCategory("Вода", category18.Id) { Comment = "" },
                    new SubCategory("Грибы", category18.Id) { Comment = "" },
                    new SubCategory("Доставка", category18.Id) { Comment = "" },
                    new SubCategory("Колбасные изделия", category18.Id) { Comment = "" },
                    new SubCategory("Консервы", category18.Id) { Comment = "" },
                    new SubCategory("Конфеты", category18.Id) { Comment = "" },
                    new SubCategory("Кофе", category18.Id) { Comment = "" },
                    new SubCategory("Крупы", category18.Id) { Comment = "" },
                    new SubCategory("Майонез и соусы", category18.Id) { Comment = "" },
                    new SubCategory("Макароны", category18.Id) { Comment = "" },
                    new SubCategory("Масло", category18.Id) { Comment = "" },
                    new SubCategory("Мед", category18.Id) { Comment = "" },
                    new SubCategory("Молочная продукция", category18.Id) { Comment = "" },
                    new SubCategory("Морепродукты", category18.Id) { Comment = "" },
                    new SubCategory("Мука", category18.Id) { Comment = "" },
                    new SubCategory("Мясо", category18.Id) { Comment = "" },
                    new SubCategory("Напитки", category18.Id) { Comment = "" },
                    new SubCategory("Офощи", category18.Id) { Comment = "" },
                    new SubCategory("Орехи", category18.Id) { Comment = "" },
                    new SubCategory("Пельмени", category18.Id) { Comment = "" },
                    new SubCategory("Печение", category18.Id) { Comment = "" },
                    new SubCategory("Пицца", category18.Id) { Comment = "" },
                    new SubCategory("Полуфабрикаты", category18.Id) { Comment = "" },
                    new SubCategory("Приправы", category18.Id) { Comment = "" },
                    new SubCategory("Ролы, суши", category18.Id) { Comment = "" },
                    new SubCategory("Салаты", category18.Id) { Comment = "" },
                    new SubCategory("Сахар", category18.Id) { Comment = "" },
                    new SubCategory("Сладости", category18.Id) { Comment = "" },
                    new SubCategory("Сыр", category18.Id) { Comment = "" },
                    new SubCategory("Фарш", category18.Id) { Comment = "" },
                    new SubCategory("Фастфуд", category18.Id) { Comment = "" },
                    new SubCategory("Хлебобулочные изделия", category18.Id) { Comment = "" },
                    new SubCategory("Хлебцы", category18.Id) { Comment = "" },
                    new SubCategory("Чай, кофе", category18.Id) { Comment = "" },
                    new SubCategory("Яйцо", category18.Id) { Comment = "" },
#endregion

#region Путешествия и отпуск
                    new SubCategory("Билеты", category19.Id) { Comment = "" },
                    new SubCategory("Виза", category19.Id) { Comment = "" },
                    new SubCategory("Мероприятия", category19.Id) { Comment = "" },
                    new SubCategory("Отпуск", category19.Id) { Comment = "" },
                    new SubCategory("Питание", category19.Id) { Comment = "" },
                    new SubCategory("Покупки", category19.Id) { Comment = "" },
                    new SubCategory("Проезд", category19.Id) { Comment = "" },
                    new SubCategory("Проживание", category19.Id) { Comment = "" },
                    new SubCategory("Развлечение", category19.Id) { Comment = "" },
                    new SubCategory("Снаряжение", category19.Id) { Comment = "" },
                    new SubCategory("Спиртные напитки", category19.Id) { Comment = "" },
                    new SubCategory("Страховка", category19.Id) { Comment = "" },
                    new SubCategory("Сувениры и вещи", category19.Id) { Comment = "" },
                    new SubCategory("Тур", category19.Id) { Comment = "" },
                    new SubCategory("Экскурсия", category19.Id) { Comment = "" },
#endregion

#region Развлечения
                    new SubCategory("Азартные игры", category20.Id) { Comment = "" },
                    new SubCategory("Дискотека", category20.Id) { Comment = "" },
                    new SubCategory("Дни рождения", category20.Id) { Comment = "" },
                    new SubCategory("Друзья", category20.Id) { Comment = "" },
                    new SubCategory("Игры", category20.Id) { Comment = "" },
                    new SubCategory("Кино", category20.Id) { Comment = "" },
                    new SubCategory("Клуб", category20.Id) { Comment = "" },
                    new SubCategory("Концерты", category20.Id) { Comment = "" },
                    new SubCategory("Корпоратив", category20.Id) { Comment = "" },
                    new SubCategory("Мероприятия", category20.Id) { Comment = "" },
                    new SubCategory("Родственники", category20.Id) { Comment = "" },
                    new SubCategory("Театр", category20.Id) { Comment = "" },
                    new SubCategory("Тусовки", category20.Id) { Comment = "" },
                    new SubCategory("Экскурсия", category20.Id) { Comment = "" },
#endregion

#region Спорт
                    new SubCategory("Абонемент", category21.Id) { Comment = "" },
                    new SubCategory("Занятия", category21.Id) { Comment = "" },
                    new SubCategory("Инвентарь", category21.Id) { Comment = "" },
                    new SubCategory("Обувь", category21.Id) { Comment = "" },
                    new SubCategory("Одежда", category21.Id) { Comment = "" },
                    new SubCategory("Питание", category21.Id) { Comment = "" },
                    new SubCategory("Секция", category21.Id) { Comment = "" },
                    new SubCategory("Спортзал", category21.Id) { Comment = "" },
                    new SubCategory("Тренер", category21.Id) { Comment = "" },
                    new SubCategory("Фитнес", category21.Id) { Comment = "" },
                    new SubCategory("Экипировка", category21.Id) { Comment = "" },
#endregion

#region Строительство и ремонт
                    new SubCategory("Бетонные работы", category22.Id) { Comment = "" },
                    new SubCategory("Документация", category22.Id) { Comment = "" },
                    new SubCategory("Доставка", category22.Id) { Comment = "" },
                    new SubCategory("Инженерные работы", category22.Id) { Comment = "" },
                    new SubCategory("Инструменты", category22.Id) { Comment = "" },
                    new SubCategory("Краска, лак", category22.Id) { Comment = "" },
                    new SubCategory("Кровля", category22.Id) { Comment = "" },
                    new SubCategory("Мебель на заказ", category22.Id) { Comment = "" },
                    new SubCategory("Оборудование", category22.Id) { Comment = "" },
                    new SubCategory("Окна, двери", category22.Id) { Comment = "" },
                    new SubCategory("Отделка", category22.Id) { Comment = "" },
                    new SubCategory("Отделочные материалы", category22.Id) { Comment = "" },
                    new SubCategory("Рабочие", category22.Id) { Comment = "" },
                    new SubCategory("Расходные материалы", category22.Id) { Comment = "" },
                    new SubCategory("Ремонтные работы", category22.Id) { Comment = "" },
                    new SubCategory("Сантехника", category22.Id) { Comment = "" },
                    new SubCategory("Стены", category22.Id) { Comment = "" },
                    new SubCategory("Стройка", category22.Id) { Comment = "" },
                    new SubCategory("Стройматериалы", category22.Id) { Comment = "" },
                    new SubCategory("Услуги", category22.Id) { Comment = "" },
                    new SubCategory("Утеплитель", category22.Id) { Comment = "" },
                    new SubCategory("Электрика", category22.Id) { Comment = "" },
#endregion

#region Техника и электроника
                    new SubCategory("Бытовая техника", category23.Id) { Comment = "" },
                    new SubCategory("Гаджеты", category23.Id) { Comment = "" },
                    new SubCategory("Инструменты", category23.Id) { Comment = "" },
                    new SubCategory("Климат", category23.Id) { Comment = "" },
                    new SubCategory("Компьютерная техника", category23.Id) { Comment = "" },
                    new SubCategory("Кухонная техника", category23.Id) { Comment = "" },
                    new SubCategory("Ремонт", category23.Id) { Comment = "" },
                    new SubCategory("Смартфон, аксуссуары", category23.Id) { Comment = "" },
                    new SubCategory("ТВ", category23.Id) { Comment = "" },
                    new SubCategory("Техника", category23.Id) { Comment = "" },
                    new SubCategory("Фото, видео", category23.Id) { Comment = "" },
                    new SubCategory("Электроника", category23.Id) { Comment = "" },
#endregion

#region Транспорт
                    new SubCategory("Аренда", category24.Id) { Comment = "" },
                    new SubCategory("Маршрутка", category24.Id) { Comment = "" },
                    new SubCategory("Метро", category24.Id) { Comment = "" },
                    new SubCategory("Поезд", category24.Id) { Comment = "" },
                    new SubCategory("Проезд", category24.Id) { Comment = "" },
                    new SubCategory("Проездной", category24.Id) { Comment = "" },
                    new SubCategory("Такси", category24.Id) { Comment = "" },
                    new SubCategory("Трамвай", category24.Id) { Comment = "" },
                    new SubCategory("Тролейбус", category24.Id) { Comment = "" },
                    new SubCategory("Электричка", category24.Id) { Comment = "" },
#endregion

#region Услуги
                    new SubCategory("Грузоперевозки", category25.Id) { Comment = "" },
                    new SubCategory("Доставка", category25.Id) { Comment = "" },
                    new SubCategory("Досуг", category25.Id) { Comment = "" },
                    new SubCategory("Консультации", category25.Id) { Comment = "" },
                    new SubCategory("Маркетинг и реклама", category25.Id) { Comment = "" },
                    new SubCategory("Медсестра", category25.Id) { Comment = "" },
                    new SubCategory("Натариус", category25.Id) { Comment = "" },
                    new SubCategory("Охрана", category25.Id) { Comment = "" },
                    new SubCategory("Печать, ксерокопия", category25.Id) { Comment = "" },
                    new SubCategory("Полиграфия", category25.Id) { Comment = "" },
                    new SubCategory("Посредники", category25.Id) { Comment = "" },
                    new SubCategory("Ремонт", category25.Id) { Comment = "" },
                    new SubCategory("Сантехник", category25.Id) { Comment = "" },
                    new SubCategory("Сиделка", category25.Id) { Comment = "" },
                    new SubCategory("Уборка", category25.Id) { Comment = "" },
#endregion

#region Хозтовары
                    new SubCategory("Бытовая химия", category26.Id) { Comment = "" },
                    new SubCategory("Для кухни", category26.Id) { Comment = "" },
                    new SubCategory("Для пикника", category26.Id) { Comment = "" },
                    new SubCategory("Инвентарь", category26.Id) { Comment = "" },
                    new SubCategory("Инструмент", category26.Id) { Comment = "" },
                    new SubCategory("Моющие средства", category26.Id) { Comment = "" },
                    new SubCategory("Мыло", category26.Id) { Comment = "" },
                    new SubCategory("Посуда", category26.Id) { Comment = "" },
                    new SubCategory("Салфетки, полотенца", category26.Id) { Comment = "" },
                    new SubCategory("Сантехника", category26.Id) { Comment = "" },
                    new SubCategory("Спецодежда", category26.Id) { Comment = "" },
                    new SubCategory("Средства защиты", category26.Id) { Comment = "" },
                    new SubCategory("Стиральный порошок", category26.Id) { Comment = "" },
                    new SubCategory("Столовые приборы", category26.Id) { Comment = "" },
                    new SubCategory("Чистящие средства", category26.Id) { Comment = "" }
#endregion
                };

                db.SubCategories.AddRange(subCategories);
                db.SaveChanges();
            }
        }

        public static void SeedAdditionals(AppDbContext db)
        {
            if (!db.Additionals.Any())
            {
                db.Additionals.Add(new Additional
                {
                    Name = "Пусто",
                    Comment = ""
                });
                db.SaveChanges();
            }
        }

        public static void SeedCurrency(AppDbContext db)
        {
            if (!db.Currencies.Any())
            {
                db.Currencies.Add(new Currency
                {
                    Name = "Рубли",
                    Symbol = "₽",
                    Rate = 1,
                    Comment = ""
                });
                db.SaveChanges();
            }
        }
    }
}
