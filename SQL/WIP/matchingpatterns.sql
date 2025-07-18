alter table gapps add column targetgeometry varchar(150) DEFAULT '4sidedpolygon';
alter table gapps add column targetgrid varchar(150) DEFAULT 'US-InnerCore';
alter table gapps add column targetgridid int DEFAULT 1;
alter table gapps add column iscompliant int;

//ADD TRIGGER TO REPORT ON COMPLIANT

//POSTGRES TRIGGER
CREATE OR REPLACE FUNCTION enforce_compliance()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.gridid IS DISTINCT FROM NEW.targetgridid THEN
        NEW.iscompliant := 0;
    ELSE
        NEW.iscompliant := 1;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_enforce_compliance
BEFORE INSERT ON gapps
FOR EACH ROW
EXECUTE FUNCTION enforce_compliance();
