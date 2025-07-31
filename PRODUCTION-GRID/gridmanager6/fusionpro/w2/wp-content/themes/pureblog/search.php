<?php
/**
 * The template for displaying search results pages
 * @package PureBlog
*/

get_header(); ?>

<div class="container">

<?php get_template_part( 'template-parts/sidebars/sidebar', 'breadcrumbs' ); ?>

<div class="row"><div class="col-md-12">

	<header class="page-header">
		<?php if ( have_posts() ) : ?>
			<h1 class="page-title"><?php printf( 
			/* translators: %s: Your keywords. */
			esc_html__( 'Search Results for: %s', 'pureblog' ), '<span>' . get_search_query() . '</span>' ); ?></h1>
		<?php else : ?>
			<h1 class="page-title"><?php esc_html_e( 'Nothing Found', 'pureblog' ); ?></h1>
		<?php endif; ?>
	</header><!-- .page-header -->

		<main id="main" class="site-main">

		<?php
		if ( have_posts() ) :

			while ( have_posts() ) : the_post();
				get_template_part( 'template-parts/post/content', 'excerpt' );
			endwhile; 

				the_posts_pagination( array(
					'prev_text' => '<span class="prev">' . __( 'Previous page', 'pureblog' ) . '</span>',
					'next_text' => '<span class="next">' . __( 'Next page', 'pureblog' ) . '</span>',
					'before_page_number' => '<span class="meta-nav sr-only">' . __( 'Page', 'pureblog' ) . ' </span>',
				) );
				
		else : ?>

			<p><?php esc_html_e( 'Sorry, but nothing matched your search terms. Please try again with some different keywords.', 'pureblog' ); ?></p>
			<?php
				get_search_form();

		endif;
		?>

		</main><!-- #main -->


</div></div></div><!-- .wrap -->

<?php get_footer();
