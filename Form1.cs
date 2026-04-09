namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
            // 폼이 시작될 때 라디오 버튼이 강제로 선택 방지
            this.ActiveControl = lblTitle;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 에러 메시지 표시
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                //MessageBox.Show("메뉴를선택하세요.");
                lblError.Visible = true;
                return;
            }
            

            // 총 금액 표시
            lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";

        }

        // 초기화 버튼 클릭 시 모든 선택 초기화
        private void btnInit_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            rdoHamBurger.TabStop = true;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            totalCost = 0;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총금액: 0원";
            lblError.Visible = false;
        }
  

        private void btnInit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInit_Click(sender, e);
            }
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 5000;
                lstOrder.Items.Remove("햄버거 5,000원");
                updateTotalCost();
            }
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 4000;
                lstOrder.Items.Remove("불고기버거 4,000원");
                updateTotalCost();
            }
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 3000;
                lstOrder.Items.Remove("치킨버거 3,000원");
                updateTotalCost();
            }
        }

        private void chkPotato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 3500;
                lstOrder.Items.Remove("감자튀김 3,500원");
                updateTotalCost();
            }
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 2500;
                lstOrder.Items.Remove("콜라 2,500원");
                updateTotalCost();
            }
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 1500;
                lstOrder.Items.Remove("치즈 1,500원");
                updateTotalCost();
            }
        }

        private void chkSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
                updateTotalCost();
            }
            else
            {
                totalCost -= 500;
                lstOrder.Items.Remove("소스 500원");
                updateTotalCost();
            }
        }
        private void updateTotalCost()
        {
            lblTotalCost.Text = "총금액: " + totalCost.ToString("N0") + "원";
        }
    }
}
