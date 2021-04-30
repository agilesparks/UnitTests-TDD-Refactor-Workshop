#include "UnbelievableComplexClass.h"

class UnInstantiableClass
{
public:
    int internalVaribleA;
    int internalVaribleB;
    UnbelievableComplexClass *complexVariable;

    UnInstantiableClass(UnbelievableComplexClass *complexVariable) : complexVariable(complexVariable)
    {internalVaribleA = complexVariable->getProfit();}

    int methodA(int myParam);
    void methodB(int myParam);
    int getAmount();
};