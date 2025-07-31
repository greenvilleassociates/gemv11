<?php
// Include the Joomla framework
define('_JEXEC', 1);
define('JPATH_BASE', realpath(dirname(__FILE__)));
require_once(JPATH_BASE . '/includes/defines.php');
require_once(JPATH_BASE . '/includes/framework.php');

// Initialize the Joomla application
$app = JFactory::getApplication('site');

// Check if form is submitted
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    // Get the username and password from the form
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Get the user object
    $credentials = array(
        'username' => $username,
        'password' => $password,
    );

    // Perform the login action
    $options = array(
        'remember' => true,
        'return' => '',
    );

    $result = $app->login($credentials, $options);

    if ($result === true) {
        // Get the logged-in user object
        $user = JFactory::getUser();
        
        // Display the user ID
        echo 'Login successful! User ID: ' . $user->id;
	$sjid = $user->id;
	$sjemail = $user->email;
	$sjname = $user->name;
	
	echo "<script>var yname = '$xxxname';
	var ssoname = '$sjname';
	var ssoid = '$sjid';
	var ssoemail = '$sjemail';
	var now = new Date();
	document.write(now);
	</script>";
	} else {
        echo 'Login failed!';
    }
}
else {
    // Display the login form
    ?>
    <form action="" method="post">
        <label for="username">Username:</label>
        <input type="text" id="username" name="username" required><br>

        <label for="password">Password:</label>
        <input type="password" id="password" name="password" required><br>

        <input type="submit" value="Login">
    </form>
    <?php
}
?>
<html>
<body>
<script type="text/javascript">
        var x = "<?php echo"$jidnumber"?>";
    
        localStorage.setItem("jname", ssoname);
        localStorage.setItem("jid", ssoid);
        localStorage.setItem("jemail", ssoemail);
        localStorage.setItem("testsum", "100");
        localStorage.setItem("jstatus", "loggedin");
        localStorage.setItem("jtime", now);
        window.open('https://gridmanager5.590team1.info/fusionpro/index.html','_self');
    </script>
</body>
  

</html>