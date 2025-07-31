<?php
/**
 * Displays header media
 * @package PureBlog
*/

?>
<div class="custom-header">

		<div class="custom-header-media">
			<?php // Only show custom header on front page
			if (is_front_page()) :
				the_custom_header_markup(); 
			endif; ?>
		</div>

	<?php get_template_part( 'template-parts/header/site', 'branding' ); ?>

</div><!-- .custom-header -->
