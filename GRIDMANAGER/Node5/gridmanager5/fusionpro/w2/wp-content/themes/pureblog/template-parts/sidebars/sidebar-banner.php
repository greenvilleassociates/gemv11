<?php
/**
 * For displaying banner
 * @package PureBlog
*/

if ( ! is_active_sidebar( 'banner' ) ) {
	return;
}
?>
	
<?php if ( is_active_sidebar( 'banner' ) ) : ?>
		<div id="banner" class="widget-area">
			<?php dynamic_sidebar( 'banner' ); ?>
		</div>
<?php endif; ?>