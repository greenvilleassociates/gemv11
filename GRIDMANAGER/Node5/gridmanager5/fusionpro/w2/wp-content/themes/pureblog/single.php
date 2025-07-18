<?php
/**
 * The template for displaying all single posts
 * @package PureBlog
*/


get_header(); ?>

<?php
	$singlestyle = esc_attr(get_theme_mod( 'pureblog_single_layout', 'single1' ));
	switch ($singlestyle) {
    case "single1":
	
echo '<div class="container">';

get_template_part( 'template-parts/sidebars/sidebar', 'breadcrumbs' );

	echo '<div class="row"><div class="col-md-8"><main id="main" class="site-main ' . esc_attr($singlestyle) . '">';

								
				while ( have_posts() ) : the_post();	
					get_template_part( 'template-parts/post/content', 'single' );
					
					// single post navigation
					if ( esc_attr(get_theme_mod( 'pureblog_post_nav', 1 )) ) :
						get_template_part( 'template-parts/navigation/navigation', 'post' );
					endif;
				
					// Author bio.
					if ( is_single() && get_the_author_meta( 'description' ) && esc_attr(get_theme_mod( 'pureblog_authorbio', 1 ) ) ) {
							get_template_part( 'author-bio' );
					}			
								
					// If comments are open or we have at least one comment, load up the comment template.
					if ( comments_open() || get_comments_number() ) :
						comments_template();
					endif;						
				endwhile; // End of the loop.
				

			echo '</main></div><div class="col-md-4">';
			 get_template_part( 'template-parts/sidebars/sidebar', 'right' );
		echo '</div></div></div>';

       
	break;
    case "single2": 


echo '<div class="container">';

 get_template_part( 'template-parts/sidebars/sidebar', 'breadcrumbs' ); 

	echo '<div class="row"><div class="col-lg-8 order-lg-2"><main id="main" class="site-main ' . esc_attr($singlestyle) . '">';

							
				while ( have_posts() ) : the_post();	
					get_template_part( 'template-parts/post/content', 'single' );
					
					// single post navigation
					if ( esc_attr(get_theme_mod( 'pureblog_post_nav', 1 )) ) :
						get_template_part( 'template-parts/navigation/navigation', 'post' );
					endif;
				
					// Author bio.
					if ( is_single() && get_the_author_meta( 'description' ) && esc_attr(get_theme_mod( 'pureblog_authorbio', 1 ) ) ) {
							get_template_part( 'author-bio' );
					}			
								
					// If comments are open or we have at least one comment, load up the comment template.
					if ( comments_open() || get_comments_number() ) :
						comments_template();
					endif;						
				endwhile; // End of the loop.
			

			echo '</main></div><div class="col-lg-4 order-4 order-lg-1">';
			 get_template_part( 'template-parts/sidebars/sidebar', 'left' );
		echo '</div></div></div>';

       
	break;
    default: 

echo '<div class="container">';

 get_template_part( 'template-parts/sidebars/sidebar', 'breadcrumbs' ); 

	echo '<div class="row"><div class="col-md-12"><main id="main" class="site-main ' . esc_attr($singlestyle) . '">';

						
				while ( have_posts() ) : the_post();	
					get_template_part( 'template-parts/post/content', 'single' );
					
					// single post navigation
					if ( esc_attr(get_theme_mod( 'pureblog_post_nav', 1 )) ) :
						get_template_part( 'template-parts/navigation/navigation', 'post' );
					endif;
				
					// Author bio.
					if ( is_single() && get_the_author_meta( 'description' ) && esc_attr(get_theme_mod( 'pureblog_authorbio', 1 ) ) ) {
							get_template_part( 'author-bio' );
					}			
								
					// If comments are open or we have at least one comment, load up the comment template.
					if ( comments_open() || get_comments_number() ) :
						comments_template();
					endif;						
				endwhile; // End of the loop.
			
echo '</main></div></div></div>';

 } 
 ?>

<?php get_footer();