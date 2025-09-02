USE ZanempiloDB;
GO

/*
  ===========================================
  sp_ManageDonationType
  INSERT, UPDATE, DELETE on Donation_Type
  ===========================================
*/
IF OBJECT_ID('sp_ManageDonationType','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonationType;
GO

CREATE PROCEDURE sp_ManageDonationType
  @Action             NVARCHAR(10),          -- 'INSERT', 'UPDATE', 'DELETE'
  @DonationType_ID    INT            = NULL, -- Required for UPDATE / DELETE
  @Description        NVARCHAR(50) = NULL   -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Donation_Type (Description)
      VALUES (@Description);
    SELECT SCOPE_IDENTITY() AS NewDonationTypeID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donation_Type
      SET Description = @Description
    WHERE DonationType_ID = @DonationType_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donation_Type
    WHERE DonationType_ID = @DonationType_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO


/*
  ===========================================
  sp_ManageDonor
  INSERT, UPDATE, DELETE on Donor
  ===========================================
*/
IF OBJECT_ID('sp_ManageDonor','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonor;
GO

CREATE PROCEDURE sp_ManageDonor
  @Action      NVARCHAR(10),          -- 'INSERT', 'UPDATE', 'DELETE'
  @Donor_ID    INT            = NULL, -- Required for UPDATE / DELETE
  @First_Name  NVARCHAR(20) = NULL,  -- Required for INSERT / UPDATE
  @Last_Name   NVARCHAR(20) = NULL,  -- Required for INSERT / UPDATE
  @Email       NVARCHAR(40) = NULL   -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Donor (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewDonorID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donor
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donor
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO


/*
  ===========================================
  sp_ManageStock
  INSERT, UPDATE, DELETE on Stock
  ===========================================
*/
IF OBJECT_ID('sp_ManageStock','P') IS NOT NULL
  DROP PROCEDURE sp_ManageStock;
GO

CREATE PROCEDURE sp_ManageStock
  @Action            NVARCHAR(10),          -- 'INSERT', 'UPDATE', 'DELETE'
  @Stock_ID          INT            = NULL, -- Required for UPDATE / DELETE
  @Donation_ID       INT            = NULL, -- Required for INSERT / UPDATE
  @Description       NVARCHAR(50) = NULL,  -- Optional for INSERT / UPDATE
  @Quantity_In_Stock INT            = NULL  -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Stock (Donation_ID, Description, Quantity_In_Stock)
      VALUES (@Donation_ID, @Description, @Quantity_In_Stock);
    SELECT SCOPE_IDENTITY() AS NewStockID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Stock
      SET Donation_ID       = @Donation_ID,
          Description       = @Description,
          Quantity_In_Stock = @Quantity_In_Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO


/*
  ===========================================
  sp_ManageClient
  INSERT, UPDATE, DELETE on Client
  ===========================================
*/
IF OBJECT_ID('sp_ManageClient','P') IS NOT NULL
  DROP PROCEDURE sp_ManageClient;
GO

CREATE PROCEDURE sp_ManageClient
  @Action     NVARCHAR(10),           -- 'INSERT', 'UPDATE', 'DELETE'
  @Client_ID  INT            = NULL,  -- Required for UPDATE / DELETE
  @First_Name NVARCHAR(20) = NULL,   -- Required for INSERT / UPDATE
  @Last_Name  NVARCHAR(20) = NULL,   -- Required for INSERT / UPDATE
  @Email      NVARCHAR(40) = NULL    -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Client (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewClientID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Client
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Client
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO

  DECLARE @OrderID INT;
  INSERT INTO Client_Order (Client_ID, Order_Date)
    VALUES (@ClientID, @OrderDate);
  SET @OrderID = SCOPE_IDENTITY();

  INSERT INTO Order_Detail (Order_ID, Stock_ID, Quantity)
    VALUES (@OrderID, @StockID, @Qty);
END;
GO

