FusionShell5.0 Requires that joomla3.10 or 3.11 be installed here running PHP Version 7.4. OneAll.com social media plugin runs on this container, and a Joomla database which should NOT BE UPGRADED EVER. This container
does nothing but SSO Integration to LDAP, and to OneAll in the current FS5.0 implementation and runs its own Postgres, or MySQL DBMS. MS-SQL Server does install but the plugins DO NOT WORK, so MS-SQL cannot be used for
SSO at this time until we develop our own Social Media client side drivers to talk to OneAll.(A Big Project we are bypassing at this time).
