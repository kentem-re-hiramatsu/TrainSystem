using System.Windows.Forms;
using TrainSystemCore.Managers;

namespace TrainSystem
{
    public partial class MainForm : Form
    {
        //メンバ変数
        private UserManager _userMana = new UserManager();

        //コンストラクタ
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateScreen()
        {
            //Viewの初期化
            TrainListView.Items.Clear();

            //Viewの更新
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
            //合計金額の更新
            TotalPriceLabel.Text = $"合計金額：{_userMana.GetTotalPrice().ToString("#,0")}円";
        }

        //予約ボタン
        private void ReservationButton_Click(object sender, System.EventArgs e)
        {
            if (new ReservationForm(_userMana).ShowDialog() == DialogResult.OK)
            {
                UpdateScreen();
            }
        }
    }
}