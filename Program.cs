namespace Lottery_Ex3_7
{
    class Program
    {
        private static int[] lotteryNum = new int[7];
        private static int RunLottery()
        {
            int openNum;
            Random rnd = new Random();
            openNum = rnd.Next(1, 50);
            if (lotteryNum.Contains(openNum))
            {
                return RunLottery();
            }
            else
            {
                return openNum;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("大樂透電腦自動選號：");
            Console.Write("一般號碼：");
            for (int i = 0; i < 7; i++)
            {
                if (i != 6)
                {
                    if (i != 5)
                    {
                        lotteryNum[i] = RunLottery();
                        Console.Write("{0} , ", lotteryNum[i]);
                    }
                    else
                    {
                        lotteryNum[i] = RunLottery();
                        Console.Write("{0}", lotteryNum[i]);
                    }

                }
                else
                {
                    lotteryNum[i] = RunLottery();
                    Console.WriteLine();
                    Console.Write("特 別 號：{0}", lotteryNum[i]);
                }

            }
            Console.Read();
        }
    }
}