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
define( 'DB_NAME', 'gemwp2' );

/** Database username */
define( 'DB_USER', 'gridsa' );

/** Database password */
define( 'DB_PASSWORD', 'test12345' );

/** Database hostname */
define( 'DB_HOST', '10.128.0.9' );

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
define( 'AUTH_KEY',         ']Z?J+)thIa(T$^+`^P5?K[2y_E5cO8)[Al=X n_%Az8~X;MV8!*QL?Q@:>_wYhx-' );
define( 'SECURE_AUTH_KEY',  'e@q&ExG+oL:N-n^#*oGre]{@39[Z$`$d|)pxocNd/<S9T`C`%kj@>KVrA.0]^;%%' );
define( 'LOGGED_IN_KEY',    '*tg~SFVLn= P;=tMH9DOg]blac0LSzm}C2bM-dR!NZ-.pCk.,ITo&t0YVnB$~%9j' );
define( 'NONCE_KEY',        'e?A,Qs.*~*5{5&x-#{SKNjzGDr+PZGHm__puXB{IsVYAWCIBf[A$C/vnW2}0IjzX' );
define( 'AUTH_SALT',        'X^$bL3YW5W|OWDYx NIY(.MwtD!=QTScblOD4g>T0{O/mD#y>f@GX@qoQ]Qp.)Qv' );
define( 'SECURE_AUTH_SALT', '1>| >)9+%($.L)eQ]O^6yQU_$|:Q<d}u<WK+RXG5-Dxll6(,}>|U%^:IEqA).~Gm' );
define( 'LOGGED_IN_SALT',   '7Qk7*6hEhpg,PhF`Fc*98t9y.g8>VMN&Ud4IJ,<3l^<Tekq::2-i)|)7*f~*rc@B' );
define( 'NONCE_SALT',       '~- #yHF,@P#H<u;]Fu,XK(6[@2UCkJgHu4ytT5E*gG9<#Ye>}Z*.8<WD#)F:~> +' );

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
$table_prefix = 'wp2_';

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