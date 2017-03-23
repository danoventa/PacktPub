using System;
using System.Activities.Statements;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        decimal salaryOne = 25000, salaryTwo = 64000;

        decimal tots = salaryOne + salaryTwo;
        sampLabel.Text += $"Total salary = {tots:c}<br>";

        decimal average = tots/2;
        sampLabel.Text += $"Average Salary = {average:c}<br>";


        Page.Title = "Table Catalog";
        string desc = "This is our table, in which table things occur<br>";
        sampLabel.Text += desc;

        bool isIt = true;
        sampLabel.Text += $"is it {isIt}<br>";

        double price = 99.99;
        sampLabel.Text += $"Price of this is {price:c}<br>";

        double x = 25.098114;
        sampLabel.Text += $"{x} is the value in money format {x:c}<br>";

        x = 7.33333;
        sampLabel.Text += $"{x} is the value in percent format {x:P2}<br>";

        sampLabel.Text += $"Today is as date = {DateTime.Now:d}<br>";
        sampLabel.Text += $"Today is as date = {DateTime.Now:D}<br>";


    sampLabel.Text += "Hai";

        double height = 100000.00;

        sampLabel.Text += "Dan's height is " + height;

        height = 72.00;
        sampLabel.Text += "<br>Dan's real height is " + height;

        height = 9999999.99;
        sampLabel.Text += $"<br>Height is {height}";

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        string input = TextBox1.Text;

        try
        {
            double x = Convert.ToDouble(input);
            x *= x;
            sampLabel.Text += $"<br>This is the new value{x}<br>";
        }
        catch
        {
            sampLabel.Text += "<br> Not a number <br>";
            sampLabel.Text += "<br> Not a number <br>";
        }


        bool hasLetter = (TextBox1.Text).ToLower().Contains("a");
        sampLabel.Text += $"<br> has letter! {hasLetter} <br>";
    }
}