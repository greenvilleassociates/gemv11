<?php
/**
 * The template for displaying image attachments
 * @package PureBlog
 */

get_header(); ?>


<div id="attachment-view">
		<main id="main" class="site-main">

			<?php
				while ( have_posts() ) : the_post();
			?>

				<article id="post-<?php the_ID(); ?>" <?php post_class(); ?>>

					<header class="entry-header">
						<?php the_title( '<h1 class="entry-title">', '</h1>' ); ?>
					</header><!-- .entry-header -->

					<div class="entry-content">

						<div class="entry-attachment">
						<div id="attachment-wrapper">
							<?php
								$image_size = apply_filters( 'pureblog_attachment_size', 'large' );
								echo wp_get_attachment_image( get_the_ID(), $image_size );
							?>
						</div>
						
							<?php if ( has_excerpt() ) : ?>
								<div class="entry-caption">
									<?php the_excerpt(); ?>
								</div><!-- .entry-caption -->
							<?php endif; ?>

						</div><!-- .entry-attachment -->

						<?php
							the_content();
						?>
					</div><!-- .entry-content -->

					<footer class="entry-footer">
					<nav id="image-navigation" class="navigation image-navigation">
						<div class="nav-links">
							<div class="prev-image"><?php previous_image_link( false, __( 'Previous Image', 'pureblog' ) ); ?></div>
							<div class="next-image"><?php next_image_link( false, __( 'Next Image', 'pureblog' ) ); ?></div>
						</div><!-- .nav-links -->
					</nav><!-- .image-navigation -->
					</footer><!-- .entry-footer -->

				</article><!-- #post-## -->

			
				<?php
					// If comments are open or we have at least one comment, load up the comment template
					if (esc_attr(get_theme_mod( 'pureblog_show_attachment_comments', false ) ) &&  comments_open() || get_comments_number() ) :
						comments_template();
					endif;
				// End the loop.
				endwhile;
			?>

		</main><!-- .site-main -->
</div>

<?php get_footer(); ?>
