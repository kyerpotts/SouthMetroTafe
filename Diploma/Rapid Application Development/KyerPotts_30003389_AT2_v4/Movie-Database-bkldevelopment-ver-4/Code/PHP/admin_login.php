
<?php
session_start();
include("../templates/login_admin_header.php");
?>
<div class="container"> <!-- Start Container -->
      <div class="row text-white"> <!-- Start Row One -->
          <div class="col-12 col-sm-6 offset-sm-3 text-center">
              <h1 class="display-4">ACME Movie Search Admin Login</h1>
              <div class="info-form">
                  <form action="adminconnect.php" method="post" class="form-inlin justify-content-center">
                    <p></p>
                    <p>
                      <input type="text" name="email" placeholder="Username">
                    </p>
                    <p>
                      <input type="password" name="password" placeholder="Password">
                    </p>
                    <button class="button" type="submit">Login</button>
                  </form>
                  <p></p>
              </div>
          </div>
      </div> <!-- End Row One -->
      <p></p>
<?php
include("../templates/footer.php"); 
session_destroy();
?>
