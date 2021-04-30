#ifndef __Cinteresting_H
#define __Cinteresting_H

#include "ExternalCalls.h"
#include "CUnbelievableComplexStruct.h"



 
    
    int cLongMethod(int param);
    int cMethodWithComplexParameters(CUnbelievableComplexStruct complexVariable);
    static int cGetSomethingFromDB(int param){return 10*param;}

#endif