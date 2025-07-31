<?php
/**
 * Template part for displaying post navigation - next and previous posts
 * @link https://codex.wordpress.org/Template_Hierarchy
 * @package PureBlog
*/

the_post_navigation( array(
	'next_text' => '<span class="meta-nav" aria-hidden="true">' . esc_html__( 'Next Post - ', 'pureblog' ) . '</span> ' .
		'<span class="screen-reader-text">' . esc_html__( 'Next post:', 'pureblog' ) . '</span> ' .
		'<span class="post-title">%title</span>',
	'prev_text' => '<span class="meta-nav" aria-hidden="true">' . esc_html__( 'Previous Post - ', 'pureblog' ) . '</span> ' .
		'<span class="screen-reader-text">' . esc_html__( 'Previous post:', 'pureblog' ) . '</span> ' .
		'<span class="post-title">%title</span>',
) );	
				
				
?>