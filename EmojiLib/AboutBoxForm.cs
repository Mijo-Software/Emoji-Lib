using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MijoSoftware.AssemblyInformation;

namespace EmojiLib
{
	internal partial class AboutBoxForm : Form
	{
		public AboutBoxForm()
		{
			InitializeComponent();
			Text = $"About {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}
	}
}
