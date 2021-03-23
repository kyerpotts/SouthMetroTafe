/*
 * Kyer Potts
 * 30003389
 */
package myloan;

/** Child class allows for interestRate attribute to be collected*/
public class PersonalLoan extends Loan {
    
    /**Constructor sets values for interest rate value*/
    public PersonalLoan(int loanNumber, String custLastName, int loanAmount, int loanTerm, int interestRate){
        super(loanNumber, custLastName, loanAmount, loanTerm);
        this.interestRate = interestRate + 2;
    }
}
