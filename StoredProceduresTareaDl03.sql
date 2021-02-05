CREATE PROCEDURE sp1_getProductModel
@idProductModel int
AS
BEGIN
SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice
FROM Production.ProductModel
JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
WHERE Product.ProductModelID = @idProductModel
ORDER BY Product.ListPrice;
END
GO


CREATE PROCEDURE sp2_getProduct
@idProductModel int
AS
BEGIN
SELECT ProductId, Size FROM Production.Product
WHERE Product.ProductModelID = @idProductModel
ORDER BY Size;
END
GO


CREATE PROCEDURE sp3_getProductModelIds
AS
BEGIN
SELECT Product.ProductModelID AS ProductId, Product.Size
FROM Production.Product 
WHERE Product.ProductModelID IS NOT NULL;
END
GO