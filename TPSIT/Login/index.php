<!DOCTYPE html>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h2 style="padding: 10px;">Area login</h2>
    <form style="padding: 10px;" action="login.php" method="post">
        <input type="text" placeholder="Nome utente" name="nomeUtente" value="<?php
            if(isset($_COOKIE["nomeUtente"]))
                echo ($_COOKIE["nomeUtente"]);
            else
                echo "";
           ?>"/><br>
        <input type="Password" placeholder="Password" name="password" value="<?php
            if(isset($_COOKIE["password"]))
                echo ($_COOKIE["password"]);
            else
                echo "";
        ?>"/><br>
        <input type="checkbox" name="cookie" checked="checked">Ricordami</input><br>
        <button>Login</button>
        <button formaction="registra.html">Crea un account</button>
    </form>
</body>
</html>