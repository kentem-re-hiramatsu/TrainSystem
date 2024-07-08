using System;
using System.Windows.Forms;
using TrainSystemCore.Enums;
using TrainSystemCore.Managers;
using TrainSystemCore.Models;

namespace TrainSystem
{
    public partial class ReservationForm : Form
    {
        private UserManager _userMana;

        public ReservationForm(UserManager userManager)
        {
            InitializeComponent();
            _userMana = userManager;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            TrainComboBox.Items.AddRange(new object[]
            {
                TrainType.普通列車,
                TrainType.急行列車,
                TrainType.特急列車,
            });

            SeatComboBox.Items.AddRange(new object[]
            {
                SeatType.普通,
                SeatType.指定,
                SeatType.グリーン指定,
            });
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var name = NameTextBox.Text;
            var adultCount = (int)AdultNumericUpDown.Value;
            var childrenCount = (int)ChildrenNumericUpDown.Value;
            var trainType = (TrainType)TrainComboBox.SelectedItem;
            var seatType = (SeatType)SeatComboBox.SelectedItem;

            try
            {
                var train = new TrainManager().GetTrain(trainType, seatType);
                var user = new User(name, adultCount, childrenCount, train);
                _userMana.Add(user);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}