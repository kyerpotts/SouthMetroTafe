/*
 * Kyer Potts
 * 30003389
 */
package createloans;

import myloan.*;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.io.*;

public class CreateLoans {

    public static void main(String[] args) {
        ArrayList<Loan> loanList = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        int counter = 0;

        while (counter < 5) {

            System.out.println("Is this a business or personal loan? \n\r Respond B/P");
            String decider = sc.next().toUpperCase();
            try {
                if (decider.endsWith("B")) {
                    System.out.println("Please enter the Loan Number");
                    int loanNumber = sc.nextInt();
                    System.out.println("Please enter the Customers Last Name");
                    String custLastName = sc.next();
                    System.out.println("Please enter the amount of the loan");
                    int loanAmount = sc.nextInt();
                    System.out.println("Please enter the current prime interest rate");
                    int interestRate = sc.nextInt();
                    System.out.println("Please enter the term of the loan");
                    int loanTerm = sc.nextInt();
                    loanList.add(new BusinessLoan(loanNumber, custLastName, loanAmount, interestRate, loanTerm));
                    counter++;
                    System.out.println();
                } else if (decider.endsWith("P")) {
                    System.out.println("Please enter the Loan Number");
                    int loanNumber = sc.nextInt();
                    System.out.println("Please enter the Customers Last Name");
                    String custLastName = sc.next();
                    System.out.println("Please enter the amount of the loan");
                    int loanAmount = sc.nextInt();
                    System.out.println("Please enter the current prime interest rate");
                    int interestRate = sc.nextInt();
                    System.out.println("Please enter the term of the loan");
                    int loanTerm = sc.nextInt();
                    loanList.add(new PersonalLoan(loanNumber, custLastName, loanAmount, interestRate, loanTerm));
                    counter++;
                    System.out.println();
                } else {
                    System.out.println("Invalid Input, please try again");
                    System.out.println();
                }
            } catch (Exception ex) {
                System.out.println("Invalid input, please ensure numbers and text are entered with the appropriate characters. : " + ex);
                System.out.println();
                sc.nextLine();
            }
        }

        try {
            FileOutputStream fileOut = new FileOutputStream("Loans.dat");
            ObjectOutputStream out = new ObjectOutputStream(fileOut);
            out.writeObject(loanList);
            out.close();
        } catch (IOException ex) {
            ex.printStackTrace();
        }

        try {
            FileInputStream fileIn = new FileInputStream("Loans.dat");
            ObjectInputStream in = new ObjectInputStream(fileIn);
            loanList.clear();
            loanList = (ArrayList) in.readObject();
            in.close();
            for (Loan c : loanList) {
                System.out.println(c);
                System.out.println();
            }

        } catch (Exception ex) {
            ex.printStackTrace();
            return;
        }
    }

}
