package NumberRules;

import Processes.DatabaseStorage;
import Processes.JavaSocket;
import java.io.IOException;
import java.sql.SQLException;
import java.util.Random;

public class Model extends Number {

    private boolean running;
    JavaSocket javaSocket;
    DatabaseStorage storage;

    public Model() throws ClassNotFoundException, IOException, SQLException {
        javaSocket = new JavaSocket();
        storage = new DatabaseStorage();
    }

    public void Game() throws IOException, SQLException, ClassNotFoundException {
        running = true;
        MakeRandomNumber(1, 50000);
        javaSocket.setHighs(0);
        javaSocket.setLows(0);
        System.out.println("Answer: " + number);

        while (running) {
            javaSocket.Initialize(number);
            running = javaSocket.RunServer();
        }

        StoreData();

        PrintStats();

        Game();
    }

    private void PrintStats() {
        System.out.println("DataStorage Example:");
        System.out.println("Highs: ");
        storage.PrintStats("high");
        System.out.println("Lows: ");
        storage.PrintStats("low");
        System.out.println("Sorting Example:");
        System.out.println("Highs: ");
        storage.SortStats("high");
        System.out.println("Lows: ");
        storage.SortStats("low");
    }

    private void StoreData() throws SQLException {
        if (!javaSocket.getReceived().equals("Reset")) {
            System.out.println("Lows: " + javaSocket.getLows() + ", Highs: " + javaSocket.getHighs() + ", Inserted into Database");
            storage.Insert(javaSocket.getLows(), javaSocket.getHighs());
            System.out.println("Currently Stored: ");
            storage.DisplayAll();
        }
    }

}
