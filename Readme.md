# Readme #
Included in the base directory is a bak file for the database. It's very small. Licensing.bak

The schema can be seen here - ![](http://www.codeproject.com/KB/dotnet/788559/LicencingSchema.PNG)

The app is a super simple Angular sample. Load the path `[basepath]/Home` for the view in question (the only view).

The relevant Javascript file can be found at `/Scripts/App/EditLicences/edit-licences-ctrl.js`

It gets data on loading from the **GetLicenceById** action of the **EditController** and the inputs you see are for a **Licence** entity.

It has a **LicenceKey** and **LicenceAllocations** (which are from related entities) . The dropdown lists full of people are because people are allocated LicenceAllocations.

If you change nothing and post back to the server (**EditLicence** action of same controller), the entity state of all entities will be deserialized by the Model Binder to unchanged.

Then an exception happens :( 
 

 