<?php
/**
 * Template file for blog headers
 * @package PureBlog
 */
?>


<?php if ( is_home() || is_front_page() ) : ?>	
	<header id="page-header" class="screen-reader-text">
		<h2 class="page-title"><?php esc_html_e( 'Posts', 'pureblog' ); ?></h2>
	</header>
<?php else : ?>
		<header id="page-header">
		<?php
			the_archive_title( '<h1 class="page-title">', '</h1>' );
			the_archive_description( '<div class="description lead">', '</div>' );
		?>
	</header>	
<?php endif; ?>