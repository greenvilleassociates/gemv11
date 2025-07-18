<?php
/**
 * The template for displaying 404 pages (not found)
 * @package PureBlog
*/

get_header(); ?>


<main id="main" class="site-main">
			
	<section class="error not-found">
		<h2 class="error-title"><?php esc_html_e( 'Error 404', 'pureblog' ); ?></h2>
		<h3 class="error-subtitle"><?php esc_html_e( 'Page Not Found.', 'pureblog' ); ?></h3>
		<p class="error-message"><?php esc_html_e( 'The page you were looking for cannot be found, it may have been moved or no longer exists. You may want to navigate back to the homepage.', 'pureblog' ); ?></p>
		<p class="error-search"><?php get_search_form(); ?></p>
	</section>			
		
</main>

<?php get_footer();