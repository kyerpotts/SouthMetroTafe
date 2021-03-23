/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package soccerleague;

/**
 * Kyer Potts
 * 30003389
 */


public class Player {
    private int id;
    private String name;
    private int[] goals;
    private String team;
    private int[] wins;

    
    public int getId() {
        return id;
    }

    
    public void setId(int id) {
        this.id = id;
    }

    
    public String getName() {
        return name;
    }

    
    public void setName(String name) {
        this.name = name;
    }

    
    public int[] getGoals() {
        return goals;
    }

    
    public void setGoals(int[] goals) {
        this.goals = goals;
    }

    
    public String getTeam() {
        return team;
    }

    
    public void setTeam(String team) {
        this.team = team;
    }

    
    public int[] getWins() {
        return wins;
    }

    
    public void setWins(int[] wins) {
        this.wins = wins;
    }
}
