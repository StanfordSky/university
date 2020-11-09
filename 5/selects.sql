/* SELECT * FROM course, headteacher, organization, student, teacher */			/* Вывести все данные из каждой таблицы. */
/* SELECT TOP 5 * FROM student  */												/* Вывести первые 5 записей из таблицы Учащийся. */
/* SELECT name, fio 
	FROM trainprog 
		INNER JOIN course ON course.id = trainprog.course 
		INNER JOIN student ON student.id = trainprog.student */ 				/* Вывести список учащихся и выбранные ими курсы, использовать переименование столбцов. */
/* SELECT student FROM trainprog WHERE course = 7 */							/* Вывести всех участников, изучающих курс с индексом 1. */
/* SELECT * FROM course WHERE name LIKE '%компьютер%' */						/* Вывести список всех курсов, в названии которых есть часть слова «компьютер» */
/* SELECT COUNT (student) FROM trainprog WHERE course = 7 AND completed = 1 */					/* Подсчитать, сколько учащихся уже завершило каждый из курсов. */
/* SELECT COUNT (student) FROM trainprog WHERE course = 8 AND completed = 1 */
/* SELECT COUNT (student) FROM trainprog WHERE course = 9 AND completed = 1 */
/* SELECT MAX (course) FROM trainprog */										/* Какой из курсов самый популярный? */
/* SELECT teacher FROM course */											    /* Вывести индексы всех преподавателей, ведущих курсы. */
/* SELECT COUNT (student) FROM trainprog WHERE course = 9 AND completed = 0 */  /* Подсчитать количество учащихся в курсе с индексом 3. */
