  DECLARE @SearchString nvarchar(max)='AAAAAAAA'
  DECLARE @TableName varchar(max)='TABLEEEEEEEE'
  DECLARE @sqlCommand varchar(max) = 'SELECT * FROM [dbo].['+@TableName+'] WHERE ' 
	   
   SELECT @sqlCommand = @sqlCommand + '[' + COLUMN_NAME + '] LIKE ''' + '%'+@SearchString+'%' + ''' OR '
   FROM INFORMATION_SCHEMA.COLUMNS 
   WHERE TABLE_SCHEMA = 'dbo'
   AND TABLE_NAME = @TableName
   AND DATA_TYPE IN ('char','nchar','ntext','nvarchar','text','varchar')

   SET @sqlCommand = left(@sqlCommand,len(@sqlCommand)-3)
   EXEC (@sqlCommand)