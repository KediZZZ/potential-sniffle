# potential-sniffle-Gary

Changes:

1. Radio Button(s) are added<br>
Basic Filter and Advance Filter are selectable via the Radio Button(s)<br>
Basic Filter is checked/selected by default<br>
At least one has to be checked/selected at all times<br>

2. All forms have been populated with placeholder<br>
The placeholder is also act as a default value (as we all as an example how to fill the forms)<br>
When user fill in the respective forms, the user input will be taken instead of the placeholder<br>

3. Added function to auto detect default AF Server<br>
Changed the flow slightly:<br>
-When the 'Search' button is trigger while the AF Server is empty,<br>
-Give an attempt to find the default AF Server,<br>
-And automatically assigned the default AF Server into the 'AFServerName' variable<br>
-User will also been notified in the Message Box about that<br>
-The code then continue to run and execute with the default AF Server being used (user dont need to press the 'Search' button again)<br>
Note:<br>
-If the code can't find the default AF Server, it will most likely still throw an exception<br>
-This is not affecting the 'Test Connection' behavior, it will still pop up with a Message Box if empty<br>

Comment:<br>
1. For the Basic Filter, realistically I think it will be very seldom for user to use 'Path'? Will it be much common to use 'lastLag' for example (as user will be interested to find analysis with high lag)? I have not change it though..<br>

I think there are still many way to break the code, especially we purposely find way to break it<br>

But at least if user wanted to execute the code, now it should be much easier to use, user should be able to execute the 'Search' button without doing any input at all


