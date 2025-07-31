<?php
/**
 * Custom template tags for this theme
 * Eventually, some of the functionality here could be replaced by core features.
 * @package PureBlog
 */

  
if ( ! function_exists( 'pureblog_post_format' ) ) :
	function pureblog_post_format() {
		
	$bloglayout = esc_attr(get_theme_mod( 'pureblog_blog_layout', 'blog1' ));
 	if( esc_attr(get_theme_mod( 'pureblog_show_post_format', true ) ) ) :
		// Show the post format label
		$format = get_post_format();
		if ( current_theme_supports( 'post-formats', $format ) ) {
			printf( '<li class="entry-format"><a href="%1$s">%2$s</a></li>',
				esc_url( get_post_format_link( $format ) ),
				esc_html( get_post_format_string( $format ) )
			);
		}
	endif;
	}
endif;
	
// Prints HTML with meta information for the current post-date/time.
if ( ! function_exists( 'pureblog_posted_on' ) ) :
	function pureblog_posted_on() {
		$time_string = '<time class="entry-date published updated" datetime="%1$s">%2$s</time>';
		if ( get_the_time( 'U' ) !== get_the_modified_time( 'U' ) ) {
			$time_string = '<time class="entry-date published" datetime="%1$s">%2$s</time><time class="updated" datetime="%3$s">%4$s</time>';
		}
		$time_string = sprintf( $time_string,
			esc_attr( get_the_date( 'c' ) ),
			esc_html( get_the_date() ),
			esc_attr( get_the_modified_date( 'c' ) ),
			esc_html( get_the_modified_date() )
		);
		$posted_on = sprintf(
			/* translators: %s: post date. */
			_x( 'Posted on %s', 'post date', 'pureblog' ),
			'<a href="' . esc_url( get_permalink() ) . '" rel="bookmark">' . $time_string . '</a>'
		);
		echo '<li class="posted-on">' . $posted_on . '</li>'; // WPCS: XSS OK.
	}
endif;

// Prints HTML with meta information for the current author.
if ( ! function_exists( 'pureblog_posted_by' ) ) :
	function pureblog_posted_by() {
		$byline = sprintf(
			/* translators: %s: post author. */
			_x( 'by %s', 'post author', 'pureblog' ),
			'<span class="author vcard"><a class="url fn n" href="' . esc_url( get_author_posts_url( get_the_author_meta( 'ID' ) ) ) . '">' . esc_html( get_the_author() ) . '</a></span>'
		);
		echo '<li class="byline"> ' . $byline . '</li>'; // WPCS: XSS OK.
	}
endif;

if ( ! function_exists( 'pureblog_comments_count' ) ) :
	function pureblog_comments_count() {
		// Add the comments link to the post meta info
		if ( ! post_password_required() && ( comments_open() || get_comments_number() ) ) {
			echo '<li class="comments-link">';
			comments_popup_link(
				sprintf(
					wp_kses(
						/* translators: %s: post title */
						__( 'Comment<span class="screen-reader-text"> on %s</span>', 'pureblog' ),
						array(
							'span' => array(
								'class' => array(),
							),
						)
					),
					get_the_title()
				)
			);
			echo '</li>';
		}
}

endif;

// Get just the first category name for our slides
function pureblog_get_first_cat_name() {
	if ( 'post' === get_post_type() ) {
		$cats = get_the_category();
		echo '<div class="post-categories">' . esc_html( $cats[0]->name ) . '</div>';
	}
}

// Add categories to the post meta info
if ( ! function_exists( 'pureblog_categories' ) ) :
function pureblog_categories() {
		
		// Add categories to the post meta info
		$categories_list = get_the_category_list( esc_html__( ', ', 'pureblog' ) );
		if ( $categories_list ) {
			/* translators: 1: list of categories. */
			printf( '<li class="cat-links">' . esc_html__( 'In %1$s', 'pureblog' ) . '</li>', $categories_list ); // WPCS: XSS OK.
		}
	}
endif;


if ( ! function_exists( 'pureblog_entry_footer' ) ) :

	//Prints HTML with meta information for the tags
	function pureblog_entry_footer() {
		
		// Hide category and tag text for pages.
		if ( 'post' === get_post_type() ) {			
			// Get tag list
			if(get_the_tag_list()) {
				echo wp_kses_post(get_the_tag_list('<ul class="tag-list"><li>','</li><li>','</li></ul>'));
			}
		}	
	}
endif;


if ( ! function_exists( 'pureblog_entry_footer' ) ) :
/**
 * Prints HTML with meta information for the categories, tags and comments.*/
function pureblog_entry_footer() {

	/* translators: used between list items, there is a space after the comma */
	$separate_meta = __( ', ', 'pureblog' );

	// Get Categories for posts.
	$categories_list = get_the_category_list( $separate_meta );

	// Get Tags for posts.
	$tags_list = get_the_tag_list( '', $separate_meta );

	// We don't want to output .entry-footer if it will be empty, so make sure its not.
	if ( ( ( pureblog_categorized_blog() && $categories_list ) || $tags_list ) || get_edit_post_link() ) {

		echo '<footer class="entry-footer">';

			if ( 'post' === get_post_type() ) {
				if ( ( $categories_list && pureblog_categorized_blog() ) || $tags_list ) {
					echo '<div id="cat-tags-block">';

						// Make sure there's more than one category before displaying.
						if ( $categories_list && esc_attr(get_theme_mod( 'pureblog_show_post_categories', true )) && pureblog_categorized_blog() ) {
							echo '<div id="category-list"><span class="cat-links">' . esc_html__( 'Categories: ', 'pureblog' ) . esc_html($categories_list) . '</span></div>';
						}

						if ( $tags_list && esc_attr(get_theme_mod( 'pureblog_show_post_tags', true ))) {
							echo '<div id="tag-list"><span class="tag-links">' . esc_html__( 'Tags: ', 'pureblog' ) . esc_html($tags_list) . '</span></div>';
						}

					echo '</div>';
				}
			}

		echo '</footer>';
	}
}
endif;


if ( ! function_exists( 'pureblog_edit_link' ) ) :
/**
 * Returns an accessibility-friendly link to edit a post or page.
 *
 * This also gives us a little context about what exactly we're editing
 * (post or page?) so that users understand a bit more where they are in terms
 * of the template hierarchy and their content. Helpful when/if the single-page
 * layout with multiple posts/pages shown gets confusing.*/
function pureblog_edit_link() {
	edit_post_link(
		sprintf(
			/* translators: %s: Name of current post */
			__( 'Edit <span class="screen-reader-text"> "%s"</span>', 'pureblog' ),
			get_the_title()
		),
		'<span class="edit-link">',
		'</span>'
	);
}
endif;


/**
 * Returns true if a blog has more than 1 category.
 * @return bool*/
function pureblog_categorized_blog() {
	$category_count = get_transient( 'pureblog_categories' );

	if ( false === $category_count ) {
		// Create an array of all the categories that are attached to posts.
		$categories = get_categories( array(
			'fields'     => 'ids',
			'hide_empty' => 1,
			// We only need to know if there is more than one category.
			'number'     => 2,
		) );

		// Count the number of categories that are attached to the posts.
		$category_count = count( $categories );

		set_transient( 'pureblog_categories', $category_count );
	}

	// Allow viewing case of 0 or 1 categories in post preview.
	if ( is_preview() ) {
		return true;
	}

	return $category_count > 1;
}


/**
 * Flush out the transients used in pureblog_categorized_blog.*/
function pureblog_category_transient_flusher() {
	if ( defined( 'DOING_AUTOSAVE' ) && DOING_AUTOSAVE ) {
		return;
	}
	// Like, beat it. Dig?
	delete_transient( 'pureblog_categories' );
}
add_action( 'edit_category', 'pureblog_category_transient_flusher' );
add_action( 'save_post',     'pureblog_category_transient_flusher' );
