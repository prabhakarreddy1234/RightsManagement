Feature: AvailableProducts
	In order to allow clients to best utilise the collection of music assets
	As a product owner
	I want to know the products available for given partner on a given date

	Background: 
	Given the supplied above reference data

Scenario Outline: Get products available
	
When user enters <input>

Then the output is : <output>

Examples:
	| input									 | output										|
	| ITunes 1st March 2012					 | Artist\|Title\|Usage\|StartDate\|EndDatenMonkey Claw\|Black Mountain\|digital download\|1st Feb 2012\|\nMonkey Claw\|Motor Mouth\|digital download\|1st Mar 2011\|\nTinie Tempah\|Frisky (Live from SoHo)\|digital download\|1st Feb 2012\|\nTinie Tempah\|Miami 2 Ibiza\|digital download\|1st Feb 2012\||
	| YouTube 1st April 2012				 | Artist\|Title\|Usage\|StartDate\|EndDate\nMonkey Claw\|Motor Mouth\|streaming\|1st Mar 2011\|\nTinie Tempah\|Frisky (Live from SoHo)\|streaming\|1st Feb 2012\|										|
	| YouTube 27th Dec 2012					 | Artist\|Title\|Usage\|StartDate\|EndDate\nMonkey Claw\|Christmas Special\|streaming\|25st Dec 2012\|31st Dec 2012\nMonkey Claw\|Iron Horse\|streaming\|1st June 2012\|\nMonkey Claw\|Motor Mouth\|streaming\|1st Mar 2011\|\nTinie Tempah\|Frisky (Live from SoHo)\|streaming\|1st Feb 2012\|									|

	# I have never tested a Console application with specflow so far. If i had more time i would have
	#achieved it.