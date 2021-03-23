package soccerleague;

/**
 * Kyer Potts 30003389
 */
public class Team {

    private int id;
    private String name;
    private int[] player;
    private int[] wins;
    private String league;

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

    public int[] getPlayer() {
        return player;
    }

    public void setPlayer(int[] player) {
        this.player = player;
    }

    public int[] getWins() {
        return wins;
    }

    public void setWins(int[] wins) {
        this.wins = wins;
    }

    public String getLeague() {
        return league;
    }

    public void setLeague(String league) {
        this.league = league;
    }

    public void winGame() {

    }

    public void addPlayer() {
        
    }
    public void removePlayer() {
        
    }
}
