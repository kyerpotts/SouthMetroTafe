package javastory;

import java.util.*;

public class JavaStory {

    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        
         
        System.out.println("Enter your name");
        String name = sc.next();
        
        System.out.println("Enter your profession");
        String profession = sc.next();
        
        System.out.println("Enter your gender");
        String gender = sc.next();
        
        System.out.println("What is your age?");
        int age = sc.nextInt();
        
        System.out.println("Enter your bank account balance");
        double bankBalance = sc.nextDouble();
        
        System.out.println("How much would you pay for this program?");
        double programCost = sc.nextDouble();
        
        System.out.println("How old do you wish you were?");
        int ageWish = sc.nextInt();
        
        System.out.println("What is your favourite food?");
        String favFood = sc.next();
        
        System.out.println("What is your favourite location?");
        String favPlace = sc.next();
        
        System.out.println("Who would you like to meet one day?");
        String meetCute = sc.next();
                
        String s1 = (name + ", you are a " + profession + ".\nYou are a " + gender + " and you are " + age + " years old.\nYou have " + bankBalance +" in your bank account.\nIf you paid for this program, you would have " + (bankBalance - programCost) + " in your bank account.\nYou wish you were " + ageWish +".\nYou were that age " + (age - ageWish) + " years ago.\nI bet you would like to meet " + meetCute + " in " + favPlace + " and eat " + favFood + " with them.\nYou are a boring " + gender + ".\nGoodbye " + name);
        
        System.out.println(s1);
      
    }
    
}
