Feature: add product


Scenario: User successfully logged in
Given that an User on the login page
When he enter the following data:
| Email            | Password  |
| test22@gmail.com | 123456789 |
Then clicks on the login button
Then Appear home page 

#Scenario: From my profile  select Add product 
Given  choose from menu of profile pic add product
 
#Scenario: Fii the fields in Add prouduct form 
 Given  Select single product
 When  fill all element including(main image, auction details , policy) 
 Then  choose selling type (estimation value) 
 Then Click save 





