<?php
/**
 * Template part for the blog navigation - previous and next
 *
 * @link https://codex.wordpress.org/Template_Hierarchy
 * @package PureBlog
*/

the_posts_pagination( array(
	'prev_text' => '<span class="prev">' . esc_html__( 'Previous page', 'pureblog' ) . '</span>',
	'next_text' => '<span class="next">' . esc_html__( 'Next page', 'pureblog' ) . '</span>',
	'before_page_number' => '<span class="meta-nav sr-only">' . esc_html__( 'Page', 'pureblog' ) . ' </span>',
) );


?>