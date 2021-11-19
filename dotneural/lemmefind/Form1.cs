using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace lemmefind
{
    public partial class Form1 : MaterialForm
    {
        MongoCRUD mDB;
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFonts();

            mDB = new MongoCRUD("mongodb+srv://developer1:hyunsoo97@qple-core.jxnch.mongodb.net/myFirstDatabase?retryWrites=true&w=majority", "Lemmefind");
            
            mDB.InsertRecord("Objects", new ObjectModel { objectName = "speed limit",  latitude = 40.7589466, longitude = 73.9289582, isFound = true });
            mDB.InsertRecord("Objects", new ObjectModel { objectName = "stop sign", latitude = 40.6523466, longitude = 77.7689582, isFound = true });

            //var recs = db.LoadRecords<ObjectModel>("Objects");
            //foreach (var rec in recs)
            //{
            //    Console.WriteLine($"{rec.Id}: {rec.objectName},{rec.IsFound}");
            //}

            //var rec = mDB.LoadRecordByObject<ObjectModel>("Objects", "stop signs");
            //if (rec == null)
            //{
            //    Console.WriteLine($"NOTHING INSIDE!");
            //}
            //else
            //{
            //    Console.WriteLine($"{rec.mId}: {rec.mObjectName},{rec.mIsFound}");
            //}

            //if (mDB.CheckRecordExist<ObjectModel>("Objects", "stop signs"))
            //{
            //    Console.WriteLine($"SOMETHING INSIDE! SIOBALLLLLLLLL");
            //}
            //else
            //{
            //    Console.WriteLine($"NOTHING INSIDE! SIOBALLLLLLLLL");
            //}
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            listView_results.Items.Clear();
            Console.WriteLine($"Clicked");

            var inputs = textbox_search.Text;
            Console.WriteLine("input:" + inputs);

            var recs = mDB.LoadRecordByObject<ObjectModel>("Objects", inputs);
            if (recs == null)
            {
                Console.WriteLine($"NOTHING INSIDE!");
            }
            else
            {
                if (recs.Count == 0)
                {
                    const string caption = "Retrain our model please";
                    const string message = "Go to Retrain tap and follow instructions.";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < recs.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(i.ToString());
                        item.SubItems.Add(recs[i].objectName.ToString());
                        item.SubItems.Add(recs[i].latitude.ToString());
                        item.SubItems.Add(recs[i].longitude.ToString());
                        listView_results.Items.Add(item);
                    }
                }
            }
            textbox_search.Focus();
        }

        private void SetFonts()
        {
            label_home.Font     = new Font("Arial", 30f, FontStyle.Regular);
            label_home2.Font    = new Font("Arial", 18f, FontStyle.Regular);

            label_search.Font   = new Font("Arial", 30f, FontStyle.Regular);

            label_retrain.Font  = new Font("Arial", 30f, FontStyle.Regular);
            label_retrain2.Font = new Font("Arial", 18f, FontStyle.Regular);

            label_settings.Font = new Font("Arial", 30f, FontStyle.Regular);
            label_settings2.Font = new Font("Arial", 18f, FontStyle.Regular);
        }

    }
}
