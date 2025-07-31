<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the website, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://developer.wordpress.org/advanced-administration/wordpress/wp-config/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'gemwpnode5remote' );

/** Database username */
define( 'DB_USER', 'gridsa' );

/** Database password */
define( 'DB_PASSWORD', 'test12345' );

/** Database hostname */
define( 'DB_HOST', 'gliops.glocation.info:5434' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'T$SCh~Yc5>&$;WrHpD0m*5S#D4YXj1%l_5ETW6.0@6h!X1^Ybjj^)q(6 >)&R@N@' );
define( 'SECURE_AUTH_KEY',  '?`^ ^R>(&xy/.TXn|gOu*&bj0Ls**)NkXQQVi~e#11VUt*b>I> G:_p=vCaWM;4b' );
define( 'LOGGED_IN_KEY',    'T@K9A)+#3pn}B]NkLWp0HKA,3xuqs*]<tO%$9C&)%eOTW)WN_m%HWe+I4G}>N&bl' );
define( 'NONCE_KEY',        'RFBAx]z:/)w2_L6MXb?w8loqJ Pnm#:S~C1@BOsi}!a:^XmhA_m43:to`i}Skg?}' );
define( 'AUTH_SALT',        'D$a~D<0zXD3i((*?lAzN<)_Zer|pzq|IrRb@PM;$M}92BDV%=|:5!B-j;bSoBc;/' );
define( 'SECURE_AUTH_SALT', 'SmQ3ottAB^<C*SjQwY8H@VVdL7obcqL`PS.AHS)NqSSTYeCGHeg]w2V=GpYuu%UX' );
define( 'LOGGED_IN_SALT',   'hf8h4Qtv5,E|l;e;~*Y8KLA9;UO4:fS.R0`>!^ML+p2Q(5VK>DL9PtCbL9D^Y{_C' );
define( 'NONCE_SALT',       'F5Z<QLDiu_5uS^,<oIOH..ydH649K)~[9A.<[dpXzlP*Ry<TN-xc^|Xt%X=;!WEx' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 *
 * At the installation time, database tables are created with the specified prefix.
 * Changing this value after WordPress is installed will make your site think
 * it has not been installed.
 *
 * @link https://developer.wordpress.org/advanced-administration/wordpress/wp-config/#table-prefix
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://developer.wordpress.org/advanced-administration/debug/debug-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
