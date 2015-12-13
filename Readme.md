# Readme #
There is a small bak file for the db - Licensing.bak - which can be [downloaded from here](https://app.box.com/s/f7ntxnhngc68okvm1oq1pq6ge3vwr9l9).

The schema can be seen here - ![](http://www.codeproject.com/KB/dotnet/788559/LicencingSchema.PNG)

The app is a super simple Angular sample. Load the path `[basepath]/Home` for the view in question (the only view).

The relevant Javascript file can be found at `/Scripts/App/EditLicences/edit-licences-ctrl.js`

It gets data on loading from the **GetLicenceById** action of the **EditController** and the inputs you see on the page are for a **Licence** entity.

It has a **LicenceKey** and **LicenceAllocations** (which are from related entities) . The dropdown lists which are full of people come about because people are allocated LicenceAllocations.

If you change nothing and post back to the server (**EditLicence** action of same controller), the entity state of all entities will be deserialized by the Model Binder to unchanged.

Then an exception happens :( 
 

 
