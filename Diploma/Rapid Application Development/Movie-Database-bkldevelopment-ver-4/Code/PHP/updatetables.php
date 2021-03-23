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
              <p><strong>Add Table</strong></p>  
              <p>
                <input type="Database Name" name="dbname1" placeholder="Database Name">
              </p>
              <p>
              <input type="Add Table" name="tableadd" placeholder="Table Name">
              </p>
              <button class="button" type="submit">send</button>
            </form>
            
            <form action="sqlhandler.php" method="post" class="form-inlin justify-content-center">
              <p><strong>Remove Table</strong></p>  
              <p>
                <input type="Database Name" name="dbname2" placeholder="Database Name">
              </p>
              <p>
                <input type="Remove Table" name="tableremove" placeholder="Table Name">
              </p>
              <button class="button" type="submit">send</button>
            </form>
                              
            <form action="sqlhandler.php" method="post" class="form-inlin justify-content-center">
              <p><strong>Insert New Column</strong></p>  
              <p>
                <input type="Database Name" name="dbname3" placeholder="Database Name">
              </p>
              <p>
                <input type="Table Name" name="tablename" placeholder="Table Name">
              </p>
              <p>
                <input type="Column Name" name="columnname" placeholder="New Column Name">
              </p>
              <p>
                <!-- <input type="text" name="rating" placeholder="Rating"> -->
                <select name="rating" onchange="this.className=this.options[this.selectedIndex].className" class="choose_rating">
                  <!-- Grayed out option with blank value-->
                  <option value="" name="datatype" class="choose_rating">Data Type</option>
                  
                  <!-- Available Options -->
                  <option value="INT" name="rating" class="rating">INT</option>
                  <option value="VARCHAR(255)" name="rating" class="rating">VARCHAR(255)</option>
                  <option value="TEXT" name="rating" class="rating">TEXT</option>
                  <option value="DATE" name="rating" class="rating">DATE</option>
                  <option value="TINYINT" name="rating" class="rating">TINYINT</option>
                  <option value="SMALLINT" name="rating" class="rating">SMALLINT</option>
                  <option value="MEDIUMINT" name="rating" class="rating">MEDIUMINT</option>
                  <option value="BIGINT" name="rating" class="rating">BIGINT</option>
                  <option value="DECIMAL" name="rating" class="rating">DECIMAL</option>
                  <option value="CHAR" name="rating" class="rating">CHAR</option>
                  <option value="BOOLEAN" name="rating" class="rating">BOOLEAN</option>
                  <option value="DATE" name="rating" class="rating">DATE</option>
                </select>
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
