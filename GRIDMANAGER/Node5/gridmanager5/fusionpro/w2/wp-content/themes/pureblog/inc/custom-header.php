<?php
/**
 * Custom header implementation
 *
 * @link https://codex.wordpress.org/Custom_Headers
 *
 * @package PureBlog
 * @since 1.0.0
 */

/**
 * Set up the WordPress core custom header feature.
 *
 * @uses pureblog_header_style()
 */
function pureblog_custom_header_setup() {

	/**
	 * Filter Twenty Seventeen custom-header support arguments.
	 *
	 * @param array $args {
	 *     An array of custom-header support arguments.
	 *
	 *     @type string $default-image          Default image of the header.
	 *     @type int    $width                  Width in pixels of the custom header image. Default 1600.
	 *     @type int    $height                 Height in pixels of the custom header image. Default 1200.
	 *     @type string $flex-height            Flex support for height of header.
	 *     @type string $video                  Video support for header.
	 *     @type string $wp-head-callback       Callback function used to styles the header image and text
	 *      displayed on the blog.
	 * }
	 */
	add_theme_support(
		'custom-header',
		apply_filters(
			'pureblog_custom_header_args',
			array(
				'default-image'      => get_parent_theme_file_uri( '/assets/images/default-header.jpg' ),
				'width'            => 1920,
				'height'           => 1200,
				'flex-height'      => true,
				'header-text' => false,
			)
		)
	);

	register_default_headers(
		array(
		'default-image' => array(
			'url'           => '%s/assets/images/default-header.jpg',
			'thumbnail_url' => '%s/assets/images/default-header.jpg',
			'description'   => esc_html__( 'Default Header Image', 'pureblog' ),
		)
		)
	);
}
add_action( 'after_setup_theme', 'pureblog_custom_header_setup' );

