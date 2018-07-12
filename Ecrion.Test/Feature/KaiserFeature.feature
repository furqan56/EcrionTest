Feature: KaiserFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Kaiser Outreach Template
	Given the XML for Kaiser Outreach Template
	When template generated from Ecrion
	Then PDF should render on Kaiser Outreach Template with XML Data
	| Name | Template |
	| abc  | KP:      |
