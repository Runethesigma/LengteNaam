namespace LengteNaam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*========== Analyse==========
1. Invoer:Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        een naam en achternaam met spatie tussen - string

2a. Bewerking: Welke ingebouwde functie ga je gebruiken om de lengte van je naam te bepalen?
        "VariableNaam".Length

b. Hoe ga je alle spaties uit je naam verwijderen? Welke ingebouwde functie ga je hiervoor gebruiken?
        door .Replace te gebruiken

==========Testdata=========

3.Testdata: Verzin en noteer testgegevens, en bereken zelf de juiste oplossing. Zo weet je of je oefening klopt.
        rune pauwels
        zonder spatie is 11
        met spatie is 12

========== Analyse==========*/
        private void BerekenButton_Click(object sender, EventArgs e)
        {
            string MetSpatie = Convert.ToString(NaamTextBox.Text);
            string ZonderSpatie = MetSpatie.Replace(" ","");
            int LengteMetSpatie = MetSpatie.Length;
            int LengteZonderSpatie = ZonderSpatie.Length;
            ResultaatInclusiefSpatieLabel.Text = Convert.ToString(LengteMetSpatie);
            ResultaatExclusiefSpatieLabel.Text = Convert.ToString(LengteZonderSpatie);
        }
    }
}
