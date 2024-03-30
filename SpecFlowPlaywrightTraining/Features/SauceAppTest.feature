Feature: SauceAppTest

@Smoke
Scenario: Test Login operation of Sauce Application
	Given I navigate to the application
	And I enter the following login details
		| UserName      | Password     |
		| standard_user | secret_sauce |
	Then I see the Products list