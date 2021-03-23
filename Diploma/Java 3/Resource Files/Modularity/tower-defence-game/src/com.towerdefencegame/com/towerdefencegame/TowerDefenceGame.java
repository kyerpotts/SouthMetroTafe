package com.towerdefencegame;

import com.gameresources.*;

public class TowerDefenceGame {
    public static void main(String[] args) {
        Enemy e1 = new Enemy(); // enemy with default HP (100)
        Enemy e2 = new Enemy(500); // enemy with extra HP (500)

        Hero hero = new Hero(1000); // hero created with HP (1000)

        System.out.println("### HPs before tower/hero attack ###");
        System.out.println(e1.getHp()); // HPs before tower/hero attack
        System.out.println(e2.getHp());
        System.out.println(hero.getHp());

        Tower tower = new Tower(); // Only one tower in our game for testing

        tower.attack(e1, 10); // tower attacks the first enemy with damamge 10
        hero.attack(e2, 25); // Hero attacks the 2nd enemy with damage 25
        e1.attack(hero, 10); // e1 attacks the hero
        e2.attack(hero, 25); // e2 attacks the hero

        System.out.println("### HPs after tower/hero attack ###");
        System.out.println(e1.getHp()); // enemy HPs after tower attack
        System.out.println(e2.getHp());
        System.out.println(hero.getHp()); // Hero took no damage
    }
}
