/*
 * Kyer Potts
 * 30003389
 */
package com.cuboiddemo;

import com.cuboid.*;

public class CuboidDemo {

    public static void main(String[] args) {
        Cuboid<Double> c1 = new Cuboid<>();
        c1.setBreadth(2.2);
        c1.setLength(1.3);
        c1.setHeight(2.0);
        
        System.out.println(c1);
        
        Cuboid<Integer> c2 = new Cuboid<>(1, 2, 3);
        System.out.println(c2);
    }
    
}
