//PARTIAL STATEMENT
DO $$ 
BEGIN
   
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'block') THEN
        ALTER TABLE shadowuser ADD COLUMN block int2;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'sendEmail') THEN
        ALTER TABLE shadowuser ADD COLUMN sendEmail int2;
    END IF;

   IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'activation') THEN
        ALTER TABLE shadowuser ADD COLUMN activation varchar(100);
    END IF;

   IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'lastResetTime') THEN
        ALTER TABLE shadowuser ADD COLUMN lastResetTime timestamp;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'resetCount') THEN
        ALTER TABLE shadowuser ADD COLUMN resetCount int8;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'otpKey') THEN
        ALTER TABLE shadowuser ADD COLUMN otpKey varchar(1000);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'otep') THEN
        ALTER TABLE shadowuser ADD COLUMN otep varchar(1000);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'requireReset') THEN
        ALTER TABLE shadowuser ADD COLUMN requireReset int2;
    END IF;
END $$;

//FULLSTATEMENT
DO $$ 
BEGIN
    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'id') THEN
        ALTER TABLE shadowuser ADD COLUMN id int4;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'name') THEN
        ALTER TABLE shadowuser ADD COLUMN name varchar(255);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'username') THEN
        ALTER TABLE shadowuser ADD COLUMN username varchar(150);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'email') THEN
        ALTER TABLE shadowuser ADD COLUMN email varchar(100);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'password') THEN
        ALTER TABLE shadowuser ADD COLUMN password varchar(100);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'block') THEN
        ALTER TABLE shadowuser ADD COLUMN block int2;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'sendEmail') THEN
        ALTER TABLE shadowuser ADD COLUMN sendEmail int2;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'registerDate') THEN
        ALTER TABLE shadowuser ADD COLUMN registerDate timestamp;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'lastvisitDate') THEN
        ALTER TABLE shadowuser ADD COLUMN lastvisitDate timestamp;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'activation') THEN
        ALTER TABLE shadowuser ADD COLUMN activation varchar(100);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'params') THEN
        ALTER TABLE shadowuser ADD COLUMN params text;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'lastResetTime') THEN
        ALTER TABLE shadowuser ADD COLUMN lastResetTime timestamp;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'resetCount') THEN
        ALTER TABLE shadowuser ADD COLUMN resetCount int8;
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'otpKey') THEN
        ALTER TABLE shadowuser ADD COLUMN otpKey varchar(1000);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'otep') THEN
        ALTER TABLE shadowuser ADD COLUMN otep varchar(1000);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM information_schema.columns WHERE table_name = 'shadowuser' AND column_name = 'requireReset') THEN
        ALTER TABLE shadowuser ADD COLUMN requireReset int2;
    END IF;
END $$;
