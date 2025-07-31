<?php
/**
 * Theme Info Page
 * Special thanks to the Consulting theme by ThinkUpThemes for this info page to be used as a foundation.
 * @package PureBlog
 */
 
function pureblog_info() {    


	// About page instance
	// Get theme data
	$theme_data     = wp_get_theme();

	// Get name of parent theme

		$theme_name    = trim( ucwords( str_replace( ' (Lite)', '', $theme_data->get( 'Name' ) ) ) );
		$theme_slug    = trim( strtolower( str_replace( ' (Lite)', '-lite', $theme_data->get( 'Name' ) ) ) );
		$theme_version = $theme_data->get( 'Version' );

	$config = array(
		// translators: %1$s: menu title under appearance
		'menu_name'             => sprintf( esc_html__( 'About %1$s', 'pureblog' ), ucfirst( $theme_name ) ),
		// translators: %1$s: page name 
		'page_name'             => sprintf( esc_html__( 'About %1$s', 'pureblog' ), ucfirst( $theme_name ) ),
		// translators: %1$s: welcome title 
		'welcome_title'         => sprintf( esc_html__( 'Welcome to %1$s - v', 'pureblog' ), ucfirst( $theme_name ) ),
		// translators: %1$s: welcome content 
		'welcome_content'       => sprintf( esc_html__(  '%1$s is simple, yet modern & stylish for personal blogging. We made PureBlog with features from the ever popular WordPress theme called Twenty Seventeen, but with a lot more features to give your readers a immersive browsing experience. PureBlog is a polished & beautifully balanced concept that makes it perfect for almost any type of blog. PureBlog comes with an array of features that let you choose your blog style layouts, show or hide various page elements, choose excerpts for blog summaries, adjust your banner height, colour options, and a whole lot more!', 'pureblog' ), ucfirst( $theme_name ) ),
		
		/**
		 * Tabs array.
		 *
		 * The key needs to be ONLY consisted from letters and underscores. If we want to define outside the class a function to render the tab,
		 * the will be the name of the function which will be used to render the tab content.
		 */
		'upgrade'             => array(
			'upgrade_url'     => 'https://www.bloggingthemestyles.com/wordpress-themes/pureblog-pro/',
			'price_discount'  => __( 'Upgrade and Save 5%', 'pureblog' ),
			'price_normal'	  => __( 'Use coupon at checkout.', 'pureblog' ),
			'coupon'	      =>  __( 'SAVEFIVE', 'pureblog' ),
			'button'	      => __( 'Get the Pro', 'pureblog' ),
		),		
		'tabs'                 => array(
			'getting_started'  => esc_html__( 'Getting Started', 'pureblog' ),
			'support_content'  => esc_html__( 'Support', 'pureblog' ),
			'changelog'           => esc_html__( 'Changelog', 'pureblog' ),
			'free_pro'         => esc_html__( 'Free VS PRO', 'pureblog' ),
		),
		// Getting started tab
		'getting_started' => array(
			'first' => array (
				'title'               => esc_html__( 'Setup Documentation', 'pureblog' ),
				'text'                => sprintf( esc_html__( 'To help you get started with the initial setup of this theme and to learn about the various features, you can check out our detailed setup documentation.', 'pureblog' ) ),
				// translators: %1$s: theme name 
				'button_label'        => sprintf( esc_html__( 'View %1$s Tutorials', 'pureblog' ), ucfirst( $theme_name ) ),
				'button_link'         => esc_url( '//www.bloggingthemestyles.com/documentation/' ),
				'is_button'           => true,
				'recommended_actions' => false,
                'is_new_tab'          => true,
			),
			'second' => array(
				'title'               => esc_html__( 'Go to Customizer', 'pureblog' ),
				'text'                => esc_html__( 'Using the WordPress Customizer, you can easily customize every aspect of the theme.', 'pureblog' ),
				'button_label'        => esc_html__( 'Go to Customizer', 'pureblog' ),
				'button_link'         => esc_url( admin_url( 'customize.php' ) ),
				'is_button'           => true,
				'recommended_actions' => false,
                'is_new_tab'          => true,
			),
			
			'third' => array(
				'title'               => esc_html__( 'Using a Child Theme', 'pureblog' ),
				'text'                => sprintf( esc_html__( 'If you plan to customize this theme, I recommend looking into using a child theme. To learn more about child themes and why it\'s important to use one, check out the WordPress documentation.', 'pureblog' ) ),
				'button_label'        => sprintf( esc_html__( 'Child Themes', 'pureblog' ), ucfirst( $theme_name ) ),
				'button_link'         => esc_url( '//developer.wordpress.org/themes/advanced-topics/child-themes/' ),
				'is_button'           => true,
				'recommended_actions' => false,
                'is_new_tab'          => true,
			),		
		),

		// Changelog content tab.
		'changelog'      => array(
			'first' => array (				
				'title'        => esc_html__( 'Changelog', 'pureblog' ),
				'text'         => esc_html__( 'I generally recommend you always read the CHANGELOG before updating so that you can see what was fixed, changed, deleted, or added to the theme.', 'pureblog' ),	
				'button_label' => '',
				'button_link'  => '',
				'is_button'    => false,
				'is_new_tab'   => false,				
				),
		),			
		// Support content tab.
		'support_content'      => array(
			'first' => array (
				'title'        => esc_html__( 'Free Support', 'pureblog' ),
				'icon'         => 'dashicons dashicons-sos',
				'text'         => esc_html__( 'If you experience any problems, please post your questions to support and we will be more than happy to help you out.', 'pureblog' ),
				'button_label' => esc_html__( 'Get Free Support', 'pureblog' ),
				'button_link'  => esc_url( '//www.bloggingthemestyles.com/support' ),
				'is_button'    => true,
				'is_new_tab'   => true,
			),
			'second' => array(
				'title'        => esc_html__( 'Common Problems', 'pureblog' ),
				'icon'         => 'dashicons dashicons-editor-help',
				'text'         => esc_html__( 'For quick answers to the most common problems, you can check out the tutorials which can provide instant solutions and answers.', 'pureblog' ),
				'button_label' => sprintf( esc_html__( 'Get Answers', 'pureblog' ) ),
				'button_link'  => '//www.bloggingthemestyles.com/common-problems',
				'is_button'    => true,
				'is_new_tab'   => true,
			),

		),	
		// Free vs pro array.
		'free_pro'                => array(
			'free_theme_name'     => ucfirst( $theme_name ) . ' (free)',
			'pro_theme_name'      => esc_html__('PureBlog','pureblog' ),
			'pro_theme_link'      => '//www.bloggingthemestyles.com/wordpress-themes/pureblog-pro/',
			'get_pro_theme_label' => sprintf( esc_html__( 'Get PureBlog', 'pureblog' ) ),
			'features'            => array(
				array(
					'title'            => esc_html__( 'Mobile Friendly', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),		
				array(
					'title'            => esc_html__( 'Unlimited Colours', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),						
				array(
					'title'            => esc_html__( 'Built-In Social Menu', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),
				array(
					'title'            => esc_html__( 'Show or Hide Elements', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),				
				array(
					'title'            => esc_html__( 'Custom Error Page', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),		
				
				array(
					'title'            => esc_html__( 'Blog Styles', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '3',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '9',
					'hidden'           => '',
				),				
				array(
					'title'            => esc_html__( 'Sidebar Positions', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '10',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '15',
					'hidden'           => '',
				),
				array(
					'title'            => esc_html__( 'Page Templates', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'true',
					'is_in_lite_text'  => '4',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '4',
					'hidden'           => '',
				),
			
				array(
					'title'            => esc_html__( 'Theme Options', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => '',
					'is_in_lite_text'  => 'Basic',
					'is_in_pro'        => '',
					'is_in_pro_text'   => 'Advanced',
					'hidden'           => '',
				),		
				array(
					'title'            => esc_html__( 'Support', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => '',
					'is_in_lite_text'  => 'Basic',
					'is_in_pro'        => '',
					'is_in_pro_text'   => 'Premium',
					'hidden'           => '',
				),				

				array(
					'title'            => esc_html__( 'Custom Blog Title &amp; Introduction', 'pureblog' ),
					'description'      => esc_html__('WordPress does not have this, but we have added a customizable blog title and intro option.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),				
				array(
					'title'            => esc_html__( 'Blog Thumbnail Creation', 'pureblog' ),
					'description'      => esc_html__('Automatically have post featured images cropped when uploading for up to 14 blog styled layouts.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),						
				array(
					'title'            => esc_html__( 'Author Widget', 'pureblog' ),
					'description'      => esc_html__('We included a custom widget for an author photo plus social links.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),		
				array(
					'title'            => esc_html__( 'Recent Posts Widget with Thumbnails', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),	
				array(
					'title'            => esc_html__( 'Related Posts with Thumbnails', 'pureblog' ),
					'description'      => '',
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),	
				
				array(
					'title'            => esc_html__( 'MailChimp Widget Styling', 'pureblog' ),
					'description'      => esc_html__('We included custom styling for an optional MailChimp widget.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),		
				array(
					'title'            => esc_html__( 'Video Front Page Header', 'pureblog' ),
					'description'      => esc_html__('Add a video to your front page header banner area instead of a static image.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),					
				array(
					'title'            => esc_html__( 'Add Google Fonts', 'pureblog' ),
					'description'      => esc_html__('Add up to 2 more Google Fonts.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),
				array(
					'title'            => esc_html__( 'FontAwesome 5', 'pureblog' ),
					'description'      => esc_html__('Although the free version includes FontAwesome 4, the Pro includes the option of FontAwesome 5.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),					
				array(
					'title'            => esc_html__( 'Typography Options', 'pureblog' ),
					'description'      => esc_html__('Includes several settings for the main elements of your web page like headings, content, and more.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),	
				array(
					'title'            => esc_html__( 'Custom Widget Style', 'pureblog' ),
					'description'      => esc_html__('You get the option to enable a custom widget style for the left and right sidebar positions.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),					
				array(
					'title'            => esc_html__( 'Custom Styled Archive Titles', 'pureblog' ),
					'description'      => esc_html__('We customized the style of archive titles for tags, categories, etc.', 'pureblog'),
					'is_in_lite'       => 'false',
					'is_in_lite_text'  => '',
					'is_in_pro'        => 'true',
					'is_in_pro_text'   => '',
					'hidden'           => '',
				),					
		
				
			),
		),
	);
	pureblog_info_page::init( $config );

}

add_action('after_setup_theme', 'pureblog_info');

?>