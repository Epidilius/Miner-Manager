using System.Windows.Forms;

namespace MinerManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            linkLabel1.LinkVisited = true;

            //var target = e.Link.LinkData as string;
            var target = linkLabel1.Text;
            System.Diagnostics.Process.Start(target);
        }
    }
}
