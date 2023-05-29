
create database school;
use school;

create table parent(
parent_id int auto_increment primary key,
first_name varchar(50),
last_name varchar(50),
phone_number varchar(45),
email_address varchar(45)
);

create table student(
student_id int auto_increment primary key,
first_name varchar(50),
last_name varchar(50),
parent_id int,
foreign key(parent_id) references parent(parent_id)
);

create table subject(
subject_id int primary key,
subject varchar(50)
);

create table student_has_subject(
student_id int,
subject_id int,
foreign key (subject_id) references subject(subject_id),
foreign key(student_id) references student(student_id)
);

create table teacher(
teacher_id int primary key,
first_name varchar(50),
last_name varchar(50),
phone_number varchar(45),
email_address varchar(45)
);

create table teacher_has_subject(
teacher_id int,
subject_id int,
foreign key (teachert_id) references teacher(teacher_id),
foreign key(subject_id) references subject(subject_id)
);

create table lesson(
lesson_id int primary key,
lesson_date date,
teacher_id int,
subject_id int,
foreign key (teachert_id) references teacher(teacher_id),
foreign key(subject_id) references subject(subject_id)
);

create table absencereason(
absencereason_id int primary key,
reason varchar(45)
);

create table attendance(
attendance_id int primary key,
lesson_id int,
student_id int,
present int,
absencereason_id int,
foreign key (student_id) references student(student_id),
foreign key(lesson_id) references lesson(lesson_id),
foreign key(absencereason_id) references absencereason(absencereason_id)
);