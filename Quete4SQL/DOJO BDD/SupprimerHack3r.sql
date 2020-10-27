USE SuperMoney;

SELECT * FROM logs;

BEGIN Transaction SuppUser
DELETE FROM logs
WHERE [user] = 'hack3r';
SELECT * FROM logs;

COMMIT;