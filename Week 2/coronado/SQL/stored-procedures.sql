-- stored procedure
CREATE PROCEDURE SalesLT.Procedure1
AS
BEGIN
	BEGIN TRANSACTION
	-- would commit at end of proc if i didn't tell it to
	-- would rollback in case of error if i didn't tell it to
	BEGIN TRY
		SELECT 1 -- four dummy statements
		--UPDATE
		--INSERT
		--INSERT
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		-- do some logic based on the error
		PRINT @@ERROR
		PRINT ERROR_MESSAGE()
		PRINT ERROR_STATE()
		PRINT ERROR_NUMBER()
		PRINT ERROR_SEVERITY()
		PRINT @@ROWCOUNT
		ROLLBACK TRANSACTION
	END CATCH	
END
-- demos, all at once:
--	stored procedure
--		like a method, can modify the database, do anything
--		can take parameters
--	try/catch
--		works like C#
--		(we do also have THROW)
--	transaction (explicit, multi-statement)
--		with explicit COMMIT and ROLLBACK

-- how to call procedures:
EXECUTE SalesLT.Procedure1