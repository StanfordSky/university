
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 5										
BEGIN		
/*������ �����*/
INSERT INTO organization(name, headteacher)				
VALUES ('�����������'+CONVERT(varchar, @i,0), @i)
SET @i = @i + 1								
END													
