#include "stdafx.h"
#include "InterestingClass.h"
using namespace legacycodepractice;
int myA(){return 4;}
 
int InterestingClass::methodWithComplexParameters(UnbelievableComplexClass *complexVariable){
     return 3*complexVariable->getProfit();
}


int InterestingClass::longMethod(int param)
{
    int i;
    int sum = 0;

    // ....
    // ....
    // ....
    for (i = 0; i < param * 45; i++) {
            if (i < 12 + param)
                sum = sum + i;
            else
                sum = sum + 5;
    }

    // ....
    // ....
    // ....

   for (i = 0; i < param * param; i++) {
            for (int j=0 ; j<param; j++) {
                if (i < getSomethingFromDB(globalVariable) + 50)
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
