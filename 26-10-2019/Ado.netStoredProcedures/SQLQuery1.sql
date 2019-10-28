USE [LOKESH]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[Insert_Records]
		@Name = N'',
		@Price = N'',
		@Date = N''

SELECT	@return_value as 'Return Value'

GO
