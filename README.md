# CUSTOMIZED USER CONTROL
Instructions for my Customized User Control for the AdventureWorks DataBase

## Importing the control:
Inside the solution directory, go to this path: <b>CustomizedUserControl > bin > Debug</b> and find the .dll file. This is the file to import to your project. </br>
After importation: </br>
In a new Windows Form, go to the Toolbox panel and drag the CustomizedUserControl component to your form.

## Using the control:
On the main view, click the panel under the 'Photo' label to get info from a random product model. </br>
Some information will be shown to you in diferent textbox. </br>
Available sizes of the product model will be shown in the Sizes panel below the Photo panel.  </br>
Click on a size button to show the Product id info  </br>
Click on the Photo panel to show information of another random Product Model </br>
Click the Change UI color button to change the color of the background of the User Control. </br>
Click the Change panels color button to change the color of the background of photo and sizes panels. </br>

## Configuring the control:
### In order to pick the color you want to change the background to:
Use some components in the container form to set values to 3 integers from 0 to 255. </br>
Create a method to set this 3 values as a Color:<b> Color c = Color.FromArgb(yourValue1, yourValue2, yourValue3); </b> </br>
Inside the same method, set this color to the UserControl Property:<b> nameOfTheControl.SizesBgColor = c; </b> </br>

### In order to show the Product ID info when a size Button is clicked:
Use a textbox component or the component you want to show text.  </br>
Create a method to set the data with 2 parameters:<b> object sender, SizeClickedEventArgs e. </b></br>
Inside the method, call your texbox and set the text to eventargs data:<b> textbox.Text = e.Data;</b></br>
#### Subscribe the User control Size Clicked event to your new method:
In the form > inside public form() { } > below InitializeComponent()</br>
<b>yourUserControlName.SizeClicked += nameOfYourMetod;</b>
