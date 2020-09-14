I used ASP .Net Core for my project. Data for the products comes from json file in wwwroot.
General purpose is showing list of products on UI, including images of the products.
I use service and controller for the functionality. ProductsService knows about the json and getting information from it,
while Controller is dealing with ViewModel and passing information to the View, I used Dependency Inversion principle.