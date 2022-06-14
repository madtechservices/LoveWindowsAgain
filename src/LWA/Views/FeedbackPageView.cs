using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoveWindowsAgain
{
    public partial class FeedbackPageView : UserControl
    {
        public FeedbackPageView()
        {
            InitializeComponent();

            PopulateFeedback();
            SetStyle();
        }

        // Some UI nicety
        private void SetStyle()
        {
            BackColor =
            listFeedback.BackColor =
            richInfo.BackColor =
              Color.FromArgb(245, 241, 249);
            btnBack.Text = "\uE72B";
        }

        private void PopulateFeedback()
        {
            // Add required columns
            listFeedback.Columns.Add("Proposal");
            //listFeedback.Columns.Add("Info");
            //listFeedback.Columns.Add("Share link");

            XDocument doc = XDocument.Load(@"https://raw.githubusercontent.com/builtbybel/LoveWindowsAgain/main/assets/linuxLover.xml");

            foreach (var dm in doc.Descendants("proposal"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dm.Element("id").Value,
                    dm.Element("info").Value,
                    dm.Element("uri").Value,
                    dm.Element("votes").Value,
                });

                listFeedback.Items.Add(item);

                listFeedback.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listFeedback.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }


        private void listFeedback_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listFeedback.SelectedItems.Count > 0)
            {
                ListViewItem item = listFeedback.SelectedItems[0];
                _lblVotes.Text = item.SubItems[3].Text + " Votes";
                richInfo.Text = item.SubItems[1].Text.Replace("\\n", "\r\n") + "\n\nLink in Feedback Hub: " + item.SubItems[2].Text;                                  // Info
            }
        }
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.pnlForm.Controls.Clear();
            if (mainForm.INavPage != null) mainForm.pnlForm.Controls.Add(mainForm.INavPage);
        }

        private void richInfo_LinkClicked(object sender, LinkClickedEventArgs e)
            => HelperTool.Utils.LaunchUri(e.LinkText);
    }
}