<?php
/**
 * For displaying breadcrumbs
 * @package PureBlog 
*/

if ( ! is_active_sidebar( 'breadcrumbs' ) ) {
	return;
}
?>

<div class="row">
<div class="col-md-12">
		<div id="breadcrumbs" class="widget-area">
			<?php dynamic_sidebar( 'breadcrumbs' ); ?>
		</div> 
</div>
</div>