CREATE PROCEDURE [dbo].[StoreMeal]
(@MealId as int = 0001,
@MName as nvarchar(50) = 'null',
@DrinkAlternate as nvarchar(50) = 'null',
@Category as nvarchar(50) = 'null',
@Area as nvarchar(50) = 'null',
@Instructions as nvarchar(MAX) = 'null',
@ThumbNail as nvarchar(50) = 'null',
@Youtube as nvarchar(50) = 'null',
@Ingred1 as nvarchar(50) = 'null',
@Ingred2 as nvarchar(50) = 'null',
@Ingred3 as nvarchar(50) = 'null',
@Ingred4 as nvarchar(50) = 'null',
@Ingred5 as nvarchar(50) = 'null',
@Ingred6 as nvarchar(50) = 'null',
@Ingred7 as nvarchar(50) = 'null',
@Ingred8 as nvarchar(50) = 'null',
@Ingred9 as nvarchar(50) = 'null',
@Ingred10 as nvarchar(50) = 'null',
@Ingred11 as nvarchar(50) = 'null',
@Ingred12 as nvarchar(50) = 'null',
@Ingred13 as nvarchar(50) = 'null',
@Ingred14 as nvarchar(50) = 'null',
@Ingred15 as nvarchar(50) = 'null',
@Ingred16 as nvarchar(50) = 'null',
@Ingred17 as nvarchar(50) = 'null',
@Ingred18 as nvarchar(50) = 'null',
@Ingred19 as nvarchar(50) = 'null',
@Ingred20 as nvarchar(50) = 'null',
@Measure1 as nvarchar(50) = 'null',
@Measure2 as nvarchar(50) = 'null',
@Measure3 as nvarchar(50) = 'null',
@Measure4 as nvarchar(50) = 'null',
@Measure5 as nvarchar(50) = 'null',
@Measure6 as nvarchar(50) = 'null',
@Measure7 as nvarchar(50) = 'null',
@Measure8 as nvarchar(50) = 'null',
@Measure9 as nvarchar(50) = 'null',
@Measure10 as nvarchar(50) = 'null',
@Measure11 as nvarchar(50) = 'null',
@Measure12 as nvarchar(50) = 'null',
@Measure13 as nvarchar(50) = 'null',
@Measure14 as nvarchar(50) = 'null',
@Measure15 as nvarchar(50) = 'null',
@Measure16 as nvarchar(50) = 'null',
@Measure17 as nvarchar(50) = 'null',
@Measure18 as nvarchar(50) = 'null',
@Measure19 as nvarchar(50) = 'null',
@Measure20 as nvarchar(50) = 'null',
@MSource as nvarchar(50) = 'null',
@ImageSource as nvarchar(50) = 'null',
@CreativeCommonsConfirmed as nvarchar(50) = 'null',
@dateModified as datetime = null)
AS

IF Exists (SELECT MealId FROM MealTable WHERE MealId = @MealId)
	BEGIN
	Print 'Already Exists'
END;
	ELSE
	BEGIN
		INSERT INTO MealTable(MealId, MName, DrinkAlternate, Category, Area, Instructions, ThumbNail, Youtube, Ingred1, Ingred2, Ingred3, Ingred4, Ingred5, Ingred6, Ingred7, Ingred8, Ingred9, Ingred10, Ingred11, Ingred12 ,Ingred13, Ingred14, Ingred15, Ingred16, Ingred17, Ingred18, Ingred19, Ingred20, Measure1, Measure2, Measure3, Measure4, Measure5, Measure6, Measure7, Measure8, Measure9, Measure10, Measure11, Measure12, Measure13, Measure14, Measure15, Measure16, Measure17, Measure18, Measure19, Measure20, MSource, ImageSource, CreativeCommonsConfirmed, dateModified)
		Values (@MealId, @MName, @DrinkAlternate, @Category, @Area, @Instructions, @ThumbNail, @Youtube, @Ingred1, @Ingred2, @Ingred3, @Ingred4, @Ingred5, @Ingred6, @Ingred7, @Ingred8, @Ingred9, @Ingred10, @Ingred11, @Ingred12, @Ingred13, @Ingred14, @Ingred15, @Ingred16, @Ingred17, @Ingred18, @Ingred19, @Ingred20, @Measure1, @Measure2, @Measure3, @Measure4, @Measure5, @Measure6, @Measure7, @Measure8, @Measure9, @Measure10, @Measure11, @Measure12, @Measure13, @Measure14, @Measure15, @Measure16, @Measure17, @Measure18, @Measure19, @Measure20, @MSource, @ImageSource, @CreativeCommonsConfirmed, @dateModified); 
END;

