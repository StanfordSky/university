<?php

/*echo '<pre>' . print_r($_POST, 1) . "</pre>";
echo '<pre>' . print_r($_FILES, 1) . "</pre>";*/



if(isset($_SESSION['user']) || empty($_POST['username']) || empty($_POST['email']) || empty($_POST['password']) || empty($_FILES)){
        header("Location: /");
    }


    $datatype = explode('/', $_FILES['avatar']['type']);
    if($datatype[0] != "image"){
        header("Location: /");
    }

    $uploaddir = '/avatars/';
    $uploadfile = $uploaddir . date('ymdhms') . '.' .$datatype[1];

    if (move_uploaded_file($_FILES['avatar']['tmp_name'], $uploadfile)) {
        echo "Файл корректен и был успешно загружен.\n";
    } else {
        echo "Возможная атака с помощью файловой загрузки!\n";
    }
?>