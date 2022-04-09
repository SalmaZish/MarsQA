Feature: PDFeature


As a seller 
I would like to ADD, Edit my Profile details
so that I can Manage My profile successfully

Scenario: Add language details with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I add my language details
	Then the language details added successfully

	Scenario: Add skills details with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I add my skill details
	Then the skill details added successfully

  Scenario: Add certification details with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I add my certification details
	Then the certification details added successfully


	Scenario Outline: Edit language details with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I edit '<language>','<level>' on an existing languages tab
	Then the profile details should have the updated '<language>','<level>'


	Examples: 
	| language | level  |
	| English  | Fluent |
	


	Scenario Outline: Edit skills with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I edit '<skill>','<level>' on an existing skills tab
	Then the skills tab should have the updated '<skill>','<level>'


	Examples: 
	| skill   | level    |
	| Testing | Expert   |
	



	Scenario Outline: Edit certification with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I edit '<certificate>','<from>','<year>' on an existing certification tab
	Then the certification tab should have the updated '<certificate>','<from>','<year>'


	Examples: 
	| certificate | from | year |
	| Masters    | UQ | 2022 |
	

	Scenario Outline: Delete language with valid data
	Given I login in the Blockchain-based skill exchange platform portal successfully
	And I navigate to profile page
	When I delete'<language>','<level>' on an existing languages tab
	Then the languages tab should delete '<language','<level>'


	Examples: 
	| Language | Level |
	| English  | Basic | 


	
