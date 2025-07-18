<?php
/**
 * The default template for displaying the full post
 * @package PureBlog
*/
?>

<article id="post-<?php the_ID(); ?>" <?php post_class(); ?>>
			
	<?php
		if( esc_attr(get_theme_mod( 'pureblog_show_single_featured', 1 ) ) ) :  
			echo '<div class="post-thumbnail">';		
				the_post_thumbnail( 'post-thumbnail', array( 'alt' => the_title_attribute( 'echo=0' ), 'class' => ''));
			echo '</div>';			
		endif; 
	?>		

	<header class="entry-header">	
		<?php	the_title( '<h1 class="entry-title">', '</h1>' );	?>
	</header>

	<div class="single-entry-meta">
		<?php 
			if ( 'post' === get_post_type() ) {
			echo '<ul class="entry-meta">';
					pureblog_post_format();
					pureblog_posted_on();
					pureblog_posted_by();
					pureblog_categories();
				};
			echo '</ul>';
		?>
	</div>

	<div class="entry-content">
		<?php	the_content();?>	
	</div>

	<?php	pureblog_entry_footer();	?>
	

</article>
	
	