<?php 
/**
 * Register theme sidebars
 * @package WordPress
 * @subpackage PureBlog
*/
 
function pureblog_widgets_init() {

	register_sidebar( array(
		'name' => esc_html__( 'Blog Right Sidebar', 'pureblog' ),
		'id' => 'blogright',
		'description' => esc_html__( 'Right sidebar for the blog', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );
	register_sidebar( array(
		'name' => esc_html__( 'Blog Left Sidebar', 'pureblog' ),
		'id' => 'blogleft',
		'description' => esc_html__( 'Left sidebar for the blog', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );	
	register_sidebar( array(
		'name' => esc_html__( 'Page Right Sidebar', 'pureblog' ),
		'id' => 'pageright',
		'description' => esc_html__( 'Right sidebar for pages', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );	
	register_sidebar( array(
		'name' => esc_html__( 'Page Left Sidebar', 'pureblog' ),
		'id' => 'pageleft',
		'description' => esc_html__( 'Left sidebar for pages', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );	
	
	register_sidebar( array(
		'name' => esc_html__( 'Banner', 'pureblog' ),
		'id' => 'banner',
		'description' => esc_html__( 'For Images and Sliders.', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h1 class="widget-title">',
		'after_title' => '</h1>',
	) );	
	
	register_sidebar( array(
		'name' => esc_html__( 'Breadcrumbs', 'pureblog' ),
		'id' => 'breadcrumbs',
		'description' => esc_html__( 'For adding breadcrumb navigation if using a plugin, or you can add content here.', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<div class="widget-title">',
		'after_title' => '</div>',
	) );

	register_sidebar( array(
		'name' => esc_html__( 'Bottom 1', 'pureblog' ),
		'id' => 'bottom1',
		'description' => esc_html__( 'Bottom 1 position', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );
	register_sidebar( array(
		'name' => esc_html__( 'Bottom 2', 'pureblog' ),
		'id' => 'bottom2',
		'description' => esc_html__( 'Bottom 2 position', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );
	register_sidebar( array(
		'name' => esc_html__( 'Bottom 3', 'pureblog' ),
		'id' => 'bottom3',
		'description' => esc_html__( 'Bottom 3 position', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );
	register_sidebar( array(
		'name' => esc_html__( 'Bottom 4', 'pureblog' ),
		'id' => 'bottom4',
		'description' => esc_html__( 'Bottom 4 position', 'pureblog' ),
		'before_widget' => '<div id="%1$s" class="widget %2$s">',
		'after_widget' => '</div>',
		'before_title' => '<h3 class="widget-title">',
		'after_title' => '</h3>',
	) );
	
}
add_action( 'widgets_init', 'pureblog_widgets_init' );


/**
 * Count the number of widgets to enable resizable widgets
 * in the bottom group.
*/

function pureblog_bottom() {
	$count = 0;
	if ( is_active_sidebar( 'bottom1' ) )
		$count++;
	if ( is_active_sidebar( 'bottom2' ) )
		$count++;
	if ( is_active_sidebar( 'bottom3' ) )
		$count++;		
	if ( is_active_sidebar( 'bottom4' ) )
		$count++;
	$class = '';
	switch ( $count ) {
		case '1':
			$class = 'col-md-12';
			break;
		case '2':
			$class = 'col-md-6';
			break;
		case '3':
			$class = 'col-md-4';
			break;
		case '4':
			$class = 'col-sm-6 col-md-3';
			break;
	}
	if ( $class )
		echo 'class="' . esc_attr($class) . '"';
}