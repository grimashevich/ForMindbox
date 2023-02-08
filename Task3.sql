SELECT Products.name AS ProductName, Category.name AS CategoryName
FROM Products
    LEFT JOIN ProductsCategory ON Products.id = ProductsCategory.Productsid
    LEFT JOIN Category on ProductsCategory.Categoryid = Category.id
