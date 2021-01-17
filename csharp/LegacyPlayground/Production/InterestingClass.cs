namespace Legacycodeplayground
{
    public class InterestingClass
    {
        int globalVariable;

        public InterestingClass()
        {
            globalVariable = 10;
        }

        public int methodWithComplexParameters(UnbelivableComplexClass complexVariable)
        {
            if (complexVariable.getProfit() > 4)
                return 5;
            else
                return 10;
        }



        void longMethod(int param)
        {
            int i;
            int sum = 0;

            // ....
            // ....
            // ....
            for (i = 0; i < param * 45; i++)
            {
                if (i < 12 + param)
                    sum = sum + i;
                else
                    sum = sum + 5;
            }

            // ....
            // ....
            // ....

            for (i = 0; i < param * param; i++)
            {
                for (int j = 0; j < param; j++)
                {
                    if (i < getSomethingFromDB(globalVariable) + 50)
                        sum = sum + i;
                    else
                        sum = sum + param;
                }
            }
            // ....
            // ....
            // ....
            if (sum < param)
            {
                sum = sum + param;
                ExternalCalls.updateDB(sum);
            }
            // ....
            // ....
            // ....
        }

        static int getSomethingFromDB(int param)
        {
            return 10 * param;
        }
    }
}