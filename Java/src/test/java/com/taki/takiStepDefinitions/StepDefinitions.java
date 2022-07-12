package com.taki.takiStepDefinitions;

import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import static org.junit.Assert.*;

import java.util.*;

public class StepDefinitions {

    @Given("a game with players:")
    public void a_game_with_players(io.cucumber.datatable.DataTable dataTable) {
        TakiGame myGame = new TakiGame();
        List<List<String>> players = dataTable.asLists(String.class);
        for (String player : players.get(0)){
            myGame.addPlayer(player);
        }
    }

    @Given("it is {string} turn, direction is {string}")
    public void it_is_turn_direction_is(String string, String string2) {
        // Write code here that turns the phrase above into concrete actions
    }

    @When("{string} places a {string} {int} card on the table")
    public void places_a_card_on_the_table(String string, String string2, Integer int1) {
        // Write code here that turns the phrase above into concrete actions
    }

    @Then("next player is {string}")
    public void next_player_is(String string) {
        // Write code here that turns the phrase above into concrete actions
    }

}
