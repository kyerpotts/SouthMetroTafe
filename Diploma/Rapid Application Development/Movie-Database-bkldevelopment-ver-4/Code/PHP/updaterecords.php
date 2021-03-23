<?php
/*
  Luke Gough 30003918
  Kyper Potts 30003389
  Brandon Price P459899
*/
session_start();
if(isset($_SESSION['admin']))
{
include("../templates/header.php");
echo "<p></p>";
echo "<div class=\"row text-white\"> <!-- Start Row One -->";
echo "<div class=\"col-12 col-sm-6\">";
echo "<a class=\"button\" href=\"../admin.html\">Back</a>";
echo "</div>";
echo "</div> <!-- End Row One -->";
} 
else
{
    echo "Please login!";
    header("refresh:0;url=admin_login.php");
}
?>
<div class="row text-white"> <!-- Start Row One -->
    <div class="col-12 col-sm-6 offset-sm-3 text-center">
        <h1 class="display-4">Table Editor</h1>
        <div class="info-form">
            <form action="sqlhandler.php" method="post" class="form-inlin justify-content-center">
              <p><strong>Add Record</strong></p>  
              <p>
              <input type="Database Name" name="dbname4" placeholder="Database Name">
              </p>
              <p>
              <input type="Table Name" name="tablename2" placeholder="Table Name">
              </p>
                <textarea name="records1" cols="40" rows="5" placeholder ="(Column 1,Column 2, Column 3, etc...)
                ##REPLACE COLUMNS AND FOLLOW FORMAT##"></textarea>
              </p>
              </p>
                <textarea name="records2" cols="40" rows="5" placeholder ="(Value 1, Value 2, Value 3, etc...)
                ##REPLACE VALUES AND FOLLOW FORMAT##"></textarea>
              </p>
              <button class="button" type="submit">send</button>
            </form>    

            <form action="sqlhandler.php" method="post" class="form-inlin justify-content-center">
              <p><strong>Remove Record</strong></p>  
              <p>
              <input type="Database Name" name="dbname5" placeholder="Database Name">
              </p>
              <p>
              <input type="Table Name" name="tablename3" placeholder="Table Name">
              </p>
                <textarea name="records3" cols="40" rows="5" placeholder ="(Column 1,Column 2, Column 3, etc...)
                ##REPLACE COLUMNS AND FOLLOW FORMAT##"></textarea>
              </p>
              </p>
                <textarea name="records4" cols="40" rows="5" placeholder ="(Value 1, Value 2, Value 3, etc...)
                ##REPLACE VALUES AND FOLLOW FORMAT##"></textarea>
              </p>
              <button class="button" type="submit">send</button>
            </form>                      
            <p></p>
        </div>
    </div>
</div> <!-- End Row One -->
<p></p>
<?php
include("../templates/footer.php"); 
?>