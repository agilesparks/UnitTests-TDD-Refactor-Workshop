Feature: Login

  I want to login

  @focus
  Scenario: wrong password
    Given Mock server returns "Incorrect password" for "login" call
    When I open the system at "http://localhost:3000/"
    And I type 'Avraham' at "user" field
    And I type 'password' at "password" field
    And click 'button'
    Then I see a message "Incorrect password"


