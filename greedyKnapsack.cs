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

            int capacity = 50;//Khả năng chứa tối đa là 50

            double maxValue = GreedyKnapsack(capacity, items);//gọi ra hàm greeknapsack để tính giá trị của ba lo
            Console.WriteLine("Maximum value in Knapsack = " + maxValue);

        }
        public class Item
        {
            public int Value { get; set; }//khai báo giá trị
            public int Weight { get; set; }//khai báo trọng lượng
            public double Ratio { get { return (double)Value / Weight; } }//Ratio chia giá trị với trọng lượng
        }
        public static double GreedyKnapsack(int capacity, List<Item> items)
        {
            // Sort items by value-to-weight ratio in descending order
            items.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));//sắp xếp theo giá trị/ trọng lượng giảm dần

            double totalValue = 0;
            int currentWeight = 0;//khởi tạo lại gT và TL = 0

            foreach (var item in items)//sau khi sắp xếp
            {
                if (currentWeight + item.Weight <= capacity)
                {
                    currentWeight += item.Weight;
                    totalValue += item.Value;//nếu đủ chỗ chứa thì thêm trọng lượng và giá trị vào
                }
                else
                {
                    int remainingWeight = capacity - currentWeight;
                    totalValue += item.Value * ((double)remainingWeight / item.Weight);//nếu quá chỗ chứa thì chỉ thêm phần vừa đủ dựa trên trọng lượng balo sau đó dừng
                    break;
                }
            }

            return totalValue;// trả về giá trị tổng của ba lo
            
        }



    }