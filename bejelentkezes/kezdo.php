<?php
session_start();
require_once("connect.php");
include('session.php');
echo file_get_contents('html/header.html');
echo file_get_contents('html/main.html');
echo file_get_contents('html/footer.html');
