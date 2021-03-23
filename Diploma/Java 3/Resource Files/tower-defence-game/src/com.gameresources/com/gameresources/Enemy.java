package com.gameresources;

public class Enemy {
    private int hp;

    public Enemy() {
        hp = 100;
    }

    public Enemy(int hpValue) {
        hp = hpValue;
    }

    public int getHp() {
        return hp;
    }

    public void getDamage(int damage) {
        hp -= damage;
    }

    public void attack(Hero h, int attackStrengh) {
        h.getDamage(attackStrengh);
    }
}
