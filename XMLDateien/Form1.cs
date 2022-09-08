using System.Text;
using System.IO;
using System.Xml;

namespace XMLDateien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSchreiben_Click(object sender, EventArgs e)
        {
            XmlTextWriter xw = new XmlTextWriter("firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument();
            xw.WriteStartElement("firma");

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Maier");
            xw.WriteAttributeString("vorname", "Hans");
            xw.WriteAttributeString("personalnummer", "6714");
            xw.WriteAttributeString("gehalt", "3500.0");
            xw.WriteAttributeString("geburtstag", "15.03.1962");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Schmitz");
            xw.WriteAttributeString("vorname", "Peter");
            xw.WriteAttributeString("personalnummer", "81343");
            xw.WriteAttributeString("gehalt", "3750.0");
            xw.WriteAttributeString("geburtstag", "12.04.1958");
            xw.WriteEndElement();

            xw.WriteStartElement("person");
            xw.WriteAttributeString("name", "Mertens");
            xw.WriteAttributeString("vorname", "Julia");
            xw.WriteAttributeString("personalnummer", "2297");
            xw.WriteAttributeString("gehalt", "3621.5");
            xw.WriteAttributeString("geburtstag", "30.12.1959");
            xw.WriteEndElement();
            
            xw.WriteEndElement();
            xw.Close();
        }

        private void btnLesen_Click(object sender, EventArgs e)
        {
            if (!File.Exists("firma.xml"))
            {
                lblDisplay.Text = "Datei firma.xml existiert nicht";
                return;
            }

            XmlReader xr = new XmlTextReader("firma.xml");

            lblDisplay.Text = "";
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    if (xr.AttributeCount > 0)
                    {
                        while (xr.MoveToNextAttribute())
                            lblDisplay.Text +=
                            xr.Name + " -> " + xr.Value + "\n";
                        lblDisplay.Text += "\n";
                    }
                }
            }

            xr.Close();
        }

        private void btnObjekteIn_Click(object sender, EventArgs e)
        {
            Person[] personFeld = new Person[3];
            personFeld[0] = new Person("Maier", "Hans", 6714, 3500.0, new DateTime(1962, 3, 5));
            personFeld[1] = new Person("Schmitz", "Peter", 81343, 3750.0, new DateTime(1958, 4, 12));
            personFeld[2] = new Person("Mertens", "Julia", 2297, 3621.5, new DateTime(1959, 12, 30));

            XmlTextWriter xw = new XmlTextWriter("firma.xml", new UnicodeEncoding());
            xw.WriteStartDocument();
            xw.WriteStartElement("firma");

            foreach (Person p in personFeld)
                p.AlsXmlElementSchreiben(xw);

            xw.WriteEndElement();
            xw.Close();
        }

        class Person
        {
            private string name;
            private string vorname;
            private int personalnummer;
            private double gehalt;
            private DateTime geburtstag;

            public Person(string na, string vo, int pe, double gh, DateTime gb)
            {
                name = na;
                vorname = vo;
                personalnummer = pe;
                gehalt = gh;
                geburtstag = gb;
            }

            public void AlsXmlElementSchreiben(XmlTextWriter xw)
            {
                xw.WriteStartElement("person");
                xw.WriteAttributeString("name", name);
                xw.WriteAttributeString("vorname", vorname);
                xw.WriteAttributeString("personalnummer", personalnummer.ToString());
                xw.WriteAttributeString("gehalt", "" + gehalt.ToString());
                xw.WriteAttributeString("geburtstag", geburtstag.ToShortDateString());
                xw.WriteEndElement();
            }

            public override string ToString()
            {
                return name + ", " + vorname + ", " + personalnummer +
                ", " + gehalt + ", " + geburtstag.ToShortDateString();
            }
        }

        private void btnObjekteAus_Click(object sender, EventArgs e)
        {
            if (!File.Exists("firma.xml"))
            {
                lblDisplay.Text = "Datei firma.xml existiert nicht";
                return;
            }

            Person[] personFeld = new Person[3];
            string na = "";
            string vo = "";
            int pe = 0;
            double gh = 0.0;
            DateTime gb = new DateTime();
            int i;

            XmlReader xr = new XmlTextReader("firma.xml");

            i = 0;
            while (xr.Read())
                if (xr.NodeType == XmlNodeType.Element)
                    if (xr.AttributeCount > 0)
                    {
                        while (xr.MoveToNextAttribute())
                            switch (xr.Name)
                            {
                                case "name":
                                    na = xr.Value;
                                    break;
                                case "vorname":
                                    vo = xr.Value;
                                    break;
                                case "personalnummer":
                                    pe = Convert.ToInt32(xr.Value);
                                    break;
                                case "gehalt":
                                    gh = Convert.ToSingle(xr.Value);
                                    break;
                                case "geburtstag":
                                    int jahr = Convert.ToInt32(
                                    xr.Value.Substring(6, 4));
                                    int monat = Convert.ToInt32(
                                    xr.Value.Substring(3, 2));
                                    int tag = Convert.ToInt32(
                                    xr.Value.Substring(0, 2));
                                    gb = new DateTime(jahr, monat, tag);
                                    break;
                            }
                        personFeld[i] = new Person(na, vo, pe, gh, gb);
                        i = i + 1;
                    }

            xr.Close();
            lblDisplay.Text = "";
            foreach (Person p in personFeld)
                lblDisplay.Text += p + "\n";
        }
    }
}