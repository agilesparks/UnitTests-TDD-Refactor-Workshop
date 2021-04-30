#include "CInterestingFunctions.h"

int cGlobalVariable;
 
int cMethodWithComplexParameters(CUnbelievableComplexStruct complexVariable){
     return 3*complexVariable.myValue;
}


int cLongMethod(int param)
{
    int i;
    int sum = 0;

    // ....
    // ....
    // ....
    for (i = 0; i < param * 45; i++) {
            if (param < 12)
                sum = sum + i;
            else
                sum = sum + 5;
    }

    // ....
    // ....
    // ....

   for (i = 0; i < param * param; i++) {
            for (int j=0 ; j<param; j++) {
                if (i < cGetSomethingFromDB(cGlobalVariable) + 50)
                    sum = sum + i;
                else
                    sum = sum + param;
            }
        }
    // ....
    // ....
    // ....
     if (sum<param) {
           sum = sum+param;
           ExternalCalls::updateDB(sum);
       }

    // ....
    // ....
    // ....

    return sum;

}
