SELECT * FROM country WHERE country LIKE 'A%a';
SELECT * FROM country WHERE country LIKE '_____%n';
SELECT * FROM film WHERE title ILIKE '%t%t%t%t%';
SELECT * FROM film WHERE title LIKE 'C%' and length>90 and rental_rate=2.99;
