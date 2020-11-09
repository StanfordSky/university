
DECLARE @i int									
SET @i = 1 									
WHILE @i <= 100										
BEGIN		
/*начало цикла*/
INSERT INTO student(fio,organization )				
VALUES ('Учащийся'+CONVERT(varchar, @i,0), @i%6)
SET @i = @i + 1								
END													
