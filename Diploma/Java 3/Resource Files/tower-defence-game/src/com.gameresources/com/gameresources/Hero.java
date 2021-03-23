package com.gameresources;

public class Hero {
    private int hp;

    public Hero() {
        hp = 100;
    }

    public Hero(int hpValue) {
        hp = hpValue;
    }

    public int getHp() {
        return hp;
    }

    public void getDamage(int damage) {
        hp -= damage;
    }

    public void attack(Enemy e, int attackStrengh) {
        e.getDamage(attackStrengh);
    }
}
