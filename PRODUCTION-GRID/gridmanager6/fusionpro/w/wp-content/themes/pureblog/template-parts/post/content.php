<?php
/**
 * Template part for displaying posts
 * @link https://codex.wordpress.org/Template_Hierarchy
 * @package PureBlog
 */
 $bloglayout = esc_attr(get_theme_mod( 'pureblog_blog_layout', 'blog1' ));
?>

    <article id="post-<?php the_ID(); ?>" <?php post_class(); ?>>

        <?php if ( '' !== get_the_post_thumbnail() ) : ?>
        <div class="post-thumbnail">
            <a href="<?php echo esc_url( get_the_permalink() ); ?>">
                <?php 
				if ( $bloglayout == 'blog1' || $bloglayout == 'blog2' )  :
					the_post_thumbnail( 'pureblog-standard' ); 
				elseif ( $bloglayout == 'blog3')  :
					the_post_thumbnail( 'pureblog-centered' ); 	
				else :
					the_post_thumbnail( 'post-thumbnails' ); 
				endif;				
				?>
            </a>
        </div>
        <!-- .post-thumbnail -->
        <?php endif; ?>
        <header class="entry-header">

		<?php 
		// get our first category
			if( esc_attr(get_theme_mod( 'pureblog_show_summary_cat', true ) ) ) {
				pureblog_get_first_cat_name();
			}
			?>
		
            <?php		
		if ( is_front_page() && is_home() ) {
			if ( is_sticky() && is_home() && ! is_paged() && esc_attr(get_theme_mod( 'pureblog_show_featured_label', 1 )) ) :
				printf( '<span class="featured-post">%s</span>', esc_html__( 'Featured', 'pureblog' ) );
			endif;
			the_title( '<h3 class="entry-title"><a href="' . esc_url( get_permalink() ) . '" rel="bookmark">', '</a></h3>' );
		} else {
			if ( is_sticky() && is_home() && ! is_paged() && esc_attr(get_theme_mod( 'pureblog_show_featured_label', 1 )) ) :
				printf( '<span class="featured-post">%s</span>', esc_html__( 'Featured', 'pureblog' ) );
			endif;
			the_title( '<h2 class="entry-title"><a href="' . esc_url( get_permalink() ) . '" rel="bookmark">', '</a></h2>' );
		}	
		?>
				
				<?php // get the post meta information - each one can be disabled.
					if ( 'post' === get_post_type() ) {
						echo '<ul class="entry-meta">';
						if( esc_attr(get_theme_mod( 'pureblog_show_post_format', true ) ) ) :
							pureblog_post_format();
						endif;									
						if( esc_attr(get_theme_mod( 'pureblog_show_post_date', true ) ) ) :
							pureblog_posted_on();
						endif;	
						if( is_multi_author() && esc_attr(get_theme_mod( 'pureblog_show_post_author', false ) ) ) :	
							pureblog_posted_by();
						endif;
						if( esc_attr(get_theme_mod( 'pureblog_show_post_comments', false ) ) ) :	
							pureblog_comments_count();
						endif;	
							echo '</ul>';
					} 							
												
				?>		

        </header>

        <div class="entry-content">
		
		<?php if ( $bloglayout == 'blog1' || $bloglayout == 'blog2' || $bloglayout == 'blog3' ) :
						if ( esc_attr(get_theme_mod( 'pureblog_use_excerpt', false )) ) :
					   the_excerpt();
					else :
					
					the_content( sprintf(
					/* translators: %s: Name of current post */
						__( 'Read More<span class="screen-reader-text"> "%s"</span>', 'pureblog' ),
						get_the_title()
					) );
					endif;
			else :
				the_excerpt();			
		endif;
		
			wp_link_pages( array(
					'before'      => '<div class="page-links"><span class="page-links-title">' . __( 'Pages:', 'pureblog' ) . '</span>',
					'after'       => '</div>',
					'link_before' => '<span>',
					'link_after'  => '</span>',
					'pagelink'    => '<span class="sr-only">' . __( 'Page', 'pureblog' ) . ' </span>%',
					'separator'   => '<span class="sr-only">, </span>',
			) );
		?>
		
        </div>

    </article>
