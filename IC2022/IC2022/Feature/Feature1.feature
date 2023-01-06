Feature: Feature1

As a Turnup portal user
I would like to create, edit time and material records
So that I can manage employees' time and materials successfully

@tag1
Scenario: Create Time and Material record with valid deatails
	Given I looged into Turnup portal successfully
	When I navigate to time and Material page
	And I create a new Time and Material Record
	Then The record should be created successfully.

Scenario Outline: Edit existing time record with valid details
	Given I looged into Turnup portal successfully
	When I navigate to time and Material page
	And I update'<Description>'on an existing time record
	Then The record should have been updated'<Description>'

Examples: 
| '<Description>' |
| Time            |
| Material        |
| EditedRecord    |
