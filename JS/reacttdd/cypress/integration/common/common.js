import { Given,When,Then } from "cypress-cucumber-preprocessor/steps";
import '@testing-library/cypress/add-commands'

When('I open the system at {string}',(URL)=>{
    cy.visit(URL)
})

