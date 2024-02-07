Feature: Tests
As a EPAM website user
I want to perform search on main page

Scenario Outline: Perform search on Epam website
	Given I navigate to EPAM website
	When I click on the Search icon element 
	And I enter the text 'Automation' into the search input
	And I click on the Find button
	Then The list of search results is displayed on the page

