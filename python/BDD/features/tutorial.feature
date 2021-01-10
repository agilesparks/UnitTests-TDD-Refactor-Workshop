Feature: showing off behave

  Scenario: run a simple test
     Given we have behave installed 3 times
      When we implement a test
      Then behave will test it for us!

 # Scenario Outline: Blenders
 #Given we have <thing> installed <other thing> times
 #     When we implement a test
 #     Then behave will test it for us!

 #Examples: Amphibians
 #  | thing         | other thing |
 #  | "behave"      | 4           |

 #Examples: Consumer Electronics
 #  | thing         | other thing |
 #  | "behave"      | 5           |
 #  | "NOTbehave"   | 4           |