Feature: next turn

  
  Scenario: regular number card
    Given a game with players:
    |player1|player2|player3|
    And it is "player1" turn, direction is "LEFT_TO_RIGHT"
    When "player1" places a "RED" 8 card on the table
    Then next player is "player2" 

  @ignore
  Scenario: regular number card takes card
    Given a game with players:
    |player1|player2|player3|
    And it is "player1" turn, direction is "LEFT_TO_RIGHT"
    When "player1" takes a card from the pack
    Then next player is "player2"


  @ignore
  Scenario: plus two card
    Given a game with players:
    |player1|player2|player3|
    And it is "player1" turn, direction is "LEFT_TO_RIGHT"
    When "player1" places a "RED" "PLUS_TWO" card on the table
    Then next player is "player2"

  @ignore
  Scenario: plus card
    Given a game with players:
    |player1|player2|player3|player4|
    And it is "player1" turn, direction is "LEFT_TO_RIGHT"
    When "player1" places a "RED" "PLUS" card on the table
    Then next player is "player1"
    When "player1" places a "RED" 8 card on the table
    Then next player is "player2"
  
 @ignore
 Scenario: taki card
    Given a game with players:
    |player1|player2|player3|player4|
    And it is "player1" turn, direction is "RIGHT_TO_LEFT"
    When "player1" places a "RED" "TAKI" card on the table
    Then next player is "player1"
    When "player1" places a "RED" 8 card on the table
    Then next player is "player1"
    When "player1" indicates Taki series is done
    Then next player is "player4"

  @ignore
  Scenario: change direction card
    Given a game with players:
    |player1|player2|player3|
    And it is "player1" turn, direction is "LEFT_TO_RIGHT"
    When "player1" places a "RED" "CHANGE_DIRECTION" card on the table
    Then next player is "player3"

  @ignore
  Scenario: stop card
    Given a game with players:
    |player1|player2|player3|player4|
    And it is "player1" turn, direction is "RIGHT_TO_LEFT"
    When "player1" places a "RED" "STOP" card on the table
    Then next player is "player3"

  