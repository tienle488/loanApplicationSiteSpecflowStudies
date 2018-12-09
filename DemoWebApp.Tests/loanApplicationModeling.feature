Feature: loanApplicationModeling
	In order to supposedly buy something nice now
	As a cash poor customer
	I want to supposedly borrow money so I don't have to wait

Scenario: Sign Up For Free with InterviewMocha.com successfully
	Given I am on the Start Your Free Trial - InterviewMocha.com screen
		And I enter a first name of Sarah
		And I enter a last name of Smith
		And I enter a work email of SarahSmith10@Microsoft.com
		And I enter a password of Password
		And I enter a phone number of 1231231234
		And I enter a company name of Company Name
		And I select the drop down list for company size
		And I select the option VerySmallBusiness and the option 1-50
		And I select the drop down list for job title
		And I select the option Other
		And I wait a second
		And I enter a job title other of Other
	When I submit Sign Up for Free
	Then I should see the sign-up complete confirmation for Sarah

Scenario: Cannot submit Sign Up For Free with InterviewMocha.com unless specify your job title is completed
	Given I am on the Start Your Free Trial - InterviewMocha.com screen
		And I enter a first name of John
		And I enter a last name of Jones
		And I enter a work email of SarahSmith10@Microsoft.com
		And I enter a password of Password
		And I enter a phone number of 1231231234
		And I enter a company name of Company Name
		And I select the drop down list for company size
		And I select the option VerySmallBusiness and the option 1-50
		And I select the drop down list for job title
		And I select the option Other
		And I wait a second
	When I submit Sign Up for Free
	Then I should see an error message telling me that I need to specify my job title

Scenario: Sign Up For Free with InterviewMocha.com successfully (Improved)
	Given I am on the Start Your Free Trial - InterviewMocha.com screen
		And I enter a first name of Sarah
		And I enter a last name of Smith
		And I enter a work email with the following information
		| workEmail                   |
		| SarahSmith{0}@Microsoft.com |
		And I enter a password of Password
		And I enter a phone number of 1231231234
		And I enter a company name of Company Name
		And I select the drop down list for company size
		And I select the option VerySmallBusiness
		And I select the option 1-50
		And I select the drop down list for job title
		And I select the option Other
		And I wait a second
		And I enter a job title other of Other
	When I submit Sign Up for Free
	Then I should see the sign-up complete confirmation for Sarah

Scenario: (just testing out commit to github repo)
	Given I have a condition
	When I do something with it 
	Then I should expect