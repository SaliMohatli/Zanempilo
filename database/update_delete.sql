USE ZanempiloDB;
GO

-- Example UPDATE: Restock 50 units on Stock_ID = 3
UPDATE Stock
SET Quantity_In_Stock = Quantity_In_Stock + 50
WHERE Stock_ID = 3;
GO

-- Example DELETE: Remove orders older than 2025-08-27
DELETE FROM Client_Order
WHERE Order_Date < '2025-08-27';
GO
