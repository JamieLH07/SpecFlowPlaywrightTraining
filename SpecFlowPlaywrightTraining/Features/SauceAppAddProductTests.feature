Feature: SauceAppAddProductTests

@Smoke
Scenario: Test that Products can be added to the Basket
	Given I navigate to the application
	And I enter the following login details
		| UserName      | Password     |
		| standard_user | secret_sauce |
	Then I see the Products list
	And I add all the products to the Basket
	Then I can see that all products have been added to the Basket
