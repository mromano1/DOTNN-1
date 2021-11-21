using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
                        ListViewItem item = new ListViewItem((i+1).ToString());
                        item.SubItems.Add(recs[i].objectName.ToString());
                        item.SubItems.Add(recs[i].latitude.ToString());
                        item.SubItems.Add(recs[i].longitude.ToString()); 
                        item.SubItems.Add(recs[i].amount.ToString());
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
            label_retrain2.Font = new Font("Arial", 14f, FontStyle.Regular);
            label_retrain3.Font = new Font("Arial", 14f, FontStyle.Regular);
            label_retrain4.Font = new Font("Arial", 14f, FontStyle.Regular);
            label_retrain5.Font = new Font("Arial", 14f, FontStyle.Regular);

            label_settings.Font = new Font("Arial", 30f, FontStyle.Regular);
            label_settings2.Font = new Font("Arial", 18f, FontStyle.Regular);
        }

        private void textbox_download_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(GetChildPath("AutoCrawler"));
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\keywords.txt", textbox_retrain_keyword.Text, Encoding.Default);

            string limit = string.Format("--limit {0}", textbox_retrain_limit.Text);
            run_cmd2("AutoCrawler", "main.py", limit);
        }

        private void textbox_retrain_Click(object sender, EventArgs e)
        {
            string args = "--weights runs/train/exp/weights/best.pt --img 416 --conf 0.1 --source ./data/images_test";
            run_cmd2("yolov5", "detect.py", args);
        }

        private void run_cmd2(string dir ,string cmd, string args)
        {
            Directory.SetCurrentDirectory(GetChildPath(dir));
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Windows\py.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
  
        private string GetChildPath(string dir)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string[] dirs = path.Split('\\');

            List<string> needs = new List<string> { };
            foreach (var word in dirs)
            {
                needs.Add(word);
                if (word == "DOTNN")
                {
                    break;
                }
            }

            needs.Add(dir);

            string finalPath = string.Join("\\", needs.ToArray());
            return finalPath;
        }
    }
}
