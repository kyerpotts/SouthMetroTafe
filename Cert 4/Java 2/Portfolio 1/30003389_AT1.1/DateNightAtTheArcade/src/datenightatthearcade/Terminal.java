package datenightatthearcade;

import java.util.*;

/**
 * Kyer Potts
 *
 * @author 30003389
 */
public class Terminal {

    Scanner sc = new Scanner(System.in);
    public Card[] cardArray = new Card[20];//cardArray holds the cards to be used later, max number of cards is 20
    int cardCounter = 0;//Counter to instantiate cards and set card ID's for later use
    PrizeCategories pc = new PrizeCategories();
    //Number of prizes per category created as attributes within the Terminal
    private int candy = 10;
    private int toyCar = 3;
    private int sillyHat = 1;

    public void NewCard() {//Instantiates new cards to the card array
        cardArray[cardCounter] = new Card(cardCounter);
        cardCounter++;
    }
    
    public void CheckBalance(Card c){//Reads through values of selected card and displays the current credit and ticket balances
        int cBalance = c.getCreditBalance();
        int tBalance = c.getTicketBalance();
        System.out.println("Your current credit balance is " + cBalance);
        System.out.println("Your current ticket balance is " + tBalance);
    }

    public void LoadCredits(Card c) {//Loads credits at a 2 to 1 ratio per dollar spent onto the selected card
        System.out.println("How much money would you like to load onto card ID: " + c.getId());
        System.out.println("2 credits = $1");
        int cashIn = (sc.nextInt() * 2);
        int currentBalance = c.getCreditBalance();
        c.setCreditBalance(cashIn + currentBalance);
        System.out.println("You bought " + cashIn + " credits!");
    }

    public void TransferCreditBalance(Card a, Card b) {//Transfers credit balance from first selection card to second selection card
        try {
            System.out.println("How many credits would you like to transfer?");
            try {
                int creditTransfer = sc.nextInt();
                int aCreditBalance = a.getCreditBalance();
                int bCreditBalance = b.getCreditBalance();
                if (aCreditBalance >= creditTransfer) {
                    b.setCreditBalance(bCreditBalance + creditTransfer);
                    a.setCreditBalance(aCreditBalance - creditTransfer);
                    System.out.println(creditTransfer + " credits have been successfully transferred!");
                } else {
                    System.out.println("Insufficient credits to complete transfer.");
                }
            } catch (Exception e) {
                System.out.println("Error!" + e);
            }
        } catch (Exception e) {
            System.out.println("Error!" + e);
        }
    }

    public void TransferTicketBalance(Card a, Card b) {//Transfers ticket balance from first selection card to second selection card
        System.out.println("How many Tickets would you like to transfer?");
        try {
            int ticketTransfer = sc.nextInt();
            int aTicketBalance = a.getTicketBalance();
            int bTicketBalance = b.getTicketBalance();
            if (aTicketBalance >= ticketTransfer) {
                b.setTicketBalance(bTicketBalance + ticketTransfer);
                a.setTicketBalance(aTicketBalance - ticketTransfer);
                System.out.println(ticketTransfer + " tickets have been successfully transferred!");
            } else {
                System.out.println("Insufficient tickets to complete transfer.");
            }
        } catch (Exception e) {
            System.out.println("Error!" + e);
        }
    }

    public void CollectPrize(Card c) {//Runs the collect prize option with the balances of the selected card
        try {
            System.out.println("please select a prize from the list! Please ensure you only enter a number");
            System.out.println("1. Candy = 5 tickets");
            System.out.println("2. Toy Car = 10 tickets");
            System.out.println("3. Silly Hat = 15 tickets");
            int choice = sc.nextInt();
            switch (choice) {
                case 1:
                    if (pc.Candy(c) == true) {
                        System.out.println("Dispensing Candy now");
                        this.candy--;
                    } else if (pc.Candy(c) == false) {
                        System.out.println("You do not have enough tickets for this item");
                    }
                    break;

                case 2:
                    if (pc.ToyCar(c) == true) {
                        System.out.println("Dispensing Toy Car now");
                        this.toyCar--;
                    } else if (pc.Candy(c) == false) {
                        System.out.println("You do not have enough tickets for this item");
                    }
                    break;

                case 3:
                    if (pc.Candy(c) == true) {
                        System.out.println("Dispensing Silly Hat now");
                        this.sillyHat--;
                    } else if (pc.SillyHat(c) == false) {
                        System.out.println("You do not have enough tickets for this item");
                    }
                    break;

                default:
                    System.out.println("Invalid choice");
            }
        } catch (Exception e) {
            System.out.println("Error!" + e);
        }
    }
}
