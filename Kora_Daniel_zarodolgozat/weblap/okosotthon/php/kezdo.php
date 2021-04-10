<?php
session_start();
require_once("../config/connect.php");
echo file_get_contents('../html/header.html');
include('../config/session.php');
echo file_get_contents('../html/main.html');
echo file_get_contents('../html/footer.html');
