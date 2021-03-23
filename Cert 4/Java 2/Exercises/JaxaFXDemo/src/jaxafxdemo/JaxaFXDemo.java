package jaxafxdemo;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;

public class JaxaFXDemo extends Application{
    
    public void start(Stage stage) {
        Circle circ = new Circle(40, 40, 30); // Circle shape
        Group root = new Group(circ); // circle object in a Group
        Scene scene = new Scene(root, 400, 300); // Scene of application
        
        // Top container, Stage
        stage.setTitle("My SimpleJavaFXDemo Application"); 
        stage.setScene(scene); // scene onto the Stage
        stage.show(); // show the stage
    }

    public static void main(String[] args) {
        launch(args); // launch a standalone application
    }
    
}
