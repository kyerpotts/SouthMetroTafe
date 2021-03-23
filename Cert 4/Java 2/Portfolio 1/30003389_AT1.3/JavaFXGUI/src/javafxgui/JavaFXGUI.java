/*
 * 30003389
 * Kyer Potts
 */
package javafxgui;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.paint.Color;
import javafx.scene.text.Text;
import javafx.stage.Stage;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JavaFXGUI extends Application {

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("JavaFX GUI AT1.3");
        GridPane grid = new GridPane();
        grid.setAlignment(Pos.CENTER);
        grid.setHgap(5);
        grid.setVgap(5);
        grid.setPadding(new Insets(25, 25, 25, 25));
        
        TextField textField = new TextField("Enter Person ID");
        Button btn = new Button("Search");
        //HBox hBox = new HBox(20);
        //hBox.setAlignment(Pos.BOTTOM_CENTER);
        //hBox.getChildren().add(btn);
        //hBox.getChildren().add(textField);
        grid.add(textField, 0, 1);
        grid.add(btn, 0, 2);

        final Text messageText = new Text("It's a trap!");
        grid.add(messageText, 0, 3);

        btn.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent event) {
                if (messageText.getText() == "It's a trap!") {
                    messageText.setFill(Color.CRIMSON);
                    messageText.setText("You fell for it!");
                } else {
                    messageText.setFill(Color.BLUE);
                    messageText.setText("It's a trap!");
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
