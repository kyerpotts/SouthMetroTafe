/*
 * Kyer Potts
 * 30003389
 */

package innerclass;
/**
 * Creates a State Object
 * @author kyerp
 */

public class State {
    private String name;
    private int population;
    private CapitalCity capitalCity;
    
    /**
     * Creates a Capital City Object, this is an inner class object
     * @author kyerp
     */
    private class CapitalCity{
        private String name;
        private int population;
        private int landSize;
        
        
        public CapitalCity(String name, int population, int landSize){
            this.name = name;
            this.population = population;
            this.landSize = landSize;
        }
        
        /**
         * Returns the name property of the Object
         * @return name
         */
        public String getName() {
            return name;
        }
        /**
         * Returns the population property of the Object
         * @return population
         */
        public int getPopulation() {
            return population;
        }
        /**
         * Returns the landSize property of the Object
         * @return 
         */
        public int getLandSize() {
            return landSize;
        }
    }
    
    /**
     * Creates a default State object
     * @param name the Int containing the State Name.
     * @param population the Int containing the State Population.
     * @param capitalCity the CapitalCity object of the State object.
     */
    State(){
        this.name = "";
        this.population = 0;
        this.capitalCity = new CapitalCity("", 0, 0);
    }
    
    /**
     * Creates a customized State object
     *
     * @param name the Int containing the State Name.
     * @param population the Int containing the State Population.
     * @param capitalCity the CapitalCity object of the State object.
     */
    State(String name, int population, String capName, int capPopulation, int capLandSize) {
        this.name = name;
        this.population = population;
        this.capitalCity = new CapitalCity(capName, capPopulation, capLandSize);
    }
    
    /**
     * Returns the State name
     * @return State name
     */
    public String getStateName() {
        return name;
    }
    
    /**
     * Returns the State population
     * @return State population
     */
    public int getStatePop() {
        return population;
    }
    
    /**
     * Returns the City Name
     * @return City Name
     */
    public String getCityName() {
        return capitalCity.getName();
    }
    
    /**
     * Returns the Capital City population
     * @return Capital City population
     */
    public int getCityPop() {
        return capitalCity.getPopulation();
    }
    
    /**
     * Returns the Capital City and Land Size
     * @return 
     */
    public int getCityLandSize() {
        return capitalCity.getLandSize();
    }

}
