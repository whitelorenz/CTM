Feature: AcceptanceCriteria
	As a user
	I want to provide my energy related data
	In order to find a better deal

@Main path (default values)
Scenario: User has the bill
	Given I am on Your Supplier page
	When I enter my postcode
	And I have the bill
	And I move to the Electricity page
	And I enter my Electricity usage
	And I move to the Gas page
	And I enter my Gas usage
	And I move to Your Preferences page
	And I fill in the mandatory fields
	And I submit the form
	Then I can view the results page

@Known energy expenditures
Scenario: User doesn't have the bill and knows energy expenditures
	Given I am on Your Supplier page
	When I enter my postcode
	And I don't have my bill 
	And I move to Your Supplier page
	And I enter my expenditures
	And I move to Your Preferences page
	Then the Preferences screen is displayed

@Unknown energy expenditures
Scenario: User doesn't have bill and doesn't know energy expenditure
	Given I am on Your Supplier page
	When I enter my postcode
	And I don't have my bill 
	And I move to Your Supplier page
	And I don't know my expenditures
	And I move to the energy calculator
	And I can work out my energy usage
	And I move to Your Preferences page
	Then the Preferences screen is displayed