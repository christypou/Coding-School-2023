namespace FuelStation.WinForms
{
	public partial class FuelStation : Form
	{
		public FuelStation()
		{
			InitializeComponent();
		}
		
		

		private void BtnToStaff_Click(object sender, EventArgs e)
		{

		}

		private void btnToManager_Click_1(object sender, EventArgs e)
		{
			ManagerForm managerForm = new();
			managerForm.ShowDialog();
		}

		private void FuelStation_Load(object sender, EventArgs e)
		{

		}
	}
}