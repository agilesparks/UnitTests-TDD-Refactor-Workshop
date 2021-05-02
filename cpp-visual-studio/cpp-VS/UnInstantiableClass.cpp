#include "stdafx.h"
#include "UnInstantiableClass.h"
using namespace legacycodepractice;
int UnInstantiableClass::methodA(int myParam){
    int i;
    int sum=0;
    if (myParam<1)
        sum = 10;
    for (i=0;i<myParam*myParam;i++){
        if (i<myParam+50)
            sum=sum+i;
        else
            sum=sum+myParam;
    }
    sum += internalVaribleA;
    return sum;
}

void UnInstantiableClass::methodB(int myParam){
    internalVaribleB = myParam*20;
}

int UnInstantiableClass::getAmount(){
    return internalVaribleA+internalVaribleB;
}