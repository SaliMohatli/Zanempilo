USE ZanempiloDB;
GO

-- 1. Total donated quantity by donor
SELECT 
  d.Donor_ID,
  d.First_Name + ' ' + d.Last_Name AS DonorName,
  SUM(do.Quantity) AS TotalDonated
FROM Donor d
JOIN Donation do ON d.Donor_ID = do.Donor_ID
GROUP BY d.Donor_ID, d.First_Name, d.Last_Name;
GO

-- 2. Current stock levels
SELECT 
  s.Stock_ID,
  s.Description,
  s.Quantity_In_Stock
FROM Stock s
ORDER BY s.Quantity_In_Stock DESC;
GO

-- 3. Orders with their items
SELECT 
  o.Order_ID,
  c.First_Name + ' ' + c.Last_Name AS ClientName,
  o.Order_Date,
  od.Stock_ID,
  od.Quantity
FROM Client_Order o
JOIN Client c ON o.Client_ID = c.Client_ID
JOIN Order_Detail od ON o.Order_ID = od.Order_ID
ORDER BY o.Order_Date;
GO
