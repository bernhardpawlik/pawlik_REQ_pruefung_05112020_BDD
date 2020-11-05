Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to calculate sun, cos and tan

@mytag
Scenario: sinus berechnen
	Given the number is Pi
	When sinus is called
	Then the result should be 0

Scenario: cosinus berechnen
	Given the number is Pi
	When cosinus is called
	Then the result should be -1

Scenario: tangens berechnen
	Given the number is Pi
	When tangens is called
	Then the result should be 0