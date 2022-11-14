-- Database: market

select products.product_name as product, category.product_category as category 
from products 
left join products_category
on products.products_id = products_category.products_id
left join
 category on products_category.category_id=category.category_id;
