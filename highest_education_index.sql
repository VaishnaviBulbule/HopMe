CREATE TABLE Highest_education(
   id     INTEGER  NOT NULL PRIMARY KEY 
  ,degree VARCHAR(36) NOT NULL
  ,value  INTEGER  NOT NULL
);
INSERT INTO Highest_education(id,degree,value) VALUES (0,'Postgraduate Degree',9);
INSERT INTO Highest_education(id,degree,value) VALUES (1,'Graduate Diploma or Certificate',8);
INSERT INTO Highest_education(id,degree,value) VALUES (2,'Bachelor Degree Level',7);
INSERT INTO Highest_education(id,degree,value) VALUES (3,'Advanced Diploma or Associate Degree',6);
INSERT INTO Highest_education(id,degree,value) VALUES (4,'Diploma',5);
INSERT INTO Highest_education(id,degree,value) VALUES (5,'Certificate III or IV',4);
INSERT INTO Highest_education(id,degree,value) VALUES (6,'Secondary School',3);
INSERT INTO Highest_education(id,degree,value) VALUES (7,'Certificate I & II Level',2);
INSERT INTO Highest_education(id,degree,value) VALUES (8,'Primary School',1);
INSERT INTO Highest_education(id,degree,value) VALUES (9,'No education background',0);
