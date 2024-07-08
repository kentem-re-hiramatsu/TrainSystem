using System.Windows.Forms;
using TrainSystemCore.Managers;

namespace TrainSystem
{
    public partial class MainForm : Form
    {
        private UserManager _userMana = new UserManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            TrainListView.Items.Clear();

            foreach (var user in _userMana.UserDatas)
            {
                TrainListView.Items.Add(new ListViewItem(new string[]
                {
                    user.Name,
                    user.AdultCount.ToString(),
                    user.ChildrenCount.ToString(),
                    user.TrainType.Name,
                    user.TrainType.SeatType.ToString(),
                }));
            }
            TotalPriceLabel.Text = $"合計金額：{_userMana.GetTotalPrice().ToString("#,0")}円";
        }

        private void ReservationButton_Click(object sender, System.EventArgs e)
        {
            if (new ReservationForm(_userMana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }
    }
}