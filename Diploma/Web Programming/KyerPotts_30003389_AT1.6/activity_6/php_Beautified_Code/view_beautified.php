<style>
<?php include 'style.css'; ?>
</style>
<?php

echo "<table>";
echo "<tr><th>First Name</th><th>Surname</th><th>Email</th>";

class TableRows extends RecursiveIteratorIterator {
    function __construct($it) {
        parent::__construct($it, self::LEAVES_ONLY);
    }
    
    function current() {
        return "<td style='width:150px;border1px solid black;'>" . parent::current(). "</td>";
    }
    
    function beginChildren() {
        echo "<tr>";
    }
    
    function endChildren() {
        echo "</tr>" . "\n";
    }
}

// Connection info
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "names_emails";

try {
    $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $stmt = $conn->prepare("SELECT firstname, surname, email FROM data");
    $stmt->execute();
    
    $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);
    foreach(new TableRows(new RecursiveArrayIterator($stmt->fetchAll())) as $k=>$v) {
        echo $v;
    }
}
catch(PDOException $e) {
    echo "Error: " . $e->getMessage();
}
$conn = null;
echo "</table>";
?>