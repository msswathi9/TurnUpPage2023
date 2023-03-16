Feature: TMfeature1

As a TurnUp portal admin
I would like to create, edit time and material records
So that I can manage employees' time and materials sucessfully

@tag1
Scenario: Creat time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigated to time and material page
	And  I created time and material record
	Then the record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigated to time and material page
	And I update '<Description>','<Code>', '<Price>' on an existing time and material record
	Then The record should have the updated '<Description>', '<Code>', '<Price>'

Examples: 
| Description  | Code     | Price     |
| Time         | Thursday |  $30.00   |
| Material     | Friday   |  $35.00   |
| EditedRecord | Monday   |  $40.00   |