# Dashboard

Setup instrcutions:

1. Restore the database from the .bak file ("Data\CAPWisej_Webinar_Dashboard.bak"). I recommend using SSMS for this.
The database should be named CAPWISEJ_WEBINAR

If needed, configure the connection string in appsettings.json

2. Open Data\DASB_RPT.sql and run it (again, I recommend running in SSMS)
It will create a stored procedure called DASB_RPT

3. You should now be able to compile and run the project with no errors.
