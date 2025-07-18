<?php
/**
 * Template part for displaying page content in page.php
 * @link https://codex.wordpress.org/Template_Hierarchy
 * @package PureBlog
*/

?>

<article id="post-<?php the_ID(); ?>" <?php post_class(); ?>>

	<?php // featured image for pages
	 if ( '' !== get_the_post_thumbnail() ) :
			echo '<div class="post-thumbnail">';		
				the_post_thumbnail( 'post-thumbnail', array( 'alt' => the_title_attribute( 'echo=0' ), 'class' => ''));
			echo '</div>';	
	endif;
	?>	
	
	<header class="page-header">
		<?php the_title( '<h1 class="page-title">', '</h1>' ); ?>
		
		<?php if( esc_attr(get_theme_mod( 'pureblog_show_edit_link', false ) ) ) :
			pureblog_edit_link( get_the_ID() ); 
		endif; ?>
		
	</header><!-- .entry-header -->
	<div class="entry-content">
		<?php
			the_content();

			wp_link_pages( array(
				'before' => '<div class="page-links">' . esc_html__( 'Pages:', 'pureblog' ),
				'after'  => '</div>',
			) );
		?>
	</div><!-- .entry-content -->
</article><!-- #post-## -->
