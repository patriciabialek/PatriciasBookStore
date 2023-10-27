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