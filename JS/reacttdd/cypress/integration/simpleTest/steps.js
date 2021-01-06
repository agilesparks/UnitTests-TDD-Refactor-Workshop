import { Given,When,Then } from "cypress-cucumber-preprocessor/steps";
import '@testing-library/cypress/add-commands'


Given(`Mock server returns {string} for {string} call`, (message,path) => {
    cy.intercept({url: path},
        {
            body: {
                message: message
            }
        })
})



When('I type {string} at {string} field',(typedText, fieldName)=>{
    cy.findByLabelText(fieldName).type(typedText)
})

When('click {string}',(buttonName)=>{
    cy.get(buttonName).click()
})

Then('I see a message {string}',(message)=>{
    cy.findByText(message)
})

