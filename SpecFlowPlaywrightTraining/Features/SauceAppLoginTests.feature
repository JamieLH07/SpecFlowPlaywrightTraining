Feature: SauceAppLoginTests

@Smoke
Scenario: Test Successful Login of Sauce Application
	Given I navigate to the application
	And I enter the following login details
		| UserName      | Password     |
		| standard_user | secret_sauce |
	Then I see the Products list


Scenario: Test Unsuccessful Login of Sauce Application
	Given I navigate to the application
	And I enter the following login details
		| UserName      | Password     |
		| standard_user1 | secret_sauce1 |
	Then I see the login error message