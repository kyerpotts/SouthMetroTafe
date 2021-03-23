/*
 * Kyer Potts
 * 30003389
 */

package innerclass;


public class TestState {

    public static void main(String[] args) {
        State WA = new State("Western Australia", 2613700, "Perth", 2022044, 6417);
        State NSW = new State("New South Wales", 7704300, "Sydney", 5131326, 12367);
        State TAS = new State("Tasmania", 1503454, "Hobart", 945785, 6012);
        State VIC = new State("Victoria", 6004815, "Melbourne", 4503845, 15045);
        State QLD = new State("Queensland", 4215365, "Brisbane", 2154854, 8025);

        System.out.println("State : " + WA.getStateName() + "\n"
                + "State Population : " + WA.getStatePop() + "\n"
                + "Capital City : " + WA.getCityName() + "\n"
                + "City Population : " + WA.getCityPop() + "\n"
                + "City Land Size : " + WA.getCityLandSize() + "\n");

        System.out.println("State : " + NSW.getStateName() + "\n"
                + "State Population : " + NSW.getStatePop() + "\n"
                + "Capital City : " + NSW.getCityName() + "\n"
                + "City Population : " + NSW.getCityPop() + "\n"
                + "City Land Size : " + NSW.getCityLandSize() + "\n");

        State newState = new State();
        System.out.println("State : " + newState.getStateName() + "\n"
                + "State Population : " + newState.getStatePop() + "\n"
                + "Capital City : " + newState.getCityName() + "\n"
                + "City Population : " + newState.getCityPop() + "\n"
                + "City Land Size : " + newState.getCityLandSize() + "\n");
        
        System.out.println("State : " + QLD.getStateName() + "\n"
                + "State Population : " + QLD.getStatePop() + "\n"
                + "Capital City : " + QLD.getCityName() + "\n"
                + "City Population : " + QLD.getCityPop() + "\n"
                + "City Land Size : " + QLD.getCityLandSize() + "\n");
        
        
    }

}
