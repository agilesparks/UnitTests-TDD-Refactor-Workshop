import '@testing-library/cypress/add-commands'

it('test', function () {

    cy.intercept({url: 'login'},
        {
        body: {
            message: "Incorrect password"
        }
    })


    cy.visit('http://localhost:3000/')
    cy.findByLabelText("user").type('Avraham')
    cy.findByLabelText("password").type('Avinu')
    cy.get('button').click()
    cy.findByText("Incorrect password")
})