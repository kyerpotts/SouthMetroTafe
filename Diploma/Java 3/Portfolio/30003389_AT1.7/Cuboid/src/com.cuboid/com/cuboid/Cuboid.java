/*
 * Kyer Potts
 * 30003389
 */
package com.cuboid;

public class Cuboid <T extends Number> {
    private T length;
    private T breadth;
    private T height;
    
    public Cuboid(){}
    
    public Cuboid(T length, T breadth, T height){
    this.length = length;
    this.breadth = breadth;
    this.height = height;
    }
    
    public T getLength(){
        return this.length;
    }
    
    public void setLength(T length){
        this.length = length;
    }
    
    public T getBreadth(){
        return this.breadth;
    }
    
    public void setBreadth(T breadth){
        this.breadth = breadth;
    }
    
    public T getHeight(){
        return this.height;
    }
    
    public void setHeight(T height){
        this.height = height;
    }
    
    public String toString(){
        return ("Length: " + length + "\n" + "Height: " + height + "\n" + "Breadth: " + breadth + "\n");
    }
}
