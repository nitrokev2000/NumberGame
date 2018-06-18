package NumberRules;

import java.util.Random;

public class Number implements InterfaceNumber {
    int number;
    
    @Override
    public void MakeRandomNumber(int vMin, int vMax) {
        int randomNumber;
        Random rand = new Random();
        randomNumber = rand.nextInt(vMax) + vMin;
        SetNumber(randomNumber);
    }

    @Override
    public void PrintRandomNumber() {
        System.out.println(number);
    }

    @Override
    public void ResetRandomNumber() {
        number = 0;
    }

    @Override
    public int GetNumber() {
        return number;
    }

    @Override
    public void SetNumber(int vNumber) {
      number = vNumber;
    }
    
}
