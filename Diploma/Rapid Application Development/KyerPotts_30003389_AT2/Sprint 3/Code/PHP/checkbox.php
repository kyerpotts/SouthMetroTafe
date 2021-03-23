<?php
//https://stackoverflow.com/questions/8699425/how-to-make-a-checkbox-selected
//https://www.homeandlearn.co.uk/php/php4p11.html
$checkedValue = 123;
$dog = 0;
echo '<input type="checkbox" value="1" '.($dog = 1 ?: $dog = 2).' />';
if($dog == 1)
{
    echo $dog;
}
else if($dog == 2)
{
    echo $dog;
}



//<input type="checkbox" name="bob" value="1" id="12" class="signup.php" <?php echo (($checked)?'checked':'') 
/*
    $ch1 = 'unchecked';
    $ch2 = 'unchecked';
    $ch3 = 'unchecked';
    $ch4 = 'unchecked';
    $ch5 = 'unchecked';

if (isset($_POST['Submit1'])) {

    if (isset($_POST['ch1'])) {
        $ch1 = $_POST['ch1'];

        if ($ch1 == 'net') {
            $ch1 = 'checked';
        }
    }

    if (isset($_POST['ch2'])) {
        $ch2 = $_POST['ch2'];

        if ($ch2  = 'word') {
            $ch2 = 'checked';
        }
    }

    if (isset($_POST['ch3'])) {
        $ch3 = $_POST['ch3'];

        if ($ch3 == 'excel') {
            $ch3 = 'checked';
        }
    }

    if (isset($_POST['ch4'])) {
        $ch4 = $_POST['ch4'];

        if ($ch4 == 'web') {
            $ch4 = 'checked';
        }
    }

    if (isset($_POST['ch5'])) {
        $ch5 = $_POST['ch5'];

        if ($ch5 == 'php') {
            $ch5 = 'checked';
        }
    }
}
*/

?>