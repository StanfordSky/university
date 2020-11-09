
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 5										
BEGIN		
/*начало цикла*/
INSERT INTO teacher(fio, phone)				
VALUES ('Фамилия'+CONVERT(varchar, @i,0), CONVERT(varchar, (@i*11111),0))
SET @i = @i + 1								
END													
