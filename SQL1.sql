--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive Büyük küçük harf duyarsızlığı 
SeLecT * FRom Products where CategoryID = 1 or CategoryID = 3

SeLecT * FRom Products where CategoryID = 1 and UnitPrice >= 10

Select * from Products order by UnitPrice  asc -- ascending (Artan)
Select * from Products order by UnitPrice desc -- descending (Azalan)
Select * from Products order by ProductName	

Select * from Products where UnitPrice >= 25 order by UnitPrice asc


Select count(*) from Products  -- Product kolonunda kaç ürün olduğunu gösterir 
Select count(*) Adet from Products where CategoryID = 5

Select * from Products group by CategoryID -- Yanlış kullanım,
Select CategoryID from Products group by CategoryID  -- Doğru kullanım 

Select CategoryID, count(*) from Products group by CategoryID --Her katagoride kaç elaman olduğunu buluruz

--ürün sayısı 10'dan az olan katagorileri listele ve ürün sayılarını ver
Select CategoryID, count(*) from Products group by CategoryID having count(*) < 10

--ürün fiyatı 20lira'dan fazla olan ürünlerinin sayısı 10'dan az olan katagorileri listele ve ürün sayılarını ver
Select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

-- JOİN
select *  
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID 

select Products.ProductID ÜrünNumarası, Products.ProductName Ürünİsmi, Products.UnitPrice Fiyat, Products.UnitsInStock StokAdeti, Categories.CategoryName Kategorisi
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID    -- DTO - Data Transformation Object

-- Detaylandırma yapılabilir
select Products.ProductID [Ürün Numarası], Products.ProductName [Ürün İsmi], Products.UnitPrice Fiyat, Products.UnitsInStock StokAdeti, Categories.CategoryName Kategorisi
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o 
on o.OrderID = od.OrderID




