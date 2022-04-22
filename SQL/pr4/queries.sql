SELECT DISTINCT replacement_cost FROM film ORDER BY replacement_cost;
SELECT count(DISTINCT replacement_cost) FROM film;
SELECT count(title) FROM film WHERE title LIKE 'T%' AND rating = 'G';
SELECT count(country) FROM country WHERE length(country) = 5;
SELECT count(city) FROM city WHERE city ILIKE '%r';
