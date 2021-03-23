package datenightatthearcade;

import java.util.*;

/**
 * Kyer Potts 30003389
 */
public class Game {

    
    public void WinRandomTickets(Card c) {//generates a random amount of tickets between 1 and 10, and then adds them to the card balance while removing the necessary credits from the card
        int availableCredits = c.getCreditBalance();
        System.out.println("This game costs 5 credits to play.");

        if (availableCredits < 5) {
            System.out.println("You do not have enough credits to play, please top up at a terminal");

        } else {
            double randomTickets = Math.random() * 10 + 1;
            System.out.println("You won " + (int) randomTickets + " tickets!");
            c.setTicketBalance(c.getTicketBalance() + (int) randomTickets);
            c.setCreditBalance(c.getCreditBalance() - 5);
        }

    }
}
