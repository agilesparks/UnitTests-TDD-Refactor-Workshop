class UnInstantiableClass:
    def __init__(self,complexVariable):
        self.internalVariableA = complexVariable.getProfit()
        self.complexVariable = complexVariable
        self.internalVariableB =0

    def methodA(self,myParam):
        sum = 0
        if (myParam < 1):
            sum = 10
        for i in range(myParam * myParam):
            if (i < myParam + 50):
                sum = sum + i
            else:
                sum = sum + myParam
        return sum

    def methodB(self,myParam):
        self.internalVariableB = myParam * 20

    def methodC(self):
        #Do things
        self.complexVariable.doSomehtingComplex()
        #Do some other things
        self.complexVariable.doSomehtingThatInvolvesSomeAPI()
        #Do some more stuff

    def getAmount(self):
        return self.internalVariableA + self.internalVariableB