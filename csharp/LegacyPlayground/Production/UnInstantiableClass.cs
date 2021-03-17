namespace Legacycodeplayground
{
    public class UnInstantiableClass
    {
        public int internalVariableA;
        public int internalVariableB;
        public UnbelievableComplexClass complexVariable;

        public UnInstantiableClass(UnbelievableComplexClass complexVariable)
        {
            internalVariableA = complexVariable.GetProfit();
        }

        public int MethodA(int myParam)
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

        public void MethodB(int myParam)
        {
            internalVariableB = myParam * 20;
        }

        public void MethodC()
        {
            //Do things
            complexVariable.DoSomethingComplex();
            //Do some other things
            complexVariable.DoSomethingThatInvolvesSomeApi();
            //Do some more stuff
        }

        public int GetAmount()
        {
            return internalVariableA + internalVariableB;
        }
    }
}