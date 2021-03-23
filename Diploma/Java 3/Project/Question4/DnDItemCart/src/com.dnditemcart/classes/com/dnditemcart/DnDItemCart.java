package com.dnditemcart;

/*
 * Kyer Potts
 * 30003389
 */
import javafx.event.ActionEvent;
import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.HBox;
import javafx.scene.shape.Circle;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.input.*;
import javafx.stage.Stage;
import java.awt.Desktop; 
import java.io.File;
import java.io.IOException;
import static javafx.application.Application.launch;
import javafx.scene.control.ListView;

public class DnDItemCart extends Application {

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("Drag and Drop Item Cart"); //Set title

        // Create Grid
        GridPane grid = new GridPane();
        grid.setAlignment(Pos.TOP_LEFT);
        grid.setHgap(10);
        grid.setVgap(10);
        grid.setPadding(new Insets(25, 25, 25, 25));

        // Create labels for drag and drop function
        final Label lbCPU = new Label("CPU");
        grid.add(lbCPU, 0, 0);

        final Label lbMemory = new Label("Memory");
        grid.add(lbMemory, 0, 1);

        final Label lbMotherBoard = new Label("Mother Board");
        grid.add(lbMotherBoard, 0, 2);

        final Label lbGPU = new Label("GPU");
        grid.add(lbGPU, 0, 3);

        final Label lbKeyboard = new Label("Keyboard");
        grid.add(lbKeyboard, 0, 4);

        final Label lbMouse = new Label("Mouse");
        grid.add(lbMouse, 0, 5);

        // Create List for drag and drop function
        ListView<String> list = new ListView<>();
        grid.add(list, 1, 0, 1, 6);

        // Drag and Drop Lambda Events
        //CPU label dnd
        lbCPU.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbCPU.getText());
            db.setContent(content);
            event.consume();
        }
        );
        // Memory label dnd
        lbMemory.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbMemory.getText());
            db.setContent(content);
            event.consume();
        }
        );
        // MotherBoard label dnd
        lbMotherBoard.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbMotherBoard.getText());
            db.setContent(content);
            event.consume();
        }
        );
        // GPU label dnd
        lbGPU.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbGPU.getText());
            db.setContent(content);
            event.consume();
        } // drag setOnDragDetected
        );
        // Keyboard label dnd
        lbKeyboard.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbKeyboard.getText());
            db.setContent(content);
            event.consume();
        } // drag setOnDragDetected
        );
        // Mouse label dnd
        lbMouse.setOnDragDetected((MouseEvent event) -> {
            Dragboard db = lbCPU.startDragAndDrop(TransferMode.MOVE);
            ClipboardContent content = new ClipboardContent();
            content.putString(lbMouse.getText());
            db.setContent(content);
            event.consume();
        } // drag setOnDragDetected
        );

        // Drop On list event
        list.setOnDragOver((DragEvent event) -> {
            if (event.getDragboard().hasString()) {
                event.acceptTransferModes(TransferMode.MOVE);
            }
            event.consume();
        }
        );

        list.setOnDragDropped((DragEvent event) -> {
            Dragboard db = event.getDragboard();
            boolean success = false;
            if (db.hasString()) {
                list.getItems().add(db.getString());
                //drop.setText(db.getString());
                success = true;
            }
            event.setDropCompleted(success);
            event.consume();
        } // drop setOnDragDropped
        );

        // 2D Graphics
        Circle c = new Circle(20, 20, 10); // Creates Circle at bottom of the window
        grid.add(c, 0, 6);

        //Create a help button that redirects to a help page
        Button helpButton = new Button("Help"); // Help Button
        HBox helpBox = new HBox(0);
        helpBox.setAlignment((Pos.BOTTOM_RIGHT));
        helpBox.getChildren().add(helpButton);
        grid.add(helpBox, 1, 6, 1, 1);

        // Help Button ActionEvent Lambda
        helpButton.setOnAction((ActionEvent event) -> {
            String url = "help.html"; //URL of the HTML help file
            File htmlFile = new File(url); // file object of the help file
            try {
                Desktop.getDesktop().browse(htmlFile.toURI()); // Opens the help file
            } catch (IOException ex) {
                System.out.println(ex);
            }
        });

        // Create Scene
        Scene scene = new Scene(grid, 400, 250);
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
