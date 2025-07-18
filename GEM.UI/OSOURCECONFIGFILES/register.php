<?php
// Include the Joomla framework
define('_JEXEC', 1);
define('JPATH_BASE', realpath(dirname(__FILE__)));
require_once(JPATH_BASE . '/includes/defines.php');
require_once(JPATH_BASE . '/includes/framework.php');

// Initialize the Joomla application
$app = JFactory::getApplication('site');
defined('_JEXEC') or die;

// Load the user model
jimport('joomla.user.helper');

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Retrieve posted data
    $username = $_POST['username'];
    $password = $_POST['password'];
    $email = $_POST['email'];
    
    // Prepare the user data
    $data = array(
        "name" => $username,
        "username" => $username,
        "password" => $password,
        "password2" => $password, // Confirm password
        "email" => $email,
        "block" => 0,
        "groups" => array("2") // Default to Registered group
    );
    
    // Create the user
    $user = new JUser;
    if (!$user->bind($data)) {
        echo "Error: " . $user->getError();
    }
    
    if (!$user->save()) {
        echo "Error: " . $user->getError();
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
        echo "Account created successfully!";
    }
}
else {
    // Display the login form
    ?>
<form action="" method="post">
        <label for="username">Username:</label><br>
        <input type="text" id="username" name="username" required><br>
        
        <label for="password">Password:</label><br>
        <input type="password" id="password" name="password" required><br>
        
        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" required><br>
        
        <input type="submit" value="Create Account">
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
        window.open('https://gridmanager3.590team1.info/fusionpro/registrationsuccess.html','_self');
    </script>
</body>
  

</html>
