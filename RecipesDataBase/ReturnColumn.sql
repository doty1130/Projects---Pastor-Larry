﻿CREATE PROCEDURE [dbo].[ReturnColumn]
	@Column VARCHAR(MAX),
	@Table VARCHAR(MAX)
AS
BEGIN
DECLARE @SQL VARCHAR(MAX) 
SET @SQL = 'SELECT ' + @Column + ' FROM ' + @Table 
EXEC (@SQL)
END

