/*
 * Kyer Potts
 * 30003389
 */

package serializationtest;

import java.io.Serializable;


public class Person implements Serializable{
    private String name;
    private int age;
    
    public Person(String n, int a){
        name = n;
        age = a;
    }
    
    @Override
    public String toString(){
    return name + " is " + age + " years old.";
    }
}
