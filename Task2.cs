using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    public int Price;
    public int Copies;
    private float Shipping;
    private float CostNoShip;
    private float Cost;
    private float Profit;

    // Start is called before the first frame update
    void Start()
    {
        CalculateProfit();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Find the cost of shipping given copies inputted
    void CalculateShipping()
    {
        // Check if the price for additional copies is needed
        if (Copies == 1)
        {
            Shipping = 3.0f;
        }
        else if (Copies > 1)
        {
            Shipping = 3.0f + (0.75f * Copies);
        }

    }

    // Find the money spent by the bookstore
    void CalculateCost()
    {
        CostNoShip = (Price * 0.6f) * Copies;
        Cost = CostNoShip + Shipping;

    }

    // Code that is ran on start, run shipping and cost methods, find the profit earned by bookstore, print to console
    void CalculateProfit()
    {
        CalculateShipping();
        CalculateCost();
        Profit = (Price * Copies) - Cost;
        Debug.Log("Cost: $" + Cost.ToString("0.00") + "  Profit: $" + Profit.ToString("0.00"));

    }
}