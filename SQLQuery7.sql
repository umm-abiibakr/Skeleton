USE [p2694202]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_SelectAll]
		@CustomerId = 1

SELECT	@return_value as 'Return Value'

GO
