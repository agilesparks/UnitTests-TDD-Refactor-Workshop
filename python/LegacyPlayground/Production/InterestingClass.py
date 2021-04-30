from .ExternalCalls import ExternalCalls
class InterestingClass:
    globalVariable = 10

    def methodWithComplexParameters(self,complexVariable):
        if complexVariable.getProfit() > 4:
            return 5
        else:
            return 10

    def getSomethingFromDB(self,param):
        return ExternalCalls.getDB()

    def longMethod(self,param):
        sum = 0
        # ....
        # ....
        # ....
        for i in range(param * 45):
            if (i < 12 + param):
                sum = sum + i
            else:
                sum = sum + 5
        # ....
        # ....
        # ....

        for i in range(param * param):
            for j in range(param):
                if i < self.getSomethingFromDB(self.globalVariable) + 50:
                    sum = sum + i
                else:
                    sum = sum + param
        # ....
        # ....
        # ....
        if sum < param:
            sum = sum + param
            ExternalCalls.updateDB(sum)
        # ....
        # ....
        # ....
        return sum

    