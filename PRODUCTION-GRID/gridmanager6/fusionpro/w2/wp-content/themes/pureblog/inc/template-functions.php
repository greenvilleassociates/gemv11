<?php
/**
 * Additional features to allow styling of the templates
 * @package PureBlog
 */

/**
 * Adds custom classes to the array of body classes.
 *
 * @param array $classes Classes for the body element.
 * @return array*/
function pureblog_body_classes( $classes ) {
	// Add class of group-blog to blogs with more than 1 published author.
	if ( is_multi_author() ) {
		$classes[] = 'group-blog';
	}

	// Add class of hfeed to non-singular pages.
	if ( ! is_singular() ) {
		$classes[] = 'hfeed';
	}

	// Add class if we're viewing the Customizer for easier styling of theme options.
	if ( is_customize_preview() ) {
		$classes[] = 'pureblog-customizer';
	}

	// Add class on front page.
	if ( is_front_page() && 'posts' !== get_option( 'show_on_front' ) ) {
		$classes[] = 'pureblog-front-page';
	}
	// Add a class if there is a custom header.
	if ( has_header_image() ) {
		$classes[] = 'has-header-image';
	}

	// Add a class if there is no custom header.
	if ( ! has_header_image() || ! is_front_page()) {
		$classes[] = 'no-header-image';
	}
	
	// Get the colorscheme or the default if there isn't one.
	$colors = pureblog_sanitize_colorscheme( get_theme_mod( 'colorscheme', 'default' ) );
	$classes[] = 'colors-' . $colors;

	return $classes;
}
add_filter( 'body_class', 'pureblog_body_classes' );


/**
 * Checks to see if we're on the homepage or not.*/
function pureblog_is_frontpage() {
	return ( is_front_page() && ! is_home() );
}

	
//----------------------------------------------------------------------------------
//	Move the Continue Reading link outside of the paragraph
//----------------------------------------------------------------------------------
if ( ! function_exists( 'pureblog_move_more_link' ) ) :
	function pureblog_move_more_link($link) {
			$link = '<p class="more-link-wrap">'.$link.'</p>';
			return $link;
		}
	add_filter('the_content_more_link', 'pureblog_move_more_link');
endif;	
		
//----------------------------------------------------------------------------------
//	Add Read More to the excerpts and add ability to show or hide it
//----------------------------------------------------------------------------------
function pureblog_excerpt_more($more) {
       global $post;
		if( esc_attr(get_theme_mod( 'pureblog_show_excerpt_readmore', true ) ) ) {
			return '&hellip;<p><a class="more-link" href="'. esc_url(get_permalink($post->ID)) . '">' . esc_html__( 'Read More', 'pureblog' ) . '</a></p>';
		} else {
			return '&hellip;';
	   }
}
add_filter('excerpt_more', 'pureblog_excerpt_more', 21);
	
		
//----------------------------------------------------------------------------------
//	Change excerpt size
//----------------------------------------------------------------------------------
function pureblog_custom_excerpt_length( $length ) { 
$pureblog_excerpt_size = esc_attr(get_theme_mod( 'pureblog_excerpt_size', '55' ));
	return $pureblog_excerpt_size;
}
add_filter( 'excerpt_length', 'pureblog_custom_excerpt_length', 999 );

