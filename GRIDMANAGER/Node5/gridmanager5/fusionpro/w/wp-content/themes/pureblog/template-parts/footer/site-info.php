<?php
/**
 * Displays footer site info
 * @package PureBlog
*/

?>
<div id="site-info" class="footer-copyright">  
  			
		<?php esc_html_e('Copyright &copy;', 'pureblog'); ?> 
		<?php echo date_i18n( __( 'Y', 'pureblog' ) ); // WPCS: XSS OK ?>
		<?php echo esc_html(get_theme_mod( 'pureblog_copyright' )); ?>. <?php esc_html_e('All rights reserved.', 'pureblog'); ?>	
				
		
		<?php if (esc_attr(get_theme_mod( 'pureblog_show_wplink', true ))) : ?>	
			<p><a href="<?php echo esc_url( __( 'https://wordpress.org/', 'pureblog' ) ); ?>">
			<?php printf( 
			/* translators: %s: WordPress. */
			esc_html__( 'Proudly powered by %s', 'pureblog' ), 'WordPress' ); ?></a></p>		
		<?php endif; ?>	
		
</div>
			
