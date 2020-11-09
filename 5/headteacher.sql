
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 5										
BEGIN		
/*начало цикла*/
INSERT INTO headteacher(fio, phone)				
VALUES ('Руководитель'+CONVERT(varchar, @i,0), CONVERT(varchar, (@i*11111),0)+'-'+CONVERT(varchar, (@i*11),0))
SET @i = @i + 1								
END													
