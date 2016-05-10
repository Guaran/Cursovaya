using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace CursovayaRabota
{
    class MensList
    {
        List<Men> mens = new List<Men>();
        public Men this[int index] { get { return mens[index]; } }
        public void Add(Men New)
        {
            mens.Add(New);
        }
        public void Delete(DataGridView table)
        {
            for (int i = 0; i < table.Rows.Count; ++i)
            {
                if (table.Rows[i].Cells[0].Value.Equals(true))
                {
                    mens.RemoveAt(i);
                    table.Rows.Remove(table.Rows[i]);
                    i--;
                }
            }
        }
        public void Save()
        {
            XmlDocument document = new XmlDocument();

            XmlDeclaration declarat = document.CreateXmlDeclaration("1.0", "utf-8", "yes");
            XmlElement root = document.CreateElement("mens");
            foreach(Men person in mens)
            {
                XmlText NameText = document.CreateTextNode(person.name);
                XmlText SurnameText = document.CreateTextNode(person.surname);
                XmlText BirthdayText = document.CreateTextNode(person.birthday);
                XmlText SomeInformationText = document.CreateTextNode(person.someinformation);

                XmlElement Name = document.CreateElement("Name");
                XmlElement Surname = document.CreateElement("Surname");
                XmlElement Birthday = document.CreateElement("Birthday");
                XmlElement SomeInformation = document.CreateElement("SomeInformation");

                Name.AppendChild(NameText);
                Surname.AppendChild(SurnameText);
                Birthday.AppendChild(BirthdayText);
                SomeInformation.AppendChild(SomeInformationText);

                XmlElement men = document.CreateElement("Men");

                men.AppendChild(Name);
                men.AppendChild(Surname);
                men.AppendChild(Birthday);
                men.AppendChild(SomeInformation);

                root.AppendChild(men);
                
            }
            document.AppendChild(root);
            document.Save(".../.../Mens.xml");
        }
        public void Download()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".../.../Mens.xml");
            XmlElement root = doc.DocumentElement;
            foreach (XmlElement men in root)
            {
                Men m = new Men(men["Name"].FirstChild.Value, men["Surname"].FirstChild.Value, men["Birthday"].FirstChild.Value, men["SomeInformation"].FirstChild.Value);
                mens.Add(m);
            }
        }
        public void Show(DataGridView table)
        {
           
            for (int i = 0; i < mens.Count; ++i)
            {
                DataGridViewCell checkBox = new DataGridViewCheckBoxCell();
                DataGridViewCell Name = new DataGridViewTextBoxCell();
                DataGridViewCell Surname = new DataGridViewTextBoxCell();
                DataGridViewCell DopInfo = new DataGridViewButtonCell();
                checkBox.Value = false;
                Name.Value = mens[i].name;
                Surname.Value = mens[i].surname;
                DopInfo.Value = "Дополнительно";
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(checkBox, Name, Surname, DopInfo);
                table.Rows.Add(row);
            }
        }
    }
}
