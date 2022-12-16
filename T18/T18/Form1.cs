using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T18
{
    public partial class Form1 : Form
    {
        DataTable school = new DataTable();
        DataTable person = new DataTable();
        DataTable contact = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Fillschooltable();
            Fillpersontable();
            SchoolCB.DataSource = school;
            SchoolCB.DisplayMember = "SName";
        }
        private void SchoolCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reference = school.Rows[SchoolCB.SelectedIndex]["SID"].ToString();
            AddressLB.Text = school.Rows[SchoolCB.SelectedIndex]["SAddress"].ToString();
            PostcodeLB.Text = school.Rows[SchoolCB.SelectedIndex]["SPostcode"].ToString();
            CityLB.Text = school.Rows[SchoolCB.SelectedIndex]["SCity"].ToString();
            PhoneLB.Text = school.Rows[SchoolCB.SelectedIndex]["SPhone"].ToString();

            contact = person.Select("SID =" + reference).CopyToDataTable();
            PersonCB.DataSource = contact;
            PersonCB.DisplayMember = "PName";
        }
        private void PersonCB_TextChanged(object sender, EventArgs e)
        {
            TitleLB.Text = contact.Rows[PersonCB.SelectedIndex]["PTitle"].ToString();
            PositionLB.Text = contact.Rows[PersonCB.SelectedIndex]["PPosition"].ToString();
            EmailLB.Text = contact.Rows[PersonCB.SelectedIndex]["PEmail"].ToString();
            MobileLB.Text = contact.Rows[PersonCB.SelectedIndex]["PMobile"].ToString();
        }
        private void Fillschooltable()
        {
            school.Columns.Add("SID", typeof(int));
            school.Columns.Add("SName");
            school.Columns.Add("SAddress");
            school.Columns.Add("SPostcode");
            school.Columns.Add("SCity");
            school.Columns.Add("SPhone");

            school.Rows.Add(1, "StadinAO", "Hattulantie 2", "00550", "Helsinki", "09 310 8600");
            school.Rows.Add(2, "Omnia", "Armas Launiksen katu 9", "02650", "Espoo", "046 877 1371");
            school.Rows.Add(3, "Varia", "Rälssitie 13", "01530", "Vantaa", "040 182 4668");
            school.Rows.Add(4, "Keuda", "Sibeliuksenväylä 55 A", "04400", "Järvenpää", "09 27 381");
        }
        private void Fillpersontable()
        {
            person.Columns.Add("PID", typeof(int));
            person.Columns.Add("PName");
            person.Columns.Add("PTitle");
            person.Columns.Add("PPosition");
            person.Columns.Add("PEmail");
            person.Columns.Add("PMobile");

            person.Rows.Add(1, "Sirpa Lindroos", "Rehtori", "Kampus 1", "sirpa.lindroos@hel.fi", "050 540 4434");
            person.Rows.Add(1, "Hanna Laurila", "Rehtori", "Kampus 2", "hanna.laurila@hel.fi", "040 676 5583");
            person.Rows.Add(1, "Annele Ranta", "Rehtori", "Kampus 3", "annele.ranta@hel.fi", "040 631 5667");
            person.Rows.Add(1, "Eeva Sahlman", "Rehtori", "Kampus 4", "eeva.sahlman@hel.fi", "040 336 1017");
            person.Rows.Add(1, "Marko Aaltonen", "Rehtori", "Kampus 5", "marko.aaltonen@hel.fi", "050 511 8115");
            person.Rows.Add(2, "Tuula Antola", "Koulutuskuntayhtymän johtaja", "Yleishallinto", "tuula.antola@omnia.fi", "");
            person.Rows.Add(2, "Tapio Siukonen", "Hallintojohtaja", "Yleishallinto", "tapio.siukonen@omnia.fi", "044 369 6600");
            person.Rows.Add(2, "Tuukko Soini", "Kehittämisjohtaja", "Yleishallinto", "tuukka.soini@omnia.fi", "046 877 2952");
            person.Rows.Add(2, "Riikka-Maria Yli-Suomu", "Liiketoimintajohtaja", "Elinvoima- ja työllisyyspalvelut", "riikka-maria.yli-suomu@omnia.fi", "050 348 6544");
            person.Rows.Add(2, "Maija Aaltola", "Rehtori", "Koulutus- ja opiskelijapalvelut", "maija-aaltola@omnia.fi", "050 384 9354");
            person.Rows.Add(2, "Kai Iivari", "Talousjohtaja", "Talous ja hankintapalvelut", "kai.iivari@omnia.fi", "0400 306 691");
            person.Rows.Add(2, "Päivi Korhonen", "Viestintäjohtaja", "Viestintä- ja markkinointipalvelut", "paivi.korhonen@omnia.fi", "040 126 7599");
            person.Rows.Add(3, "Pekka Tauriainen", "Rehtori", "", "pekka.tauriainen@vantaa.fi", "050 312 4514");
            person.Rows.Add(3, "Anne Heinonen", "Työelämäpalvelupäällikkö", "", "anne.heinonen@vantaa.fi", "040 524 1242");
            person.Rows.Add(3, "Tuula Kiistinen", "Yhteisten palveluiden päällikkö", "", "tuula.kiiskinen@vantaa.fi", "040 193 9048");
            person.Rows.Add(4, "Tiina Halmevuo", "Kuntayhtymän johtaja", "Hallinto- ja johtamispalvelut", "tiina.halmevuo@keuda.fi", "050 336 9709");
            person.Rows.Add(4, "Anna Mari Leinonen", "Rehtori", "Hallinto", "annamari.leinonen@keuda.fi", "040 174 4523");
            person.Rows.Add(4, "Anne Vuorinen", "Johtaja", "Yritys- ja elinvoimapalvelut", "anne.vuorinen@keuda.fi", "050 415 0974");
            person.Rows.Add(4, "Hanna Nyrönen", "Viestintä- ja markkinointipäällikkö", "Viestintäpalvelut", "hanna.nyronen@keuda.fi", "040 521 8428");
            person.Rows.Add(4, "Maarit Flinck", "Asianhallintapäällikkö", "Hallinto- ja johtamispalvelut", "maarit.flinck@keuda.fi", "0500 837 357");
        }
    }
}