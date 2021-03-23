package datenightatthearcade;

import java.util.*;

/**
 * Kyer Potts
 *
 * @author 30003389
 */
public class DateNightAtTheArcade {

    public static void main(String[] args) {
        Terminal tm1 = new Terminal();
        Game gm1 = new Game();

        //instatiate 2 new cards onto tm1 array
        tm1.NewCard();
        tm1.NewCard();

        //load credits onto both cards
        tm1.LoadCredits(tm1.cardArray[0]);
        tm1.LoadCredits(tm1.cardArray[1]);

        System.out.println();//print line for readability

        //check balances of both cards before proceeding 
        tm1.CheckBalance(tm1.cardArray[0]);
        tm1.CheckBalance(tm1.cardArray[1]);

        System.out.println();//print line for readability
        
        //run WinRandomTickets game to generate ticket balances for both cards
        gm1.WinRandomTickets(tm1.cardArray[0]);
        gm1.WinRandomTickets(tm1.cardArray[1]);

        System.out.println();//print line for readability
        
        //check balances of both cards again to determine ticket balances
        tm1.CheckBalance(tm1.cardArray[0]);
        tm1.CheckBalance(tm1.cardArray[1]);

        System.out.println();//print line for readability

        //transfer balances from card 1 to card 2
        tm1.TransferCreditBalance(tm1.cardArray[0], tm1.cardArray[1]);
        tm1.TransferTicketBalance(tm1.cardArray[0], tm1.cardArray[1]);

        System.out.println();//print line for readability

        //check balances again to confirm successful balance transfer
        tm1.CheckBalance(tm1.cardArray[0]);
        tm1.CheckBalance(tm1.cardArray[1]);

        System.out.println();//print line for readability

        //collect prize using card 2
        tm1.CollectPrize(tm1.cardArray[1]);

        System.out.println();//print line for readability

        //run WinRandomTickets game for card 1 to generate ticket balance
        gm1.WinRandomTickets(tm1.cardArray[0]);

        System.out.println();//print line for readability

        //attempt to collect prize with card 1
        tm1.CollectPrize(tm1.cardArray[0]);

        System.out.println();//print line for readability

        //check balances of both cards again to determine if code is running correctly
        tm1.CheckBalance(tm1.cardArray[0]);
        tm1.CheckBalance(tm1.cardArray[1]);
    }
}
