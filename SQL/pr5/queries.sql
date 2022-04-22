SELECT title, length, description FROM film WHERE title LIKE '%n' ORDER BY length DESC OFFSET 0 LIMIT 5;
SELECT title, length, description FROM film WHERE title LIKE '%n' ORDER BY length ASC OFFSET 5 LIMIT 5;
SELECT * FROM customer WHERE store_id = 1 ORDER BY last_name DESC OFFSET 0 LIMIT 4;
