package soccerleague;
import java.sql.*;
/**
 * Kyer Potts
 * 30003389
 */
public class Game {
    private int id;
    private String teamWin;
    private String teamOne;
    private String teamTwo;
    private int teamOneScore;
    private int teamTwoScore;
    private Timestamp time;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTeamWin() {
        return teamWin;
    }

    public void setTeamWin(String teamWin) {
        this.teamWin = teamWin;
    }

    public String getTeamOne() {
        return teamOne;
    }

    public void setTeamOne(String teamOne) {
        this.teamOne = teamOne;
    }

    public String getTeamTwo() {
        return teamTwo;
    }

    public void setTeamTwo(String teamTwo) {
        this.teamTwo = teamTwo;
    }

    public int getTeamOneScore() {
        return teamOneScore;
    }

    public void setTeamOneScore(int teamOneScore) {
        this.teamOneScore = teamOneScore;
    }

    public int getTeamTwoScore() {
        return teamTwoScore;
    }

    public void setTeamTwoScore(int teamTwoScore) {
        this.teamTwoScore = teamTwoScore;
    }

    public void setTime(Timestamp time) {
        this.time = time;
    }
    public void startGame() {
        
    }
    public void endGame() {
        
    }
    
}
