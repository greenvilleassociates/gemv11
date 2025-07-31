<?php
/**
 * Add inline styles to the head area
 * These styles represents options from the customizer
 * @package PureBlog
*/
 
 // Dynamic styles
function pureblog_inline_styles($custom) {
	
// BEGIN CUSTOM CSS	

// body font family
if( esc_attr(get_theme_mod( 'pureblog_body_font_family' ) ) ) :
		$pureblog_body_font_family = get_theme_mod( 'pureblog_body_font_family' );	
		$custom .= "html, body { font-family: " . esc_attr($pureblog_body_font_family) . "; }"."\n";		
	endif;
	
// heading font family	
	if( esc_attr(get_theme_mod( 'pureblog_heading_font_family' ) ) ) :
		$pureblog_heading_font_family = get_theme_mod('pureblog_heading_font_family');		
		$custom .= "h1, h2, h3, h4, h5, h6, .entry-title a, #site-title { font-family: " . esc_attr($pureblog_heading_font_family) . "; }	"."\n";	
	endif;

// change container widths
	if( esc_attr(get_theme_mod( 'pureblog_container_width' ) ) ) :
		$pureblog_container_width = get_theme_mod('pureblog_container_width', 1260 );	
		$custom .= " @media (min-width: 1200px) {
			.container {max-width: " . esc_attr($pureblog_container_width) . "px; }
		}"."\n";
	endif;
	
// site branding header height
	if( esc_attr(get_theme_mod( 'pureblog_branding_height' ) ) ) :
		$pureblog_branding_height = get_theme_mod('pureblog_branding_height', 20 );	
		$custom .= ".page.has-header-image .site-branding, .page.no-header-image .site-branding, .blog.has-header-image .site-branding, .blog.no-header-image .site-branding, .archive.no-header-image .site-branding, .single.no-header-image .site-branding { padding: " . esc_attr($pureblog_branding_height) . "px 0; }"."\n";
	endif;

// custom colours
		$pureblog_custom_tag_bg = get_theme_mod('pureblog_custom_tag_bg', '#3d4a6f' );	
		$pureblog_custom_tag_text = get_theme_mod('pureblog_custom_tag_text',  '#ffffff' );		
		
		$pureblog_custom_tag_hbg = get_theme_mod('pureblog_custom_tag_hbg', '#985c5c' );	
		$pureblog_custom_tag_htext = get_theme_mod('pureblog_custom_tag_htext',  '#ffffff' );	
		
		$custom .= ".tag-list a, .tag-list a:visited, .colors-custom .tag-list a, .colors-custom .tag-list a:visited {background-color: " . esc_attr($pureblog_custom_tag_bg) . "; color: " . esc_attr($pureblog_custom_tag_text) . "; }
		.tag-list a:hover, .colors-custom .tag-list a:hover {background-color: " . esc_attr($pureblog_custom_tag_hbg) . "; color: " . esc_attr($pureblog_custom_tag_htext) . "; }
		"."\n";

	

// front page header height
	if( esc_attr(get_theme_mod( 'pureblog_fp_height' ) ) ) :
		$pureblog_fp_height = get_theme_mod('pureblog_fp_height', 80 );		
		$custom .= "@media (min-width: 768px) {
			.pureblog-front-page.has-header-image .custom-header-media,
			.pureblog-front-page.has-header-video .custom-header-media,
			.home.blog.has-header-image .custom-header-media,
			.home.blog.has-header-video .custom-header-media {	height: " . esc_attr($pureblog_fp_height) . "vh;	max-height: " . esc_attr($pureblog_fp_height) . "%; }
			.pureblog-front-page.has-header-image .custom-header-media:before,
			.pureblog-front-page.has-header-video .custom-header-media:before,
			.home.blog.has-header-image .custom-header-media:before,
			.home.blog.has-header-video .custom-header-media:before { height: " . esc_attr($pureblog_fp_height) . "%; }
			.admin-bar.pureblog-front-page.has-header-image .custom-header-media,
			.admin-bar.pureblog-front-page.has-header-video .custom-header-media,
			.admin-bar.home.blog.has-header-image .custom-header-media,
			.admin-bar.home.blog.has-header-video .custom-header-media { height: calc(" . esc_attr($pureblog_fp_height) . "vh - 32px); }
		}"."\n";	
	endif;

	if( esc_attr(get_theme_mod( 'pureblog_show_excerpt_readmore', false ) ) ) :
		$custom .= ".blog .more-link, .archive .more-link { display:inline-block;}	"."\n";
	endif; 
	
	if( esc_attr(get_theme_mod( 'pureblog_show_dropcap', false ) ) ) :
		$custom .= "
		.single-post .entry-content > p:first-of-type::first-letter {
		font-weight: 700;
		font-style: normal;
		font-family: \"Times New Roman\", Times, serif;
		font-size: 54px;
		font-size: 5.75rem;
		font-weight: normal;
		line-height: 0.8;
		color: #222;
		float: left;
		margin-bottom: 0;
		padding-right: 8px;
		text-transform: uppercase;
	}
	.single-post .entry-content h2 ~ p:first-of-type::first-letter {
		font-size: initial;
		font-weight: initial;
		line-height: initial;
		float: initial;
		margin-bottom: initial;
		padding-right: initial;
		text-transform: initial;
	}

.rtl.single-post .entry-content > p:first-of-type::first-letter {
    float: right;
    padding-left: 8px;
} "."\n";
	endif;


	
// END CUSTOM CSS
//Output all the styles
	wp_add_inline_style( 'pureblog-style', $custom );	
}
add_action( 'wp_enqueue_scripts', 'pureblog_inline_styles' );	