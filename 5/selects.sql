/* SELECT * FROM course, headteacher, organization, student, teacher */			/* ������� ��� ������ �� ������ �������. */
/* SELECT TOP 5 * FROM student  */												/* ������� ������ 5 ������� �� ������� ��������. */
/* SELECT name, fio 
	FROM trainprog 
		INNER JOIN course ON course.id = trainprog.course 
		INNER JOIN student ON student.id = trainprog.student */ 				/* ������� ������ �������� � ��������� ��� �����, ������������ �������������� ��������. */
/* SELECT student FROM trainprog WHERE course = 7 */							/* ������� ���� ����������, ��������� ���� � �������� 1. */
/* SELECT * FROM course WHERE name LIKE '%���������%' */						/* ������� ������ ���� ������, � �������� ������� ���� ����� ����� ���������� */
/* SELECT COUNT (student) FROM trainprog WHERE course = 7 AND completed = 1 */					/* ����������, ������� �������� ��� ��������� ������ �� ������. */
/* SELECT COUNT (student) FROM trainprog WHERE course = 8 AND completed = 1 */
/* SELECT COUNT (student) FROM trainprog WHERE course = 9 AND completed = 1 */
/* SELECT MAX (course) FROM trainprog */										/* ����� �� ������ ����� ����������? */
/* SELECT teacher FROM course */											    /* ������� ������� ���� ��������������, ������� �����. */
/* SELECT COUNT (student) FROM trainprog WHERE course = 9 AND completed = 0 */  /* ���������� ���������� �������� � ����� � �������� 3. */
