package soccerleague;

import java.util.*;
import java.util.ArrayList;

public class Scheduler {
    ArrayList<Game> gamesList = new ArrayList<>();
    private Team[] teamArray = new Team[4];
    private int[] selector = new int[4];
    private int gameCounter = 0;
    private Random rgen = new Random();

    Scanner sc = new Scanner(System.in);

    public void CreateTeams() {
        teamArray[0] = new Team("Team One");
        teamArray[1] = new Team("Team Two");
        teamArray[2] = new Team("Team Three");
        teamArray[3] = new Team("Team Four");
        selector[0] = 0;
        selector[1] = 1;
        selector[2] = 2;
        selector[3] = 3;
    }

    public void RandomiseArray() {
        for (int i = 0; i < selector.length; i++) {
            int randPos = rgen.nextInt(selector.length);
            int temp = selector[i];
            selector[i] = selector[randPos];
            selector[randPos] = temp;
        }
    }

    public void RunSeason(int temp) {
        try {
            int tempCount = 0;
            while (tempCount < 2) {
                if (temp > 0 && temp < 30) {
                    RandomiseArray();
                    RunGame(temp, teamArray[selector[0]], teamArray[selector[1]]);
                    gameCounter++;
                    RunGame(temp, teamArray[selector[2]], teamArray[selector[3]]);
                    gameCounter++;
                    tempCount = 0;
                    System.out.println("Enter the temperature for the next day");
                    temp = sc.nextInt();
                } else if (temp <= 0) {
                    System.out.println("it is too cold to play");
                    System.out.println("Enter the temperature for the next day");
                    temp = sc.nextInt();
                    tempCount++;
                } else if (temp >= 30) {
                    System.out.println("It is too hot and nobody wants to play");
                    System.out.println("Enter the temperature for the next day");
                    temp = sc.nextInt();
                }
            }
            System.out.println("The season has ended, printing end of season stats...");
            System.out.println("***TEAM RESULTS***");
            for (int i = 0; i < teamArray.length; i++) {
                System.out.println(teamArray[i].getTeamName());
                System.out.println("Wins: " + teamArray[i].getWinTotal() + ", Losses: " + teamArray[i].getLossTotal() + ", Ties: " + teamArray[i].getTieTotal());
                System.out.println("Goals Scored: " + teamArray[i].getTotalScored() + ", Goals Allowed: " + teamArray[i].getTotalAllowed());
                System.out.println();
            }
            System.out.println();
            System.out.println("***MATCH RESULTS***");
            for (int i = 0; i < gamesList.size(); i++) {
                System.out.println("Game # " + (gamesList.get(i).getId() + 1));
                System.out.println("Temperature: " + gamesList.get(i).getTemp());
                System.out.println(gamesList.get(i).getTeamOne() + " Score: " + gamesList.get(i).getTeamOneScore());
                System.out.println(gamesList.get(i).getTeamTwo() + " Score: " + gamesList.get(i).getTeamTwoScore());
                System.out.println("Result: " + gamesList.get(i).getResult());
                System.out.println();

            }
        }catch(Exception e){
            System.out.println("Invalid Input");
        }
    }

    public void RunGame(int temp, Team teamOne, Team teamTwo) {
        if (temp > 0 && temp < 15) {
            gamesList.add(new Game(gameCounter, teamOne, teamTwo));
            gamesList.get(gameCounter).setTemp(temp);
            gamesList.get(gameCounter).setTeamOneScore(rgen.nextInt(4));
            gamesList.get(gameCounter).setTeamTwoScore(rgen.nextInt(4));
            teamOne.setTotalScored(teamOne.getTotalScored() + gamesList.get(gameCounter).getTeamOneScore());
            teamOne.setTotalAllowed(teamOne.getTotalAllowed() + gamesList.get(gameCounter).getTeamTwoScore());
            teamTwo.setTotalScored(teamTwo.getTotalScored() + gamesList.get(gameCounter).getTeamTwoScore());
            teamTwo.setTotalAllowed(teamTwo.getTotalAllowed() + gamesList.get(gameCounter).getTeamOneScore());
            if (gamesList.get(gameCounter).getTeamOneScore() > gamesList.get(gameCounter).getTeamTwoScore()) {
                gamesList.get(gameCounter).setResult(gamesList.get(gameCounter).getTeamOne() + " won");
                teamOne.setWinTotal(teamOne.getWinTotal() + 1);
                teamTwo.setLossTotal((teamTwo.getLossTotal() + 1));
            } else if (gamesList.get(gameCounter).getTeamTwoScore() > gamesList.get(gameCounter).getTeamOneScore()) {
                gamesList.get(gameCounter).setResult(gamesList.get(gameCounter).getTeamTwo() + " won");
                teamTwo.setWinTotal(teamTwo.getWinTotal() + 1);
                teamOne.setLossTotal((teamOne.getLossTotal() + 1));
            } else {
                gamesList.get(gameCounter).setResult("Tie");
                teamOne.setTieTotal(teamOne.getTieTotal() + 1);
                teamTwo.setTieTotal(teamTwo.getTieTotal() + 1);
            }
        } else if (temp >= 15 && temp < 30) {
            gamesList.add(new Game(gameCounter, teamOne, teamTwo));
            gamesList.get(gameCounter).setTemp(temp);
            gamesList.get(gameCounter).setTeamOneScore(rgen.nextInt(6));
            gamesList.get(gameCounter).setTeamTwoScore(rgen.nextInt(6));
            teamOne.setTotalScored(teamOne.getTotalScored() + gamesList.get(gameCounter).getTeamOneScore());
            teamOne.setTotalAllowed(teamOne.getTotalAllowed() + gamesList.get(gameCounter).getTeamTwoScore());
            teamTwo.setTotalScored(teamTwo.getTotalScored() + gamesList.get(gameCounter).getTeamTwoScore());
            teamTwo.setTotalAllowed(teamTwo.getTotalAllowed() + gamesList.get(gameCounter).getTeamOneScore());
            if (gamesList.get(gameCounter).getTeamOneScore() > gamesList.get(gameCounter).getTeamTwoScore()) {
                gamesList.get(gameCounter).setResult(gamesList.get(gameCounter).getTeamOne() + " won");
                teamOne.setWinTotal(teamOne.getWinTotal() + 1);
                teamTwo.setLossTotal((teamTwo.getLossTotal() + 1));
            } else if (gamesList.get(gameCounter).getTeamTwoScore() > gamesList.get(gameCounter).getTeamOneScore()) {
                gamesList.get(gameCounter).setResult(gamesList.get(gameCounter).getTeamTwo() + " won");
                teamTwo.setWinTotal(teamTwo.getWinTotal() + 1);
                teamOne.setLossTotal((teamOne.getLossTotal() + 1));
            } else {
                gamesList.get(gameCounter).setResult("Tie");
                teamOne.setTieTotal(teamOne.getTieTotal() + 1);
                teamTwo.setTieTotal(teamTwo.getTieTotal() + 1);
            }
        }
    }
}



