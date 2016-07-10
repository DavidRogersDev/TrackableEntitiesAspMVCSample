# Readme #
The schema can be seen here - ![](http://www.codeproject.com/KB/dotnet/788559/LicencingSchema.PNG)

The app is a super simple Angular sample. Load the path `[basepath]/Home` for the view in question (the only view).

The relevant Javascript file can be found at `/Scripts/App/EditLicences/edit-licences-ctrl.js`

It gets data on loading from the **GetLicenceById** action of the **EditController** and the inputs you see on the page are for a **Licence** entity.

It has a **LicenceKey** and **LicenceAllocations** (which are from related entities) . The dropdown lists which are full of people come about because people are allocated LicenceAllocations.

Change one of the people in one of the ComboBoxes and click the button. It posts to the **EditLicence** action of the **EditController**. 

The example is a bit flaky, and the code is quite awful in parts, but it demonstrates the usage. I was also trying out a few other things in the solution.

# DTOs #
Also note that there are no DTOs in the example. That was me being lazy (using Models in the view). The good thing about DTOs are that I do not include the ModifiedProperties and EntityIdentifier properties in them. I don't think they are required in the ASP.NET sense and are just part of the ITrackable and IMergable interface and have to be there on the EF Models. They get used in the WPF are, I believe (going by his videos). 

So in my app at work, those two properties aren't in my DTOs (unlike the TrackingState property) and as such, don't polute the client-side stuff. Oh and for clarity, I do include a TrackingState property on my DTOs (that was probably obvious). It is the only property required from those two interfaces to make it onto the client-side run-time.

Best of luck!
 

 
