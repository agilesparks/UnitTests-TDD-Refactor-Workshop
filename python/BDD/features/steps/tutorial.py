from behave import *
from hamcrest import assert_that, equal_to


#https://pypi.org/project/parse/
@given('we have {text} installed {number:n} times')
def step_impl(context,text,number):
    assert_that(text,equal_to("behave"))
    assert_that(number,equal_to(3))
    times = []
    for row in context.table:
        times.append(row['time'])
    assert_that(len(times),equal_to(3))
    pass

@when('we implement a test')
def step_impl(context):
    assert True is not False

@then('behave will test it for us!')
def step_impl(context):
    assert context.failed is False