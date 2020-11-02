
SELECT product_name, Stock.stock_product 
FROM Product 
JOIN Stock ON Product.product_id = Stock.FK_product_id
WHERE FK_category_id = 1;
