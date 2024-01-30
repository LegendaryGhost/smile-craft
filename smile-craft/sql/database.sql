CREATE DATABASE smilecraft;

\c smilecraft;

CREATE TABLE patient(
   id_patient SERIAL,
   firstname VARCHAR(50)  NOT NULL,
   lastname VARCHAR(50)  NOT NULL,
   birthday DATE,
   PRIMARY KEY(id_patient)
);

CREATE TABLE operation(
   id_operation SERIAL,
   name VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_operation)
);

CREATE TABLE mark(
   id_mark SERIAL,
   mark INTEGER NOT NULL,
   description VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_mark),
   UNIQUE(mark)
);

CREATE TABLE category(
   id_category SERIAL,
   designation VARCHAR(50)  NOT NULL,
   PRIMARY KEY(id_category)
);

CREATE TABLE tooth(
   id_tooth SERIAL,
   location VARCHAR(5)  NOT NULL,
   id_category INTEGER NOT NULL,
   PRIMARY KEY(id_tooth),
   FOREIGN KEY(id_category) REFERENCES category(id_category)
);

CREATE TABLE state(
   id_patient INTEGER,
   id_tooth INTEGER,
   id_mark INTEGER NOT NULL,
   PRIMARY KEY(id_patient, id_tooth),
   FOREIGN KEY(id_patient) REFERENCES patient(id_patient),
   FOREIGN KEY(id_tooth) REFERENCES tooth(id_tooth),
   FOREIGN KEY(id_mark) REFERENCES mark(id_mark)
);

CREATE TABLE perform(
   id_perform SERIAL NOT NULL,
   id_patient INTEGER,
   id_tooth INTEGER,
   id_operation INTEGER,
   date_operation DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,
   PRIMARY KEY(id_perform),
   FOREIGN KEY(id_patient) REFERENCES patient(id_patient),
   FOREIGN KEY(id_tooth) REFERENCES tooth(id_tooth),
   FOREIGN KEY(id_operation) REFERENCES operation(id_operation)
);

CREATE TABLE price(
   id_operation INTEGER,
   id_category INTEGER,
   price MONEY NOT NULL,
   PRIMARY KEY(id_operation, id_category),
   FOREIGN KEY(id_operation) REFERENCES operation(id_operation),
   FOREIGN KEY(id_category) REFERENCES category(id_category)
);

CREATE TABLE tooth_state_history (
   id_history SERIAL PRIMARY KEY,
   id_patient INTEGER NOT NULL,
   id_tooth INTEGER NOT NULL,
   id_old_mark INTEGER NOT NULL,
   id_new_mark INTEGER NOT NULL,
   date_history DATE NOT NULL DEFAULT NOW(),
   FOREIGN KEY (id_patient) REFERENCES patient(id_patient),
   FOREIGN KEY (id_tooth) REFERENCES tooth(id_tooth),
   FOREIGN KEY (id_old_mark) REFERENCES mark(id_mark),
   FOREIGN KEY (id_new_mark) REFERENCES mark(id_mark)
);

----------------------------------------------------------------
--                         TRIGGERS                           --
----------------------------------------------------------------

-- Populate state function
CREATE OR REPLACE FUNCTION populate_state() RETURNS TRIGGER AS $$
BEGIN
 FOR i IN 1..32 LOOP
    INSERT INTO state (id_patient, id_tooth, id_mark) VALUES (NEW.id_patient, i, 11);
 END LOOP;
 RETURN NEW;
END;
$$ LANGUAGE plpgsql;
-- Corresponding trigger
CREATE TRIGGER after_patient_insert
AFTER INSERT ON patient
FOR EACH ROW EXECUTE PROCEDURE populate_state();


-- Record state change function
CREATE OR REPLACE FUNCTION record_state_change() RETURNS TRIGGER AS $$
BEGIN
 IF TG_OP = 'UPDATE' THEN
    INSERT INTO tooth_state_history (id_patient, id_tooth, id_old_mark, id_new_mark)
    VALUES (OLD.id_patient, OLD.id_tooth, OLD.id_mark, NEW.id_mark);
 END IF;
 RETURN NEW;
END;
$$ LANGUAGE plpgsql;
-- Corresponding trigger
CREATE TRIGGER after_state_update
AFTER UPDATE ON state
FOR EACH ROW EXECUTE PROCEDURE record_state_change();


-- Update state function
CREATE OR REPLACE FUNCTION update_state() RETURNS TRIGGER AS $$
BEGIN
 IF NEW.id_operation = 3 THEN
    UPDATE state SET id_mark = 1 WHERE id_patient = NEW.id_patient AND id_tooth = NEW.id_tooth;
 ELSE
    UPDATE state SET id_mark = 11 WHERE id_patient = NEW.id_patient AND id_tooth = NEW.id_tooth;
 END IF;
 RETURN NEW;
END;
$$ LANGUAGE plpgsql;
-- Corresponding trigger
CREATE TRIGGER after_perform_insert
AFTER INSERT ON perform
FOR EACH ROW EXECUTE PROCEDURE update_state();

