﻿﻿Name: Patricia Bialek
Project: Assignment #2: PatriciasBookStore (ASP.NET Core MVC NET.5.0)
Date: 2023-10-23 IS0 8601 1540

2023-10230 1540:
Created my ASP.NET Core MVC project, added a text file README, and created a Git repo. 

2023-10-23 1540:
In Properties > launchSetting.json - comment out sslport, will have to uncomment before I submit the project.
//,
      //"sslPort": 44340

2023-10-23 1547:
Commented out Startup.cs file - line 35.

2023-10-24 1009:
REVIEW (pt.1.1):
Reviewed and commented the IAction in the HomeController.cs page. 
Can put JS scripts below the footer in Views > Shared > Layout.cshtml.
In the same Shared folder - _LoginPartial.cshtml is used for buttons to login and register.
In the same Shared folder - _ValidationScriptsPartial.cshtml is used for JQuery responses to validate
the model states on the client side.
In the same Shared folder - Error.cshtml creates a generic error view (404).
In the same Shared folder - _ViewImports.cshtml is for tag helpers and where custom tag helpers can be created.
In the same Shared folder - _ViewStart.cshtml will be the master page for all the views within the project folder. 

2023-10-24 1026:
About to use bootstrap (pt.1.3).
Run the project - no issues.

2023-10-24 1049:
Downloaded 'Minty' theme (bootstrap.css) on bootswatch.com.
Replaced previous bootstrap with new Minty bootstrap in:
wwwroot > lib > bootstrap > dist > css
Made changes in Views > Shared > _Layout.cshtml file.
Made changes in _LoginPartial.cshtml file.
Run the project - no issues.

2023-10-24 1120:
Replaced the prevoius site.css with the new one provided.
In _Layout.cshtml I addded additional scripts and stylesheets that were provided.
Run the project - no issues.

2023-10-24 1146:
Working on the dropdown in the nav bar but having issues will fix later.

2023-10-27 1316:
Fixed navbar for the drop down to properly work added this to the class: class="nav-link dropdown-toggle":
id="navbarDropdown" 
data-toggle="dropdown" 
type="button"
Run the project - no issues.

2023-10-27 1325:
Onto part 1.4
Added 3 new projects to the application (PatriciasBooks.DataAccess, .Models, .Utility)
Copy and Pasted the Data folder to the PatriciasBooks.DataAccess.
Deleted previous Data folder.

2023-10-27 1333:
Installed Microsoft.EntityFrameworkCore.Relational(v.5.0.17) & Microsoft.EntityFrameworkCore.SqlServer(v.5.0.17).

2023-10-27 1336:
Deleted Migrations folder.
Installed Identity.EntityFrameworkCore(v.5.0.17).

2023-10-27 1343:
Change the namespace to : (namespace PatriciasBookStore.DataAccess.Data) in ApplicationDbContext.cs.
Deleted defualt Class1.cs files.

2023-10-27 1346:
Moved Models folder to PatriciasBooks.Models and deleted origional.

2023-10-27 1352:
In PatriciasBookStore right click to Add > Project reference and clicked on .DataAccess and .Models.
Renamed Models folder to ViewModels.
Changed the ErrorViewModels.cs namespace .Models.ViewModels

2023-10-27 1402:
Was having an error but I changed the startup.cs using statement to (using PatriciasBookStore.DataAccess.Data;) adding the 
DataAccess to it.
Run the project - no issues.

2023-10-27 1410:
In ErrorViewModel.cs I chnaged the namespace to (namespace PatriciasBookStore.Models.ViewModels).
Changed the namespace in Error.cshtml file to (PatriciasBookStore.Models.ViewModels.ErrorViewModel).
Had an error I had to chnage the namespace in HomeController.cs to (PatriciasBookStore.Models.ViewModels.ErrorViewModel) on line 37.

2023-10-27 1420:
Added a new class called SD.cs to Utility folder.
Change the class to (public static class SD).
In PatriciasBookStore > project References add Utility.
In PatriciasBooks.DataAccess > project References add Models and Utility

2023-10-27 1440:
Added a new area called "Customers".
In Startup.cs added {area:Customer}/ in pattern.
Moved the HomeController.cs to the Area > Customer > Controller folder and delete Data and Models in the same directory.
In HomeController.cs add [Area("Customer")] under the namespace.
In the same file chnage the namespace to (namespace PatriciasBookStore.Area.Customer.Controllers).
Had an error will fix later.
Error: InvalidOperationException: The constraint reference 'Customer' could not be resolved to a type.

2023-10-27 1443:
Copy _ViewImport and _ViewStart to Customer View > Home Area.
Modified the _ViewStart.cshtml to (Layout = "~/Views/Shared/_Layout.cshtml";)
Added a new area called "Admin".
Delete the Controllers, Data, Models folder.
Copy _ViewImport and _ViewStart to Admin View > Home Area.

2023-10-27 1419:
Changed the versions of the packaged to 5.0.11 for relational and sqlserver and 5.0.2 for entityframeworkcore

2023-10-27 1427:
Finally fixed the error I had to change the pattern to:( pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}"); ).
And have completed all the Views to import in the Admin and Customer folder.

{PART 2}
2023-10-30 1509:
Cleaned the project, then Build the project.
Beginning Part 2 - creating the DB.
Changed all the packages frameworks to version 5.0.17.
Run the project - no issues.

2023-10-30 1535:
Replace the text that was next to the connection string to the local DB with: Database=PatriciasBookStore
In the PM: add-migration AddDefaultIdentityMigration - error occured have to change the default to PatriciasBooks.DataAccess
Where the console is, there is a bar that says 'Default project: PatriciasBookStore', click the drop down and click PatriciasBooks.DataAccess.
Again in the PM:  add-migration AddDefaultIdentityMigration - build succeeded, created timestamps in migrations folder in .DataAccess.

{MIGRATION TIME STAMP}
Migration file name: 20231030192808_AddDefaultIdentityMigration.cs & 20231030192808_AddDefaultIdentityMigration.Designer.cs

2023-10-30 1538:
have to update DB, in the PM: update-database - build succeeded
Run the project - no issues.

2023-10-30 1548:
Add a new class in .Models named: Category.cs.
Populated the class, added Id & Name.
In the PM: add-migration AddCategoryToDb - build succeeded, created another time stamp in .DataAccess.

2023-10-30 1611:
Added a new using statement and more to ApplicationDbContext.cs file.
To resolve the duplication error - I deleted the AddCategoryToDb file in Migrations folder and then ran the commands:
add-migration AddCategoryToDb & update-database - build succeeded.

2023-10-30 1702:
Beginning Pt.2.2 Repository now.
Ddded a new folder in .DataAccess named 'Repository', added a folder inside Repository named 'IRepository'.
Add a new item (type: Interface) in the IRepository folder named 'IRepository.cs'.
Populated the IRepository file.
Run the project - no issues.

2023-10-31 1026:
In the Repository folder in .DataAccess I uploaded the Repository.cs file.
Changed the file to relate to PatriciasBookStore.
Run the Project -no issues.

2023-10-31 1034:
Added a new interface inside the IRepository folder named 'ICategoryRepository'.
And added a new class file inside the Repository folder named 'CategoryRepository'.
Added using statements and code into CategoryRepository.

2023-10-31 1041:
Added code inside ICategoryRepository.
Added more code inside CategoryRepository but i have an error on line 13 saying I need to implement all the other methods because I only have the Update
method. So Intellisense recommended code to add to remove the error so I left it in, for the meantime.

2023-11-03 1427:
Created a new interface file in IRepo folder named 'ISP_Call.cs'.
Input code into the file.
Created a new class file in Repo folder named 'SP_Call.cs'.
Input code into the file.

2023-11-03 1447:
Created a new interface file in IRepo folder named 'IUnitOfWork'.
Input code into the file.
Created a new class file in Repo folder named 'UnitOfWork'.
Input code into the file.
In start up add the using statements:
using PatriciasBooks.DataAccess.Repository.IRepository;
using PatriciasBooks.DataAccess.Repository;
In Startup Config services add: services.AddScoped<IUnitOfWork, UnitOfWork>();

2023-11-03 1730:
Starting Part 2.3.
Created a Controllers folder inside Areas > Admin named 'CategoryController.cs'.
Input code. 
Created a new View inside Areas > Views > *NEWFOLDER Category named: 'Index.cshtml'.
Input code.
Added category.js file in wwwroot. and linked in Index file.

2023-11-03 1752:
Input upsert method in category controller.
Created a view called upsert in same folder, input code.
Need to create partial view.

2023-11-06 1415:
Created a PARTIAL View file named '_CreateAndBackToListButton' inside general Views > Shared folder.
Input code inside file. 
Created a PARTIAL View file named '_EditAndBackToListButton' inside general Views > Shared folder.
Input code inside file. 

2023-11-06 1521:
Updated the Upsert.cshtml file.
Added the asp action to the index.cshtml file.
Added a script to validate in Upsert.cshtml.
Updating categorycontroller.

2023-11-06 1531:
Updated the category.js file.

2023-11-06 1551:
error: InvalidOperationException: The view 'Index' was not found. The following locations were searched:
/Areas/Customer/Views/Home/Index.cshtml
/Areas/Customer/Views/Shared/Index.cshtml
/Views/Shared/Index.cshtml
/Pages/Shared/Index.cshtml

2023-11-06 1608:
Fixed the index error: the home folder that had the index and privacy had to be moved to customer views folder.

2023-11-06 1629:
Fixed the error in CategoryRepository by changing <CategoryRepository> to <Category>.
Made a spelling mistake in index - upset  to upsert.
run the program - no issues.

**********update-database***********

2023-11-14 1030:
Beginning Part 3.1.
Created a new class inside the .Models project 'CoverType.cs'.
Input code in file.

2023-11-14 1125:
Added CoverType to Repository and IRepository.
Confused for: AddCoverType to IUnitOfWork and UnitOfWork?????
Commented out everything in the meantime.
Just with the CoverType.cs in the .Models project, in the PM with the project connected to .DataAccess input 'add-migration AddCoverTypeToDb'.

Timestamp created: 20231114160659_AddCoverTypeToDb.cs

Updated database: ' update-database '.
Input CoverType in ApplicationDbContext.cs file.
Copied code from ICategoryRepository & CategoryRepository to ICoverTypeRepository & CoverTypeRepository.
Input CoverType into UnitOfWord & IUnitOfWork - no errors so i think I did it correctly.
Updated the database.

2023-11-14 1140:
Added CoverType to the nav Bar drop down and added action/controller.
Created a CoverType View folder in Admin.
Copied the Category View index/Upsert and pasted it to the CoverType View folder (changed some code to match).
Copied the CategoryController and created a CoverTypeController and pasted the code (changed some code to match).
deleted teh upsert/index/controller from CoverType for now.
Deleted the previous 20231114160659_AddCoverTypeToDb.cs and add the migration again in the PM

new timestamp: 20231114165233_AddCoverTypeToDb

recieving an error when clicking on either category or cover type in nav barerror
error: Microsoft.Data.SqlClient.SqlException: 'Invalid object name 

2023-11-16 1527:
Commented out Covertype in UnitOfWork and IUnitOfWork and run the project - no issues.
Uncommented it, run the project - no issues.
Added the CoverType folderin Admin, added the 2 file (index/upsert) - chnaged some code to match covertype.
run the project no issues.

2023-11-16 1710:
CoverType as a table now but still getting errors when i run the project.

2023-11-16 1757:
fixed the error i had to chnage the category table name to categories.
Created a new javascript file for covertype and replaced some code.

2023-11-16 1813:
Beginning 3.2 CRUD
Add a new class 'Product' in models folder.
Added product reference to ApplicatioDbContext.
In the PM add-migration addProductToDb & update-database

TimeStamp: 20231116231238_addProductToDb

2023-11-16 1833:
In the product.cs file make somemore columns required.
In the PM add-migration addValidationToProduct & update-database
Add product and Iproduct repos + input code.
Add it to IUnitOfWork and UnitOfWork.
Run the project no issues.

2023-11-16 1905:
Add product controller to admin + input code.
Add class ProductVM to models project + input code.
Updated the product controller.

2023-11-16 1926:
Add a product javascript file.
And create a View product folder + add the index/upsert files.
Add product link to layout.
Run the project - error :
System.InvalidOperationException
  HResult=0x80131509
  Message=An error was generated for warning 'Microsoft.EntityFrameworkCore.Query.InvalidIncludePathError': Unable to find navigation ' CoverType' specified in string based include path ' CoverType'. This exception can be suppressed or logged by passing event ID 'CoreEventId.InvalidIncludePathError' to the 'ConfigureWarnings' method in 'DbContext.OnConfiguring' or 'AddDbContext'.

2023-11-17 1318:
Input tiny.cloud functions in upsert.cshtml.
Added a new folder and subfolder in wwwroot: images > products.
Uncommented the upsert post method in product controller.

2023-11-20 1433:
Changed code to move ProductVM to ViewModels folder. 

2023-11-21 1022:
Removed the space inside include properties in productController between covertype and category to fix toList() error.
I changed the categoryId to covertypeid for covertype in product.cs model.
Removed product migration and created a new migration for products - updated the database.
In product upsert changed categoryid to covertype id to retrieve the cover types.
error when I run the project in products: 
DataTables warning: table id=tblData - Requested unknown parameter 'price' for row 0, column 2. For more information about this error, please see http://datatables.net/tn/4

2023-11-21 1130:
In product.cs in models - add new data for price.
In the utility project in SD.cs file add new code.
In covertypecontroller new code. (errors)
In productcontroller new code.
In product upsert new code.
In customer homecontroller new code.
In customer view index new code.

2023-11-23 1721:
Uncommented out all the new code I placed - when I build the database the build fails. 
Uncommented index in cutomer view - build succeeded but error: Cannot find the object "Products" because it does not exist or you do not have permissions.