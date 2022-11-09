﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace CRUDNET
{
    class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA();

        public DataTable asiakaslista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, Concat(etunimi, ' ',sukunimi) AS Kokonimi FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            String ktunnus = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            String salis = salasana();
            String salattu = Encrypt(salis);
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero, ktunnus, salasana) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono, @usr, @ssa); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            MessageBox.Show("Käyttäjätunnuksesi on " + ktunnus + "\nSalasanasi on " + salis + "\nSalattuna se on" + salattu + "\nkirjoita nämä visusti talteen");

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `etunimi`= @enm," +
                "`sukunimi`= @snm,`puhelin`= @puh,`sahkoposti`= @eml,`opiskelijanumero`= @ono" +
                " WHERE oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool poistaOpiskelija(int ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @oid";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = ktunnus;
            String salattu = "rIcQwyLOwjxbi7JdVNulwTvPETORgfcGwtuPsvQAuVc=";
            String salasana = Decrypt(salattu);
            MessageBox.Show(salasana + "");
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public String salasana()
        {
            char[] merkkijono = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            String ssana = "";
            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                int rInt = r.Next(0, 61);
                ssana += merkkijono[rInt];
            }
            return ssana;
        }
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}