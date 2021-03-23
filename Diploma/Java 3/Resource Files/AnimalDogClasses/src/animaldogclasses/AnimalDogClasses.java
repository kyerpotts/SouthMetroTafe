package animaldogclasses;

public class AnimalDogClasses {

    public static void main(String[] args) {
        // Instantiate Animal object
        Animal a = new Animal();
        // Instantiate Dog object
        Dog d = new Dog();
        // Upcast Dog object
        Animal ad = (Animal)d;
        // Downcast Animal object
        Dog da = (Dog)a;
        
        //Print out makeNoise() behaviours for each object
        System.out.print("hello");
        a.makeNoise();
        d.makeNoise();
        ad.makeNoise();
        da.makeNoise();
    }
    
}
