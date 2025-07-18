<?php
/**
 * The main template file
 * @package PureBlog
*/

get_header(); ?>


<div class="container">
<div class="row">
	
<?php
$bloglayout = esc_attr(get_theme_mod( 'pureblog_blog_layout', 'blog1' ));

switch ($bloglayout) {

    case "blog3":
		// centered no sidebars
        echo '<div class="content-area col-lg-12"><main id="main" class="site-main ' . esc_attr( $bloglayout ) . '">';
		// for our archive headers and custom blog intro group
		get_template_part( 'template-parts/page-headings' );		
			if ( have_posts() ) :
				while ( have_posts() ) : the_post(); get_template_part( 'template-parts/post/content', get_post_format() );	
				endwhile;	get_template_part( 'template-parts/navigation/navigation', 'blog' );
				else : get_template_part( 'template-parts/post/content', 'none' );
			endif;		
		echo '</main></div>';
        break;
    case "blog2":
		// standard blog left sidebar
        echo '<div class="content-area col-lg-8 order-lg-2"><main id="main" class="site-main ' . esc_attr( $bloglayout ) . '">';
		// for our archive headers and custom blog intro group
		get_template_part( 'template-parts/page-headings' );		
			if ( have_posts() ) :
				while ( have_posts() ) : the_post(); get_template_part( 'template-parts/post/content', get_post_format() );	
				endwhile;	get_template_part( 'template-parts/navigation/navigation', 'blog' );
				else : get_template_part( 'template-parts/post/content', 'none' );
			endif;	
		echo '</main></div><div class="col-lg-4 order-3 order-lg-1">';
		get_template_part( 'template-parts/sidebars/sidebar', 'left' );
		echo '</div>';
        break;
    default:
		// standard blog right sidebar
        echo '<div class="content-area col-lg-8"><main id="main" class="site-main ' . esc_attr( $bloglayout ) . '">';
		// for our archive headers and custom blog intro group
		get_template_part( 'template-parts/page-headings' );
			if ( have_posts() ) :
				while ( have_posts() ) : the_post(); get_template_part( 'template-parts/post/content', get_post_format() );	
				endwhile;	get_template_part( 'template-parts/navigation/navigation', 'blog' );
				else : get_template_part( 'template-parts/post/content', 'none' );
			endif;		
		echo '</main></div><div class="col-lg-4">';
		get_template_part( 'template-parts/sidebars/sidebar', 'right' );
		echo '</div>';
		
}
?>

</div>
</div>

<?php get_footer();
