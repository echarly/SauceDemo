Project Name: Sauce Demo

URL: https://www.saucedemo.com/

#Purpose of the Project:
The purpose of the project is test the page saucedemo.com and obtain test scenarios so the company has the best quality page possible. The QAs responsability on the project is to create test cases/test scenarios for the site and develope the test scripts in the following language C#.

#Pre-requisites for installation:

Note: **** You will need to install Visual Studio 2017 or 2019 ****

The scripts and test cases were created on Visual Studio 2017

Language: C#

The Chrome Web Driver location:
C:\Chromedriver\

Nuget Packages required:
------------------------
MSTest.TestAdapter v2.2.3
MSTest.TestFramework v2.2.3
NUnit v3.13
NUnit3TestAdapter v3.17
Selenium.Support v3.141
Selenium.WebDriver v89
Selenium.WebDriver.ChromeDriver v90.0.443

---------------------------------------------------------------

#The scenarios created so far:

1. Login with a valid user
	Expected: Validate the user navigates to the products page when logged in.
	
2. Login with an invalid user
	Expected: Validate error message is displayed.
	
3. Logout from the home page
	Expected: Validate the user navigates to the login page.
	
4. Sort products by Price (low to high)
	Expected: Validate the products have been sorted by price correctly
	
5. Add multiple items to the shopping cart
	Expected: Validate all the items that have been added to the shopping cart.
	
6. Add the specific product ‘Sauce Labs Onesie’ to the shopping cart
	Expected: Validate the correct product was added to the cart.
	
7. Complete a purchase
	Expected: Validate the user navigates to the order confirmation page.

----------------------------------------------

How-to: Install the solution
Step #1: go to the following url: https://github.com/echarly/SauceDemo
	Expected: The GitHub page is displayed and the following project is shown: echarly/SauceDemo
	
Step #2: Click on the green button that says "Code" with an arrow pointing down.
	Expected: Two options will be displayed:
				- Open with GitHub Desktop
				- Download Zip File

Step #3: Click the option that says "Download Zip file"
	Expected: a Zip file named "SauceDemo-main.zip" will be downloaded in your "downloads" folder.
	
Step #4: UnZip the Zip file named in the previous step. 
	Expected: a set of folders and files will be unzipped into a folder with 13 files.
	
Step #5: Search for the file named "SauceDemo.sln" in the root folder of the unzipped folder and Open it (double click or press enter). With that file you can open the solution of the project which contains the classes, methods and also the test scenarios to run.
	Expected: The Visual Studio application will open and with it the 2 projects containing the classes, methods and also the test scenarios.
	
	The two projects will be displayed in the Solution Explorer section as follows:
		- SauceDemo (containing the classes, methods, locators)
		- TestingSauce (containing the test scenarios)
		
Step #6: Press Ctrl + Shift + B or navigate to the "build" option in the menu bar and select "Build Solution".
	Expected: After completion you should get the following message: Build: 2 succeeded.
	
Step #7: Navigate to the "Test" option in the menu bar and select "Test Explorer" to open the test scenarios.
	Expected: The dropdown "TestingSauce" will be appeared and with it another option named the same, until you get to the option "UnitTest" which displays the 7 test scenarios that are contained in the project.

--------------------------------------------

How-to: Execute the test scenarios
After you build the solution and the two projects appear with no issues whatso ever follow these steps.

Open the Test explorer and click the dropdowns to get to the test cases.
	Expected: The test cases are displayed. You can click one by one and run them or you can click the first green triangle like button and that will run them all or just press ctrl + R to execute all the scenarios.
	
The Total Duration of te test scenarios is aproximately : 15 seconds 

For any questions or comments please email: charlyh@gmail.com

Have fun! 
