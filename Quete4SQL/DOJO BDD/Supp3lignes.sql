USE Quete4;

BEGIN TRANSACTION Supp3ligne
DELETE TOP(3)
FROM quete4;
SELECT * FROM quete4;
COMMIT;
