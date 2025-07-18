CREATE OR REPLACE FUNCTION create_shadow_user()
RETURNS TRIGGER AS $$
BEGIN
INSERT INTO shadow_user (id, name, username, email, password, registerdate, params, originatingnode)
VALUES (NEW.id, NEW.name, NEW.username, NEW.email, NEW.password, NEW.registerdate, NEW.params, '3or5');
RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER after_h_users_insert
AFTER INSERT ON h_users
FOR EACH ROW
EXECUTE FUNCTION create_shadow_user();

create table shadowuser (id int primary key, name varchar(150), username varchar(150), email varchar(150), password varchar(100), registerdate date, params varchar(150));
