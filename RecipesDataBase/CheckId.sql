CREATE PROCEDURE [dbo].[CheckId]
	@MealIdCheck int = 0,
AS
BEGIN
IF EXISTS (select * from MealTable where MealId = @MealIdCheck)
RETURN 0
ELSE
RETURN 1
END