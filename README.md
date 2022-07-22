# C# Pierre's Vendors

#### By _**Filmer Tolentino**_  

#### _C# Week 2 Friday Independent Project: Basic Web Applications_  

---
## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_

---
## Description

_Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors._

_For example, Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships._

_Use Razor to display information on each page._

* Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.
* Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
* The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
* The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and * * Pierre should be routed back to the homepage.
* Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
* Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".

---
## Setup/Installation Requirements

<details>
<summary><strong>To Setup</strong></summary>
<li>Install <em>Microsoft .NET SDK<em></li>
<li>Clone the repo

```sh
$ git clone
```
</li>
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>VendorOrder.Solution
   ├── <strong>PierresVendors</strong>
   └── PierresVendors.Tests</pre>

```
$ dotnet restore
```
```
$ dotnet run
```
</details>

<details>
<summary><strong>For Testing</strong></summary>
Navigate to  
    <pre>VendorOrder.Solution
    ├── PierresVendors
    └── <strong>PierresVendors.Tests</strong></pre>

```
$ dotnet restore
```
```
$ dotnet test
```

</details>
<br/>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _Any known issues_
* _should go here_

## License
MIT

## Contact Information
Filmer Tolentino <filmer.tolentino@gmail.com>

Copyright &copy; 2022 Filmer Tolentino