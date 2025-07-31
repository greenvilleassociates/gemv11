<?php
/**
 * PureBlog: Customizer
 * @package PureBlog
 */

/**
 * Add postMessage support for site title and description for the Theme Customizer.
 * @param WP_Customize_Manager $wp_customize Theme Customizer object.
 */
function pureblog_customize_register( $wp_customize ) {
	$wp_customize->get_setting( 'blogname' )->transport          = 'postMessage';
	$wp_customize->get_setting( 'blogdescription' )->transport   = 'postMessage';
	$wp_customize->get_setting( 'header_textcolor' )->transport  = 'postMessage';

	$wp_customize->selective_refresh->add_partial( 'blogname', array(
		'selector' => '.site-title a',
		'render_callback' => 'pureblog_customize_partial_blogname',
	) );
	$wp_customize->selective_refresh->add_partial( 'blogdescription', array(
		'selector' => '.site-description',
		'render_callback' => 'pureblog_customize_partial_blogdescription',
	) );


 /**
 * Control type.
 * For Upsell content in the customizer
 */
if ( ! class_exists( 'Pureblog_Customize_Static_Text_Control' ) ){
	if ( ! class_exists( 'WP_Customize_Control' ) )
    return NULL;
		class Pureblog_Customize_Static_Text_Control extends WP_Customize_Control {
		public $type = 'static-text';
		public function esc_html__construct( $manager, $id, $args = array() ) {
			parent::__construct( $manager, $id, $args );
		}
		protected function render_content() {
			if ( ! empty( $this->label ) ) :
				?><span class="pureblog-customize-control-title"><?php echo esc_html( $this->label ); ?></span><?php
			endif;
			if ( ! empty( $this->description ) ) :
				?><div class="pureblog-description pureblog-customize-control-description"><?php

				if ( is_array( $this->description ) ) {
					$sanitized_descriptions = array_map( 'wp_kses_post', $this->description );
					echo '<p>' . implode( '</p><p>', $sanitized_descriptions ) . '</p>';					
				} else {
					echo wp_kses_post( $this->description );
				}
				?>
							
			<h1><?php esc_html_e('PureBlog Pro', 'pureblog') ?></h1>
			
			<p><?php esc_html_e('If you decide to upgrade to the pro version of this theme, use this discount code on checkout.','pureblog'); ?></p>	
			<div id="promotion-header"><p class="main-title"><?php esc_html_e('Upgrade to Pro (Save 5%)', 'pureblog') ?><br><?php esc_html_e('Use Code:', 'pureblog') ?> <strong><?php esc_html_e('SAVEFIVE', 'pureblog') ?></strong></p>
			<p><a href="https://www.bloggingthemestyles.com/wordpress-themes/pureblog-pro/" target="_blank" class="button button-primary"><?php esc_html_e('Get the Pro - Save 5%', 'pureblog') ?></a></p></div>

			<p style="font-weight: 700;"><?php esc_html_e('Pro Features:', 'pureblog') ?></p>
			<ul>
				<li><?php esc_html_e('&bull; 9 Blog Styles', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; 15 Dynamic Sidebar Positions', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Thumbnail Creation for the Blogs', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; An Author Info Widget with Social Icons', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; A Recent Posts Widget with Thumbnails', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Related Posts with Thumbnails on Posts', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Add a Video to Front Page Banner  Header', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Custom MailChimp Styles for an Optional Plugin', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; FontAwesome v5 Icons', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Add More Google Fonts', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Typography Options', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Featured Image Captions for Posts', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Blog Home Page with Customizable Title and Intro', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Custom Archive Page Headings', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Custom Widget Style', 'pureblog')?></li>
				<li><?php esc_html_e('&bull; Premium Support', 'pureblog')?></li>
			</ul>
						
			<?php
			endif;
		}
	}
}

// SECTION - UPGRADE
    $wp_customize->add_section( 'pureblog_upgrade', array(
        'title'       => esc_html__( 'Upgrade to Pro', 'pureblog' ),
        'priority'    => 0
    ) );
	
		$wp_customize->add_setting( 'pureblog_upgrade_pro', array(
			'default' => '',
			'sanitize_callback' => '__return_false'
		) );
		
		$wp_customize->add_control( new Pureblog_Customize_Static_Text_Control( $wp_customize, 'pureblog_upgrade_pro', array(
			'label'	=> esc_html__('Get The Pro Version:','pureblog'),
			'section'	=> 'pureblog_upgrade',
			'description' => array('')
		) ) );	
		
	/**
	 * Custom colors.
	 */
	$wp_customize->add_setting( 'colorscheme', array(
		'default'           => 'default',
		'transport'         => 'postMessage',
		'sanitize_callback' => 'pureblog_sanitize_colorscheme',
	) );

	$wp_customize->add_setting( 'colorscheme_hue', array(
		'default'           => 3, 
		'transport'         => 'postMessage',
		'sanitize_callback' => 'absint', // The hue is stored as a positive integer.
	) );

	$wp_customize->add_control( 'colorscheme', array(
		'type'    => 'radio',
		'label'    => esc_html__( 'Color Scheme', 'pureblog' ),
		'choices'  => array(
			'default'  => esc_html__( 'Default', 'pureblog' ),
			'dark'   => esc_html__( 'Dark', 'pureblog' ),
			'custom' => esc_html__( 'Custom', 'pureblog' ),
		),
		'section'  => 'colors',
		'priority' => 5,
	) );

	$wp_customize->add_control( new WP_Customize_Color_Control( $wp_customize, 'colorscheme_hue', array(
		'mode' => 'hue',
		'section'  => 'colors',
		'priority' => 6,
	) ) );

	
// SECTION - THEME OPTIONS
	$wp_customize->add_section( 'pureblog_theme_options', array(
		'title'    => esc_html__( 'Theme Options', 'pureblog' ),
		'priority' => 20, 
	) ); 	
	
	// Setting group for blog layout  
	$wp_customize->add_setting( 'pureblog_blog_layout', array(
		'default' => 'blog1',
		'sanitize_callback' => 'pureblog_sanitize_select',
	) );  
	$wp_customize->add_control( 'pureblog_blog_layout', array(
		  'type' => 'radio',
		  'label' => esc_html__( 'Blog Layout', 'pureblog' ),
		  'section' => 'pureblog_theme_options',
		  'choices' => array(	
				'blog1' => esc_html__( 'Standard With Right Sidebar', 'pureblog' ),	  
				'blog2' => esc_html__( 'Standard With Left Sidebar', 'pureblog' ),
				'blog3' => esc_html__( 'Centered With No Sidebar', 'pureblog' ),
		) ) );		

	// Setting group for full post (single) layout  
	$wp_customize->add_setting( 'pureblog_single_layout', array(
		'default' => 'single1',
		'sanitize_callback' => 'pureblog_sanitize_select',
	) );  
	$wp_customize->add_control( 'pureblog_single_layout', array(
		  'type' => 'radio',
		  'label' => esc_html__( 'Full Post Layout', 'pureblog' ),
		  'section' => 'pureblog_theme_options',
		  'choices' => array(	
				'single1' => esc_html__( 'Single With Right Sidebar', 'pureblog' ),	 
				'single2' => esc_html__( 'Single With Left Sidebar', 'pureblog' ), 
				'single3' => esc_html__( 'Single With No Sidebars', 'pureblog' ),
		) ) );		

		// page container width
		$wp_customize->add_setting( 'pureblog_container_width' , array(
			'default'     => 1260,
			'sanitize_callback' => 'absint',
		) );

		$wp_customize->add_control( 'pureblog_container_width', array(
			'type'        => 'range',
			'section'     => 'pureblog_theme_options',
					'label'    => esc_html__( 'Page Container Width', 'pureblog' ),
					'description' => esc_html__( 'Control the maximum width of your page containers. Default is 1260 pixels but you can go down to 960px. You can reduce this with increments of 10 pixels.', 'pureblog' ),
			'input_attrs' => array(
				'min'   => 960,
				'max'   => 1260,
				'step'  => 10,
			),
		) );		
		// site branding padding
		$wp_customize->add_setting( 'pureblog_branding_height' , array(
			'default'     => 20,
			'sanitize_callback' => 'absint',
		) );

		$wp_customize->add_control( 'pureblog_branding_height', array(
			'type'        => 'range',
			'priority'    => 10,
			'section'     => 'pureblog_theme_options',
					'label'    => esc_html__( 'Site Branding Height', 'pureblog' ),
					'description' => esc_html__( 'Control the height for the site branding area where the site title is with increments of 5 pixels.', 'pureblog' ),
			'input_attrs' => array(
				'min'   => 10,
				'max'   => 100,
				'step'  => 5,
			),
		) );	
	
	// footer logo
  	$wp_customize->add_setting( 'pureblog_footer_logo',  array(
		'default' => '',
		'sanitize_callback' => 'esc_url_raw',
   	 ) ); 	 
	$wp_customize->add_control(  new WP_Customize_Image_Control(  $wp_customize,  'pureblog_footer_logo',  array(
				   'label'      => esc_html__( 'Footer Logo', 'pureblog' ),
				   'description'	=> esc_html__( 'Add a footer logo.', 'pureblog' ),
				   'section'    => 'pureblog_theme_options',
				   'settings'   => 'pureblog_footer_logo',
			   )
		   )
	   ); 		
			
	 // Use excerpts for blog posts
	  $wp_customize->add_setting( 'pureblog_use_excerpt',  array(
		  'default' => false,
		  'sanitize_callback' => 'pureblog_sanitize_checkbox',
		) );  
	  $wp_customize->add_control( 'pureblog_use_excerpt', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Use Excerpts', 'pureblog' ),
		'description' => esc_html__( 'Use excerpts for your blog post summaries or uncheck the box to use the standard Read More tag.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	  ) );
 
    // Excerpt size
    $wp_customize->add_setting( 'pureblog_excerpt_size',  array(
            'sanitize_callback' => 'absint',
            'default'           => '55',
        ) );
    $wp_customize->add_control( 'pureblog_excerpt_size', array(
        'type'        => 'number',
        'section'     => 'pureblog_theme_options',
        'label'       => esc_html__('Excerpt Size', 'pureblog'),
		'description' => esc_html__('You can change the size of your blog summary excerpts with increments of 5 words.', 'pureblog'), 
        'input_attrs' => array(
            'min'   => 10,
            'max'   => 200,
            'step'  => 5,
        ),
    ) );		
	
	// Use FontAwesome 
	$wp_customize->add_setting( 'pureblog_enable_fontawesome',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_enable_fontawesome', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Use FontAwesome Icons', 'pureblog' ),
		'description' => esc_html__( 'You can disable Font Awesome icons from the theme if you are using a plugin instead.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	
	
	// Show read more on excerpts
	$wp_customize->add_setting( 'pureblog_show_excerpt_readmore',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_excerpt_readmore', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Continue Reading Link', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the blog excerpt Continue Reading link on blog related posts.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );		

	// Show summary category name
	$wp_customize->add_setting( 'pureblog_show_summary_cat',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_summary_cat', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Summary Category', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the category name for the post summary.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );
	
	// Show post format
	$wp_customize->add_setting( 'pureblog_show_post_format',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_format', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Format', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post format linked tag in the meta info group for the summary.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );
	
	// Show post date
	$wp_customize->add_setting( 'pureblog_show_post_date',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_date', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Date', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post date in the meta info group for the summary.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	
	
	// Show post author
	$wp_customize->add_setting( 'pureblog_show_post_author',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_author', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Author', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post author in the meta info group for the summary.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	
	
	// Show post meta comments
	$wp_customize->add_setting( 'pureblog_show_post_comments',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_comments', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Comment Link', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post comment link in the meta info group for the summary.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );		
	
	// show hide edit link
	$wp_customize->add_setting( 'pureblog_show_edit_link',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_edit_link', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Edit Link', 'pureblog' ),
		'description' => esc_html__( 'This lets you show or hide the front-end edit link on pages. When enabled, only you will see it.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );
	
	// Show author bio
	$wp_customize->add_setting( 'pureblog_authorbio',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_authorbio', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Author Bio', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the author bio information at the bottom of any post whenever you have more than one author.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );		
	
	// Show categories list
	$wp_customize->add_setting( 'pureblog_show_post_categories',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_categories', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Categories', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post list of categories', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	
	
	// Show tags
	$wp_customize->add_setting( 'pureblog_show_post_tags',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_post_tags', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show the Post Tags', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post list of tags.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );		
	
	// Show single navigation
	$wp_customize->add_setting( 'pureblog_post_nav',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_post_nav', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show Full Post Navigation', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post previous and next navigation when viewing the full article.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	

	// Show featured label
	$wp_customize->add_setting( 'pureblog_show_featured_label',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_featured_label', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show Featured Label', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the post featured label.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );
	
	// Show powered by WordPress
	$wp_customize->add_setting( 'pureblog_show_wplink',	array(
		'default' => true,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_wplink', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show Powered By WordPress', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the Powered By WordPress link in the site footer.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );	

	// Enable attachment comments
	$wp_customize->add_setting( 'pureblog_show_attachment_comments',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_attachment_comments', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show Image Attachment Page Comments', 'pureblog' ),
		'description' => esc_html__( 'If you are using a WP gallery shortcode and want to showcase your images on the custom attachment page, you can enable or disable comments for images.', 'pureblog' ),
		'section'  => 'pureblog_theme_options',
	) );		

	// Copyright
	$wp_customize->add_setting( 'pureblog_copyright', array(
		'sanitize_callback' => 'sanitize_text_field',
	) );
	$wp_customize->add_control( 'pureblog_copyright', array(
		'settings' => 'pureblog_copyright',
		'label'    => esc_html__( 'Your Copyright Name', 'pureblog' ),
		'section'  => 'pureblog_theme_options',		
		'type'     => 'text',
	) );  	


// SECTION - THUMBNAILS
	$wp_customize->add_section( 'pureblog_thumbnail_options' , array(
		'title'      => esc_html__( 'Thumbnail Options', 'pureblog' ),
		'priority' => 32,
	) );
	
	// Enable blog style 1 and 2 thumbnails
	$wp_customize->add_setting( 'pureblog_standard_thumbnails',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_standard_thumbnails', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Enable Blog Standard Thumbnail Creation', 'pureblog' ),
		'description' => esc_html__( 'When enabled, a custom thumbnail will be created for the Standard blog layout with Right" or "Left Sidebar". Images will be 750x475 pixels.', 'pureblog' ),
		'section'  => 'pureblog_thumbnail_options',
	) );	
	// Enable blog style 3 thumbnails
	$wp_customize->add_setting( 'pureblog_blogcentered_thumbnails',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_blogcentered_thumbnails', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Enable Blog Centered Thumbnail Creation', 'pureblog' ),
		'description' => esc_html__( 'When enabled, a custom thumbnail will be created for the Centered layout. Images will be 1140x625.', 'pureblog' ),
		'section'  => 'pureblog_thumbnail_options',
	) );	

	// Enable full post thumbnails
	$wp_customize->add_setting( 'pureblog_singlepost_thumbnails',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_singlepost_thumbnails', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Enable Full Post Thumbnail Creation', 'pureblog' ),
		'description' => esc_html__( 'When enabled, a custom thumbnail will be created for the Single Style 5 featured image. (Images will be 1130x450 pixels.', 'pureblog' ),
		'section'  => 'pureblog_thumbnail_options',
	) );


// ADD to COLOUR SETTINGS

// custom post tag background
 	$wp_customize->add_setting( 'pureblog_custom_tag_bg', array(
		'default'        => '#3d4a6f',
		'sanitize_callback' => 'sanitize_hex_color',
	) );	
	$wp_customize->add_control( new WP_Customize_Color_Control( $wp_customize, 'pureblog_custom_tag_bg', array(
		'label'   => esc_html__( 'Post Tag Background', 'pureblog' ),	
		'description' => esc_html__( 'This is for the background colour to the full post tags list.', 'pureblog' ),		
		'settings'   => 'pureblog_custom_tag_bg',
		'section' => 'colors',
	) ) );	
	
// custom post tag text
 	$wp_customize->add_setting( 'pureblog_custom_tag_text', array(
		'default'        => '#ffffff',
		'sanitize_callback' => 'sanitize_hex_color',
	) );	
	$wp_customize->add_control( new WP_Customize_Color_Control( $wp_customize, 'pureblog_custom_tag_text', array(
		'label'   => esc_html__( 'Post Tag Text', 'pureblog' ),	
		'description' => esc_html__( 'This is for the text colour to the full post tags list.', 'pureblog' ),		
		'settings'   => 'pureblog_custom_tag_text',
		'section' => 'colors',
	) ) );	
	
// custom post tag hover background
 	$wp_customize->add_setting( 'pureblog_custom_tag_hbg', array(
		'default'        => '#985c5c',
		'sanitize_callback' => 'sanitize_hex_color',
	) );	
	$wp_customize->add_control( new WP_Customize_Color_Control( $wp_customize, 'pureblog_custom_tag_hbg', array(
		'label'   => esc_html__( 'Post Tag Hover Background', 'pureblog' ),	
		'description' => esc_html__( 'This is for the hover background colour to the full post tags list.', 'pureblog' ),		
		'settings'   => 'pureblog_custom_tag_hbg',
		'section' => 'colors',
	) ) );	
	
// custom post tag hover text
 	$wp_customize->add_setting( 'pureblog_custom_tag_htext', array(
		'default'        => '#ffffff',
		'sanitize_callback' => 'sanitize_hex_color',
	) );	
	$wp_customize->add_control( new WP_Customize_Color_Control( $wp_customize, 'pureblog_custom_tag_htext', array(
		'label'   => esc_html__( 'Post Tag Hover Text', 'pureblog' ),	
		'description' => esc_html__( 'This is for the text hover colour to the full post tags list.', 'pureblog' ),		
		'settings'   => 'pureblog_custom_tag_htext',
		'section' => 'colors',
	) ) );		
	
	
	
	
	
	
    // ADD to HEADER SETTINGS	
    // Setting group to adjust header image height
    $wp_customize->add_setting( 'pureblog_fp_height',  array(
            'sanitize_callback' => 'absint',
            'default'           => '80',
        ) );
    $wp_customize->add_control( 'pureblog_fp_height', array(
        'type'        => 'number',
        'section'     => 'header_image',
		'priority' => 1,
        'label'       => esc_html__('Front Page Header Image Height', 'pureblog'),
		'description' => esc_html__('You can adjust the height of your front page custom header image in percentage values and 5% increments. Go as low as 25 to 100 percent.', 'pureblog'), 
        'input_attrs' => array(
            'min'   => 25,
            'max'   => 100,
            'step'  => 5,
        ),
    ) );	
	
	
    // SECTION - TYPOGRAPHY SETTINGS
    $wp_customize->add_section( 'pureblog_typography_settings', array(
        'title'       => esc_html__( 'Typography Settings', 'pureblog' ),
        'priority'    => 25
    ) ); 	


	// Enable Default Google Fonts
	$wp_customize->add_setting( 'pureblog_default_google_fonts', array(
		'default'           => true,
		'description' => esc_html__( 'This theme has a couple Google Fonts included. If you choose to use a plugin for different fonts, you can disable them.', 'pureblog' ),
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );

	$wp_customize->add_control( 'pureblog_default_google_fonts', array(
		'label'    => esc_html__( 'Enable the Default Google Fonts', 'pureblog' ),
		'section'  => 'pureblog_typography_settings',
		'type'     => 'checkbox',
	) );
	
		// First Google font url setting
	$wp_customize->add_setting('pureblog_font_url1', array(
			'default' => '',
			'sanitize_callback' => 'esc_url_raw'
		));
		$wp_customize->add_control('pureblog_font_url1', array(
			 'label' => esc_html__('First Google Font URL', 'pureblog'),
			 'section' => 'pureblog_typography_settings',
			 'type'    => 'text',
			 'description' => sprintf('%1$s <a href="%2$s" target="_blank">%3$s</a> %4$s',
				__( 'Insert first', 'pureblog' ),
				esc_url('https://www.google.com/fonts'),
				__('Google Font URL' , 'pureblog'),
				__('for embed fonts.' ,'pureblog')
				),		
		));	
		// Second Google font url setting
		$wp_customize->add_setting('pureblog_font_url2', array(
			'default' => '',
			'sanitize_callback' => 'esc_url_raw'
		));
		$wp_customize->add_control('pureblog_font_url2', array(
			 'label' => esc_html__('Second Google Font URL', 'pureblog'),
			 'section' => 'pureblog_typography_settings',
			 'type'    => 'text',
			 'description' => sprintf('%1$s <a href="%2$s" target="_blank">%3$s</a> %4$s',
				__( 'Insert second', 'pureblog' ),
				esc_url('https://www.google.com/fonts'),
				__('Google Font URL' , 'pureblog'),
				__('for embed fonts.' ,'pureblog')
				),		
		));			
			
		// Body Font family
		$wp_customize->add_setting('pureblog_body_font_family', array(
			'default' => '',
			'sanitize_callback' => 'pureblog_sanitize_strip_slashes'
		));		
		$wp_customize->add_control('pureblog_body_font_family', array(
			 'label' => esc_html__('Font Family for the Body', 'pureblog'),
			 'section' => 'pureblog_typography_settings',
			 'type'    => 'text',
			 'description' => esc_html__( 'Insert Font Family for the main body text by name and separate additional fonts with a comma.', 'pureblog' ),			
		));	
		// Heading Font family
		$wp_customize->add_setting('pureblog_heading_font_family', array(
			'default' => '',
			'sanitize_callback' => 'pureblog_sanitize_strip_slashes'
		));		
		$wp_customize->add_control('pureblog_heading_font_family', array(
			 'label' => esc_html__('Font Family for Headings', 'pureblog'),
			 'section' => 'pureblog_typography_settings',
			 'type'    => 'text',
			 'description' => esc_html__( 'Insert Font Family for the headings (and site title) by name and separate additional fonts with a comma.', 'pureblog' ),			
		));		


	// Show dropcaps
	$wp_customize->add_setting( 'pureblog_show_dropcap',	array(
		'default' => false,
		'sanitize_callback' => 'pureblog_sanitize_checkbox',
	) );  
	$wp_customize->add_control( 'pureblog_show_dropcap', array(
		'type'     => 'checkbox',
		'label'    => esc_html__( 'Show Full Post Dropcap', 'pureblog' ),
		'description' => esc_html__( 'This lets you show the drop cap style on the first letter of the first paragraph.', 'pureblog' ),
		'section'  => 'pureblog_typography_settings',
	) );	

}
add_action( 'customize_register', 'pureblog_customize_register' );


/*------------------------------------------------------------------
   SANITIZATION
------------------------------------------------------------------*/

/**
 * Sanitize the colorscheme.
 * @param string $input Color scheme.*/
function pureblog_sanitize_colorscheme( $input ) {
	$valid = array( 'default', 'dark', 'custom' );
	if ( in_array( $input, $valid, true ) ) {
		return $input;
	}
	return 'default';
}

//Checkboxes
if ( ! function_exists( 'pureblog_sanitize_checkbox' ) ) :
	function pureblog_sanitize_checkbox( $input ) {
		return ( isset( $input ) && true === (bool) $input ? true : false );
	}
endif;

// Strip Slashes
function pureblog_sanitize_strip_slashes($input) {
    return wp_kses_stripslashes($input);
}	
	
// Radio and Select	
function pureblog_sanitize_select( $input, $setting ) {
	// Ensure input is a slug.
	$input = sanitize_key( $input );
	// Get list of choices from the control associated with the setting.
	$choices = $setting->manager->get_control( $setting->id )->choices;
	// If the input is a valid key, return it; otherwise, return the default.
	return ( array_key_exists( $input, $choices ) ? $input : $setting->default );
}
	 	
// Checkbox
function pureblog_sanitize_checkbox( $input ) {
	// Boolean check 
	return ( ( isset( $input ) && true == $input ) ? true : false );
}

function pureblog_sanitize_image( $image, $setting ) {
	/*
	 * Array of valid image file types.
	 * The array includes image mime types that are included in wp_get_mime_types()
	 */
    $mimes = array(
        'jpg|jpeg|jpe' => 'image/jpeg',
        'gif'          => 'image/gif',
        'png'          => 'image/png',
    );
	// Return an array with file extension and mime_type.
    $file = wp_check_filetype( $image, $mimes );
	// If $image has a valid mime_type, return it; otherwise, return the default.
    return ( $file['ext'] ? $image : $setting->default );
}


/**
 * Render the site title for the selective refresh partial.
 * @see pureblog_customize_register()
 * @return void
 */
function pureblog_customize_partial_blogname() {
	bloginfo( 'name' );
}

/**
 * Render the site tagline for the selective refresh partial.
 * @see pureblog_customize_register()
 * @return void
 */
function pureblog_customize_partial_blogdescription() {
	bloginfo( 'description' );
}

/**
 * Return whether we're previewing the front page and it's a static page.*/
function pureblog_is_static_front_page() {
	return ( is_front_page() && ! is_home() );
}



/**
 * Bind JS handlers to instantly live-preview changes.*/
function pureblog_customize_preview_js() {
	wp_enqueue_script( 'pureblog-customize-preview', get_theme_file_uri( '/assets/js/customize-preview.js' ), array( 'customize-preview' ), '1.0', true );
}
add_action( 'customize_preview_init', 'pureblog_customize_preview_js' );

/**
 * Load dynamic logic for the customizer controls area.*/
function pureblog_panels_js() {
	wp_enqueue_script( 'pureblog-customize-controls', get_theme_file_uri( '/assets/js/customize-controls.js' ), array(), '1.0', true );
}
add_action( 'customize_controls_enqueue_scripts', 'pureblog_panels_js' );
