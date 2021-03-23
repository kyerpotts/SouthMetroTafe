/*
 * Kyer Potts
 * 30003389
 */
package myloan;

/** Loan parent class generates the attributes and methods to be used by child classes*/
public abstract class Loan implements LoanConstants, java.io.Serializable{
    
    private int loanNumber;
    private String custLastName;
    private int loanAmount;
    protected int interestRate;
    private int loanTerm;
    
    /**Constructor sets the values for attributes to be used by child classes */
    public Loan(int loanNumber, String custLastName, int loanAmount, int loanTerm){
        this.loanNumber = loanNumber;
        this.custLastName = custLastName;
        if (loanAmount > MAX_LOAN_AMOUNT){
            this.loanAmount = MAX_LOAN_AMOUNT;
        }
        else{
            this.loanAmount = loanAmount;
        }
        if (loanTerm != SHORT_TERM || loanTerm != MEDIUM_TERM || loanTerm != LONG_TERM){
            this.loanTerm = SHORT_TERM;
        }
        else{
            this.loanTerm = loanTerm;
        }
    }
    
    @Override
    /**Overridden toString method formats all attribute data into printable string*/
    public String toString(){
        return String.format("Loan Number: " + loanNumber + "\r\n" + "Customer Last Name: " + custLastName + "\r\n" +  "Loan Amount: " + loanAmount + "\r\n" +  "Interest Rate: " + interestRate + "\r\n" +  "Loan Term: " + loanTerm);
    }
}
