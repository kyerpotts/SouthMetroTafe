/*
 * 30003389
 * Kyer Potts
 */
package idnamedatabase;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Text;
import javafx.stage.Stage;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javafx.scene.control.TextField;
import static javafx.application.Application.launch;

public class IDNameDatabase extends Application {

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("IDNameDatabase");
        GridPane grid = new GridPane();
        grid.setAlignment(Pos.CENTER);
        grid.setHgap(5);
        grid.setVgap(5);
        grid.setPadding(new Insets(25, 25, 25, 25));
        
        TextField textField = new TextField("Enter Person ID");
        Button btn = new Button("Search");
        grid.add(textField, 0, 1);
        grid.add(btn, 0, 2);
        final Text messageText = new Text("No ID Found");
        grid.add(messageText, 0, 3);

        btn.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent event) {
                String url = "jdbc:mysql://localhost:3306/";
                String user = "root";
                String password = "usbw";

                Connection con = null;
                Statement stmt = null;
                
                String query;
                ResultSet result = null;
                

                try {
                    con = DriverManager.getConnection(url, user, password);
                    stmt = con.createStatement();

                    String sql = "USE idnamedatabase;";
                    stmt.executeUpdate(sql);

                    String search = textField.getText();
                    query = "SELECT * FROM idname WHERE ID = " + search + ";";
                    result = stmt.executeQuery(query);
                    while (result.next()) {
                        String searchResult = result.getString("Name");
                        messageText.setText(searchResult);
                    }

                } catch (Exception ex) {
                    System.out.println("SQLException caught: " + ex.getMessage());
                    messageText.setText("No ID Found");
                } finally {
                    // Close all database objects nicely
                    try {
                        if (result != null) {
                            result.close();
                        }

                        if (stmt != null) {
                            stmt.close();
                        }
                        if (con != null) {
                            con.close();
                        }
                    } catch (SQLException ex) {
                        System.out.println("SQLException caught: " + ex.getMessage());
                    }
                }

            }
        });
        
        Scene scene = new Scene(grid, 150, 150);
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
