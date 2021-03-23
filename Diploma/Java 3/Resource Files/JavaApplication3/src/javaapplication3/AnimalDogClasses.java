package javaapplication3;

public class AnimalDogClasses {

    public static void main(String[] args) {
        // Instantiate Animal object
        Animal a = new Animal();
        // Instantiate Dog object
        Dog d = new Dog();
        // Upcast Dog object
        Animal ad = (Animal)d;
        // Downcast Animal object
        Animal da = new Dog();
        
        //Print out makeNoise() behaviours for each object
        System.out.print("hello");
        a.makeNoise();
        d.makeNoise();
        ad.makeNoise();
        ((Dog) da).bark();
    }
    
}
