# potential-sniffle-Gary

Changes:

1. Radio Button(s) are added
Basic Filter and Advance Filter are selectable via the Radio Button(s)
Basic Filter is checked/selected by default
At least one has to be checked/selected at all times

2. All forms has been populated with placeholder
The placeholder is also act as a default value (as we all as an example how to fill the forms)
When user fill in the respective forms, the user input will be taken instead of the placeholder

3. Added function to auto detect default AF Server
Changed the flow slightly:
-When the 'Search' button is trigger while the AF Server is empty, 
-Give an attempt to find the default AF Server,
-And automatically assigned the default AF Server into the 'AFServerName' variable
-User will also been notified in the Message Box about that
-The code then continue to run and execute with the default AF Server being used (user dont need to press the 'Search' button again)
Note:
-If the code can't find the default AF Server, it will most likely still throw an exception
-This is not affecting the 'Test Connection' behaviour, it will still pop up with a Message Box if empty

Comment:

1. For the Basic Filter, realistcally I think it will be very seldom for user to use 'Path'? Will it be much common to use 'lastLag' for example (as user will be interested to find analysis with high lag)? I have not change it for now though..

I think there are still many way to break the code, especially we purposedly find way to break it

But at least if user wanted to execute the code, with those quality of life improvements, it should be easier to use, user should be able to execute the 'Search' button without doing any input at all


