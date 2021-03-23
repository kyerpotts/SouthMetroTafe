package datenightatthearcade;

/**
 * Kyer Potts
 *
 * @author 30003389
 */
public class PrizeCategories {//Checks the credit balance of the selected card and returns true if remaining balance exceeds cost of the item, returns false if selected card does not have enough remaining credit balance

    public boolean Candy(Card c) {
        if (c.getTicketBalance() < 5) {
            return false;
        } else {
            return true;
        }

    }

    public boolean ToyCar(Card c) {
        if (c.getTicketBalance() < 10) {
            return false;
        } else {
            return true;
        }

    }

    public boolean SillyHat(Card c) {
        if (c.getTicketBalance() < 15) {
            return false;
        } else {
            return true;
        }
    }
}
