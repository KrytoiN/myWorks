<?php
$phone = '79260377636';
$text = "ФИО клиента: " . $_POST['buy-fio'] . ". Номер телефона: " . $_POST['buy-number'];
$sender = 'INFORM';
$apikey = 'P94X1AZC248885EZG12BX543907YZ4DKH009L9FP8R3F6L3B4QC5TN170ER4SP66';

$url = 'https://smspilot.ru/api.php'
    .'?send='.urlencode( $text )
    .'&to='.urlencode( $phone )
    .'&from='.$sender
    .'&apikey='.$apikey
    .'&format=json';

$json = file_get_contents( $url );
echo $json.'<br/>';

$j = json_decode( $json );
if ( !isset($j->error)) {
    echo 'SMS успешно отправлена server_id='.$j->send[0]->server_id;
} else {
    trigger_error( $j->error->description_ru, E_USER_WARNING );
}
?>

<script type="text/javascript">
  document.location.replace("https://emotion-fit.ru/#prices");
</script>