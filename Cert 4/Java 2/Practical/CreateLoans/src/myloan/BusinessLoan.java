/*
 * Kyer Potts
 * 30003389
 */
package myloan;

/** Child class allows for interestRate attribute to be collected*/
public class BusinessLoan extends Loan{
    
    /**Constructor sets values for interest rate value*/
    public BusinessLoan(int loanNumber, String custLastName, int loanAmount, int loanTerm, int interestRate){
        super(loanNumber, custLastName, loanAmount, loanTerm);
        this.interestRate = interestRate + 1;
    }
    
}
