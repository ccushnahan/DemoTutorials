@Checkout
Feature: Checkout
  User should be able to checkout items and be charged correct amount.

  @Ckout-1
  Scenario: Checkout a banana
    Given the price of a "banana" is 40c
    When I checkout 1 "banana"
    Then the total price should be 40c

  @Ckout-2
  Scenario Outline: Checkout bananas
    Given the price of a "banana" is 40c
    When I checkout <count> "banana"
    Then the total price should be <total>c

    Examples: 
      | count | total |
      |     1 |    40 |
      |     2 |    80 |

  @Ckout-3
  Scenario: Checkout two bananas scanned separately
    Given the price of a "banana" is 40c
    When I checkout 1 "banana"
    And I checkout 1 "banana"
    Then the total price should be 80c

  @Ckout-4
  Scenario: Checkout two bananas scanned separately
    Given the price of a "banana" is 40c
    And the price of a "apple" is 25c
    When I checkout 1 "banana"
    And I checkout 1 "apple"
    Then the total price should be 65c
