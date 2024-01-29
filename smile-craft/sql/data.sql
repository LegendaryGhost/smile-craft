INSERT INTO mark (mark, description) VALUES
    (0, 'Removed'),
    (1, 'Almost completely gone'),
    (2, 'Almost completely gone'),
    (3, 'Almost completely gone'),
    (4, 'Having cavities'),
    (5, 'Having cavities'),
    (6, 'Having cavities'),
    (7, 'Quite dirty'),
    (8, 'Quite dirty'),
    (9, 'Quite dirty'),
    (10, 'Perfect');

INSERT INTO operation(name) VALUES
    ('cleaning'),
    ('fixing'),
    ('removing'),
    ('replacement');
    
INSERT INTO category (designation) VALUES
    ('Incisor'),
    ('Canine'),
    ('Premolar'),
    ('Molar');

INSERT INTO tooth (location, id_category) VALUES
    ('up', 4),
    ('up', 4),
    ('up', 4),
    ('up', 3),
    ('up', 3),
    ('up', 2),
    ('up', 1),
    ('up', 1),
    ('up', 1),
    ('up', 1),
    ('up', 2),
    ('up', 3),
    ('up', 3),
    ('up', 4),
    ('up', 4),
    ('up', 4),
    ('down', 4),
    ('down', 4),
    ('down', 4),
    ('down', 3),
    ('down', 3),
    ('down', 2),
    ('down', 1),
    ('down', 1),
    ('down', 1),
    ('down', 1),
    ('down', 2),
    ('down', 3),
    ('down', 3),
    ('down', 4),
    ('down', 4),
    ('down', 4);

INSERT INTO price VALUES
    (1, 1, 5000),
    (1, 2, 5200),
    (1, 3, 5400),
    (1, 4, 5600),
    (2, 1, 10000),
    (2, 2, 11000),
    (2, 3, 12000),
    (2, 4, 15000),
    (3, 1, 8000),
    (3, 2, 8200),
    (3, 3, 8400),
    (3, 4, 8600),
    (4, 1, 20000),
    (4, 2, 22000),
    (4, 3, 23000),
    (4, 4, 25000);

INSERT INTO patient(firstname, lastname, birthday) VALUES
    ('John', 'Doe', '1990-01-01'), 
    ('Jane', 'Smith', '1992-02-02'), 
    ('Bob', 'Johnson', '1994-03-03'),
    ('Emma', 'Brown', '1996-04-04'),
    ('Mike', 'Green', '1998-05-05');

-- Insert more random data for the perform table
INSERT INTO perform (id_patient, id_tooth, id_operation, date_operation)
VALUES
  (1, 5, 3, '2024-01-25'),
  (2, 12, 2, '2024-01-26'),
  (3, 21, 4, '2024-01-27'),
  (4, 8, 1, '2024-01-28'),
  (5, 15, 3, '2024-01-29'),
  (1, 10, 1, '2024-01-30'),
  (2, 28, 2, '2024-01-31'),
  (3, 14, 3, '2024-02-01'),
  (4, 7, 4, '2024-02-02'),
  (5, 20, 1, '2024-02-03'),
  (1, 3, 2, '2024-02-04'),
  (2, 17, 3, '2024-02-05'),
  (3, 25, 4, '2024-02-06'),
  (4, 9, 1, '2024-02-07'),
  (5, 13, 2, '2024-02-08');
