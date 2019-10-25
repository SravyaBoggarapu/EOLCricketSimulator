# EOLCricketSimulator

Problem Statement:

It is the finals of the EOL Cricket Premier T20 league. The Remus team and Niburu team are battling it out for the title. It’s the last 4 overs of the match, and Remus team needs 40 runs to win and have 3 wickets left. 
You will need to write code to simulate the last 4 overs of the match, ball by ball. The match simulation will require you to use a weighted random number generator based on probability to determine the runs scored per ball. You can use any randomizer (built-in or external) of your choice.

Solution:

The designed project is a console application and the execution starts from Main program.

Classes information :

Player:

It has information about Player name, Order of the player, score , number of balls and probability of runs.

Team :

It has list of players along with there probability , total runs scored by the team, number of overs left, number of runs to win , striker and runner details

Weight Random :

It holds the logic of weighted random number .

Next method is to update the score of the player where a random number is generated and based on the index value returned from findCeilValue method the corresponding number of runs is picked from the runs array and is returned.

