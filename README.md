# Тестовое задание от Mindbox
для позиции стажера - разработчика C#

### C# библиотека классов, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам
#### Основные возможности и особенности:
* Фигуры унаследованы от общего класса Figure, в котором реализованы общие для фигур возможности:
    * Перегружен метод ToString();
    * Перегрежены операторы равенства и сравнения. Сравнение возможно в том числе и для разных типов фигур;
* Подсчет площади фигур:
    * По радиусу для круга;
    * По трем сторонам для треугольника;
* В случае попытки создания фигуры с некорректными параметрами возбуждается исключение ArgumentException;
* Определение является ли треугольник прямоугольным двумя способами (один закомментирован);
* Возможность вычисления площади фигуры без знания типа фигуры в compile time (пример приведен в проекте UsageExample);
* Для добавления новой фигуры нужно унаследоваться от абстрактного класса Figure и реализовать абстрактный метод GetArea(), а так же конструктор и логику проверки на корректность данных, подаваемых в конструктор;
* Реаоизованы юнит тесты как для родительского класса, так и для дочерних (всего 45 тестов).

### Написать SQL запрос, который выводит продукты и соотвестствующие им категории, включая продукты без категорий
Файл с SQL запросом находится в корне репозитория: [Task3.sql](https://github.com/grimashevich/ForMindbox/blob/main/Task3.sql)
