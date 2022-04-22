SELECT rating, COUNT(rating) FROM film GROUP BY rating ORDER BY rating;
SELECT replacement_cost, COUNT(replacement_cost) FROM film GROUP BY replacement_cost HAVING COUNT(replacement_cost)>50 ORDER BY COUNT(replacement_cost) DESC;
SELECT store_id, COUNT(*) FROM customer GROUP BY store_id ORDER BY store_id;
SELECT country_id, COUNT(*) FROM city GROUP BY country_id;
