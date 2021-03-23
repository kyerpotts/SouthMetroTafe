/*
 * Kyer Potts
 * 30003389
 */

package lambdaexpressions;

import javafx.event.ActionEvent;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.shape.Circle;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.input.*;
import javafx.stage.Stage;

public class LambdaExpressions extends Application {
    
    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("Java GUI");
        GridPane grid = new GridPane();
        grid.setAlignment(Pos.TOP_CENTER); 
        grid.setHgap(10);
        grid.setVgap(10);
        grid.setPadding(new Insets(25, 25, 25, 25));
        
        // Create a Circle
        Circle c = new Circle(20, 20, 10);
        grid.add(c, 0, 2);
        
        // Create a TextField
        TextField textField = new TextField(); // Username TextField
        grid.add(textField, 0, 3);
        
        // Create a Button
        Button button = new Button("Click Me");
        HBox hBox = new HBox(10);
        hBox.getChildren().add(button);
        grid.add(hBox, 0, 1);
        
        // button click handler
        button.setOnAction((ActionEvent event) -> {
            System.out.println("Hello World");
        });
        
        // mouse entered handler
        c.setOnMouseEntered((MouseEvent event) -> {
            System.out.println("Mouse Entered");
        });
        
        // keyboard pressed handler
        textField.setOnKeyPressed((KeyEvent event) -> {
            System.out.println("Key Pressed: " + event.getText());
        });
        
        // Scene
        Scene scene = new Scene(grid, 200, 150);
        primaryStage.setScene(scene);
        primaryStage.show();
        
    }

    public static void main(String[] args) {
        launch(args);
    }

}
