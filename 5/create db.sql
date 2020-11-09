create table teacher
(
	id integer not null primary key,
	fio varchar(100),
	phone varchar(20)
);


create table headteacher
(
	id integer not null primary key,
	fio varchar(100),
	phone varchar(20)
);

create table organization
(
	id int not null primary key,
	name varchar(128),
	headteacher int
);

create table course 
(
	id int not null primary key,
	name varchar(128),
	teacher int 
);

create table student 
(
	id int not null primary key,
	fio varchar(100),
	organization int
);

create table trainprog 
(
	id int not null primary key,
	course int,
	student int, 
	completed bit
);




ALTER TABLE organization
	ADD CONSTRAINT FK_organization_headteacher FOREIGN KEY (headteacher)
		REFERENCES headteacher (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE 


ALTER TABLE course
	ADD CONSTRAINT FK_course_teacher FOREIGN KEY (teacher)
		REFERENCES teacher (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE 


ALTER TABLE student
	ADD CONSTRAINT FK_student_organiation FOREIGN KEY (organization)
		REFERENCES organization (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE


ALTER TABLE trainprog
	ADD CONSTRAINT FK_trainprog_course FOREIGN KEY (course)
		REFERENCES course (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE


ALTER TABLE trainprog
	ADD CONSTRAINT FK_trainprog_student FOREIGN KEY (student)
		REFERENCES student (id)
		ON DELETE CASCADE
		ON UPDATE CASCADE
