
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 100										
BEGIN		
/*������ �����*/
INSERT INTO student(fio,organization )				
VALUES ('��������'+CONVERT(varchar, @i,0), @i%6)
SET @i = @i + 1								
END													
