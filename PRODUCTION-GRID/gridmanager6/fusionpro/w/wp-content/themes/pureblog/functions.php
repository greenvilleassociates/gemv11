<?php
/**
 *PureBlog functions and definitions
 * @link https://developer.wordpress.org/themes/basics/theme-functions/
 * @package PureBlog
 */

 // Declare latest theme version
$GLOBALS['pureblog_theme_version'] = wp_get_theme()->get( 'Version' );

/**
 *PureBlog only works in WordPress 4.7 or later.*/
if ( version_compare( $GLOBALS['wp_version'], '4.7-alpha', '<' ) ) {
	require get_template_directory() . '/inc/back-compat.php';
	return;
}

/**
 * Sets up theme defaults and registers support for various WordPress features.
 *
 * Note that this function is hooked into the after_setup_theme hook, which
 * runs before the init hook. The init hook is too late for some features, such
 * as indicating support for post thumbnails.*/
function pureblog_setup() {
	/*
	 * Make theme available for translation.
	 * Translations can be filed at WordPress.org. See: https://translate.wordpress.org/projects/wp-themes/pureblog
	 * If you're building a theme based onPureBlog, use a find and replace
	 * to change 'pureblog' to the name of your theme in all the template files.
	 */
	load_theme_textdomain( 'pureblog', get_template_directory() . '/languages' );

	// Add default posts and comments RSS feed links to head.
	add_theme_support( 'automatic-feed-links' );

	/*
	 * Let WordPress manage the document title.
	 * By adding theme support, we declare that this theme does not use a
	 * hard-coded <title> tag in the document head, and expect WordPress to
	 * provide it for us.
	 */
	add_theme_support( 'title-tag' );

	//----------------------------------------------------------------------------------
	//	Enable support for Post Thumbnails on posts and pages.
	//  @link https://developer.wordpress.org/themes/functionality/featured-images-post-thumbnails/
	//----------------------------------------------------------------------------------		 
	add_theme_support( 'post-thumbnails' );
	
	// create featured images for the default blog style
	if( esc_attr(get_theme_mod( 'pureblog_standard_thumbnails', false ) ) ) :
	add_image_size( 'pureblog-standard', 750, 475, true );
	endif;
	// create featured images for Centered  blog
	if( esc_attr(get_theme_mod( 'pureblog_blogcentered_thumbnails', false ) ) ) :
	add_image_size( 'pureblog-centered', 1140, 625, true );
	endif;
	
	// create featured images for the single post thumbnail
	if( esc_attr(get_theme_mod( 'pureblog_singlepost_thumbnails', false ) ) ) :
		add_image_size( 'pureblog-singlepost', 1140, 500, true );
	endif;
		
	// Set the default content width.
	$GLOBALS['content_width'] = 1140;

	// Register theme menus.
		register_nav_menus( array(
		'top' => esc_html__( 'Header Menu', 'pureblog' ),
		'social' => esc_html__( 'Social Menu', 'pureblog' ),
		'footer'  => esc_html__( 'Footer Menu', 'pureblog' ),
	) );

	// Add custom background support. https://codex.wordpress.org/Custom_Backgrounds
	add_theme_support( 'custom-background', array(
		'default-color' => '1b1b1b',
	) );
	
	//----------------------------------------------------------------------------------
	//	Switch default core markup for search form, comment form, and comments
	//  to output valid HTML5.
	//----------------------------------------------------------------------------------		 
	add_theme_support( 'html5', array(
		'comment-list',
		'gallery',
		'caption',
	) );

	// Add support for custom logo
		add_theme_support( 'custom-logo', array( 
		'width' => 200, 
		'height' => 100,
		'flex-width' => true, 
		'flex-height' => true 
		) );	

	// Add theme support for selective refresh for widgets.
	add_theme_support( 'customize-selective-refresh-widgets' );

	/*
	 * This theme styles the visual editor to resemble the theme style,
	 * specifically font, colors, and column width.
 	 */
	add_editor_style( 'assets/css/editor-style.css' );

}
add_action( 'after_setup_theme', 'pureblog_setup' );


//----------------------------------------------------------------------------------
//	Set the content width
//----------------------------------------------------------------------------------
	function pureblog_content_width() {
		$content_width = $GLOBALS['content_width'];
	 
		// Check if is single post and there is no sidebar.
		if ( is_active_sidebar( 'pageleft'  ) || is_active_sidebar( 'blogleft' ) || is_active_sidebar( 'blogright' ) || is_active_sidebar( 'blogright' ) ) {
			$content_width = 800;
		}
		
	  $GLOBALS['content_width'] = apply_filters( 'pureblog_content_width', $content_width );
	}
	add_action( 'template_redirect', 'pureblog_content_width', 0 );
	
	
/**
 * Handles JavaScript detection.
 * Adds a `js` class to the root `<html>` element when JavaScript is detected.
 */
function pureblog_javascript_detection() {
	echo "<script>(function(html){html.className = html.className.replace(/\bno-js\b/,'js')})(document.documentElement);</script>\n";
}
add_action( 'wp_head', 'pureblog_javascript_detection', 0 );

/**
 * Add a pingback url auto-discovery header for singularly identifiable articles.*/
function pureblog_pingback_header() {
	if ( is_singular() && pings_open() ) {
		printf( '<link rel="pingback" href="%s">' . "\n", esc_url(get_bloginfo( 'pingback_url' )) );
	}
}
add_action( 'wp_head', 'pureblog_pingback_header' );

/**
 * Display custom color CSS.*/
function pureblog_colors_css_wrap() {
	if ( 'custom' !== get_theme_mod( 'colorscheme' ) && ! is_customize_preview() ) {
		return;
	}

	require_once( get_parent_theme_file_path( '/inc/color-patterns.php' ) );
	$hue = absint( get_theme_mod( 'colorscheme_hue', 3 ) );
?>
    <style type="text/css" id="custom-theme-colors" <?php if ( is_customize_preview() ) { echo 'data-hue="' . esc_attr($hue) . '"'; } ?>>
		<?php echo pureblog_custom_colors_css(); ?>
    </style>
    <?php }
add_action( 'wp_head', 'pureblog_colors_css_wrap' );


/**
 * Register Google Fonts.
 */
if ( ! function_exists( 'pureblog_fonts_url' ) ) :

function pureblog_fonts_url() {
	$fonts_url = '';
	$fonts     = array();
	$subsets   = 'latin,latin-ext';

	// Translators: If there are characters in your language that are not supported by this font, translate this to 'off'. Do not translate into your own language.
	if ( 'off' !== _x( 'on', 'Lato font: on or off', 'pureblog' ) ) {
		$fonts[] = 'Lato:400';
	}		

	// Translators: If there are characters in your language that are not supported by this font, translate this to 'off'. Do not translate into your own language.
	if ( 'off' !== _x( 'on', 'Raleway font: on or off', 'pureblog' ) ) {
		$fonts[] = 'Raleway:400,600,800';
	}	
	
	// Translators: To add an additional character subset specific to your language, translate this to 'greek', 'cyrillic', 'devanagari' or 'vietnamese'. Do not translate into your own language.
	$subset = _x( 'no-subset', 'Add new subset (greek, cyrillic, devanagari, vietnamese)', 'pureblog' );

	if ( 'cyrillic' == $subset ) {
		$subsets .= ',cyrillic,cyrillic-ext';
	} elseif ( 'greek' == $subset ) {
		$subsets .= ',greek,greek-ext';
	} elseif ( 'devanagari' == $subset ) {
		$subsets .= ',devanagari';
	} elseif ( 'vietnamese' == $subset ) {
		$subsets .= ',vietnamese';
	}

	if ( $fonts ) {
		$fonts_url = add_query_arg( array(
			'family' => urlencode( implode( '|', $fonts ) ),
			'subset' => urlencode( $subsets ),
		), 'https://fonts.googleapis.com/css' );
	}

	return esc_url_raw( $fonts_url );
}
endif;


/**
 * Add preconnect for Google Fonts.
 * @param array  $urls           URLs to print for resource hints.
 * @param string $relation_type  The relation type the URLs are printed.
 * @return array $urls           URLs to print for resource hints.
 */
function pureblog_resource_hints( $urls, $relation_type ) {
	if ( wp_style_is( 'pureblog-fonts', 'queue' ) && 'preconnect' === $relation_type ) {
		$urls[] = array(
			'href' => 'https://fonts.gstatic.com',
			'crossorigin',
		);
	}

	return $urls;
}
add_filter( 'wp_resource_hints', 'pureblog_resource_hints', 10, 2 );

/**
 * Enqueue scripts and styles.*/
function pureblog_scripts() {
	
	global $pureblog_theme_version;
		
	$pureblog_font_url1   = get_theme_mod('pureblog_font_url1');
	if($pureblog_font_url1 != ''):
		wp_enqueue_style('pureblog-google_fonts',$pureblog_font_url1 , null, false, 'all');
	endif;		

	$pureblog_font_url2   = get_theme_mod('pureblog_font_url2');
	if($pureblog_font_url2 != ''):
		wp_enqueue_style('pureblog-google_fonts',$pureblog_font_url2 , null, false, 'all');
	endif;	


	// Enable or Disable Google default fonts
	if ( esc_attr(get_theme_mod( 'pureblog_default_google_fonts', true ) ) ) {
	wp_enqueue_style( 'pureblog-fonts', pureblog_fonts_url(), array(), null );
	}	

	// FontAwesome 4
	if( esc_attr(get_theme_mod( 'pureblog_enable_fontawesome', true ) ) ) {
			wp_enqueue_style( 'font-awesome-4', get_template_directory_uri() . '/assets/css/fontawesome4.css', '', '4.7.0' );		
	}
	
	// Theme stylesheet.
	wp_enqueue_style( 'pureblog-style', get_stylesheet_uri() );

	// Load the dark colorscheme.
	if ( 'dark' === get_theme_mod( 'colorscheme', 'default' ) || is_customize_preview() ) {
		wp_enqueue_style( 'pureblog-colors-dark', get_theme_file_uri( '/assets/css/colors-dark.css' ), array( 'pureblog-style' ), $pureblog_theme_version  );
	}

	wp_register_script( 'pureblog-skip-link-focus-fix', get_theme_file_uri() . '/assets/js/skip-link-focus-fix.js', array(), $pureblog_theme_version, false );

	$pureblog_l10n = array(
		'quote'          => '<span class="fa fa-arrow"></span>',
	);

	if ( has_nav_menu( 'top' ) ) {
		wp_enqueue_script( 'pureblog-navigation', get_theme_file_uri( '/assets/js/navigation.js' ), array( 'jquery' ), '1.0', true );
		$pureblog_l10n['expand']         = __( 'Expand child menu', 'pureblog' );
		$pureblog_l10n['collapse']       = __( 'Collapse child menu', 'pureblog' );
		$pureblog_l10n['icon']           = '<i class="icon fa fa-angle-down" aria-hidden="true"></i>';
	}
	// load theme scripts
	wp_enqueue_script( 'pureblog-global', get_theme_file_uri( '/assets/js/global.js' ), array( 'jquery' ), '1.0', true );
	// load scrollTo
	wp_enqueue_script( 'jquery-scrollto', get_theme_file_uri( '/assets/js/jquery.scrollTo.js' ), array( 'jquery' ), '2.1.2', true );

	$script_data = 'var pureblogScreenReaderText = ' . json_encode( $pureblog_l10n ) . ';';
	wp_add_inline_script( 'pureblog-skip-link-focus-fix', $script_data, 'before' );
	wp_enqueue_script( 'pureblog-skip-link-focus-fix' );
	
	if ( is_singular() && comments_open() && get_option( 'thread_comments' ) ) {
		wp_enqueue_script( 'comment-reply' );
	}
}
add_action( 'wp_enqueue_scripts', 'pureblog_scripts' );


/**
 * Enqueue scripts for the admin.
 * Script for our custom ad widgets to allow image uploading
 */

if( !function_exists('pureblog_admin_scripts') ) {
  function pureblog_admin_scripts($hook) {
  	if( $hook != 'widgets.php' ) 
  			return;
    wp_enqueue_media();
    wp_enqueue_script( 'jquery-ui-tabs' );
    wp_enqueue_script( 'pureblog-image-uploader', get_template_directory_uri() .'/assets/js/image-uploader.js', false, '', true );
  }
}
add_action('admin_enqueue_scripts', 'pureblog_admin_scripts');


/**
 * Modifies tag cloud widget arguments to display all tags in the same font size and use list format for better accessibility.
 * @param array $args Arguments for tag cloud widget.
 * @return array The filtered arguments for tag cloud widget.
 */
function pureblog_widget_tag_cloud_args( $args ) {
	$args['largest']  = 1;
	$args['smallest'] = 1;
	$args['unit']     = 'rem';
	$args['format']   = 'list';

	return $args;
}
add_filter( 'widget_tag_cloud_args', 'pureblog_widget_tag_cloud_args' );

/**
 * Filter the `sizes` value in the header image markup.
 * @param string $html   The HTML image tag markup being filtered.
 * @param object $header The custom header object returned by 'get_custom_header()'.
 * @param array  $attr   Array of the attributes for the image tag.
 * @return string The filtered header image HTML.
 */
function pureblog_header_image_tag( $html, $header, $attr ) {
	if ( isset( $attr['sizes'] ) ) {
		$html = str_replace( $attr['sizes'], '100vw', $html );
	}
	return $html;
}
add_filter( 'get_header_image_tag', 'pureblog_header_image_tag', 10, 3 );

/**
 * Use front-page.php when Front page displays is set to a static page.
 * @param string $template front-page.php.
 * @return string The template to be used: blank if is_home() is true (defaults to index.php), else $template.
 */
function pureblog_front_page_template( $template ) {
	return is_home() ? '' : $template;
}
add_filter( 'frontpage_template', 'pureblog_front_page_template' );


// Implement the Custom Header feature.
require get_parent_theme_file_path( '/inc/custom-header.php' );

// Custom template tags for this theme.
require get_parent_theme_file_path( '/inc/template-tags.php' );

// Additional features to allow styling of the templates.
require get_parent_theme_file_path( '/inc/template-functions.php' );

// Customizer additions.
require get_parent_theme_file_path( '/inc/customizer.php' );

// sidebars.
require get_parent_theme_file_path( '/inc/sidebars.php' );

// Inline Styles.
require get_parent_theme_file_path( '/inc/inline-styles.php' );

// Theme Info Page
require get_parent_theme_file_path( '/inc/theme-info/pureblog-info.php' );

// Theme info page class
require get_template_directory() . '/inc/theme-info/pureblog-info-class-about.php';