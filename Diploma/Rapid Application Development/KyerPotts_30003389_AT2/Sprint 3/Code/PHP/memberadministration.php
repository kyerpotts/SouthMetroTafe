
<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
// this line includes the HTML file header.php
include("../templates/header.php");

// Get Variables
$email = trim($_POST['email']);

// check if the variables contain data
//echo "<div class=\"container\">";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<h1>Searching</h1>";
if(!("" == $email)) {
  echo "<p>Email: $email</p>";
}

echo "<a class=\"button\" href=\"../memberadministration.html\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
echo "<br>";

// Connect to Database
try {
    require("connect.php");
} catch(PDOException $e) {
    echo "ERROR: Could not connect. " . $e->getMessage();
}

try {
    if(("" == $email)) {
        // if email is empty
        echo "<div class=\"row text-white\"> <!-- Start Row Two -->";
        echo "<div class=\"col-12 col-sm-6\">";
        echo "<p>No data entered, unable to find any records.</p>";
        echo "</div>";
        echo "</div> <!-- End Row Two -->";

        $query = "SELECT * FROM movies_table WHERE id = '-1'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    } elseif(!($email == "")) {
        // else if email is entered
        $query = "SELECT * FROM members_table WHERE email = '$email'";
        $stmt = $conn->prepare($query);
        $stmt->execute();
    }
    
    $static_value = 0;

    if($stmt->rowCount() > 0) {
            while($row = $stmt->fetchObject()) {
                ?>
                    <div class="row text-white"> <!-- Start Row One -->
                        <div class="col-12 col-sm-6">
                            <h1 class="display-4">Details</h1>
                            <div class="info-form">
                                <form action="./memberupdate.php" method="post" class="form-inlin justify-content-center">
                                <p>
                                    <a>First Name:</a>
                                    <input type="text" name="firstname" value="<?php echo "{$row->firstname}"; ?>" readonly>
                                </p>
                                <p>
                                    <a>Email:</a>
                                    <input type="text" name="email" value="<?php echo "{$row->email}"; ?>" readonly> 
                                </p>
                                <p>
                                    <a>Monthly Newsletter</a>
                                    <?php
                                    if( $row->monthly_newsletter > 0){
                                    ?>
                                    <input type="checkbox" name="monthly_newsletter" value="1" checked>
                                    <?php
                                    } else {
                                    ?>
                                    <input type="checkbox" name="monthly_newsletter" value="0">
                                    <?php
                                    }
                                    ?>
                                </p>
                                <button class="button" type="submit">Submit</button>
                                </form>
                            </div>
                        </div>
                    </div> <!-- End Row One -->
                <?php
            }
    echo "</div>";
    echo "</div> <!-- End Row Three -->";
    }
} catch(PDOException $e) {
    echo "ERROR: Could not run query. " . $e->getMessage();
}

// this line includes the HTML file footer.php
include("../templates/footer.php"); 
?>