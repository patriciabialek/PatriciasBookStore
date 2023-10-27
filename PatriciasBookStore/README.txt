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
Was having an error but I chnaged the startup.cs using statement to (using PatriciasBookStore.DataAccess.Data;) adding the 
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

2023-10-27 1443:
Copy _ViewImport and _ViewStart to Customer View > Home Area.
Modified the _ViewStart.cshtml to (Layout = "~/Views/Shared/_Layout.cshtml";)
Added a new area called "Admin".
Delete the Controllers, Data, Models folder.
Copy _ViewImport and _ViewStart to Admin View > Home Area.
