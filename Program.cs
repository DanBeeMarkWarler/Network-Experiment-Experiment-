using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Plz forgive my spaghetti code
 */

namespace project_163
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            bool loop = true;
                while (loop == true) {
                    loop = false;
                    //if (y < quarter) { randInt3 = 1; randInt = 1; randInt2 = 1; } else if (y > quarter && y < quarter * 2) { randInt3 = 2; randInt = 1; randInt2 = 2; }
                    //int loopNum = 0;
                    //while (loopNum < 19) {Console.WriteLine("if (y =< " + loopNum + "*quarter && y > ") };
                    //the doubles below are the weights
                    //yeah yeah, I know I was stupid for creating 84 weights instead of creating an array
                    Random rand = new Random();
                    //int u = 0;
                    //int randomStart = 0;
                    //int randomLimit = 100;
                    //while (u < 85) { Console.WriteLine("double w" + u + " = rand.Next(randomStart, randomLimit);"); u++; };
                    double w1 = 0;
                    double w2 = 0;
                    double w3 = 0;
                    double w4 = 0;
                    double w5 = 0;
                    double w6 = 0;
                    double w7 = 0;
                    double w8 = 0;
                    double w9 = 0;
                    double w10 = 0;
                    double w11 = 0;
                    double w12 = 0;
                    double w13 = 0;
                    double w14 = 0;
                    double w15 = 0;
                    double w16 = 0;
                    double w17 = 0;
                    double w18 = 0;
                    double w19 = 0;
                    double w20 = 0;
                    double w21 = 0;
                    double w22 = 0;
                    double w23 = 0;
                    double w24 = 0;
                    double w25 = 0;
                    double w26 = 0;
                    double w27 = 0;
                    double w28 = 0;
                    double w29 = 0;
                    double w30 = 0;
                    double w31 = 0;
                    double w32 = 0;
                    double w33 = 0;
                    double w34 = 0;
                    double w35 = 0;
                    double w36 = 0;
                    double w37 = 0;
                    double w38 = 0;
                    double w39 = 0;
                    double w40 = 0;
                    double w41 = 0;
                    double w42 = 0;
                    double w43 = 0;
                    double w44 = 0;
                    double w45 = 0;
                    double w46 = 0;
                    double w47 = 0;
                    double w48 = 0;
                    double w49 = 0;
                    double w50 = 0;
                    double w51 = 0;
                    double w52 = 0;
                    double w53 = 0;
                    double w54 = 0;
                    double w55 = 0;
                    double w56 = 0;
                    double w57 = 0;
                    double w58 = 0;
                    double w59 = 0;
                    double w60 = 0;
                    double w61 = 0;
                    double w62 = 0;
                    double w63 = 0;
                    double w64 = 0;
                    double w65 = 0;
                    double w66 = 0;
                    double w67 = 0;
                    double w68 = 0;
                    double w69 = 0;
                    double w70 = 0;
                    double w71 = 0;
                    double w72 = 0;
                    double w73 = 0;
                    double w74 = 0;
                    double w75 = 0;
                    double w76 = 0;
                    double w77 = 0;
                    double w78 = 0;
                    double w79 = 0;
                    double w80 = 0;
                    double w81 = 0;
                    double w82 = 0;
                    double w83 = 0;
                    double w84 = 0;
                    //the rule is that 'n' = the neuron number and 'L' = the layer number
                    //doubles n1 - n4 is the information on what the numbers are, the other two are for specifying the operation.
                    double n1L1 = 0;
                    double n2L1 = 0;
                    double n3L1 = 0;
                    double n4L1 = 0;
                    //the doubles below determine the operator, if its 1 or 2 then the operation will be done
                    //1 = n5L1 = + 
                    //2 = n6L1 = -
                    double n5L1 = 0;
                    double n6L1 = 0;
                    //below is the loop that lets the user interact with the network
                    /*
                    Console.WriteLine("Do you want to enter the numbers or have it automated? (y/n)");
                    string entry0 = Console.ReadLine();
                    if(entry0 == "y") { };
                    */
                    Console.WriteLine("Enter how long the dataset should be");
                    int datasetLength = Convert.ToInt32(Console.ReadLine());
                    int y = 0;
                    int trainingSectionAmount = 28;
                    while (y < datasetLength) {
                        
                        int randInt = 0;
                        int randInt2 = 0;
                        int randInt3 = 0;
                        Console.WriteLine(y);
                        //int quarter = Math.Floor(datasetLength / trainingSectionAmount);
                        int quarter = datasetLength / trainingSectionAmount;
                        if (y < quarter) { randInt3 = 1; randInt = 1; randInt2 = 1; } else if (y > quarter && y < quarter * 2) { randInt3 = 2; randInt = 1; randInt2 = 2; } else if (y > quarter * 2 && y < quarter * 3) { randInt3 = 1; randInt = 2; randInt2 = 1; } else if (y > quarter * 3 && y < quarter * 4) { randInt3 = 4; randInt = 1; randInt2 = 2; }
                        else if (y > quarter * 4 && y < quarter * 5) { randInt3 = 1; randInt = 1; randInt2 = 3; } else if (y > quarter * 5 && y < quarter * 6) { randInt3 = 2; randInt = 2; randInt2 = 3; } else if (y > quarter * 6 && y < quarter * 7) { randInt3 = 4; randInt = 1; randInt2 = 4; } else if (y > quarter * 7 && y < quarter * 8) { randInt3 = 3; randInt = 1; randInt2 = 2; } else if (y > quarter * 8 && y < quarter * 9) { randInt3 = 4; randInt = 2; randInt2 = 3; } else if (y > quarter * 9 && y < quarter * 10) { randInt3 = 1; randInt = 2; randInt2 = 3; }
                        else if (y > quarter * 10 && y < quarter * 11) { randInt3 = 3; randInt = 2; randInt2 = 1; } else if (y > quarter * 11 && y < quarter * 12) { randInt3 = 3; randInt = 1; randInt2 = 3; } else if (y > quarter * 12 && y < quarter * 13) { randInt3 = 2; randInt = 1; randInt2 = 3; } else if (y > quarter * 13 && y < quarter * 14) { randInt3 = 2; randInt = 2; randInt2 = 4; } else if (y > quarter * 14 && y < quarter * 15) { randInt3 = 3; randInt = 1; randInt2 = 4; } else if (y > quarter * 15 && y < quarter * 16) { randInt3 = 3; randInt = 2; randInt2 = 4; } else if (y > quarter * 16 && y < quarter * 17) { randInt3 = 4; randInt = 1; randInt2 = 3; }
                        else if (y > quarter * 17 && y < quarter * 18) { randInt3 = 2; randInt = 1; randInt2 = 4; } else if (y > quarter * 18 && y < quarter * 19) { randInt3 = 3; randInt = 2; randInt2 = 3; } else if (y > quarter * 19 && y < quarter * 20) { randInt3 = 4; randInt = 1; randInt2 = 4; } else if (y > quarter * 20 && y < quarter * 21) { randInt3 = 4; randInt = 2; randInt2 = 1; } else if (y > quarter * 21 && y < quarter * 22) { randInt3 = 4; randInt = 1; randInt2 = 1; } else if (y > quarter * 22 && y < quarter * 23) { randInt3 = 4; randInt = 2; randInt2 = 2; } else if (y > quarter * 23 && y < quarter * 24) { randInt3 = 3; randInt = 1; randInt2 = 1; }
                        else if (y > quarter * 24 && y < quarter * 25) { randInt3 = 3; randInt = 1; randInt2 = 1; } else if (y > quarter * 25 && y < quarter * 26) { randInt3 = 4; randInt = 2; randInt2 = 1; } else if (y > quarter * 26 && y < quarter * 27) { randInt3 = 2; randInt = 1; randInt2 = 1; } else if (y > quarter * 27 && y < quarter * 28) { randInt3 = 3; randInt = 1; randInt2 = 2; } else if (y > quarter * 28 && y < quarter * 29) { randInt3 = 1; randInt = 2; randInt2 = 4; }
                        //The if statement below compares 'entry' with a number and depending on the number, it assigns the value to the corosponding number
                        if (randInt2 == 1) { n1L1 = n1L1 + 1; } else if (randInt2 == 2) { n2L1 = n2L1 + 1; } else if (randInt2 == 3) { n3L1 = n3L1 + 1; } else if (randInt2 == 4) { n4L1 = n4L1 + 1; } else { Console.WriteLine("Error2"); };
                        if (randInt == 1) { n5L1 = 1; } else if (randInt == 2) { n6L1 = 1; } else { Console.WriteLine("Error7"); };
                        if (randInt3 == 1) { n1L1 = n1L1 + 1; } else if (randInt3 == 2) { n2L1 = n2L1 + 1; } else if (randInt3 == 3) { n3L1 = n3L1 + 1; } else if (randInt3 == 4) { n4L1 = n4L1 + 1; } else { Console.WriteLine("Error5"); };
                        y++;
                        Console.WriteLine(randInt2+" "+randInt+" "+randInt3);
                        Console.ReadLine();
                        double n1L2 = n1L1 * w1 + n2L1 * w2 + n3L1 * w3 + n4L1 * w4 + n5L1 * w5 + n6L1 * w6;
                        double n2L2 = n1L1 * w7 + n2L1 * w8 + n3L1 * w9 + n4L1 * w10 + n5L1 * w11 + n6L1 * w12;
                        double n3L2 = n1L1 * w13 + n2L1 * w14 + n3L1 * w15 + n4L1 * w16 + n5L1 * w17 + n6L1 * w18;
                        double n4L2 = n1L1 * w19 + n2L1 * w20 + n3L1 * w21 + n4L1 * w22 + n5L1 * w23 + n6L1 * w24;
                        double n5L2 = n1L1 * w25 + n2L1 * w26 + n3L1 * w27 + n4L1 * w28 + n5L1 * w29 + n6L1 * w30;
                        double n6L2 = n1L1 * w31 + n2L1 * w32 + n3L1 * w33 + n4L1 * w34 + n5L1 * w35 + n6L1 * w36;

                        double n1L3 = n1L2 * w37 + n2L2 * w38 + n3L2 * w39 + n4L2 * w40 + n5L2 * w41 + n6L2 * w42;
                        double n2L3 = n1L2 * w43 + n2L2 * w44 + n3L2 * w45 + n4L2 * w46 + n5L2 * w47 + n6L2 * w48;
                        double n3L3 = n1L2 * w49 + n2L2 * w50 + n3L2 * w51 + n4L2 * w52 + n5L2 * w53 + n6L2 * w54;
                        double n4L3 = n1L2 * w55 + n2L2 * w56 + n3L2 * w57 + n4L2 * w58 + n5L2 * w59 + n6L2 * w60;
                        double n5L3 = n1L2 * w61 + n2L2 * w62 + n3L2 * w63 + n4L2 * w64 + n5L2 * w65 + n6L2 * w66;
                        double n6L3 = n1L2 * w67 + n2L2 * w68 + n3L2 * w69 + n4L2 * w70 + n5L2 * w71 + n6L2 * w72;

                        double n1L4 = n1L3 * w73 + n2L3 * w74 + n3L3 * w75 + n4L2 * w76 + n5L3 * w77 + n6L3 * w78;
                        double n2L4 = n1L3 * w79 + n2L3 * w80 + n3L3 * w81 + n4L2 * w82 + n5L3 * w83 + n6L3 * w84;
                        // n1L4 = <0
                        // n2L4 = >0
                        double[] inputNumbers = { n1L1, n2L1, n3L1, n4L1};
                        double[] inputOperators = { n5L1, n6L1};
                        int num1 = 0;
                        int num2 = 0;
                        int operation = 0;
                        int i = 1;
                        while (i < 3) {
                            i++;
                            if (inputNumbers[i] == 1) { if (n1L1 == 1) { num1 = 1; } else if (n2L1 == 1) { num1 = 2; } else if (n3L1 == 1) { num1 = 3; } else if (n4L1 == 1) { num1 = 4; } else if (n1L1 == 2) { num1 = 1; num2 = 1; } else if (n2L1 == 2) { num1 = 2; num2 = 2; } else if (n3L1 == 2) { num1 = 3; num2 = 3; } else if (n4L1 == 2) { num1 = 4; num2 = 4; } };
                            if (inputOperators[i] == 1) { if (n5L1 == 1) { operation = 1; } else if (n6L1 == 1) { operation = 2; } };
                        };
                        double answer = 0;
                        bool correct = true;
                        if (operation == 1) { answer = num1 + num2; } else if (operation == 2) { answer = num1 - num2; } else { Console.WriteLine("Error 13"); };
                        if ( n1L4 == 1 && answer <= 0) { correct = true; } else if (n1L4 == 1 && answer >= 0) { correct = false; };
                        if (n2L4 == 1 && answer >= 0) { correct = true; } else if (n2L4 == 1 && answer <= 0) { correct = false; };
                        Console.WriteLine(correct);
                    }
                    Console.ReadLine();
                }
            }
            catch { Console.WriteLine("Error0"); Console.ReadLine(); }
        }
    }
}
