package com.gildedrose;

class UnInstantiableClass {
    public int internalVariableA;
    public int internalVariableB;
    public UnbelivableComplexClass complexVariable;

    UnInstantiableClass(UnbelivableComplexClass complexVariable) {
        complexVariable = complexVariable;
        internalVariableA = complexVariable.getProfit();
    }

    public void methodA(int myParam) {
        int i;
        int sum = 0;
        if (myParam < 1)
            myParam = 10;
        for (i = 0; i < myParam * myParam; i++) {
            if (i < myParam + 50)
                sum = sum + i;
            else
                sum = sum + myParam;
        }
    }

    public void methodB(int myParam) {
        internalVariableB = myParam * 20;
    }

    public int getAmount() {
        return internalVariableA + internalVariableB;
    }
};