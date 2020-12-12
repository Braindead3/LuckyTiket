using System;

namespace LuckyTiket
{
    class Tiket
    {
        int[] leftSide = new int[3];
        int[] rightSide = new int[3];
        public bool lucky;

        public void FillTiket()
        {
            string str="";

            for (int i = 0; i < leftSide.Length; i++)
            {
                str = "";
                for (int j = 0; j < 3; j++)
                {
                    var random = RandomProvider.GetThreadRandom();
                    str += Convert.ToString(random.Next(1,10));
                }
                leftSide[i] = Convert.ToInt32(str);
            }

            for (int i = 0; i < rightSide.Length; i++)
            {
                str = "";
                for (int j = 0; j < 3; j++)
                {
                    var random = RandomProvider.GetThreadRandom();
                    str += Convert.ToString(random.Next(1,10));
                }
                rightSide[i] = Convert.ToInt32(str);
            }
        }

        public void LuckyChiNe()
        {
            int leftSum = 0, RightSum = 0;
            for (int i = 0; i < leftSide.GetLength(0); i++)
            {
                    leftSum += leftSide[i];
            }

            for (int i = 0; i < rightSide.GetLength(0); i++)
            {
                    RightSum += rightSide[i];
            }

            if (leftSum == RightSum)
            {
                lucky = true;
            }
            else
            {
                lucky = false;
            }
        }

        public override string ToString()
        {
            for (int i = 0; i < leftSide.Length; i++)
            {
                Console.WriteLine($"{leftSide[i]}{rightSide[i]}");
            }
            return "";
        }
    }
}
