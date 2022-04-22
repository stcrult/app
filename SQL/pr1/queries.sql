select title,description from film order by title, description;
select * from film where length > 60 and length <=75 order by length;
select * from film where rental_rate = 0.99 and (replacement_cost = 12.99 or replacement_cost =  28.99) order by rental_rate, replacement_cost;
select first_name, last_name from customer where first_name = 'Mary';
select * from film where length <=50 and (rental_rate != 2.99 or rental_rate != 4.99) order by length, rental_rate;
