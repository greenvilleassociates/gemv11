<?php
/**
 * The template for displaying the footer
 * Contains the closing of the #content div and all content after.
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 * @package PureBlog
*/

 $pureblog_footer_logo = esc_url(get_theme_mod('pureblog_footer_logo' ));
?>

		</div>
	</div>
</div>

<div id="bottom-sidebars">
	<?php get_template_part( 'template-parts/sidebars/sidebar', 'bottom' ); ?>
</div>

<footer id="colophon" class="site-footer">
	<div class="container">
	<div class="row">
	<div class="col-md-12">
	
	<?php if ( get_theme_mod( 'pureblog_footer_logo' ) ) : ?>
		<div id="footer-logo">
			<img id="footer-logo-image" src="<?php echo esc_attr($pureblog_footer_logo); ?>" alt="<?php bloginfo( 'name' ); ?>" />
		</div>
	<?php endif; ?>
				
	 <nav id="footer-nav">
		<?php wp_nav_menu( array( 
				'theme_location' => 'footer', 
				'fallback_cb' => false, 
				'depth' => 1,
				'container' => false, 
				'menu_id' => 'footer-menu', 
			) ); 
		?>
	</nav>

	<?php

			if ( has_nav_menu( 'social' ) ) : ?>
			<nav class="social-navigation" aria-label="<?php esc_attr_e( 'Footer Social Links Menu', 'pureblog' ); ?>">
				<?php
					wp_nav_menu( array(
						'theme_location' => 'social',
						'menu_class'     => 'footer-social',
						'depth'          => 1,
						'link_before'    => '<span class="sr-only">',
						'link_after'     => '</span>',
					) );
				?>
			</nav><!-- .social-navigation -->
			
			<hr class="footer-divider">
			
		<?php endif;
		get_template_part( 'template-parts/footer/site', 'info' );
		?>
	</div></div></div><!-- .wrap -->
</footer><!-- #colophon -->
		
<?php wp_footer(); ?>

</body>
</html>
