@DayOfTheWeek
Feature: Is it Friday yet?
  Everyone wants to know when it's Friday

  @Friday-1
  Scenario: Sunday isn't Friday
    Given today is Sunday
    When I ask whether it's Friday yet
    Then I should be told "Nope"

  @Friday-2
  Scenario: Friday is Friday
    Given today is Friday
    When I ask whether it's Friday yet
    Then I should be told "TGIF"
 	
 	@Friday-3
 	Scenario Outline: Today is or is not Friday
   	Given today is "<day>"
    When I ask whether it's Friday yet
    Then I should be told "<answer>"

  Examples:
    | day            | answer |
    | Friday         | TGIF   |
    | Sunday         | Nope   |
    | anything else! | Nope   |