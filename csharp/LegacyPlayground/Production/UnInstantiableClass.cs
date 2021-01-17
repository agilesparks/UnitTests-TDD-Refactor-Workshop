namespace Legacycodeplayground
{
    public class UnInstantiableClass
    {
        public int internalVariableA;
        public int internalVariableB;
        public UnbelivableComplexClass complexVariable;

        public UnInstantiableClass(UnbelivableComplexClass complexVariable)
        {
            internalVariableA = complexVariable.getProfit();
        }

        public int methodA(int myParam)
        {
            int i;
            int sum = 0;
            if (myParam < 1)
                sum = 10;
            for (i = 0; i < myParam * myParam; i++)
            {
                if (i < myParam + 50)
                    sum = sum + i;
                else
                    sum = sum + myParam;
            }
            return sum;
        }

        public void methodB(int myParam)
        {
            internalVariableB = myParam * 20;
        }

        public void methodC()
        {
            //Do things
            complexVariable.doSomehtingComplex();
            //Do some other things
            complexVariable.doSomehtingThatInvolvesSomeAPI();
            //Do some more stuff
        }

        public int getAmount()
        {
            return internalVariableA + internalVariableB;
        }
    }
}