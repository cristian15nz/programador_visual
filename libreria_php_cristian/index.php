<?php

// Conexion a la Base de Datos
$server="127.0.0.1";
$user="root";
$pass="";
$db="libreria";
$link=mysql_connect($server,$user,$pass) or die("Error al conectar al servidor").mysql_error();
mysql_select_db($db) or die("Error al seleccionar la bd.").mysql_error();

// Verificar si el usuario presionó Guardar
if (isset($_POST['guardar'])) {
	$id_pub = $_POST['id_publicador'];
	$nombre_pub = $_POST['nombre_publicador'];
	$ciudad = $_POST['ciudad_publicador'];
    $estado = $_POST['estado_publicador'];

    // Ejecutar el INSERT
	$sql = "INSERT INTO publicadores(id_pub, nombre_pub, ciudad, estado) VALUES('$id_pub','$nombre_pub','$ciudad','$estado')";
    $re = mysql_query($sql) or die("Error al insertar datos") . mysql_error();
}

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Libreria Cristian</title>

    <!-- Include Bootstrap -->
    <link rel="stylesheet" href="css/bootstrap.css">

    <!-- Include FontAwesome -->
    <!-- <link rel="stylesheet" href="css/fontawesome.css"> -->

    <!-- Include Custom CSS -->
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <nav class="navbar navbar-dark bg-dark">
        <div class="container">
            <a href="#" class="navbar-brand">Libreria Cristian</a>
        </div>
    </nav>

    <nav aria-label="breadcrumb">
        <ol class="breadcrumb container">
            <li class="breadcrumb-item"><a href="#">Inicio</a></li>
            <li class="breadcrumb-item active" aria-current="page">Publicaciones</li>
        </ol>
    </nav>

    <main>
        <div class="container">
        <div class="row">
            <div class="col-md-3">
                <div class="list-group">
                    <a href="#" class="list-group-item">Autores</a>
                    <a href="#" class="list-group-item">Biografias</a>
                    <a href="#" class="list-group-item">Fotografias</a>
                    <a href="#" class="list-group-item active">Publicadores</a>
                    <a href="#" class="list-group-item">Tiendas</a>
                    <a href="#" class="list-group-item">Titulos</a>
                    <a href="#" class="list-group-item">Ventas</a>
                </div>
            </div>
            <div class="col-md-5">
                <h4>Agregar Publicador</h4>
                <form action="index.php" method="POST">
                    <div class="form-group">
                        <label for="id_publicador" class="label">ID</label>
                        <input type="text" class="form-control" name="id_publicador">
                    </div>
                    <div class="form-group">
                        <label for="nombre_publicador">Nombre</label>
                        <input type="text" class="form-control" name="nombre_publicador">
                    </div>
                    <div class="form-group">
                        <label for="ciudad_publicador">Ciudad</label>
                        <select class="form-control" name="ciudad_publicador">
                            <option value="Santiago" selected="selected">Santiago</option>
                            <option value="La Vega">La vega</option>
                            <option value="Puerto Plata">Puerto Plata</option>
                            <option value="San Jose de Ocoa">San jose de Ocoa</option>
                            <option value="Santo Domingo">Santo Domingo</option>
                            <option value="Mao">Mao</option>
                            <option value="Bonao">Bonao</option>
                            <option value="Nagua">Nagua</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label for="estado_publicador">Estado</label>
                        <select class="form-control" name="estado_publicador">
                            <option value="Santiago" selected="selected">Santiago</option>
                            <option value="La Vega">La vega</option>
                            <option value="Puerto Plata">Puerto Plata</option>
                            <option value="San Jose de Ocoa">San jose de Ocoa</option>
                            <option value="Santo Domingo">Santo Domingo</option>
                            <option value="Mao">Mao</option>
                            <option value="Bonao">Bonao</option>
                            <option value="Nagua">Nagua</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <input type="submit" class="btn btn-primary" name="guardar" value="Guardar">
                        <input type="reset" class="btn btn-danger" name="reset" value="Limpiar">
                    </div>
                </form>
            </div>

            <div class="col-md-12">
            <h5>Listado de Publicadores</h5>
            <table class="table table-bordered table-striped table-hover">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nombre</th>
                        <th>Ciudad</th>
                        <th>Estado</th>
                    </tr>
                </thead>
                <tbody>
                <?php
                    $sql = "SELECT * FROM publicadores ORDER BY nombre_pub ASC";
                    $re = mysql_query($sql) or die("Error al ejecutar consulta") . mysql_error();
                    while ($campo = mysql_fetch_array($re)) {
                        echo '<tr><td>' . $campo['id_pub'] . '</td><td>' . $campo['nombre_pub'] . '</td><td>' . $campo['ciudad'] . '</td><td>' . $campo['estado'] . '</td></tr>';
                    }
                    ?>
                </tbody>
            </table>
            </div>
            

        </div>
        </div>
    </main>
    
</body>
</html>