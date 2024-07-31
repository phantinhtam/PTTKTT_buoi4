using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>
        {
            new Item { Value = 60, Weight = 10 },
            new Item { Value = 100, Weight = 20 },
            new Item { Value = 120, Weight = 30 }
        };

        int capacity = 50;

        double maxValue = KnapsackBranchAndBound(capacity, items);
        Console.WriteLine("Maximum value in Knapsack = " + maxValue);
    }

    public class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public double Ratio { get { return (double)Value / Weight; } }
    }

    public class Node
    {
        public int Level { get; set; }
        public int Profit { get; set; }
        public int Weight { get; set; }
        public double Bound { get; set; }
    }

    static double Bound(Node u, int n, int W, List<Item> items)
    {
        if (u.Weight >= W)
            return 0;

        double profit_bound = u.Profit;

        int j = u.Level + 1;
        int totweight = u.Weight;

        while ((j < n) && (totweight + items[j].Weight <= W))
        {
            totweight += items[j].Weight;
            profit_bound += items[j].Value;
            j++;
        }

        if (j < n)
            profit_bound += (W - totweight) * items[j].Ratio;

        return profit_bound;
    }

    public static double KnapsackBranchAndBound(int W, List<Item> items)
    {
        items.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));

        Queue<Node> Q = new Queue<Node>();
        Node u, v;

        u = new Node { Level = -1, Profit = 0, Weight = 0 };
        Q.Enqueue(u);

        double maxProfit = 0;

        while (Q.Count > 0)
        {
            u = Q.Dequeue();

            if (u.Level == -1)
                v = new Node { Level = 0 };
            if (u.Level == items.Count - 1)
                continue;

            v = new Node { Level = u.Level + 1 };

            v.Weight = u.Weight + items[v.Level].Weight;
            v.Profit = u.Profit + items[v.Level].Value;

            if (v.Weight <= W && v.Profit > maxProfit)
                maxProfit = v.Profit;

            v.Bound = Bound(v, items.Count, W, items);

            if (v.Bound > maxProfit)
                Q.Enqueue(v);

            v.Weight = u.Weight;
            v.Profit = u.Profit;

            v.Bound = Bound(v, items.Count, W, items);

            if (v.Bound > maxProfit)
                Q.Enqueue(v);
        }

        return maxProfit;
    }
}
