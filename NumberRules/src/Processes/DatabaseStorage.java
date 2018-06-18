package Processes;

import java.sql.Connection;

import java.sql.DriverManager;
import java.sql.ResultSet;

import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class DatabaseStorage {

    private Connection connection;
    private Statement statement;
    private ResultSet resultSet;
    private List high = new ArrayList();
    private List low = new ArrayList();

    public DatabaseStorage() throws ClassNotFoundException, SQLException {
        DatabaseLevel data = new DatabaseLevel();
        data.Connect();
    }

    private class DatabaseLevel {
        public void Connect() throws ClassNotFoundException, SQLException {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
            String connectionURL = "jdbc:sqlserver://localhost:1433;databaseName=Stats;user=USER;password=PASSWORD";
            connection = DriverManager.getConnection(connectionURL);
            System.out.println("You are connected to SQLServer");
        }
    }

    public void PrintStats(String temp) {
        if (temp.equals("high")) {
            for (int i = 0; i < high.size(); i++) {
                
                System.out.println(high.get(i));
            }
        } else if (temp.equals("low")) {
            for (int i = 0; i < low.size(); i++) {
                System.out.println(low.get(i));
            }
        }
    }

    public void SortStats(String temp) {
        if (temp.equals("high")) {
            Collections.sort(high);
        } else if (temp.equals("low")) {
            Collections.sort(low);
        }
        PrintStats(temp);
    }

    public void Insert(int lows, int highs) throws SQLException {
        statement = connection.createStatement();

        high.add(highs);
        low.add(lows);

        statement.executeUpdate("INSERT INTO Statistic(Highs, Lows) " + "VALUES (" + highs + "," + lows + ")");
    }

    public void DisplayAll() throws SQLException {
        resultSet = statement.executeQuery("select * from Statistic");
        while (resultSet.next()) {
            String ID = resultSet.getString(1);
            String Highs = resultSet.getString(2);
            String Lows = resultSet.getString(3);
            System.out.println(ID + " " + Highs + " " + Lows);
        }
    }
}
