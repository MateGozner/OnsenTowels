# Onsen Towels Pattern Matcher

Solution for the towel pattern matching problem. The program determines which designs are possible to create using available towel patterns.

## Problem

Given a set of towel patterns and desired designs, determine how many designs are possible to create using the available patterns.

## Approach

1. Parse input into patterns and designs
2. For each design, determine if it can be constructed from available patterns
3. Use dynamic programming to optimize pattern matching

We can use dynamic programming where:
State: Position in the target string
Transition: Try to match each available pattern at current position
Base case: Reached end of string = success
Time complexity: O(n * m * k) where:
n = length of design
m = number of patterns
k = average pattern length