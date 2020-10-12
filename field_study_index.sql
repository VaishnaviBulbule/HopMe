CREATE TABLE filed_study(
   id     INTEGER  NOT NULL PRIMARY KEY 
  ,degree VARCHAR(46) NOT NULL
  ,value  INTEGER  NOT NULL
);
INSERT INTO filed_study(id,degree,value) VALUES (0,'NO FIELD OF STUDY',0);
INSERT INTO filed_study(id,degree,value) VALUES (1,'NATURAL AND PHYSICAL SCIENCES',1);
INSERT INTO filed_study(id,degree,value) VALUES (2,'INFORMATION TECHNOLOGY',2);
INSERT INTO filed_study(id,degree,value) VALUES (3,'ENGINEERING AND RELATED TECHNOLOGIES',3);
INSERT INTO filed_study(id,degree,value) VALUES (4,'ARCHITECTURE AND BUILDING',4);
INSERT INTO filed_study(id,degree,value) VALUES (5,'AGRICULTURE, ENVIRONMENTAL AND RELATED STUDIES',5);
INSERT INTO filed_study(id,degree,value) VALUES (6,'HEALTH',6);
INSERT INTO filed_study(id,degree,value) VALUES (7,'EDUCATION',7);
INSERT INTO filed_study(id,degree,value) VALUES (8,'MANAGEMENT AND COMMERCE',8);
INSERT INTO filed_study(id,degree,value) VALUES (9,'SOCIETY AND CULTURE',9);
INSERT INTO filed_study(id,degree,value) VALUES (10,'CREATIVE ARTS',10);
INSERT INTO filed_study(id,degree,value) VALUES (11,'FOOD, HOSPITALITY AND PERSONAL SERVICES',11);
INSERT INTO filed_study(id,degree,value) VALUES (12,'MIXED FIELD PROGRAMMES',12);
