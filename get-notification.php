<?PHP
$data = array('title' => 'Thông báo quan trọng 3', 'body' => $_GET['s'], 'icon' => '/images/icon-192x192.png', 'tag' => 'simple-push-demo-notification-tag',	'url'=> 'http://google.com.vn');

header("Content-Type: application/json;charset=utf-8");
echo json_encode($data);
?>