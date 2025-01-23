using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int Money;

    private int Hunds;
    private int Fiftys;
    private int Twentys;
    private int Tens;
    private int Fives;
    private int Ones;

    // Start is called before the first frame update
    void Start()
    {
        FindCash();
        PrintResults();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Method Prints Results based on FindCash method and int inputted by user
    void PrintResults()
    {
        if (Hunds >= 1)
        {
            Debug.Log("Hunds: " + Hunds + "   Fiftys: " + Fiftys + "   Twentys: " + Twentys + "   Tens: " + Tens + "   Fives: " + Fives + "   Ones: " + Ones);
        }
        else if (Fiftys >= 1)
        {
            Debug.Log("Fiftys: " + Fiftys + "   Twentys: " + Twentys + "   Tens: " + Tens + "   Fives: " + Fives + "   Ones: " + Ones);
        }
        else if (Twentys >= 1)
        {
            Debug.Log("Twentys: " + Twentys + "   Tens: " + Tens + "   Fives: " + Fives + "   Ones: " + Ones);
        }
        else if (Tens >= 1)
        {
            Debug.Log("Tens: " + Tens + "   Fives: " + Fives + "   Ones: " + Ones);
        }
        else if (Fives >= 1)
        {
            Debug.Log("Fives: " + Fives + "   Ones: " + Ones);
        }
        else
        {
            Debug.Log("Ones: " + Ones);
        }
    }

    // Method condenses all bill methods into one
    void FindCash()
    {
        FindHunds();
        FindFiftys();
        FindTwentys();
        FindTens();
        FindFives();
        FindOnes();
    }

    // Methods for each bill type
    // $100 bills
    void FindHunds()
    {
        Hunds = Money / 100;
    }
    // $50 bills
    void FindFiftys()
    {
        Fiftys = (Money - (Hunds * 100)) / 50;
    }
    // $20 bills
    void FindTwentys()
    {
        Twentys = ((Money - (Hunds * 100)) - (Fiftys * 50)) / 20;
    }
    // $10 bills
    void FindTens()
    {
        Tens = (((Money - (Hunds * 100)) - (Fiftys * 50)) - (Twentys * 20)) / 10;
    }
    // $5 bills
    void FindFives()
    {
        Fives = ((((Money - (Hunds * 100)) - (Fiftys * 50)) - (Twentys * 20)) - (Tens * 10)) / 5;
    }
    // $1 bills
    void FindOnes()
    {
        Ones = (((((Money - (Hunds * 100)) - (Fiftys * 50)) - (Twentys * 20)) - (Tens * 10)) - (Fives * 5));
    }
}