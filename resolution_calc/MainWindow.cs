using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    float ratioX, ratioY, resWidth, resHeight;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnBtnCalcResWidthPressed(object sender, EventArgs e)
    {

        //String rtX = txtBoxRatioX.Text.ToString();
        //Console.WriteLine(rtX);
        if(txtBoxRatioX.Text.ToString().Length.Equals(0) || txtBoxRatioY.Text.ToString().Length.Equals(0) || txtBoxResHeight.Text.ToString().Length.Equals(0))
        {
            lblResult.Text = $"Insert \"ratio x\", \"ratio y\" and \"pixel height\"";
        }
        else
        {
            ratioX = float.Parse(txtBoxRatioX.Text.ToString());
            ratioY = float.Parse(txtBoxRatioY.Text.ToString());
            resHeight = float.Parse(txtBoxResHeight.Text.ToString());
            resWidth = ratioX * resHeight / ratioY;

            lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            Console.WriteLine($"Ratio\t\t{ratioX}:{ratioY}\r\nResolution\t{resWidth} x {resHeight}");
        }

        // txtBoxResHeight.AppendText(text: $"Ratio\t\t{ratioX}:{ratioY}\r\nResolution\t{resWidth} x {resHeight}");



    }

    protected void OnBtnCalcRatioClicked(object sender, EventArgs e)
    {

        if (txtBoxResWidth.Text.ToString().Length.Equals(0) || txtBoxResHeight.Text.ToString().Length.Equals(0))
        {
            lblResult.Text = $"Insert \"pixel width\" and \"pixel height\"";

        }
        else
        {

            resWidth = float.Parse(txtBoxResWidth.Text.ToString());
            resHeight = float.Parse(txtBoxResHeight.Text.ToString());
            float r = resWidth / resHeight;
            if (r >= 1.24 && r <= 1.25)
            {
                ratioX = 5;
                ratioY = 4;

                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            } else if (r == 2.0)
            {
                ratioX = 2;
                ratioY = 1;
                Console.WriteLine(r);
                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            }
            else if (r == 1.0)
            {
                ratioX = 1;
                ratioY = 1;
                Console.WriteLine(r);
                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            }
            else if (r == 1.5)
            {
                ratioX = 3;
                ratioY = 2;
                Console.WriteLine(r);
                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            }
            else if (r >= 1.32 && r <= 1.34)
            {
                ratioX = 4;
                ratioY = 3;
                Console.WriteLine(r);
                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            }
            else if (r >= 1.76 && r <= 1.78)
            {
                ratioX = 16;
                ratioY = 9;
                Console.WriteLine(r);
                lblResult.Text = $"Ratio\t\t\t{ratioX} : {ratioY}\r\nResolution\t{resWidth} x {resHeight}";
            }
            else
            {
                lblResult.Text = $"Ratio unknown.. Sorry! :)";

            }


        }
    }
}
