/*
 * Kyer Potts
 * 30003389
 */

package javafxgui;

import javafx.event.ActionEvent;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;
import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.input.*;
import javafx.scene.paint.Color;
import javafx.scene.text.Text;
import javafx.stage.Stage;
import java.awt.Desktop;
import java.io.File;
import java.io.IOException;


public class JavaFXGUI extends Application {
    
    @Override
    public void start(Stage primaryStage) {
        //Set title for stage
        primaryStage.setTitle("Java GUI");
        
        //Create GridPane
        GridPane grid = new GridPane();
        grid.setAlignment(Pos.TOP_CENTER);
        grid.setHgap(10);
        grid.setVgap(10);
        grid.setPadding(new Insets(25, 25, 25, 25));
        
        //Creates a label for the 2D graphical elements
        Label tdg = new Label("2D Graphics");
        grid.add(tdg, 0, 1, 5, 1);
        
        //Create circle shape
        Circle c = new Circle(20, 20, 10);
        grid.add(c, 0, 2);
        
        //Create square shape
        Rectangle r = new Rectangle(20, 20);
        grid.add(r, 1 ,2);
        
        //Creates a label for the GUI components
        Label GUIComponents = new Label("GUI Components");
        grid.add(GUIComponents, 0, 4, 5, 1);
        
        //Creates a label
        Label textField = new Label("Text Field");
        grid.add(textField, 0, 5, 5, 1);
        
        
        //Creates a new textfield
        TextField tbField = new TextField();
        grid.add(tbField, 2, 5);
        
        Button enter = new Button("Enter");
        HBox enterBox = new HBox(10);
        enterBox.setAlignment(Pos.BOTTOM_RIGHT);
        enterBox.getChildren().add(enter);
        grid.add(enterBox, 2, 6);
        
        //Drag and drop
        Label dnd = new Label("Drag and Drop");
        grid.add(dnd, 0, 7, 5, 1);
        
        final Text drag = new Text("Drag me");
        grid.add(drag, 1, 8);
        
        final Text drop = new Text("Drop Here");
        grid.add(drop, 3, 8);
        
        drag.setOnDragDetected(new EventHandler<MouseEvent>() { // drag setOnDragDetected
            @Override
            public void handle(MouseEvent event) {
                Dragboard db = drag.startDragAndDrop(TransferMode.MOVE);
                ClipboardContent content = new ClipboardContent();
                content.putString(drag.getText());
                db.setContent(content);
                event.consume();
            }
        });
        
        drop.setOnDragOver(new EventHandler<DragEvent>() { // drop setOnDragOver
            @Override
            public void handle(DragEvent event) {
                if (event.getGestureSource() != drop && event.getDragboard().hasString()) {
                    event.acceptTransferModes(TransferMode.MOVE);
                }
                event.consume();
            }
        });
        
        drop.setOnDragEntered(new EventHandler<DragEvent>() { // drop setOnDragEntered
            @Override
            public void handle(DragEvent event) {
                if (event.getGestureSource() != drop && event.getDragboard().hasString()) {
                    drop.setFill(Color.GREEN);
                }
                event.consume();
            }
        });
        
        drop.setOnDragExited(new EventHandler<DragEvent>() { // drop setOnDragExited
            @Override
            public void handle(DragEvent event) {
                drop.setFill(Color.BLACK);
                event.consume();
            }
        });
        
        drop.setOnDragDropped(new EventHandler<DragEvent>() { // drop setOnDragDropped
            @Override
            public void handle(DragEvent event) {
                Dragboard db = event.getDragboard();
                boolean success = false;
                if (db.hasString()) {
                    drop.setText(db.getString());
                    success = true;
                }
                event.setDropCompleted(success);
                event.consume();
            }
        });
        
        drag.setOnDragDone(new EventHandler<DragEvent>() { // drag setOnDragDone
            @Override
            public void handle(DragEvent event) {
                if (event.getTransferMode() == TransferMode.MOVE) {
                    drag.setText("");
                }
                event.consume();
            }
        });
        
        Label help = new Label("Help"); // Help Label
        grid.add(help, 0, 9, 5, 1);

        Button helpButton = new Button("Help"); // Help Button
        HBox helpBox = new HBox(10);
        helpBox.setAlignment((Pos.BOTTOM_RIGHT));
        helpBox.getChildren().add(helpButton);
        grid.add(helpBox, 0, 10, 2, 1);

        helpButton.setOnAction(new EventHandler<ActionEvent>() {
            @Override
            public void handle(ActionEvent event) {
                String url = "help.html"; 
                File htmlFile = new File(url);
                try {
                    Desktop.getDesktop().browse(htmlFile.toURI()); 
                } catch (IOException ex) {
                    System.out.println("IOException : " + ex);
                }
            }
        });
        
        // Scene
        Scene scene = new Scene(grid, 300, 350);
        primaryStage.setScene(scene);
        primaryStage.show();
    }
    
    public static void main(String[] args) {
        launch(args);
    }
}

