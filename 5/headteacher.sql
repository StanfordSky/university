
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 5										
BEGIN		
/*������ �����*/
INSERT INTO headteacher(fio, phone)				
VALUES ('������������'+CONVERT(varchar, @i,0), CONVERT(varchar, (@i*11111),0)+'-'+CONVERT(varchar, (@i*11),0))
SET @i = @i + 1								
END													
