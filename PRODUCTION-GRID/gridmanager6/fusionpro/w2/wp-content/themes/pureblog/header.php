<?php
/**
 * The header for our theme
 * This is the template that displays all of the <head> section and everything up until <div id="content">
 * @link https://developer.wordpress.org/themes/basics/template-files/#template-partials
 * @package PureBlog
*/

?><!DOCTYPE html>
<html <?php language_attributes(); ?> class="no-js no-svg">
<head>
<meta charset="<?php bloginfo( 'charset' ); ?>">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="profile" href="http://gmpg.org/xfn/11">

<?php wp_head(); ?>
</head>

<body <?php body_class(); ?>>
<?php wp_body_open(); ?>
<div id="page" class="site">
	<a class="skip-link screen-reader-text" href="#content"><?php esc_html_e( 'Skip to content', 'pureblog' ); ?></a>

	<header id="masthead" class="site-header">

		<?php get_template_part( 'template-parts/header/header', 'image' ); ?>
	

		<?php if ( has_nav_menu( 'top' ) ) : ?>
			<div class="navigation-top">
				<div class="container"><div class="row"><div class="col-md-12">
				<div class="wrap">
					<?php get_template_part( 'template-parts/navigation/navigation', 'top' ); ?>
				</div></div></div></div><!-- .wrap -->
			</div><!-- .navigation-top -->
		<?php endif; ?>
		


	</header><!-- #masthead -->
	
	<?php get_template_part( 'template-parts/sidebars/sidebar', 'banner' ); ?>
		
	<div class="site-content-contain">
	
	<div id="content" class="site-content">
		
			