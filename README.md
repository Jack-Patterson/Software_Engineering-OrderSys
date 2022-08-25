# Software Engineering Project - OrderSys

This project was created using *Windows Forms* for my **Requirements Engineering/Software Engineering Project** done during the course of second year in college. The aim with this project was to create a functional printer ink business system which will allow the user to manage their *Suppliers*, their *Products*, their *Orders* and finally view *up-to-date charts of their finances* for the year. This is all connected to a *database* which stores the data and allows it to be retrieved for use within the project. This repsitory only has the finished product which has been published to Github for the purposes of my CV. The versions were saved on Microsoft OneDrive due to confusion when I first began the project but I would be happy to show them on request.

## Project Structure
### Main Menu
The main menu is just a simple splash screen with the logo of the company and a bar on the top which allows you to navigate where to go to.

### Suppliers
The suppliers tab has two subsections which all perform a task pertaining to the management of suppliers. 

 - **Register Supplier** - Allows a new supplier to be created. Once created this supplier will be logged in the database to be retrieved wherever appropriate. It also assigns the supplier a unique ID which can be used to reference it later.
 - **Update Supplier** - Allows the information such as the phone number of the supplier to be changed.

### Products

 - **Add Product** - Allows a new product to be created. Once created this product will be logged in the database to be retrieved wherever appropriate. It also assigns the product a unique ID which can be used to reference it later.
 - **Update Product** - Allows the information such as the quantity of the product to be changed.
 - **Update Product** - Allows for a product to be discontinued if it goes out of use. This will remove it from any displays when looking at product information.

### Orders
 - **Place Order** - Allows a new order to be created. Once created this order will be logged in the database to be retrieved wherever appropriate. It also assigns the order a unique ID which can be used to reference it later.
 - **Pay Invoice** - Allows an invoice of one supplier to be paid for and displayed on the screen. Each invoice will only contain the information of one order.
 - **List Outstanding Payments** - Shows all unpaid orders and invoices on screen to be viewed. No direct action may be taken from this page and is purely to show what is yet to be paid for.

### Administration

 - **Yearly Revenue Analysis** - It shows all the revenue for the year per month.
 - **Yearly Supplier Analysis** - It shows all the revenue for the year per month for a specific supplier.

### Database
The structure for the database is displayed in a *.sql* file which is present in the repository. It also includes dummy data for the purposes of testing and showing off the capabilities of the database and how it works with the program.

### Requirements Document
The requirements *.docx* is there to show off the requirements that went into the construction of the project and to show off the planning that has gone into it. The document is meant to be a reflection of what the project is supposed to become.