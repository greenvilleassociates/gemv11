<?php
/**
 * Template Name: Right Column
 * @package PureBlog 
*/

get_header(); ?>
		
<div class="container">

<?php get_template_part( 'template-parts/sidebars/sidebar', 'breadcrumbs' ); ?>

	<div class="row">
		<div class="col-md-8">
		
			<main id="main" class="site-main">		
				<?php 
				while ( have_posts() ) : the_post(); 
					get_template_part( 'template-parts/page/content', 'page' ); 
					if ( comments_open() || get_comments_number() ) :
					comments_template();
					endif;				
				endwhile;
			 ?>				
			</main>
		</div>

		<div class="col-md-4">        
			<?php get_template_part( 'template-parts/sidebars/sidebar', 'right' ); ?>    
		</div>
		
	</div>
</div>

<?php 
get_footer();