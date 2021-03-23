/*
 * 30003389
 * Kyer Potts
 */
package activity5;

import carpackage.Car;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.io.*;
public class Activity5 {
    
    
    public static void main(String[] args) {
        ArrayList<Car> carList = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        
        carList.add(new Car("Mitsubishi", "Lancer", "2006", 140000));
        carList.add(new Car("Dodge", "Charger", "1973", 80000));
        carList.add(new Car("Chevrolet", "Corvette", "1963", 65000));
        carList.add(new Car("Ford", "Mustang", "1967", 132000));
        for (Car c : carList){
            c.display();
        }
        
        System.out.println("---------------------------------------------");
        
        Collections.sort(carList);
        for (Car c : carList){
            c.display();
        }
        System.out.println("Please enter the make of the car you would like to search for");
        String make = sc.next();
        int index = BinarySearch(carList, make);
        if(index >= 0 && index <= 3){
            System.out.println("Item was found at index = " + index);
        }else{
            System.out.println("Item was not found");
        }
        
        
        System.out.println("---------------------------------------------");
        
        try {
            FileOutputStream fileOut = new FileOutputStream("Car.dat");
            ObjectOutputStream out = new ObjectOutputStream(fileOut);
            out.writeObject(carList);
            out.close();
            fileOut.close();
        }catch(IOException ex){
            ex.printStackTrace();
        }
        
        ArrayList<Car> carList2 = new ArrayList<>();
        
        try{
            FileInputStream fileIn = new FileInputStream("Car.dat");
            ObjectInputStream in = new ObjectInputStream(fileIn);
            carList2 = (ArrayList) in.readObject();
            in.close();
        } catch(Exception ex){
            ex.printStackTrace();
            return;
        }
        
        for (Car c : carList2){
            c.display();
        }
        
    }
    
    /** Binary Search Method takes in parameters from ArrayLists and a comparator, then returns the index of comparator found*/
    public static int BinarySearch(ArrayList<Car> carList, String make){
        int index = Collections.binarySearch(carList, new Car(make));
        return index;
    }
    
    
}
