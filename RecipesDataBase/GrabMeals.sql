CREATE PROCEDURE [dbo].[GrabMeals]
	@Cat text = 'Chicken'
	AS
	SELECT * FROM MealTable WHERE Category LIKE @Cat;