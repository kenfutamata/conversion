namespace conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void meterinputupdown_ValueChanged(object sender, EventArgs e)
        {
            double doublemeterupdown = Convert.ToDouble(meterinputupdown.Value);
            double inch = 0.0254;
            double feet = 0.3048;
            double yard = 0.9144; 
            double mile = 1609.344;

            double inchoutput = doublemeterupdown / inch; 
            outputinch.Text = inchoutput.ToString();
            double feetoutput = doublemeterupdown / feet;
            outputfoot.Text = feetoutput.ToString();    
            double yardoutput = doublemeterupdown / yard;
            outputyard.Text = yardoutput.ToString();
            double mileoutput = doublemeterupdown / mile;
            outputmile.Text = mileoutput.ToString();    
        }
    }
}
