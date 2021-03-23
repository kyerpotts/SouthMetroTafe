/*
 * 30003389
 * Kyer Potts
 */
package databaseapplication;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class DatabaseApplication {

    public static void main(String[] args) {
        String url = "jdbc:mysql://localhost:3306/";
        String user = "root";
        String password = "usbw";

        Connection con = null;
        Statement stmt = null;
        Statement stmt2 = null;
        String query;
        ResultSet result = null;
        ResultSet result2 = null;

        try {
            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();

            String sql = "USE schoolreport;";
            stmt.executeUpdate(sql);

            System.out.println("Grades:");

            query = "SELECT * FROM grades";
            result = stmt.executeQuery(query);

            while (result.next()) {
                String subject = result.getString("Subject");
                int score = result.getInt("Score");

                System.out.printf("%-20s %2d\n", subject, score);
            }

            stmt.close();

            System.out.println("Updating new grades...");
            stmt2 = con.createStatement();

            sql = "UPDATE grades SET Score = 75 WHERE Subject = \"English\";";
            stmt2.executeUpdate(sql);

            sql = "UPDATE grades SET Score = 69 WHERE Subject = \"Maths\";";
            stmt2.executeUpdate(sql);

            sql = "UPDATE grades SET Score = 50 WHERE Subject = \"Science\";";
            stmt2.executeUpdate(sql);

            sql = "UPDATE grades SET Score = 73 WHERE Subject = \"History\";";
            stmt2.executeUpdate(sql);

            result2 = stmt2.executeQuery(query);

            while (result2.next()) {
                String subject = result2.getString("Subject");
                int score = result2.getInt("Score");

                System.out.printf("%-20s %2d\n", subject, score);
            }

        } catch (Exception ex) {
            System.out.println("SQLException caught: " + ex.getMessage());
        } finally {
            // Close all database objects nicely
            try {
                if (result != null) {
                    result.close();
                }

                if (stmt != null) {
                    stmt.close();
                }
                if (result2 != null) {
                    result2.close();
                }
                if (stmt2 != null) {
                    stmt2.close();
                }
                if (con != null) {
                    con.close();
                }
            } catch (SQLException ex) {
                System.out.println("SQLException caught: " + ex.getMessage());
            }
        }
    }

}
