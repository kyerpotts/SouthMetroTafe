/*
 * 30003389
 * Kyer Potts
 */
package soccerleague;

public class Team {
    private String teamName;
    private int winTotal;
    private int lossTotal;
    private int tieTotal;
    private int totalScored;
    private int totalAllowed;
    
    public Team(String teamName){
        this.teamName = teamName;
        this.winTotal = 0;
        this.lossTotal = 0;
        this.tieTotal = 0;
        this.totalScored = 0;
        this.totalAllowed = 0;
    }

    public String getTeamName() {
        return teamName;
    }

    public void setTeamName(String teamName) {
        this.teamName = teamName;
    }

    public int getWinTotal() {
        return winTotal;
    }

    public void setWinTotal(int winTotal) {
        this.winTotal = winTotal;
    }

    public int getLossTotal() {
        return lossTotal;
    }

    public void setLossTotal(int lossTotal) {
        this.lossTotal = lossTotal;
    }

    public int getTieTotal() {
        return tieTotal;
    }

    public void setTieTotal(int tieTotal) {
        this.tieTotal = tieTotal;
    }

    public int getTotalScored() {
        return totalScored;
    }

    public void setTotalScored(int totalScored) {
        this.totalScored = totalScored;
    }

    public int getTotalAllowed() {
        return totalAllowed;
    }

    public void setTotalAllowed(int totalAllowed) {
        this.totalAllowed = totalAllowed;
    }
}
