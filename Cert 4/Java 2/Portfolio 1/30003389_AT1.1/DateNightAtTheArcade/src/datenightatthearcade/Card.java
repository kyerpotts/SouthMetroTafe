package datenightatthearcade;

import java.util.*;

/**
 * Kyer Potts
 *
 * @author 30003389
 */
public class Card {

    private int id;
    private int creditBalance;
    private int ticketBalance;

    public Card(int id) {
        this.id = id;
        this.creditBalance = 0;
        this.ticketBalance = 0;
    }

    public int getId() {
        return id;
    }

    public int getCreditBalance() {
        return creditBalance;
    }

    public void setCreditBalance(int creditBalance) {
        this.creditBalance = creditBalance;
    }

    public int getTicketBalance() {
        return ticketBalance;
    }

    public void setTicketBalance(int ticketBalance) {
        this.ticketBalance = ticketBalance;
    }
}
