/*
 * 30003389
 * Kyer Potts
 */
package soccerleague;

import java.util.Scanner;

public class SoccerLeague {

    public static void main(String[] args) {
        Scheduler sched = new Scheduler();
        Scanner sc = new Scanner(System.in);
        sched.CreateTeams();
        System.out.println("Enter the temperature of the first day of the season");
        try {
            int temp = sc.nextInt();
            sched.RunSeason(temp);
        } catch (Exception e) {
            System.out.println("Invalid Input" + e);
        }
    }

}
