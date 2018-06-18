package Processes;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class JavaSocket {

    private int highs;
    private int lows;
    private boolean running;
    private int number;
    private String received, toSend;
    private JavaSocket.ServerLevel serverLevel;
    private ServerSocket serverSocket;
    private Socket socket;
    private InputStream is;
    private OutputStream os;

    private class ServerLevel {

        //Server Receiving
        private void Receiving() throws IOException {
            // Receiving
            byte[] lenBytes = new byte[4];
            is.read(lenBytes, 0, 4);
            int len = (((lenBytes[3] & 0xff) << 24) | ((lenBytes[2] & 0xff) << 16) | ((lenBytes[1] & 0xff) << 8) | (lenBytes[0] & 0xff));
            byte[] receivedBytes = new byte[len];
            is.read(receivedBytes, 0, len);
            received = new String(receivedBytes, 0, len);

            System.out.println("received: " + received);
        }

        //Server Sending
        private void Send() throws IOException {
            byte[] toSendBytes = toSend.getBytes();
            int toSendLen = toSendBytes.length;
            byte[] toSendLenBytes = new byte[4];
            toSendLenBytes[0] = (byte) (toSendLen & 0xff);
            toSendLenBytes[1] = (byte) ((toSendLen >> 8) & 0xff);
            toSendLenBytes[2] = (byte) ((toSendLen >> 16) & 0xff);
            toSendLenBytes[3] = (byte) ((toSendLen >> 24) & 0xff);
            os.write(toSendLenBytes);
            os.write(toSendBytes);
        }

        //End Server
        private void EndServer() throws IOException {
            socket.close();
            serverSocket.close();
        }

        //Server Proccess
        private void ServerProcess() throws IOException {
            String newReceived;

            if (received.contains("Guess")) {

                newReceived = received.replace("Guess: ", "");
                if (Integer.parseInt(newReceived) == number) {
                    toSend = "1";
                    Reset();
                } else if (Integer.parseInt(newReceived) > number) {
                    lows++;
                    toSend = "2";
                } else {
                    highs++;
                    toSend = "3";
                }
            } else if (received.equals("Reset")) {
                toSend = "4";
                Reset();
            } else {
                toSend = "Test Connection Successful";
            }
        }
    }
    
    public JavaSocket() {
        serverLevel = new ServerLevel();
    }
    
    //Run Server
    public boolean RunServer() throws IOException {
        serverLevel.Receiving();
        serverLevel.ServerProcess();
        serverLevel.Send();
        serverLevel.EndServer();
        return running;
    }

    //Initialize Server
    public void Initialize(int vNumber) throws IOException {
        running = true;
        number = vNumber;
        serverSocket = new ServerSocket(4343, 10);
        socket = serverSocket.accept();
        is = socket.getInputStream();
        os = socket.getOutputStream();
    }
    
    private void Reset() {
        running = false;
    }

    public int getLows() {
        return lows;
    }

    public int getHighs() {
        return highs;
    }

    public void setLows(int vLows) {
        lows = vLows;
    }

    public void setHighs(int vHighs) {
        highs = vHighs;
    }
    
    public String getReceived() {
        return received;
    }

    public void setReceived(String vReceived) {
        received = vReceived;
    }
}
